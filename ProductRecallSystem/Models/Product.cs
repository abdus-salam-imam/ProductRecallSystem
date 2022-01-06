using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
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
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }


        //Recall
        public int? RecallId { get; set; }
        public virtual Recall Recall { get; set; }


        //Announcement
        public int? AnnouncementId { get; set; }
        public virtual Announcement Announcement { get; set; }

        //Manufacturere DropDown List

        [NotMapped]
        public SelectList ManufacuturerList { get; set; }


    }
}
