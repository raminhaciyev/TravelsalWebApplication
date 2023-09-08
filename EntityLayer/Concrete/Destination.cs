﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
        public string DImageLarge { get; set; }
        public string DTitle { get; set; }
        public string DExplanation1 { get; set; }
        public string DExplanation2 { get; set; }
        public string DExplanation3 { get; set; }
        public string DImage1 { get; set; }
        public string DImage2 { get; set; }
    }
}
