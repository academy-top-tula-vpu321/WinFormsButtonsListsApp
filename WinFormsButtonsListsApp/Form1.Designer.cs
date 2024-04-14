namespace WinFormsButtonsListsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chkCpp = new CheckBox();
            chkJava = new CheckBox();
            chkPython = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            panel1 = new Panel();
            lstCities = new ListBox();
            textBox2 = new TextBox();
            btnAddCity = new Button();
            btnDelCity = new Button();
            btnViewCities = new Button();
            lstUsers = new ListBox();
            btnAddUser = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chkCpp
            // 
            chkCpp.AutoSize = true;
            chkCpp.Checked = true;
            chkCpp.CheckState = CheckState.Indeterminate;
            chkCpp.Font = new Font("Segoe UI", 20F);
            chkCpp.Location = new Point(33, 58);
            chkCpp.Name = "chkCpp";
            chkCpp.Size = new Size(89, 41);
            chkCpp.TabIndex = 0;
            chkCpp.Text = "C++";
            chkCpp.ThreeState = true;
            chkCpp.UseVisualStyleBackColor = true;
            // 
            // chkJava
            // 
            chkJava.AutoSize = true;
            chkJava.Font = new Font("Segoe UI", 20F);
            chkJava.Location = new Point(33, 118);
            chkJava.Name = "chkJava";
            chkJava.Size = new Size(87, 41);
            chkJava.TabIndex = 0;
            chkJava.Text = "Java";
            chkJava.UseVisualStyleBackColor = true;
            // 
            // chkPython
            // 
            chkPython.AutoSize = true;
            chkPython.Font = new Font("Segoe UI", 20F);
            chkPython.Location = new Point(33, 183);
            chkPython.Name = "chkPython";
            chkPython.Size = new Size(119, 41);
            chkPython.TabIndex = 0;
            chkPython.Text = "Python";
            chkPython.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkJava);
            groupBox1.Controls.Add(chkPython);
            groupBox1.Controls.Add(chkCpp);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.Location = new Point(22, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 266);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Program Language";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(22, 316);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 347);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(34, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(34, 63);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(34, 100);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(349, 223);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 19);
            radioButton4.TabIndex = 7;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(349, 248);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(94, 19);
            radioButton5.TabIndex = 8;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton3);
            panel1.Location = new Point(315, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 159);
            panel1.TabIndex = 9;
            // 
            // lstCities
            // 
            lstCities.Font = new Font("Segoe UI", 16F);
            lstCities.FormattingEnabled = true;
            lstCities.ItemHeight = 30;
            lstCities.Items.AddRange(new object[] { "Москва", "Тула", "Воронеж", "Новгород", "Казань" });
            lstCities.Location = new Point(532, 33);
            lstCities.Name = "lstCities";
            lstCities.Size = new Size(303, 244);
            lstCities.TabIndex = 10;
            lstCities.SelectedIndexChanged += lstCities_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.Location = new Point(532, 283);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 36);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnAddCity
            // 
            btnAddCity.Font = new Font("Segoe UI", 16F);
            btnAddCity.Location = new Point(532, 334);
            btnAddCity.Name = "btnAddCity";
            btnAddCity.Size = new Size(144, 39);
            btnAddCity.TabIndex = 12;
            btnAddCity.Text = "Add city";
            btnAddCity.UseVisualStyleBackColor = true;
            btnAddCity.Click += btnAddCity_Click;
            // 
            // btnDelCity
            // 
            btnDelCity.Font = new Font("Segoe UI", 16F);
            btnDelCity.Location = new Point(691, 334);
            btnDelCity.Name = "btnDelCity";
            btnDelCity.Size = new Size(144, 39);
            btnDelCity.TabIndex = 12;
            btnDelCity.Text = "Delete city";
            btnDelCity.UseVisualStyleBackColor = true;
            btnDelCity.Click += btnDelCity_Click;
            // 
            // btnViewCities
            // 
            btnViewCities.Font = new Font("Segoe UI", 16F);
            btnViewCities.Location = new Point(532, 389);
            btnViewCities.Name = "btnViewCities";
            btnViewCities.Size = new Size(144, 39);
            btnViewCities.TabIndex = 12;
            btnViewCities.Text = "View cities";
            btnViewCities.UseVisualStyleBackColor = true;
            btnViewCities.Click += btnViewCities_Click;
            // 
            // lstUsers
            // 
            lstUsers.Font = new Font("Segoe UI", 16F);
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 30;
            lstUsers.Location = new Point(899, 33);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(245, 244);
            lstUsers.TabIndex = 13;
            // 
            // btnAddUser
            // 
            btnAddUser.Font = new Font("Segoe UI", 16F);
            btnAddUser.Location = new Point(899, 296);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(144, 39);
            btnAddUser.TabIndex = 12;
            btnAddUser.Text = "Add user";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 450);
            Controls.Add(lstUsers);
            Controls.Add(btnViewCities);
            Controls.Add(btnDelCity);
            Controls.Add(btnAddUser);
            Controls.Add(btnAddCity);
            Controls.Add(textBox2);
            Controls.Add(lstCities);
            Controls.Add(panel1);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkCpp;
        private CheckBox chkJava;
        private CheckBox chkPython;
        private GroupBox groupBox1;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private Panel panel1;
        private ListBox lstCities;
        private TextBox textBox2;
        private Button btnAddCity;
        private Button btnDelCity;
        private Button btnViewCities;
        private ListBox lstUsers;
        private Button btnAddUser;
    }
}
