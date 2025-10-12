using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
{
    public class studentquizUpdate
    {
        public int squizid { get; set; }
        public List<int> answers { get; set; }
    }
}