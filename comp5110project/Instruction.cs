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
    public partial class Instruction : Form
    {
        public Instruction()
        {
            InitializeComponent();
        }

        private void Instruction_Load(object sender, EventArgs e)
        {
           
            label1.Text = "Welcome! And is &&, Or is V(UpperCaseEnglishLetter), Not is ~, DoubleNegation is ~~, \n Implication is ->, Contradition is _|_\n Enter Premise and Conclusion Properly in the textbox. \n You can only edit/delete the premise and conclusion in the large textbox \n Then click the start to begin the proof\n You can type the line number,choose rule in the dropbox and apply it";
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
