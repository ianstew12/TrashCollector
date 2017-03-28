using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class CollectorsViewModel
    {
        public List<ApplicationUser> customersToday { get; set; }
        public ApplicationUser user { get; set; }
    }
}