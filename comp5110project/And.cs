using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp5110project
{
  public class And:Connective 
    {
        public And(Formula f1, Formula f2):base(f1, f2)
        {
         
        }

        protected void checkInput(Formula f1, Formula f2)
        {
            if (f1 == null || f2 == null)
                throw new Exception("An 'and' requires two formulas");
        }

        public String symbolToString()
        {
            return "&";
        }
    }
}
