namespace WindowsFormsApplication3
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
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.perhour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hourday = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.perday = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sss = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.philh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.minos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nsalary = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.deduc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gsalary = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(988, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAYROLL SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EmployeeName.Location = new System.Drawing.Point(77, 133);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(202, 30);
            this.EmployeeName.TabIndex = 1;
            this.EmployeeName.TextChanged += new System.EventHandler(this.EmployeeName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(74, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = " EMPLOYEE NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(74, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "RATE PER HOUR";
            // 
            // perhour
            // 
            this.perhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.perhour.Location = new System.Drawing.Point(77, 189);
            this.perhour.Name = "perhour";
            this.perhour.Size = new System.Drawing.Size(202, 30);
            this.perhour.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(74, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "HOUR PER DAY";
            // 
            // hourday
            // 
            this.hourday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.hourday.Location = new System.Drawing.Point(77, 255);
            this.hourday.Name = "hourday";
            this.hourday.Size = new System.Drawing.Size(202, 30);
            this.hourday.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(74, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "24 DAYS OF WORKED";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // perday
            // 
            this.perday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.perday.Location = new System.Drawing.Point(77, 321);
            this.perday.Name = "perday";
            this.perday.Size = new System.Drawing.Size(202, 30);
            this.perday.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(375, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "TOTAL DEDUCTION";
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.total.Location = new System.Drawing.Point(378, 408);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(202, 30);
            this.total.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(375, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "SSS %2";
            // 
            // sss
            // 
            this.sss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sss.Location = new System.Drawing.Point(378, 255);
            this.sss.Name = "sss";
            this.sss.Size = new System.Drawing.Size(202, 30);
            this.sss.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(375, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "PHIL HEALTH %5";
            // 
            // philh
            // 
            this.philh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.philh.Location = new System.Drawing.Point(378, 189);
            this.philh.Name = "philh";
            this.philh.Size = new System.Drawing.Size(202, 30);
            this.philh.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(375, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "TAX %15 OF MONTHLY WAGE";
            // 
            // minos
            // 
            this.minos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.minos.Location = new System.Drawing.Point(378, 133);
            this.minos.Name = "minos";
            this.minos.Size = new System.Drawing.Size(202, 30);
            this.minos.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(689, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "NET SALARY";
            // 
            // nsalary
            // 
            this.nsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nsalary.Location = new System.Drawing.Point(692, 408);
            this.nsalary.Name = "nsalary";
            this.nsalary.Size = new System.Drawing.Size(202, 30);
            this.nsalary.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(689, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "DEDUCTION";
            // 
            // deduc
            // 
            this.deduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.deduc.Location = new System.Drawing.Point(692, 189);
            this.deduc.Name = "deduc";
            this.deduc.Size = new System.Drawing.Size(202, 30);
            this.deduc.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(689, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "GROSS SALARY ";
            // 
            // gsalary
            // 
            this.gsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gsalary.Location = new System.Drawing.Point(692, 133);
            this.gsalary.Name = "gsalary";
            this.gsalary.Size = new System.Drawing.Size(202, 30);
            this.gsalary.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(74, 388);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "GROSS SALARY";
            // 
            // salary
            // 
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.salary.Location = new System.Drawing.Point(77, 408);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(202, 30);
            this.salary.TabIndex = 25;
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCompute.Location = new System.Drawing.Point(378, 453);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(202, 52);
            this.btnCompute.TabIndex = 27;
            this.btnCompute.Text = "COMPUTE";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 571);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nsalary);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.deduc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gsalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sss);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.philh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.minos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.perday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hourday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.perhour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmployeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox perhour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hourday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox perday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sss;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox philh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox minos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nsalary;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox deduc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox gsalary;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Button btnCompute;
    }
}

