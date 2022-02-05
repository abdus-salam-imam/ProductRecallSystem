using ProductRecallSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductRecallSystem.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Announcement> AnnouncementList { get; set; }

        public IEnumerable<Recall> RecallList { get; set; }



    }
}
