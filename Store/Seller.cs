using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Sellers : Goods
    {
        public struct Seller
        {
            private string Name { get; set; }
            public int Sell(int Count, int UserValue)
            {
                int newCount = Count - UserValue;
                return newCount;
            }

            public int ExperienceIncrease(int Experience)
            {
                int newExperience = Experience + 1;
                return newExperience;
            }

            public string Null()
            {
                string a = " ";
                return a;
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
