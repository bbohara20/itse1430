/*Bam Bohara
 * ITSE 1430
 * Lab 4
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;



namespace Nile.Stores
{
    /// <summary>Base class for product database.</summary>
    public abstract class ProductDatabase : IProductDatabase
    {
        /// <summary>Adds a product.</summary>
        /// <param name="product">The product to add.</param>
        /// <returns>The added product.</returns>
        public Product Add ( Product product )
        {
            //TODO: Check arguments

            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }



            var validationResults = new ObjectValidator().TryValidateFullobject(product);
            if (validationResults.Count() > 0)
            {
                var builder = new System.Text.StringBuilder();
                foreach (var result in validationResults)
                {
                    builder.AppendLine(result.ErrorMessage);
                };
                // Show error message
                throw new Exception(builder.ToString());

               // return null;
            };
            var existing = GetAll();
            if (existing != null)
                foreach (var product2 in existing)
                {
                    if (String.Compare(product.Name, product2.Name, true) == 0)
                        throw new InvalidOperationException(" Product name must be unique");
                };
            //Emulate database by storing copy
            try
            {
                return AddCore(product);
            } catch (Exception e)
            {
                //Throwing a new exception
                throw new InvalidOperationException("Add Failed", e);
            };

        }

        /// <summary>Get a specific product.</summary>
        /// <returns>The product, if it exists.</returns>
        public Product Get ( int id )
        {
            //TODO: Check arguments
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");

            return GetCore(id);
        }

        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        public IEnumerable<Product> GetAll ()
        {
            try
            {
                return GetAllCore();
            } catch (Exception e)
            {
                throw new InvalidOperationException("GetAll Failed", e);
            }
        }

        /// <summary>Removes the product.</summary>
        /// <param name="id">The product to remove.</param>
        public void Remove ( int id )
        {
            //TODO: Check arguments
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");

            RemoveCore(id);
        }

        /// <summary>Updates a product.</summary>
        /// <param name="product">The product to update.</param>
        /// <returns>The updated product.</returns>
        public Product Update ( Product product )
        {
            //TODO: Check arguments
            if (product == null)
                throw new ArgumentNullException(nameof(product));
            if (product.Id <= 0)
                throw new ArgumentOutOfRangeException(nameof(product), "Id must be greater than zero");

            //TODO: Validate product
            var validationResults = new ObjectValidator().TryValidateFullobject(product);
            if (validationResults.Count() > 0)
            {
                var builder = new System.Text.StringBuilder();
                foreach (var result in validationResults)
                {
                    builder.AppendLine(result.ErrorMessage);
                };
                //Show error message
                throw new Exception(builder.ToString());


              //  return null;
            };

            //Get existing product
            var existing = GetCore(product.Id);
            var products = GetAll();
            if (products != null)
                foreach (var product2 in products)
                {
                    if (String.Compare(product.Name, product2.Name, true) == 0)
                        if (!(String.Compare(existing.Name, product.Name, true) == 0))
                            throw new InvalidOperationException(" Product name must be unique");
                };

            return UpdateCore(existing, product);
        }

        #region Protected Members

        protected abstract Product GetCore ( int id );

        protected abstract IEnumerable<Product> GetAllCore ();

        protected abstract void RemoveCore ( int id );

        protected abstract Product UpdateCore ( Product existing, Product newItem );

        protected abstract Product AddCore ( Product product );
        #endregion
    }
}
