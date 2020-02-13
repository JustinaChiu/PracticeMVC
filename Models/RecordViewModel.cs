using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeMVC.Models
{
    public class Records
    {
        public Guid ID { get; set; }
        public int Type { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
    }
}