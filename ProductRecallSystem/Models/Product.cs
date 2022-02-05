using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductRecallSystem.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        //Manufacturer 
        [DisplayName("Manufacturer")]
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }


        
        //Manufacturere DropDown List

        [NotMapped]
        public SelectList ManufacuturerList { get; set; }

        //Recall
        public virtual IEnumerable<Product> Products { get; set; }

        [NotMapped]
        public string Title
        {
            get
            {
                if (ProductId > 0)
                {
                    return "Edit Product";

                }
                else
                {
                    return "New Product";
                }

            }
        }


    }
}
