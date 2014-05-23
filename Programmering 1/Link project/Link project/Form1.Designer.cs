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
            this.bandDGV = new System.Windows.Forms.DataGridView();
            this.bandBS = new System.Windows.Forms.BindingSource(this.components);
            this.bandcountTBX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bandnameTBX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Spara_btn = new System.Windows.Forms.Button();
            this.bandinfoTBX = new System.Windows.Forms.TextBox();
            this.bandfromTBX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bandRemoveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bandDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandBS)).BeginInit();
            this.SuspendLayout();
            // 
            // bandDGV
            // 
            this.bandDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bandDGV.Location = new System.Drawing.Point(12, 12);
            this.bandDGV.Name = "bandDGV";
            this.bandDGV.Size = new System.Drawing.Size(412, 199);
            this.bandDGV.TabIndex = 0;
            // 
            // bandcountTBX
            // 
            this.bandcountTBX.Location = new System.Drawing.Point(12, 269);
            this.bandcountTBX.Name = "bandcountTBX";
            this.bandcountTBX.Size = new System.Drawing.Size(100, 20);
            this.bandcountTBX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Antal members";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bandnameTBX
            // 
            this.bandnameTBX.Location = new System.Drawing.Point(12, 230);
            this.bandnameTBX.Name = "bandnameTBX";
            this.bandnameTBX.Size = new System.Drawing.Size(100, 20);
            this.bandnameTBX.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Guildnamn";
            // 
            // Spara_btn
            // 
            this.Spara_btn.Location = new System.Drawing.Point(349, 269);
            this.Spara_btn.Name = "Spara_btn";
            this.Spara_btn.Size = new System.Drawing.Size(75, 31);
            this.Spara_btn.TabIndex = 5;
            this.Spara_btn.Text = "Spara";
            this.Spara_btn.UseVisualStyleBackColor = true;
            this.Spara_btn.Click += new System.EventHandler(this.Spara_btn_Click);
            // 
            // bandinfoTBX
            // 
            this.bandinfoTBX.Location = new System.Drawing.Point(119, 230);
            this.bandinfoTBX.Name = "bandinfoTBX";
            this.bandinfoTBX.Size = new System.Drawing.Size(100, 20);
            this.bandinfoTBX.TabIndex = 6;
            // 
            // bandfromTBX
            // 
            this.bandfromTBX.Location = new System.Drawing.Point(119, 268);
            this.bandfromTBX.Name = "bandfromTBX";
            this.bandfromTBX.Size = new System.Drawing.Size(100, 20);
            this.bandfromTBX.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inriktning";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ursprung";
            // 
            // bandRemoveBtn
            // 
            this.bandRemoveBtn.Location = new System.Drawing.Point(339, 228);
            this.bandRemoveBtn.Name = "bandRemoveBtn";
            this.bandRemoveBtn.Size = new System.Drawing.Size(85, 23);
            this.bandRemoveBtn.TabIndex = 10;
            this.bandRemoveBtn.Text = "Ta bort objekt";
            this.bandRemoveBtn.UseVisualStyleBackColor = true;
            this.bandRemoveBtn.Click += new System.EventHandler(this.bandRemoveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 312);
            this.Controls.Add(this.bandRemoveBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bandfromTBX);
            this.Controls.Add(this.bandinfoTBX);
            this.Controls.Add(this.Spara_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bandnameTBX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bandcountTBX);
            this.Controls.Add(this.bandDGV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bandDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bandDGV;
        private System.Windows.Forms.BindingSource bandBS;
        private System.Windows.Forms.TextBox bandcountTBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bandnameTBX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Spara_btn;
        private System.Windows.Forms.TextBox bandinfoTBX;
        private System.Windows.Forms.TextBox bandfromTBX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bandRemoveBtn;
    }
}

