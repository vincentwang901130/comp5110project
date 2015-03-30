using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp5110project
{
    public partial class MainForm : Form
    {
        public String premise;
        public String conclusion;
        public String inputline;
        public String pl;
        public int countline;
        public List<String> formula = new List<String>();
        public void checkedfinished(String formula) {
            if (formula.Equals(conclusion)) {
                MessageBox.Show("Done!");
                
            }
        
        }

        public MainForm()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputpre.Text.ToString() == "")
            {
                MessageBox.Show("Cannot be blank");
            }
            else
            {
                premise = inputpre.Text.ToString();
                List<string> lists = this.premiseinput.Lines.ToList<string>();
                lists.Add(premise);
                this.premiseinput.Lines = lists.ToArray();
                inputpre.Clear();
            }
      

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (inputcon.Text.ToString() == "")
            {
                MessageBox.Show("Cannot be blank");
            }
            else
            {
                conclusion = inputcon.Text.ToString();
                List<string> lists = this.conclusioninput.Lines.ToList<string>();
                lists.Add(conclusion + "  conclusion");
                this.conclusioninput.Lines = lists.ToArray();
                inputcon.Clear();
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
          
            if (conclusioninput.Text.ToString().Equals(""))
                MessageBox.Show("Conclusion cannot be blank");

            else
            {
              
                    List<string> premiselists = this.premiseinput.Lines.ToList<string>();
                    List<string> lists = this.Proof.Lines.ToList<string>();
                    for (int i = 0; i < premiseinput.Lines.Length; i++)
                    {
                        lists.Add(i + 1 + "   " + premiselists[i]+"     Premise");
                        formula.Add(premiselists[i]);
                    }
                    this.Proof.Lines = lists.ToArray();
                    countline = Proof.Lines.ToList<String>().Count;
                    this.premiseinput.ReadOnly = true;
                    this.conclusioninput.ReadOnly = true;
                    this.button1.Hide();
                    this.button2.Hide();
                    this.start.Hide();
               
               
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Proof.Clear();
            conclusioninput.Clear();
            premiseinput.Clear();
            lineinput.Clear();
            premiseinput.ReadOnly = false;
            conclusioninput.ReadOnly = false;
            start.Show();
            formula.Clear();
            premise="";
            conclusion="";
            inputline="";
            pl="";
            countline=0;
            button1.Visible = true;
            button2.Visible = true;
            start.Show();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Assumption.Text.ToString() != "")
            {
                List<String> list = Proof.Lines.ToList<String>();
                list.Add(countline + 1 + "   " + Assumption.Text.ToString() + "  Assumption");
                countline++;
                this.Proof.Lines = list.ToArray();
                formula.Add(Assumption.Text.ToString());
                Assumption.Clear();
            }
            else
                MessageBox.Show("Assumption cannot be blank");
        }

        private void Apply_Click(object sender, EventArgs e)
        {

            ProofLine pl = new ProofLine();
            String proof;
            String result1;
            String[] result2;
            Rule r = new Rule();
            String[] f = new String[2] { "0", "0" };
            List<String> list = Proof.Lines.ToList<String>();
            String[] line = lineinput.Text.ToString().Split(',');
            if (lineinput.Text.ToString() == "")
            {
                MessageBox.Show("Textbox:Line cannot be blank");
            }
            else
            {  // 将要使用规则的行号输入框内容转换整形数组
                //最多为2
                int[] str = Array.ConvertAll<string, int>(line, s => int.Parse(s));
                for (int i = 0; i < str.Length; i++)
                {
                    //list里的行号是从0开始计算，而用户界面看到的数字是从1开始计算，因此要减一
                    f[i] = formula[str[i] - 1];
                }
                int index = comboBox1.SelectedIndex;

                //and elim
                if (index == 0)
                {
                    if (str.Length == 1)
                    {
                        result2 = r.AndElim(f[0]);
                        if (result2[0] != "Error Input")
                        {
                            Hint1.Show();
                            Hint1.Text = result2[0];
                            Hint2.Show();
                            Hint2.Text = result2[1];
                        }
                        else
                            MessageBox.Show("Error Input");
                    }
                    else if (str.Length == 2)
                    {
                        result1 = r.AndElim(f[0], f[1]);
                        if (result1 != "Error Input")
                        {
                            countline++;
                            proof = pl.proofLine(countline, result1, "&e" + lineinput.Text.ToString());
                            formula.Add(result1);
                            list.Add(proof);
                            checkedfinished(result1);
                        }
                        else
                            MessageBox.Show("Error Input");
                    }
                }




                //and intro
                if (index == 1)
                {
                    if (str.Length == 1)
                    {
                        MessageBox.Show("To apply this rule you need two line input");
                    }
                    else if (str.Length == 2)
                    {
                        result1 = r.AndIntro(f[0], f[1]);
                        countline++;
                        proof = pl.proofLine(countline, result1, "&i" + lineinput.Text.ToString());
                        formula.Add(result1);
                        list.Add(proof);
                    }


                }
                //dn elim
                if (index == 2)
                {

                    result1 = r.DNElim(f[0]);
                    if (result1 != "Error Input")
                    {
                        countline++;
                        proof = pl.proofLine(countline, result1, "~~e" + lineinput.Text.ToString());
                        formula.Add(result1);
                        list.Add(proof);
                        checkedfinished(result1);
                    }
                    else
                        MessageBox.Show("Error Input");
                }
                //dn intro
                if (index == 3)
                {
                    result1 = r.DNIntro(f[0]);
                    result1 = r.DNIntro(f[0]);
                    countline++;
                    proof = pl.proofLine(countline, result1, "~~i" + lineinput.Text.ToString());
                    formula.Add(result1);
                    list.Add(proof);
                }

                //implication elim
                if (index == 4)
                {
                    if (str.Length == 1)
                    {
                        MessageBox.Show("To apply this rule you need two line input");
                    }
                    else if (str.Length == 2)
                    {

                        result1 = r.ImplicationElim(f[0], f[1]);
                        if (result1 != "Error Input")
                        {
                            countline++;
                            proof = pl.proofLine(countline, result1, "->e" + lineinput.Text.ToString());
                            formula.Add(result1);
                            list.Add(proof);
                            checkedfinished(result1);
                        }
                        else
                            MessageBox.Show("Error Left Formula Input");
                    }

                }
                //implication intro
                if (index == 5)
                {
                    if (str.Length == 1)
                    {
                        MessageBox.Show("To apply this rule you need two line input");
                    }
                    else if (str.Length == 2)
                    {


                        result1 = r.ImplicationIntro(f[0], f[1]);
                        if (result1 != "Error Input")
                        {
                            countline++;
                            proof = pl.proofLine(countline, result1, "->i" + lineinput.Text.ToString());
                            formula.Add(result1);
                            list.Add(proof);
                            checkedfinished(result1);
                        }
                        else
                            MessageBox.Show("Error Input");
                    }

                }



                //not-elim
                if (index == 6)
                {
                    if (str.Length == 1)
                    {
                        MessageBox.Show("To apply this rule you need two line input");
                    }
                    else if (str.Length == 2)
                    {
                        result1 = r.NotElim(f[0], f[1]);
                        if (result1 != "Error Input")
                        {
                            countline++;
                            proof = pl.proofLine(countline, result1, "->~e" + lineinput.Text.ToString());
                            formula.Add(result1);
                            list.Add(proof);
                            checkedfinished(result1);

                        }
                        else
                            MessageBox.Show("Error Input");
                    }

                }
                //not-intro
                if (index == 7)
                {
                    if (str.Length == 1)
                    {
                        MessageBox.Show("To apply this rule you need two line input");

                    }
                    else if (str.Length == 2)
                    {
                        result1 = r.NotIntro(f[0], f[1]);
                        if (result1 != "Error Input")
                        {
                            countline++;
                            proof = pl.proofLine(countline, result1, "->~i" + lineinput.Text.ToString());
                            formula.Add(result1);
                            list.Add(proof);

                        }
                        else
                            MessageBox.Show("Error Input");
                    }
                }




                //or-elim
                if (index == 8)
                {
                    if (str.Length == 1)
                    {
                        MessageBox.Show("To apply this rule you need two line input");
                    }
                    else if (str.Length == 2)
                    {
                        result1 = r.OrElim(f[0], f[1]);
                        if (result1 != "Error Input")
                        {
                            countline++;
                            proof = pl.proofLine(countline, result1, "->e" + lineinput.Text.ToString());
                            formula.Add(result1);
                            list.Add(proof);
                            checkedfinished(result1);

                        }
                        else
                            MessageBox.Show("Please check the line input");


                    }
                }
                //or-intro
                if (index == 9)
                {
                    if (str.Length == 1)
                    {
                        result1 = r.OrIntro(f[0], Vformula.Text.ToString());
                        countline++;
                        proof = pl.proofLine(countline, result1, "Vi" + lineinput.Text.ToString());
                        formula.Add(result1);
                        list.Add(proof);

                    }
                    else if (str.Length == 2)
                    {
                        MessageBox.Show("Error, You must enter another formula in textbox or apply &i");

                    }
                    this.label13.Hide();
                    this.Vformula.Hide();
                }
                //MT
                if (index == 10)
                {
                    if (str.Length == 1)
                    {
                        MessageBox.Show("To apply this rule you need two line input");
                    }
                    else if (str.Length == 2)
                    {
                        result1 = r.MT(f[0], f[1]);
                        if (result1 != "Error Input")
                        {
                            countline++;
                            proof = pl.proofLine(countline, result1, "MT" + lineinput.Text.ToString());
                            formula.Add(result1);
                            list.Add(proof);
                            checkedfinished(result1);
                        }
                        else
                            MessageBox.Show("Please check the line input");


                    }
                }
                //LEM
                if (index == 11)
                {
                    if (str.Length == 1)
                    {
                        result1 = r.LEM(f[0]);
                        countline++;
                        proof = pl.proofLine(countline, result1, "LEM" + lineinput.Text.ToString());
                        formula.Add(result1);
                        list.Add(proof);


                    }
                    else if (str.Length == 2)
                    {
                        MessageBox.Show("Error, You can only apply this rulle for one formula");

                    }
                }



                this.Proof.Lines = list.ToArray();
                
            }
        }
   
        private void Hint1_Click(object sender, EventArgs e)
        {
            ProofLine pl = new ProofLine();
            String proof;
            List<String> list = Proof.Lines.ToList<String>();
            countline = list.Count;
            countline++;
            String l1="&e1," + lineinput.Text.ToString();
            proof = pl.proofLine(countline, Hint1.Text.ToString(), l1);
            formula.Add(Hint1.Text.ToString());
            list.Add(proof);
            this.Proof.Lines = list.ToArray();
            checkedfinished(Hint1.Text.ToString());
            Hint1.Hide();
            Hint2.Hide();
           
        }

        private void Hint2_Click(object sender, EventArgs e)
        {
            ProofLine pl = new ProofLine();
            String proof;
            List<String> list = Proof.Lines.ToList<String>();
            countline = list.Count;
            countline++;
            String l2;
            l2 = "&e2," + lineinput.Text.ToString();
            proof = pl.proofLine(countline, Hint2.Text.ToString(), l2);
            formula.Add(Hint2.Text.ToString());
            list.Add(proof);
            this.Proof.Lines = list.ToArray();
            checkedfinished(Hint2.Text.ToString());
            Hint1.Hide();
            Hint2.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Instruction form = new Instruction();
            form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 9)
            {
                label13.Visible = true;
                Vformula.Visible = true;
            }
            
        }



    
    }
}
