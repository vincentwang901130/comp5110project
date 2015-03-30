using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp5110project
{
   public class FormulaExtract
    {

      

        public String RemoveBracket(String formula)
        {
            if (formula.Length < 3)
                return formula;
            if (!((formula[0] == '(') && (formula[formula.Length - 1] == ')')))
                return formula;

            // if formula has out bracket
            Boolean hasOuterParenthesis = true;

            // Try to find where the bracket that started at 1st char ends
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
                        // First bracket ended somewhere before the last char of the string
                        hasOuterParenthesis = false;
                        break;
                    }
                }
            }

            if (hasOuterParenthesis)
                return formula.Substring(1, formula.Length - 2).Trim(); 			// Remove bracket
            else
                return formula;										 	//Return original String
        }
        public String[] parsedformula(String f)
        {

            String[] str = new String[3];
            int count = 0;
            int pointer = 0;
            int pointer1 = 0;
            if (f.Length == 1) {
                str[0] = str[1] = str[2] = "Error Input";
            }


            //~()connective... ~~()connective...
            if ((f[0] == '~' && f[1] == '(') || (f[1] == '~' && f[2] == '('))
            {
                for (int i = 0; i < f.Length - 1; i++)
                {
                    if (f[i] == '(')
                    {
                        count = count + 1;
                    }

                    if (f[i] == ')')
                    {
                        count = count - 1;
                        if (count == 0)
                        {
                            pointer1 = i;

                        }
                    }

                }
                str[0] = f.Substring(0, pointer1 + 1);
                if (f[pointer1 + 1] == '-')
                {
                    str[1] = f.Substring(pointer1 + 1, 2);
                    str[2] = f.Substring(pointer1 + 3);
                }
                else
                {
                    str[1] = f.Substring(pointer1 + 1, 1);
                    str[2] = f.Substring(pointer1 + 2);
                }
            }

                //~s connective ... ~~s connective ...  s connective ...
            else if (f[0] != '(')
            {
                if (Char.IsLower(f[0]))
                {
                    str[0] = f[0].ToString();
                    if (f[1] == '-')
                    {
                        str[1] = f.Substring(1, 2);
                        str[2] = f.Substring(3);
                    }
                    else
                    {
                        str[1] = f[1].ToString();
                        str[2] = f.Substring(2);
                    }
                }
                if (f[0] == '~')
                {
                    if (Char.IsLower(f[1]))
                    {
                        str[0] = f.Substring(0, 2);
                        if (f[2] == '-')
                        {
                            str[1] = f.Substring(2, 2);
                            str[2] = f.Substring(4);
                        }
                        else
                        {
                            str[1] = f[2].ToString();
                            str[2] = f.Substring(3);
                        }
                    }

                }
                if (f[0] == '~' && f[1] == '~')
                {
                    str[0] = f.Substring(0, 3);
                    if (f[3] == '-')
                    {
                        str[1] = f.Substring(3, 2);
                        str[2] = f.Substring(5);
                    }
                    else
                    {
                        str[1] = f[3].ToString();
                        str[2] = f.Substring(4);
                    }
                }
            }
            else
            {
                //()connective...
                for (int i = 0; i < f.Length - 1; i++)
                {



                    if (f[i] == '(' || f[1] == '(' || f[2] == '(')
                    {
                        count = count + 1;
                    }

                    if (f[i] == ')')
                    {
                        count = count - 1;
                        if (count == 0)
                        {
                            pointer = i;

                        }
                    }

                }
                str[0] = f.Substring(0, pointer + 1);
                if (f[pointer + 1] == '-')
                {
                    str[1] = f.Substring(pointer + 1, 2);
                    str[2] = f.Substring(pointer + 3);
                }
                else
                {
                    str[1] = f.Substring(pointer + 1, 1);
                    str[2] = f.Substring(pointer + 2);
                }
            }
            return str;
        }
            
        }
        
    }


