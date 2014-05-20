namespace Link_project
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
            this.components = new System.ComponentModel.Container();
            this.bandBS = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bandRemoveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bandfromTBX = new System.Windows.Forms.TextBox();
            this.bandinfoTBX = new System.Windows.Forms.TextBox();
            this.Spara_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bandnameTBX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bandcountTBX = new System.Windows.Forms.TextBox();
            this.bandDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recordBS = new System.Windows.Forms.BindingSource(this.components);
            this.recordBandCbx = new System.Windows.Forms.ComboBox();
            this.BandChangeBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bandBS)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bandDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 344);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BandChangeBTN);
            this.tabPage1.Controls.Add(this.bandRemoveBtn);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.bandfromTBX);
            this.tabPage1.Controls.Add(this.bandinfoTBX);
            this.tabPage1.Controls.Add(this.Spara_btn);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.bandnameTBX);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.bandcountTBX);
            this.tabPage1.Controls.Add(this.bandDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(484, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.recordBandCbx);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(484, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bandRemoveBtn
            // 
            this.bandRemoveBtn.Location = new System.Drawing.Point(333, 222);
            this.bandRemoveBtn.Name = "bandRemoveBtn";
            this.bandRemoveBtn.Size = new System.Drawing.Size(85, 23);
            this.bandRemoveBtn.TabIndex = 21;
            this.bandRemoveBtn.Text = "Ta bort objekt";
            this.bandRemoveBtn.UseVisualStyleBackColor = true;
            this.bandRemoveBtn.Click += new System.EventHandler(this.bandRemoveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ursprung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Inriktning";
            // 
            // bandfromTBX
            // 
            this.bandfromTBX.Location = new System.Drawing.Point(113, 262);
            this.bandfromTBX.Name = "bandfromTBX";
            this.bandfromTBX.Size = new System.Drawing.Size(100, 20);
            this.bandfromTBX.TabIndex = 18;
            // 
            // bandinfoTBX
            // 
            this.bandinfoTBX.Location = new System.Drawing.Point(113, 224);
            this.bandinfoTBX.Name = "bandinfoTBX";
            this.bandinfoTBX.Size = new System.Drawing.Size(100, 20);
            this.bandinfoTBX.TabIndex = 17;
            // 
            // Spara_btn
            // 
            this.Spara_btn.Location = new System.Drawing.Point(343, 263);
            this.Spara_btn.Name = "Spara_btn";
            this.Spara_btn.Size = new System.Drawing.Size(75, 31);
            this.Spara_btn.TabIndex = 16;
            this.Spara_btn.Text = "Spara";
            this.Spara_btn.UseVisualStyleBackColor = true;
            this.Spara_btn.Click += new System.EventHandler(this.Spara_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Guildnamn";
            // 
            // bandnameTBX
            // 
            this.bandnameTBX.Location = new System.Drawing.Point(6, 224);
            this.bandnameTBX.Name = "bandnameTBX";
            this.bandnameTBX.Size = new System.Drawing.Size(100, 20);
            this.bandnameTBX.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Antal members";
            // 
            // bandcountTBX
            // 
            this.bandcountTBX.Location = new System.Drawing.Point(6, 263);
            this.bandcountTBX.Name = "bandcountTBX";
            this.bandcountTBX.Size = new System.Drawing.Size(100, 20);
            this.bandcountTBX.TabIndex = 12;
            // 
            // bandDGV
            // 
            this.bandDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bandDGV.Location = new System.Drawing.Point(6, 6);
            this.bandDGV.Name = "bandDGV";
            this.bandDGV.Size = new System.Drawing.Size(412, 199);
            this.bandDGV.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Ta bort objekt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ursprung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Inriktning";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 224);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "Spara";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Guildnamn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Antal members";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 263);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 199);
            this.dataGridView1.TabIndex = 11;
            // 
            // recordBandCbx
            // 
            this.recordBandCbx.FormattingEnabled = true;
            this.recordBandCbx.Location = new System.Drawing.Point(9, 222);
            this.recordBandCbx.Name = "recordBandCbx";
            this.recordBandCbx.Size = new System.Drawing.Size(121, 21);
            this.recordBandCbx.TabIndex = 22;
            // 
            // BandChangeBTN
            // 
            this.BandChangeBTN.Location = new System.Drawing.Point(262, 271);
            this.BandChangeBTN.Name = "BandChangeBTN";
            this.BandChangeBTN.Size = new System.Drawing.Size(75, 23);
            this.BandChangeBTN.TabIndex = 22;
            this.BandChangeBTN.Text = "Change";
            this.BandChangeBTN.UseVisualStyleBackColor = true;
            this.BandChangeBTN.Click += new System.EventHandler(this.BandChangeBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 369);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bandBS)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bandDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bandBS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bandRemoveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bandfromTBX;
        private System.Windows.Forms.TextBox bandinfoTBX;
        private System.Windows.Forms.Button Spara_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bandnameTBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bandcountTBX;
        private System.Windows.Forms.DataGridView bandDGV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox recordBandCbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource recordBS;
        private System.Windows.Forms.Button BandChangeBTN;
    }
}

