using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace VragenTool
{
    public class Vraag
    {
        [XmlAttribute]
        public string txtVraag { get; set; }
        [XmlAttribute]
        public string txtAntwoord { get; set; }
    }
}
