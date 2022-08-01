using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Food
    {
        public virtual int Price(int a)
        {
            price += a * 200;
            return price;
        }
        public virtual int Caloria(int b)
        {
            caloria += b * 20;
            return caloria;
        }
        public string ingridients;
        public int price;
        public string size;
        public bool IsDiet;
        public int caloria;
        public DateTime DateTime; 
    }
}
