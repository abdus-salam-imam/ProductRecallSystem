using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductRecallSystem.Models
{
    public class Announcement
    {
        public int AnnouncementId { get; set; }

        [DisplayName("Announcement Title")]
        public string Description { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }


        //Recall
        public int RecallId { get; set; }

        public virtual Recall Recall { get; set; }
    }
}
