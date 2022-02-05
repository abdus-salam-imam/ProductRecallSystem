using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductRecallSystem.Models
{
    public class Manufacturer
    {

        public int ManufacturerId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }


        [NotMapped]
        public string Title
        {
            get
            {
                if (ManufacturerId> 0)
                {
                    return "Edit Manufacturer";
                    
                }
                else
                {
                    return "New Manufacturer";
                }
                
            }
        }
        
}     
            
             
                

}

