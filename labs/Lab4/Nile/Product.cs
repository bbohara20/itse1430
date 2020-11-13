/*Bam Bohara
 * ITSE 1430
 * Lab4
 */
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;



namespace Nile
{
    /// <summary>Represents a product.</summary>
    public class Product: IValidatableObject
    {
        /// <summary>Gets or sets the unique identifier.</summary>
        public int Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>Never returns null.</value>
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value?.Trim(); }
        }
        
        /// <summary>Gets or sets the description.</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value?.Trim(); }
        }

        /// <summary>Gets or sets the price.</summary>
        public decimal Price { get; set; } = 0;      

        /// <summary>Determines if discontinued.</summary>
        public bool IsDiscontinued { get; set; }

        public override string ToString()
        {
            return Name;
        }

        #region Private Members

        private string _name;
        private string _description;
        #endregion

        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            //Id is required
            if(Id < 0 )
                yield return new ValidationResult("Id is required", new[] { nameof(Id) });

            //Name is required
            if (String.IsNullOrEmpty(Name))//this.Name
                yield return new ValidationResult("Name is required", new[] { nameof(Name) });
            //Price is required
            if (Price < 0)
                yield return new ValidationResult("Price is required", new[] { nameof(Price) });





        }

    }

}
