using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp5110project
{
    public abstract class Connective : Formula
    {
        protected Formula formula1 = null;
        protected Formula formula2 = null;

     
        public abstract String symbolToString();

        public Connective(Formula f1, Formula f2)
        {
          
            formula1 = f1;
            formula2 = f2;
        }

        public Formula getSubformula1()
        {
            return formula1;
        }

        public Formula getSubformula2()
        {
            return formula2;
        }

        public String toString()
        {
            return toString(false);
        }

        public String toString(Boolean skipParenthesesOnce)
        {
            // This function is overridden in Not 
            String s = "";
            if (!skipParenthesesOnce)
                s += '(';
            if (formula1 != null)
                s += formula1.ToString() + ' ';
            s += symbolToString();
            if (formula2 != null)
                s += ' ' + formula2.ToString();
            if (!skipParenthesesOnce)
                s += ')';
            return s;


        }
    }
}
