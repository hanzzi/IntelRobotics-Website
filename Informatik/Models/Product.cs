using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Informatik.Models
{
    public class Product
    {
        public int ID;
        public string Name;
        public List<Image> Images;
        public List<Description> Descriptions;
    }
}
