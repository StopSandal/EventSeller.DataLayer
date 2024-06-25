﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.Event
{
    public class AddEventDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime StartEventDateTime { get; set; }
        [Required]
        public DateTime EndEventDateTime { get; set; }
        [Required]
        public long EventTypeID { get; set; }
    }
}
