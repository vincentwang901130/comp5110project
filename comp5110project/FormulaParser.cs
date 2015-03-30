using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp5110project
{
    public class FormulaParser{
     public Formula parse(String text) {
		Formula result = null;
		
		try {
			text = text.Trim();
			text = removeoutbracket(text);
			result = tryParseAsSymbol(text);
			if(result == null)
				result = tryParseAsContradiction(text);
			if(result == null)
				result = tryParseImplicationAndEquivalence(text);
			if(result == null)
				result = tryParseAndAndOr(text);
			if(result == null)
				result = tryParseNot(text);
			
		} catch(Exception e) {
			result = null;
		}
		
		return result;
	}
	
        public String removeoutbracket(String formula)
        {
            if (formula.Length < 3)
                return formula;
            if (!((formula[0] == '(') && (formula[formula.Length - 1] == ')')))
                return formula;
            Boolean outbracket = true;
            int numParen = 0;
            for (int i = 0; i < formula.Length - 1; i++)
            {
                if (formula[i] == '(')
                    numParen++;
                else if (formula[i] == ')')
                {
                    numParen--;
                    if (numParen == 0)
                    {

                        outbracket = false;
                        break;

                    }
                }
            }
            if (outbracket)
                return formula.Substring(1, formula.Length - 2).Trim();
            else
                return formula;
        }

       // public List<String> getsubformula(String formula)
       //{
       //   int LCcount = 0;
       //   int RCcount = 0;
       //   List<String> list = new List<String>();
       //         String f = this.removeoutbracket(formula);
       //         for (int i = 0; i < f.Length; i++)
       //             {
       //                 if (i == 0)
       //              {
       //             if (f[i] != '(')
       //             {
       //                 if (Char.IsLower(f[i]))
       //                 {
       //                     list[0] = f[i].ToString();
       //                     list[1] = f[i + 1].ToString();
       //                     list[2] = f.Substring(i + 2, f.Length - 2);
       //                     break;
       //                 }
       //                 else if (f[i] == '~' || Char.IsLower(f[i + 1]))
       //                 {
       //                     list[0] = f.Substring(i, 2);
       //                     list[1] = f[i + 2].ToString();
       //                     list[2] = f.Substring(i + 3, f.Length - 3);
       //                     break;
       //                 }
       //                 else if (f[i] == '~' || f[i + 1] == '~')
       //                 {
       //                     list[0] = f.Substring(i, 3);
       //                     list[1] = f[i + 3].ToString();
       //                     list[2] = f.Substring(i + 4, f.Length - 4);
       //                     break;
       //                 }

       //             }
       //              else if (f[i] == '(')
       //                     LCcount++;
       //                    if (f[i] == ')')
       //                     RCcount++;
       //                  if (RCcount == LCcount)
       //                     {
       //                     list[0] = f.Substring(0, i);
       //                     list[1] = f[i + 1].ToString();
       //                     list[2] = f.Substring(i + 2, f.Length - (i + 2));
       //                     }
       //              }
               
       //      }
       //     return list;
       //  }

  
    
	
	public Formula tryParseAsSymbol(String text)  {
		Formula result = null;
		
		if((text.Length == 1) && (Symbol.charIsEnglishLetter(text[0])))
				result = new Symbol(text[0]);
		
		return result;
	}
	
	public Formula tryParseAsContradiction(String text) {
		if(text.Equals("_|_"))
			return new Contradiction();
		else 
			return null;
	}
	
	public Formula tryParseImplicationAndEquivalence(String text){
		Formula result = null;

		// Go thorugh every char in the String, but do not consider things within parentheses
		int numParen = 0;		
		for(int i = 0; i < text.Length; i++) {		
			if(text[i] == '(')
				numParen++;
			else if(text[i] == ')') { 
				numParen--;
			}
			
			if(numParen == 0) {
				// Implication (->)
				if((text[i] == '-') && (i < text.Length-1) && (text[i+1] == '>')) {
					Formula subformula1 = parse(text.Substring(0, i));
					Formula subformula2 = parse(text.Substring(i+2));
					if(subformula1 != null && subformula2 != null)
						result = new Implication(subformula1, subformula2);
					break;
				}
				
				// Equivalence (<->)
				if((text[i] == '<') && (i < text.Length-2) && (text[i+1] == '-') && (text[i+2] == '>')) {
					Formula subformula1 = parse(text.Substring(0, i));
					Formula subformula2 = parse(text.Substring(i+3));
					if(subformula1 != null && subformula2 != null)
						result = new Equivalence(subformula1, subformula2);
					break;					
				}
			}
		}
		
		return result;		
	}
	
	public Formula tryParseAndAndOr(String text){
		Formula result = null;

		// Go thorugh every char in the String, but do not consider things within parentheses
		int numParen = 0;		
		for(int i = 0; i < text.Length; i++) {		
			if(text[i] == '(')
				numParen++;
			else if(text[i] == ')') { 
				numParen--;
			}
			
			if(numParen == 0) {
				// And (&)
				if(text[i] == '&') {
					Formula subformula1 = parse(text.Substring(0, i));
					Formula subformula2 = parse(text.Substring(i+1));
					if(subformula1 != null && subformula2 != null)
						result = new And(subformula1, subformula2);
					break;
				}
				
				// Or (\/)
				if((text.[i] == '\\') && (i < text.Length-1) && (text[i+1] == '/')) {
					Formula subformula1 = parse(text.Substring(0, i));
					Formula subformula2 = parse(text.Substring(i+2));
					if(subformula1 != null && subformula2 != null)
						result = new Or(subformula1, subformula2);
					break;					
				}
			}
		}
		
		return result;
	}
	
	public Formula tryParseNot(String text) {
		Formula result = null;

		if(text.Length > 0 && (text[0] == '~' || text[0] == '-')) {
			Formula subresult = parse(text.Substring(1));
			if(subresult != null)
				result = new Not(subresult);
		}
		
		return result;
	}





    }
}

