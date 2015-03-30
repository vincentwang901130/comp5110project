namespace comp5110project
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.inputpre = new System.Windows.Forms.TextBox();
            this.Proof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputcon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.premiseinput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.conclusioninput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lineinput = new System.Windows.Forms.TextBox();
            this.Assumption = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Hint1 = new System.Windows.Forms.Label();
            this.Hint2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Vformula = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(363, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Apply
            // 
            this.Apply.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apply.Location = new System.Drawing.Point(363, 223);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(87, 29);
            this.Apply.TabIndex = 2;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // inputpre
            // 
            this.inputpre.Location = new System.Drawing.Point(105, 48);
            this.inputpre.Name = "inputpre";
            this.inputpre.Size = new System.Drawing.Size(250, 22);
            this.inputpre.TabIndex = 3;
            // 
            // Proof
            // 
            this.Proof.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proof.Location = new System.Drawing.Point(457, 33);
            this.Proof.Multiline = true;
            this.Proof.Name = "Proof";
            this.Proof.Size = new System.Drawing.Size(453, 412);
            this.Proof.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Premise";
            // 
            // inputcon
            // 
            this.inputcon.Location = new System.Drawing.Point(105, 93);
            this.inputcon.Name = "inputcon";
            this.inputcon.Size = new System.Drawing.Size(250, 22);
            this.inputcon.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Conclusion";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.button4.Location = new System.Drawing.Point(595, 460);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 27);
            this.button4.TabIndex = 10;
            this.button4.Text = "Instruction";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Welcome! This is a tool for building natural deduction proofs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.label4.Location = new System.Drawing.Point(6, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Line";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "&E",
            "&I",
            "~~E",
            "~~I",
            "->E",
            "->I",
            "~E",
            "~I",
            "VE",
            "VI",
            "MT",
            "LEM"});
            this.comboBox1.Location = new System.Drawing.Point(206, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 22);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.label6.Location = new System.Drawing.Point(153, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Rules";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.start.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(345, 125);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(105, 50);
            this.start.TabIndex = 16;
            this.start.Text = "StartProof";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.label7.Location = new System.Drawing.Point(6, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Start Proof";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.button5.Location = new System.Drawing.Point(458, 460);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 27);
            this.button5.TabIndex = 18;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // premiseinput
            // 
            this.premiseinput.Location = new System.Drawing.Point(23, 372);
            this.premiseinput.Multiline = true;
            this.premiseinput.Name = "premiseinput";
            this.premiseinput.Size = new System.Drawing.Size(422, 69);
            this.premiseinput.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.label8.Location = new System.Drawing.Point(455, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Proof";
            // 
            // conclusioninput
            // 
            this.conclusioninput.Location = new System.Drawing.Point(23, 477);
            this.conclusioninput.Multiline = true;
            this.conclusioninput.Name = "conclusioninput";
            this.conclusioninput.Size = new System.Drawing.Size(422, 69);
            this.conclusioninput.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.label5.Location = new System.Drawing.Point(14, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Premise";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.label9.Location = new System.Drawing.Point(20, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Conclusion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.label10.Location = new System.Drawing.Point(6, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Select";
            // 
            // lineinput
            // 
            this.lineinput.Location = new System.Drawing.Point(52, 223);
            this.lineinput.Name = "lineinput";
            this.lineinput.Size = new System.Drawing.Size(93, 22);
            this.lineinput.TabIndex = 25;
            // 
            // Assumption
            // 
            this.Assumption.Location = new System.Drawing.Point(105, 182);
            this.Assumption.Name = "Assumption";
            this.Assumption.Size = new System.Drawing.Size(248, 22);
            this.Assumption.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.Location = new System.Drawing.Point(6, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Assumption";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(363, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 29);
            this.button3.TabIndex = 28;
            this.button3.Text = "Insert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Hint1
            // 
            this.Hint1.AutoSize = true;
            this.Hint1.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.Hint1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Hint1.Location = new System.Drawing.Point(66, 329);
            this.Hint1.Name = "Hint1";
            this.Hint1.Size = new System.Drawing.Size(50, 17);
            this.Hint1.TabIndex = 29;
            this.Hint1.Text = "label12";
            this.Hint1.Visible = false;
            this.Hint1.Click += new System.EventHandler(this.Hint1_Click);
            // 
            // Hint2
            // 
            this.Hint2.AutoSize = true;
            this.Hint2.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.Hint2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Hint2.Location = new System.Drawing.Point(153, 329);
            this.Hint2.Name = "Hint2";
            this.Hint2.Size = new System.Drawing.Size(50, 17);
            this.Hint2.TabIndex = 30;
            this.Hint2.Text = "label13";
            this.Hint2.Visible = false;
            this.Hint2.Click += new System.EventHandler(this.Hint2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(769, 460);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.label12.Location = new System.Drawing.Point(589, 521);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Wenqian Wang 100977180";
            // 
            // Vformula
            // 
            this.Vformula.Location = new System.Drawing.Point(92, 267);
            this.Vformula.Name = "Vformula";
            this.Vformula.Size = new System.Drawing.Size(259, 22);
            this.Vformula.TabIndex = 33;
            this.Vformula.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Formula";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(589, 538);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 14);
            this.label14.TabIndex = 35;
            this.label14.Text = "vincentwnag901130@me.com";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 561);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Vformula);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Hint2);
            this.Controls.Add(this.Hint1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Assumption);
            this.Controls.Add(this.lineinput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.conclusioninput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.premiseinput);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Proof);
            this.Controls.Add(this.inputpre);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "RavenProver";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.TextBox inputpre;
        private System.Windows.Forms.TextBox Proof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox premiseinput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox conclusioninput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lineinput;
        private System.Windows.Forms.TextBox Assumption;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Hint1;
        private System.Windows.Forms.Label Hint2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Vformula;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

