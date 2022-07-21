using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class SupplierOfGoods : Goods // постачальник
    {
        public struct SupplierOfGood
        {
           private string Name { get; set; }

            public int Buy(int Count, int UserValue)
            {
                int newCount = Count + UserValue;
                return newCount;
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
