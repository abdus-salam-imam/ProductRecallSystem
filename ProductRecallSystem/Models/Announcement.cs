using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductRecallSystem.Models
{
    public class Announcement
    {
        public int AnnouncementId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }

    }
}
