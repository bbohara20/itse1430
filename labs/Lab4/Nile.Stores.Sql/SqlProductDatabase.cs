/*
 * /*Bam Bohara
 * ITSE 1430
 * Lab 4
 */using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Nile.Stores.Sql
{

    /// <summary>Base class for product database.</summary>
    public class SqlProductDatabase : ProductDatabase
    {
    
        public SqlProductDatabase ( string connectionString )
        {
            //Should probably validate this...
            _connectionString = connectionString;
        }

        //Make readonly as it is only set in constructor
        private readonly string _connectionString;

        /// <inheritdoc />
        protected override Product AddCore ( Product product )
        {
            using (var connection = OpenConnection())
            {
                //Provider-agnostic way to create command
                var command = connection.CreateCommand();
                command.CommandText = "AddProduct";
                command.CommandType = CommandType.StoredProcedure;

                //Add parameters
                //   1. Create parameter and add manually
                var parmName = new SqlParameter("@name", product.Name);
                command.Parameters.Add(parmName);

                command.Parameters.AddWithValue("@price", product.Price);

                var parmDescription = command.CreateParameter();
                parmDescription.ParameterName = "@description";
                parmDescription.Value = product.Description;
                parmDescription.SqlDbType = SqlDbType.NVarChar;
                command.Parameters.Add(parmDescription);
                command.Parameters.AddWithValue("@isDiscontinued", product.IsDiscontinued);

               object result = command.ExecuteScalar();
                var id = Convert.ToInt32(result);

                //Finish out method
                product.Id = id;
                return product;
            };
        }

        /// <inheritdoc />
        protected  override void RemoveCore ( int id )
        {
            using (var connection = OpenConnection())
            {
                //Provider-agnostic way to create command
                var command = connection.CreateCommand();
                command.CommandText = "DeleteProduct";
                command.CommandType = CommandType.StoredProcedure;

                //Add parameters
                command.Parameters.AddWithValue("@id", id);

                
                command.ExecuteNonQuery();
            };
        }

        /// <inheritdoc />
        protected override IEnumerable<Product> GetAllCore ()
        {
            var ds = new DataSet();
            

            //IDisposable so always wrap in a using
            using (var connection = OpenConnection())
            {
            var command = new SqlCommand("GetProducts", connection);
            command.CommandType = CommandType.StoredProcedure;
           //Execute the command - using the buffered approach                
                var da = new SqlDataAdapter() {
                    SelectCommand = command
                };

                //Retrieve data (buffered)
                da.Fill(ds);
            };

            //Get table, if any
            var table = ds.Tables.Count > 0 ? ds.Tables[0] : null;
            if (table != null)
            {
                
                foreach (var row in table.Rows.OfType<DataRow>())
                {
                    

                    yield return new Product() {
                        Id = Convert.ToInt32(row[0]),
                        Name = row["name"].ToString(),
                        Price = row.IsNull("Price") ? 0 : row.Field<decimal>("Price"),
                         Description = row.IsNull("Description") ? null : row.Field<string>("description"),
                         IsDiscontinued  = row.Field<bool>("isDiscontinued"),
                        };

                   
                    };
                };
            
        }

        protected override Product GetCore ( int id )
        {
            using (var connection = OpenConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "GetProduct";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", id);

                //Stream data using reader
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productId = reader.GetInt32(0);
                        if (productId == id)
                        {

                            return new Product() {
                                Id = productId,
                                Name = reader.GetString(1),
                                Price = reader.IsDBNull(2) ? 0 : reader.GetFieldValue<decimal>(2),
                                Description = reader.IsDBNull(3) ? null : reader.GetString(3),
                                IsDiscontinued  = reader.GetFieldValue<bool>(4),   
                            };
                        };
                    };
                };
            };

            return null;
        }

        /// <inheritdoc />
        protected  Product GetByName ( string name )
        {
            var products = GetAllCore();
            
            return products.FirstOrDefault(product => String.Compare(product.Name, name, true) == 0);

            
        }

        

       
        protected override Product UpdateCore ( Product existing, Product product)
        {
            using (var connection = OpenConnection())
            {
                //Provider-agnostic way to create command
                var command = connection.CreateCommand();
                command.CommandText = "UpdateProduct";
                command.CommandType = CommandType.StoredProcedure;

                //Add parameters
                //   1. Create parameter and add manually
                var parmName = new SqlParameter("@name", product.Name);
                command.Parameters.Add(parmName);

                //   2. Create parameter using command
                var parmDescription = command.CreateParameter();
                parmDescription.ParameterName = "@description";
                parmDescription.Value = product.Description;
                parmDescription.SqlDbType = SqlDbType.NVarChar;
                command.Parameters.Add(parmDescription);

                //   3. (SQL Server) AddWithValue (PREFERRED when SQL)
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@isDiscontinued", product.IsDiscontinued);
                command.Parameters.AddWithValue("@id", product.Id);

                
                command.ExecuteNonQuery();
                return product;
            };
            
        }

        
        private SqlConnection OpenConnection ()
        {
            //Connect to database using connection string
            var conn = new SqlConnection(_connectionString);

            //SqlException if something goes wrong
            conn.Open();
            return conn;
        }
    }
}
