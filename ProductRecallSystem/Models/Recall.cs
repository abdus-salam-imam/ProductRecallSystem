using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductRecallSystem.Models
{
    public class Recall
    {
        [DisplayName("Recall")]
        public int RecallId { get; set; }

        [DisplayName("Recall Title")]
        public string Description { get; set; }
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]

        public DateTime StartDate { get; set; }

        [DisplayName("End Date")]
        [DataType(DataType.Date)]

        public DateTime EndDate { get; set; }

        //product 
        [DisplayName("Product")]
        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }


        //Manufacture 
        [DisplayName("Manufactuer")]
        public int? ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }

        //Annoucement 

        public IEnumerable<Announcement> Announcements { get; set; }

        [NotMapped]
        public SelectList ManufactureList { get; set; }

        [NotMapped]
        public string Title
        {
            get
            {
                if (RecallId > 0)
                {
                    return "Edit Recall";

                }
                else
                {
                    return "New Recall";
                }

            }
        }

    }
}
