
namespace lab_8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Register = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Select_Training_Box = new System.Windows.Forms.ComboBox();
            this.Age_Box = new System.Windows.Forms.TextBox();
            this.Email_Box = new System.Windows.Forms.TextBox();
            this.Number_Phone_Box = new System.Windows.Forms.TextBox();
            this.Last_Name_Box = new System.Windows.Forms.TextBox();
            this.First_Name_Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.Button();
            this.Report1 = new System.Windows.Forms.Button();
            this.Select_Coach_Box = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.Report1);
            this.splitContainer1.Panel1.Controls.Add(this.Select_Coach_Box);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.Check);
            this.splitContainer1.Panel1.Controls.Add(this.Register);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.Select_Training_Box);
            this.splitContainer1.Panel1.Controls.Add(this.Age_Box);
            this.splitContainer1.Panel1.Controls.Add(this.Email_Box);
            this.splitContainer1.Panel1.Controls.Add(this.Number_Phone_Box);
            this.splitContainer1.Panel1.Controls.Add(this.Last_Name_Box);
            this.splitContainer1.Panel1.Controls.Add(this.First_Name_Box);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 324;
            this.splitContainer1.TabIndex = 0;
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(167, 219);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(137, 23);
            this.Register.TabIndex = 42;
            this.Register.Text = "Реєстрація";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Тренінг :";
            // 
            // Select_Training_Box
            // 
            this.Select_Training_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Select_Training_Box.FormattingEnabled = true;
            this.Select_Training_Box.Location = new System.Drawing.Point(167, 175);
            this.Select_Training_Box.Name = "Select_Training_Box";
            this.Select_Training_Box.Size = new System.Drawing.Size(137, 21);
            this.Select_Training_Box.TabIndex = 40;
            // 
            // Age_Box
            // 
            this.Age_Box.Location = new System.Drawing.Point(167, 149);
            this.Age_Box.Name = "Age_Box";
            this.Age_Box.Size = new System.Drawing.Size(137, 20);
            this.Age_Box.TabIndex = 39;
            // 
            // Email_Box
            // 
            this.Email_Box.Location = new System.Drawing.Point(167, 123);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.Size = new System.Drawing.Size(137, 20);
            this.Email_Box.TabIndex = 38;
            // 
            // Number_Phone_Box
            // 
            this.Number_Phone_Box.Location = new System.Drawing.Point(167, 97);
            this.Number_Phone_Box.Name = "Number_Phone_Box";
            this.Number_Phone_Box.Size = new System.Drawing.Size(137, 20);
            this.Number_Phone_Box.TabIndex = 37;
            // 
            // Last_Name_Box
            // 
            this.Last_Name_Box.Location = new System.Drawing.Point(167, 71);
            this.Last_Name_Box.Name = "Last_Name_Box";
            this.Last_Name_Box.Size = new System.Drawing.Size(137, 20);
            this.Last_Name_Box.TabIndex = 36;
            // 
            // First_Name_Box
            // 
            this.First_Name_Box.Location = new System.Drawing.Point(167, 45);
            this.First_Name_Box.Name = "First_Name_Box";
            this.First_Name_Box.Size = new System.Drawing.Size(137, 20);
            this.First_Name_Box.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Вік :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Адреса електронної пошти :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Номер телефону :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Прізвище :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ім\'я :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Реєстрація студента";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(472, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(15, 263);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(289, 44);
            this.Check.TabIndex = 43;
            this.Check.Text = "Отримати дані всіх студентів";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Report1
            // 
            this.Report1.Location = new System.Drawing.Point(15, 384);
            this.Report1.Name = "Report1";
            this.Report1.Size = new System.Drawing.Size(289, 27);
            this.Report1.TabIndex = 53;
            this.Report1.Text = "Вивести модулі, що викладає цей тренер";
            this.Report1.UseVisualStyleBackColor = true;
            this.Report1.Click += new System.EventHandler(this.Report1_Click);
            // 
            // Select_Coach_Box
            // 
            this.Select_Coach_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Select_Coach_Box.FormattingEnabled = true;
            this.Select_Coach_Box.Location = new System.Drawing.Point(167, 357);
            this.Select_Coach_Box.Name = "Select_Coach_Box";
            this.Select_Coach_Box.Size = new System.Drawing.Size(137, 21);
            this.Select_Coach_Box.TabIndex = 52;
            this.Select_Coach_Box.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.Select_Coach_Format);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Вибрати тренера :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Звіт";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "lab8";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Select_Training_Box;
        private System.Windows.Forms.TextBox Age_Box;
        private System.Windows.Forms.TextBox Email_Box;
        private System.Windows.Forms.TextBox Number_Phone_Box;
        private System.Windows.Forms.TextBox Last_Name_Box;
        private System.Windows.Forms.TextBox First_Name_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button Report1;
        private System.Windows.Forms.ComboBox Select_Coach_Box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

