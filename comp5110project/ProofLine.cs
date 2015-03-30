using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp5110project
{
    public class ProofLine
    {
        public String proofLine(int linenum, String formula, String j) {
            String pl="";
            pl= linenum.ToString() + "        " +formula+"     "+j;
            return pl;
        }

    }
}
