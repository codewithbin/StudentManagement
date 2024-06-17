namespace CuoiKy.UI
{
    partial class DetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFemale = new System.Windows.Forms.RadioButton();
            this.btnMale = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbMSSV = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbbLSH = new System.Windows.Forms.ComboBox();
            this.cbbLHP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbBT = new System.Windows.Forms.TextBox();
            this.tbGK = new System.Windows.Forms.TextBox();
            this.tbCK = new System.Windows.Forms.TextBox();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp SH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Học phần";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFemale);
            this.groupBox1.Controls.Add(this.btnMale);
            this.groupBox1.Location = new System.Drawing.Point(49, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // btnFemale
            // 
            this.btnFemale.AutoSize = true;
            this.btnFemale.Location = new System.Drawing.Point(106, 40);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(74, 20);
            this.btnFemale.TabIndex = 1;
            this.btnFemale.TabStop = true;
            this.btnFemale.Text = "Female";
            this.btnFemale.UseVisualStyleBackColor = true;
            // 
            // btnMale
            // 
            this.btnMale.AutoSize = true;
            this.btnMale.Location = new System.Drawing.Point(28, 40);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(58, 20);
            this.btnMale.TabIndex = 0;
            this.btnMale.TabStop = true;
            this.btnMale.Text = "Male";
            this.btnMale.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(120, 401);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(511, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbMSSV
            // 
            this.tbMSSV.Location = new System.Drawing.Point(148, 39);
            this.tbMSSV.Name = "tbMSSV";
            this.tbMSSV.Size = new System.Drawing.Size(100, 22);
            this.tbMSSV.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(144, 89);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 8;
            // 
            // cbbLSH
            // 
            this.cbbLSH.FormattingEnabled = true;
            this.cbbLSH.Location = new System.Drawing.Point(142, 156);
            this.cbbLSH.Name = "cbbLSH";
            this.cbbLSH.Size = new System.Drawing.Size(121, 24);
            this.cbbLSH.TabIndex = 9;
            // 
            // cbbLHP
            // 
            this.cbbLHP.FormattingEnabled = true;
            this.cbbLHP.Location = new System.Drawing.Point(141, 223);
            this.cbbLHP.Name = "cbbLHP";
            this.cbbLHP.Size = new System.Drawing.Size(121, 24);
            this.cbbLHP.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày thi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Điểm BT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Điểm GK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Điểm CK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tổng kết";
            // 
            // tbBT
            // 
            this.tbBT.Location = new System.Drawing.Point(538, 91);
            this.tbBT.Name = "tbBT";
            this.tbBT.Size = new System.Drawing.Size(100, 22);
            this.tbBT.TabIndex = 17;
            // 
            // tbGK
            // 
            this.tbGK.Location = new System.Drawing.Point(541, 145);
            this.tbGK.Name = "tbGK";
            this.tbGK.Size = new System.Drawing.Size(100, 22);
            this.tbGK.TabIndex = 18;
            // 
            // tbCK
            // 
            this.tbCK.Location = new System.Drawing.Point(541, 207);
            this.tbCK.Name = "tbCK";
            this.tbCK.Size = new System.Drawing.Size(100, 22);
            this.tbCK.TabIndex = 19;
            // 
            // tbTK
            // 
            this.tbTK.Enabled = false;
            this.tbTK.Location = new System.Drawing.Point(538, 278);
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(100, 22);
            this.tbTK.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(538, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbTK);
            this.Controls.Add(this.tbCK);
            this.Controls.Add(this.tbGK);
            this.Controls.Add(this.tbBT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbLHP);
            this.Controls.Add(this.cbbLSH);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbMSSV);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailForm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnFemale;
        private System.Windows.Forms.RadioButton btnMale;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbMSSV;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbbLSH;
        private System.Windows.Forms.ComboBox cbbLHP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbBT;
        private System.Windows.Forms.TextBox tbGK;
        private System.Windows.Forms.TextBox tbCK;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}