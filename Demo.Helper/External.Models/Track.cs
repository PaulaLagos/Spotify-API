﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Demo.Helper.External.Models
{
    [Serializable]
    [XmlRoot("Tracks"), XmlType("Tracks")]
    public class Track
    {
        public string ID { get; set; }
        public string name { get; set; }
        public string tracknumber { get; set; }
        public string length { get; set; }
        public string popularity { get; set; }
    }
}
