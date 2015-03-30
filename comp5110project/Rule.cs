using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp5110project
{
    public class Rule
    {
        public String result;
        //合取导出
        public String AndElim(String formula1, String formula2) {
            String[] temp;
            string result="";
           if(formula1.Length<4&&formula1[0]=='~'||formula1.Length==1){
                 string a= formula1;
                 formula1=formula2;
                 formula2=a;
           }
            FormulaExtract FE = new FormulaExtract();
            temp = FE.parsedformula(formula1);
            if (!temp[1].Equals("&")){
                result = "Error Input";
                 }
            else {

                if (formula2 == (FE.RemoveBracket(temp[0])))
                    result = temp[2];
                else if (formula2==(FE.RemoveBracket(temp[2])))
                    result = temp[0];
                else
                    result = "Error Input";
            }
            return result;
        }

        

        public String[] AndElim(String formula) {
            String[] temp;
            String[] result=new String[2]; 
            FormulaExtract FE = new FormulaExtract();
            temp = FE.parsedformula(formula);
            if (!temp[1].Equals("&"))
            {
                result[0] = "Error Input";
            }
            else {
                result[0] = FE.RemoveBracket(temp[0]);
                result[1] = FE.RemoveBracket(temp[2]);
            }
            return result;

        }
        //合取引入
        public String AndIntro(String formula1, String formula2) {
            String result = "";
            String f1;
            String f2;
            if (formula1[0] != '~' && formula1.Length > 3)
                f1 = "(" + formula1 + ")";
            else
                f1 = formula1;
            if (formula1[0] != '~' && formula2.Length > 3||Char.IsLower(formula2[0])&&formula2.Length==3)
                f2 = "(" + formula2 + ")";
            else
                f2 = formula2;
            return result=f1+"&"+f2;
        }
        //双重否定引入
        public String DNIntro(String formula1)
        {  
         
            String result ;
            if(Char.IsLower(formula1[0])&&formula1.Length==1)
            return result="~~"+formula1;
            else 
            return result="~~"+"("+formula1+")";

       }
        //双重否定导出
        public String DNElim(String formula1)
        {
            String result;
            if (formula1[0] == '~' && formula1[1] == '~')
                return result = formula1.Substring(2, formula1.Length - 2);
            else
                return result = "Error Input";
        }
        //涉及导出
        public String ImplicationElim(String formula1, String formula2)
        {
            String[] temp;
            string result;
            FormulaExtract FE = new FormulaExtract();
            temp = FE.parsedformula(formula1);
            if (!temp[1].Equals("->"))
            {
                result = "Error Input";
            }
            else
            {
                if (formula2==FE.RemoveBracket(temp[0]))
                    result = temp[2];
              else
                result = "Error Input";
            }
            return result;
        }
        //涉及引入
        public String ImplicationIntro(String formula1, String formula2)
        {
            String f1;
            String f2;
            String result;
         if(formula1.Length==1||(formula1[1]=='~'&&formula1.Length<3))
            f1=formula1;
         if (formula2.Length == 1 || (formula2[1] == '~' && formula2.Length < 3))
            f2=formula2;              
         if ((Char.IsLower(formula1[0]) && formula1.Length > 1) || (formula1[0] == '~' && formula1.Length > 3))
                f1 = "(" + formula1 + ")";
                else
                f1 = formula1;
         if ((Char.IsLower(formula2[0]) && formula2.Length > 1 ) ||(formula2[0] == '~' && formula2.Length > 3))
                f2 = "(" + formula2 + ")";
                 else
                f2 = formula2;
            
            return result = f1 + "->" + f2;
        }
        //否定导出
        public String NotElim(String formula1, String formula2)
        {
            string result;
            if(formula1[0]!='~'||formula2[0]!='~')
                 result="Error Input";
            if (formula1.Equals(formula2.Substring(1))||formula1.Substring(1).Equals(formula2))
            {
                 result = "_|_";
            }
            else
                result = "Error Input";
            return result;
        }
        //否定引入
        public String NotIntro(String formula1, String formula2)
        {
            String result="0";
            FormulaExtract FE = new FormulaExtract();
            if (formula2 != "_|_")
            {
                result = "Error Input";
            }
            else
            {
                if (formula1[0] == '~' && formula1[1]!='(')
                    result = formula1.Substring(1);
                if (formula1[0] == '~' && formula1[1] == '(')
                    result = FE.RemoveBracket(formula1.Substring(1));
                if (formula1[0] == '~' && formula1[1] == '~' && formula1.Length > 3)
                    result = "~" + formula1.Substring(2);
                if (Char.IsLower(formula1[1])&& formula1.Length==1)
                    result = "~" + formula1;
                if (Char.IsLower(formula1[0]) && formula1.Length > 2)
                    result = "~(" + formula1 + ")";
            }
            return result;
        }
        //或者导出
        public String OrElim(String formula1, String formula2)
        {
            String result;
            if (formula1 != formula2)
            {
                return result = "Error Input";
            }
            else
                return result = formula1;
           
           
        }
        //或者引入
        public String OrIntro(String formula1, String formula2)
        {
            String result;
            String f1;
            String f2;

            if (formula1.Length >= 3 && formula1[0] != '~')
                f1 = "(" + formula1 + ")";
            else
                f1 = formula1;
            if (formula2.Length >= 3 && formula2[0] != '~')
                f2 = "(" + formula2 + ")";
            else
                f2 = formula2;
            return result = f1 + "V" + f2;
        }
        //引入MT
        public String MT(String formula1, String formula2) {
            String result;
            String[] f1;
            FormulaExtract FE= new FormulaExtract();
            f1 = FE.parsedformula(formula1);
            if(f1[1]!="->"){
               result="Error Input";
            }

            if (formula2[0] == '~')
            {
                if (formula2.Substring(1).Equals(f1[2]))
                {
                    result = "~" + formula1[0];
                }
                else
                {
                    result = "Error Input";
                }
            }
            else{
                if (formula2[0] != '~') 
                { 
                if(formula2.Equals(f1[2].Substring(1)))
                    result="~"+formula1[0];
                    else
                        result="Error Input";
                }
                else  
                     result="Error Input";
            }
        return result;
        }
        //引入LEM

        public String LEM(String formula1) {
            String result;
            String f1;

            if (formula1[0] == '~')
            {
                f1 = formula1.Substring(1);

            }
            else{
                if (formula1.Length > 1)
                {
                    f1 = "~(" + formula1 + ")";
                    
                }
                else
                    f1 = "~" + formula1;
           }

            return result = formula1+"V"+f1;
        }
  
           

    }
}
