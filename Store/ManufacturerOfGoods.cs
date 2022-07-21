using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public class ManufacturerOfGoods : Goods // виробник
    {
        public struct ManufacturerOfGood
        {
            private string Name { get; set; }
            private double ManufacturerPrice { get; set; }
            

            public double NewPrice(double Price)
            {
                ManufacturerPrice = Price;
                return ManufacturerPrice;
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
