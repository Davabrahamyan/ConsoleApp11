using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Shaurma : Food, IFood
    {
        public override int Price(int a)
        {
            return price+400*a;
        }
        public override int Caloria(int b)
        {
            return caloria+b*25;
        }
       
        public bool IsSpicy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ingridients1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
