using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    internal class Checker
    {
        public bool Check(object o)
        {
            if (o is IFormattable)
            {
                IFormattable form = o as IFormattable; 
                if (form != null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
