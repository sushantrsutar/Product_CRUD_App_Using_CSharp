using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionCrud
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Company { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , Price : {Price} , Company : {Company}";
        }
    }
}
