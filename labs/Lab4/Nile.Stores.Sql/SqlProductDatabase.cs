/*Bam Bohara
 * ITSE 1430
 * Lab 4
 */
using System;
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
             _connectionString = connectionString;
        }
        private readonly string _connectionString;
        protected override Product AddCore ( Product product )
        {
            using (var connection = OpenConnection())
            {
                //createing  commands
                var command = connection.CreateCommand();
                command.CommandText = "AddProduct";
                command.CommandType = CommandType.StoredProcedure;

                //Adding parameters
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

                product.Id = id;
                return product;
            };
        }
        
        protected override void RemoveCore ( int id )
        {
            using (var connection = OpenConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "RemoveProduct";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            };
        }
        protected override IEnumerable<Product> GetAllCore ()
        {
            var ds = new DataSet();
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("GetAllProducts", connection);
                command.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter() {
                    SelectCommand = command
                };
                
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
        protected override Product UpdateCore ( Product existing, Product product )
        {
            using (var connection = OpenConnection())
            {
                // create commands
                var command = connection.CreateCommand();
                command.CommandText = "UpdateProduct";
                command.CommandType = CommandType.StoredProcedure;

                //Add parameters
                var parmName = new SqlParameter("@name", product.Name);
                command.Parameters.Add(parmName);

                // Create parameter using command
                var parmDescription = command.CreateParameter();
                parmDescription.ParameterName = "@description";
                parmDescription.Value = product.Description;
                parmDescription.SqlDbType = SqlDbType.NVarChar;
                command.Parameters.Add(parmDescription);

                //(SQL Server) AddWithValue 
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
            conn.Open();
            return conn;
        }
    }
}
