namespace SSH_Manager_V2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDir1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDir2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbR2 = new System.Windows.Forms.Label();
            this.lbE2 = new System.Windows.Forms.Label();
            this.lbR1 = new System.Windows.Forms.Label();
            this.lbE1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.rbEg = new System.Windows.Forms.RadioButton();
            this.rbEu = new System.Windows.Forms.RadioButton();
            this.rbSp = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btFilterExcept = new System.Windows.Forms.Button();
            this.txProper = new System.Windows.Forms.TextBox();
            this.rbProper = new System.Windows.Forms.RadioButton();
            this.txtEUUS = new System.Windows.Forms.TextBox();
            this.rbEUUS = new System.Windows.Forms.RadioButton();
            this.txtCAll = new System.Windows.Forms.TextBox();
            this.txtSp = new System.Windows.Forms.TextBox();
            this.txtEu = new System.Windows.Forms.TextBox();
            this.txtEg = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lbIP = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDir1
            // 
            this.txtDir1.AllowDrop = true;
            this.txtDir1.Location = new System.Drawing.Point(91, 21);
            this.txtDir1.Multiline = true;
            this.txtDir1.Name = "txtDir1";
            this.txtDir1.Size = new System.Drawing.Size(283, 23);
            this.txtDir1.TabIndex = 0;
            this.txtDir1.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDir1_DragDrop);
            this.txtDir1.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDir1_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dir Source 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dir Source 2";
            // 
            // txtDir2
            // 
            this.txtDir2.AllowDrop = true;
            this.txtDir2.Location = new System.Drawing.Point(91, 79);
            this.txtDir2.Multiline = true;
            this.txtDir2.Name = "txtDir2";
            this.txtDir2.Size = new System.Drawing.Size(283, 23);
            this.txtDir2.TabIndex = 2;
            this.txtDir2.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDir2_DragDrop);
            this.txtDir2.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDir2_DragEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbR2);
            this.groupBox1.Controls.Add(this.lbE2);
            this.groupBox1.Controls.Add(this.lbR1);
            this.groupBox1.Controls.Add(this.lbE1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDir2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDir1);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dir Source";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbR2
            // 
            this.lbR2.AutoSize = true;
            this.lbR2.Location = new System.Drawing.Point(252, 112);
            this.lbR2.Name = "lbR2";
            this.lbR2.Size = new System.Drawing.Size(52, 13);
            this.lbR2.TabIndex = 7;
            this.lbR2.Text = "Result : 0";
            // 
            // lbE2
            // 
            this.lbE2.AutoSize = true;
            this.lbE2.Location = new System.Drawing.Point(107, 112);
            this.lbE2.Name = "lbE2";
            this.lbE2.Size = new System.Drawing.Size(49, 13);
            this.lbE2.TabIndex = 6;
            this.lbE2.Text = "Errors : 0";
            // 
            // lbR1
            // 
            this.lbR1.AutoSize = true;
            this.lbR1.Location = new System.Drawing.Point(252, 53);
            this.lbR1.Name = "lbR1";
            this.lbR1.Size = new System.Drawing.Size(52, 13);
            this.lbR1.TabIndex = 5;
            this.lbR1.Text = "Result : 0";
            // 
            // lbE1
            // 
            this.lbE1.AutoSize = true;
            this.lbE1.Location = new System.Drawing.Point(107, 53);
            this.lbE1.Name = "lbE1";
            this.lbE1.Size = new System.Drawing.Size(49, 13);
            this.lbE1.TabIndex = 4;
            this.lbE1.Text = "Errors : 0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 31);
            this.button3.TabIndex = 10;
            this.button3.Text = "Dup One File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(91, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 31);
            this.button4.TabIndex = 11;
            this.button4.Text = "Dup Two Files";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 90);
            this.button5.TabIndex = 12;
            this.button5.Text = "Filter Country";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // rbEg
            // 
            this.rbEg.AutoSize = true;
            this.rbEg.Location = new System.Drawing.Point(69, 50);
            this.rbEg.Name = "rbEg";
            this.rbEg.Size = new System.Drawing.Size(154, 17);
            this.rbEg.TabIndex = 13;
            this.rbEg.Text = "English Speaking Countries";
            this.rbEg.UseVisualStyleBackColor = true;
            // 
            // rbEu
            // 
            this.rbEu.AutoSize = true;
            this.rbEu.Location = new System.Drawing.Point(69, 80);
            this.rbEu.Name = "rbEu";
            this.rbEu.Size = new System.Drawing.Size(118, 17);
            this.rbEu.TabIndex = 14;
            this.rbEu.Text = "European Countries";
            this.rbEu.UseVisualStyleBackColor = true;
            // 
            // rbSp
            // 
            this.rbSp.AutoSize = true;
            this.rbSp.Location = new System.Drawing.Point(69, 108);
            this.rbSp.Name = "rbSp";
            this.rbSp.Size = new System.Drawing.Size(158, 17);
            this.rbSp.TabIndex = 15;
            this.rbSp.Text = "Spanish Speaking Countries";
            this.rbSp.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(69, 135);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(75, 17);
            this.rbAll.TabIndex = 16;
            this.rbAll.Text = "All Country";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btFilterExcept);
            this.groupBox2.Controls.Add(this.txProper);
            this.groupBox2.Controls.Add(this.rbProper);
            this.groupBox2.Controls.Add(this.txtEUUS);
            this.groupBox2.Controls.Add(this.rbEUUS);
            this.groupBox2.Controls.Add(this.txtCAll);
            this.groupBox2.Controls.Add(this.txtSp);
            this.groupBox2.Controls.Add(this.txtEu);
            this.groupBox2.Controls.Add(this.txtEg);
            this.groupBox2.Controls.Add(this.rbAll);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.rbSp);
            this.groupBox2.Controls.Add(this.rbEu);
            this.groupBox2.Controls.Add(this.rbEg);
            this.groupBox2.Location = new System.Drawing.Point(7, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 212);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Country";
            // 
            // btFilterExcept
            // 
            this.btFilterExcept.Location = new System.Drawing.Point(8, 113);
            this.btFilterExcept.Name = "btFilterExcept";
            this.btFilterExcept.Size = new System.Drawing.Size(55, 90);
            this.btFilterExcept.TabIndex = 25;
            this.btFilterExcept.Text = "Filter Except";
            this.btFilterExcept.UseVisualStyleBackColor = true;
            this.btFilterExcept.Click += new System.EventHandler(this.btFilterExcept_Click);
            // 
            // txProper
            // 
            this.txProper.Location = new System.Drawing.Point(150, 166);
            this.txProper.Name = "txProper";
            this.txProper.Size = new System.Drawing.Size(305, 20);
            this.txProper.TabIndex = 24;
            this.txProper.Text = "KW,AU,NZ,SG,FI,SA,GA,AE,NL,PF,FJ,MP,KN,DK,KY,SE,CI,ZA,KE,TO,BS,IE,DE,NC,NO,MD,NG," +
    "SI,ZM,PL,AZ,GB,AR,LV,HK,GH,ZW,CM,CA,US,PK,JP,LB,CZ,AT,KZ,AO,MN,CH,TR,MY,DZ,LT,KH" +
    ",CY,LK,MK,PH,FR,PS,BD";
            // 
            // rbProper
            // 
            this.rbProper.AutoSize = true;
            this.rbProper.Checked = true;
            this.rbProper.Location = new System.Drawing.Point(69, 166);
            this.rbProper.Name = "rbProper";
            this.rbProper.Size = new System.Drawing.Size(57, 17);
            this.rbProper.TabIndex = 23;
            this.rbProper.TabStop = true;
            this.rbProper.Text = "ProPer";
            this.rbProper.UseVisualStyleBackColor = true;
            // 
            // txtEUUS
            // 
            this.txtEUUS.Location = new System.Drawing.Point(240, 21);
            this.txtEUUS.Name = "txtEUUS";
            this.txtEUUS.Size = new System.Drawing.Size(215, 20);
            this.txtEUUS.TabIndex = 22;
            this.txtEUUS.Text = "AT,IT,BE,UK,CH,CZ,DE,DK,ES,FI,FR,GR,SE,IE,NL,NO,PL,PT,RO,AU,CA,NZ,US,BO,CO,CR,CU," +
    "DO,EC,GT,HN,NI,PA,PR,PY,SV,UY";
            // 
            // rbEUUS
            // 
            this.rbEUUS.AutoSize = true;
            this.rbEUUS.Location = new System.Drawing.Point(69, 22);
            this.rbEUUS.Name = "rbEUUS";
            this.rbEUUS.Size = new System.Drawing.Size(154, 17);
            this.rbEUUS.TabIndex = 21;
            this.rbEUUS.Text = "English Speaking Countries";
            this.rbEUUS.UseVisualStyleBackColor = true;
            // 
            // txtCAll
            // 
            this.txtCAll.Location = new System.Drawing.Point(240, 132);
            this.txtCAll.Name = "txtCAll";
            this.txtCAll.Size = new System.Drawing.Size(215, 20);
            this.txtCAll.TabIndex = 20;
            this.txtCAll.Text = resources.GetString("txtCAll.Text");
            // 
            // txtSp
            // 
            this.txtSp.Location = new System.Drawing.Point(240, 105);
            this.txtSp.Name = "txtSp";
            this.txtSp.Size = new System.Drawing.Size(215, 20);
            this.txtSp.TabIndex = 19;
            this.txtSp.Text = "BO,CO,CR,CU,DO,EC,GT,HN,NI,PA,PR,PY,SV,UY";
            // 
            // txtEu
            // 
            this.txtEu.Location = new System.Drawing.Point(240, 76);
            this.txtEu.Name = "txtEu";
            this.txtEu.Size = new System.Drawing.Size(215, 20);
            this.txtEu.TabIndex = 18;
            this.txtEu.Text = "AT,IT,BE,UK,CH,CZ,DE,DK,ES,FI,FR,GR,SE,IE,NL,NO,PL,PT,RO";
            // 
            // txtEg
            // 
            this.txtEg.Location = new System.Drawing.Point(240, 49);
            this.txtEg.Name = "txtEg";
            this.txtEg.Size = new System.Drawing.Size(215, 20);
            this.txtEg.TabIndex = 17;
            this.txtEg.Text = "AU,CA,IE,NZ,UK,US";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.lbIP);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(7, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 74);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Duplicate";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(340, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(57, 52);
            this.button7.TabIndex = 22;
            this.button7.Text = "Dup IP";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(403, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 52);
            this.button6.TabIndex = 21;
            this.button6.Text = "Filter Country";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(237, 52);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(52, 13);
            this.lbIP.TabIndex = 10;
            this.lbIP.Text = "Result : 0";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(194, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 448);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tool Xử Lý SSH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDir1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDir2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbR2;
        private System.Windows.Forms.Label lbE2;
        private System.Windows.Forms.Label lbR1;
        private System.Windows.Forms.Label lbE1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton rbEg;
        private System.Windows.Forms.RadioButton rbEu;
        private System.Windows.Forms.RadioButton rbSp;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCAll;
        private System.Windows.Forms.TextBox txtSp;
        private System.Windows.Forms.TextBox txtEu;
        private System.Windows.Forms.TextBox txtEg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtEUUS;
        private System.Windows.Forms.RadioButton rbEUUS;
        private System.Windows.Forms.TextBox txProper;
        private System.Windows.Forms.RadioButton rbProper;
        private System.Windows.Forms.Button btFilterExcept;

    }
}

