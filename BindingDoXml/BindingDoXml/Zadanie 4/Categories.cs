using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Zadanie_4
{
    [XmlRoot("categories")]
    public class Categories
    {
        [XmlElement("category")]
        public List<Category> CategoryList { get; set; }
    }
}