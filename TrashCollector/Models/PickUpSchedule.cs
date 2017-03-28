using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace TrashCollector.Models
{
    public class PickUpSchedule
    {
        [Key]
        public int id { get; set; }        
   
        public int weeklyPickUpDay { get; set; }
        public DateTime specialPickUpDate { get; set; }
        public DateTime noPickUpsStart { get; set; }
        public DateTime noPickUpsEnd { get; set; }
        
        //date picker may help 
    }
}