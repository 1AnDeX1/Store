using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Store.ManufacturerOfGoods;

namespace Store
{
    public class Goods 
    {
        
        public struct Good 
        {           
            private string Name { get; set; }
            private double Price { get; set; }
            
            public double NewPrice(double manufacturerOfGoodPrice)
            {
                ManufacturerOfGood manufacturerOfGood = new ManufacturerOfGood();
                
                Price = manufacturerOfGood.NewPrice(manufacturerOfGoodPrice) *1.3;
                return Price;
            }

            public string Mark(string Name)
            {
                string mark = " (+)";
                this.Name = Name + mark; 
                return this.Name;
            }
            public string UnMark(string Name)
            {
                
                this.Name = Name.Replace(" (+)", "");
                return this.Name;
            }
        }
        
    }
}
