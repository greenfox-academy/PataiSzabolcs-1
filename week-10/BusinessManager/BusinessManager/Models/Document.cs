﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessManager.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public Case Case { get; set; }
        public IList<Event> Events { get; set; }
    }
}
