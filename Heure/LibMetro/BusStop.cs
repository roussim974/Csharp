﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMetro
{
    public class BusStop
    {
       
            public string id { get; set; }
            public string name { get; set; }
            public double lon { get; set; }
            public double lat { get; set; }
            public List<string> lines { get; set; }
       
    }
}
