namespace MFCTable
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
            this.surnameTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.middleNameTextBox3 = new System.Windows.Forms.TextBox();
            this.birthDayDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.surmaneLabel1 = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.middleNameLabel3 = new System.Windows.Forms.Label();
            this.birthDayLabel4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.seriesLabel2 = new System.Windows.Forms.Label();
            this.numberLabel3 = new System.Windows.Forms.Label();
            this.issuedByWhomLabel4 = new System.Windows.Forms.Label();
            this.whenIssuedLabel5 = new System.Windows.Forms.Label();
            this.addressLabel6 = new System.Windows.Forms.Label();
            this.placeOfBirthLabel7 = new System.Windows.Forms.Label();
            this.seriesTextBox1 = new System.Windows.Forms.TextBox();
            this.numberTextBox2 = new System.Windows.Forms.TextBox();
            this.issuedByWhomTextBox3 = new System.Windows.Forms.TextBox();
            this.addressTextBox4 = new System.Windows.Forms.TextBox();
            this.placeOfBirthTextBox5 = new System.Windows.Forms.TextBox();
            this.whenIssuedDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.actualAddresstextBox6 = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox7 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.forJobCheckBox3 = new System.Windows.Forms.CheckBox();
            this.forVisaCheckBox2 = new System.Windows.Forms.CheckBox();
            this.internPassCheckBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signUpButton1 = new System.Windows.Forms.Button();
            this.tableDataGridView1 = new System.Windows.Forms.DataGridView();
            this.surnameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualAddressColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internPassColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visaColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forJobColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // surnameTextBox1
            // 
            this.surnameTextBox1.Location = new System.Drawing.Point(211, 54);
            this.surnameTextBox1.Name = "surnameTextBox1";
            this.surnameTextBox1.Size = new System.Drawing.Size(286, 39);
            this.surnameTextBox1.TabIndex = 0;
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.Location = new System.Drawing.Point(211, 114);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(286, 39);
            this.nameTextBox2.TabIndex = 1;
            this.nameTextBox2.TextChanged += new System.EventHandler(this.nameTextBox2_TextChanged);
            // 
            // middleNameTextBox3
            // 
            this.middleNameTextBox3.Location = new System.Drawing.Point(211, 172);
            this.middleNameTextBox3.Name = "middleNameTextBox3";
            this.middleNameTextBox3.Size = new System.Drawing.Size(286, 39);
            this.middleNameTextBox3.TabIndex = 2;
            // 
            // birthDayDateTimePicker1
            // 
            this.birthDayDateTimePicker1.Location = new System.Drawing.Point(211, 240);
            this.birthDayDateTimePicker1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.birthDayDateTimePicker1.Name = "birthDayDateTimePicker1";
            this.birthDayDateTimePicker1.Size = new System.Drawing.Size(286, 39);
            this.birthDayDateTimePicker1.TabIndex = 3;
            // 
            // surmaneLabel1
            // 
            this.surmaneLabel1.AutoSize = true;
            this.surmaneLabel1.Location = new System.Drawing.Point(21, 54);
            this.surmaneLabel1.Name = "surmaneLabel1";
            this.surmaneLabel1.Size = new System.Drawing.Size(113, 32);
            this.surmaneLabel1.TabIndex = 4;
            this.surmaneLabel1.Text = "Фамилия";
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Location = new System.Drawing.Point(21, 114);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(61, 32);
            this.nameLabel2.TabIndex = 5;
            this.nameLabel2.Text = "Имя";
            this.nameLabel2.Click += new System.EventHandler(this.label2_Click);
            // 
            // middleNameLabel3
            // 
            this.middleNameLabel3.AutoSize = true;
            this.middleNameLabel3.Location = new System.Drawing.Point(21, 172);
            this.middleNameLabel3.Name = "middleNameLabel3";
            this.middleNameLabel3.Size = new System.Drawing.Size(117, 32);
            this.middleNameLabel3.TabIndex = 6;
            this.middleNameLabel3.Text = "Отчество";
            // 
            // birthDayLabel4
            // 
            this.birthDayLabel4.AutoSize = true;
            this.birthDayLabel4.Location = new System.Drawing.Point(21, 240);
            this.birthDayLabel4.Name = "birthDayLabel4";
            this.birthDayLabel4.Size = new System.Drawing.Size(184, 32);
            this.birthDayLabel4.TabIndex = 7;
            this.birthDayLabel4.Text = "Дата рождения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Паспортные данные";
            // 
            // seriesLabel2
            // 
            this.seriesLabel2.AutoSize = true;
            this.seriesLabel2.Location = new System.Drawing.Point(621, 114);
            this.seriesLabel2.Name = "seriesLabel2";
            this.seriesLabel2.Size = new System.Drawing.Size(82, 32);
            this.seriesLabel2.TabIndex = 9;
            this.seriesLabel2.Text = "Серия";
            // 
            // numberLabel3
            // 
            this.numberLabel3.AutoSize = true;
            this.numberLabel3.Location = new System.Drawing.Point(621, 172);
            this.numberLabel3.Name = "numberLabel3";
            this.numberLabel3.Size = new System.Drawing.Size(89, 32);
            this.numberLabel3.TabIndex = 10;
            this.numberLabel3.Text = "Номер";
            // 
            // issuedByWhomLabel4
            // 
            this.issuedByWhomLabel4.AutoSize = true;
            this.issuedByWhomLabel4.Location = new System.Drawing.Point(621, 240);
            this.issuedByWhomLabel4.Name = "issuedByWhomLabel4";
            this.issuedByWhomLabel4.Size = new System.Drawing.Size(134, 32);
            this.issuedByWhomLabel4.TabIndex = 11;
            this.issuedByWhomLabel4.Text = "Кем выдан";
            // 
            // whenIssuedLabel5
            // 
            this.whenIssuedLabel5.AutoSize = true;
            this.whenIssuedLabel5.Location = new System.Drawing.Point(621, 294);
            this.whenIssuedLabel5.Name = "whenIssuedLabel5";
            this.whenIssuedLabel5.Size = new System.Drawing.Size(152, 32);
            this.whenIssuedLabel5.TabIndex = 12;
            this.whenIssuedLabel5.Text = "Когда выдан";
            this.whenIssuedLabel5.Click += new System.EventHandler(this.label5_Click);
            // 
            // addressLabel6
            // 
            this.addressLabel6.AutoSize = true;
            this.addressLabel6.Location = new System.Drawing.Point(621, 348);
            this.addressLabel6.Name = "addressLabel6";
            this.addressLabel6.Size = new System.Drawing.Size(228, 32);
            this.addressLabel6.TabIndex = 13;
            this.addressLabel6.Text = "Адрес по прописке";
            // 
            // placeOfBirthLabel7
            // 
            this.placeOfBirthLabel7.AutoSize = true;
            this.placeOfBirthLabel7.Location = new System.Drawing.Point(621, 402);
            this.placeOfBirthLabel7.Name = "placeOfBirthLabel7";
            this.placeOfBirthLabel7.Size = new System.Drawing.Size(203, 32);
            this.placeOfBirthLabel7.TabIndex = 14;
            this.placeOfBirthLabel7.Text = "Место рождения";
            // 
            // seriesTextBox1
            // 
            this.seriesTextBox1.Location = new System.Drawing.Point(865, 111);
            this.seriesTextBox1.Name = "seriesTextBox1";
            this.seriesTextBox1.Size = new System.Drawing.Size(288, 39);
            this.seriesTextBox1.TabIndex = 15;
            // 
            // numberTextBox2
            // 
            this.numberTextBox2.Location = new System.Drawing.Point(865, 172);
            this.numberTextBox2.Name = "numberTextBox2";
            this.numberTextBox2.Size = new System.Drawing.Size(288, 39);
            this.numberTextBox2.TabIndex = 16;
            // 
            // issuedByWhomTextBox3
            // 
            this.issuedByWhomTextBox3.Location = new System.Drawing.Point(865, 240);
            this.issuedByWhomTextBox3.Name = "issuedByWhomTextBox3";
            this.issuedByWhomTextBox3.Size = new System.Drawing.Size(288, 39);
            this.issuedByWhomTextBox3.TabIndex = 17;
            // 
            // addressTextBox4
            // 
            this.addressTextBox4.Location = new System.Drawing.Point(865, 348);
            this.addressTextBox4.Name = "addressTextBox4";
            this.addressTextBox4.Size = new System.Drawing.Size(288, 39);
            this.addressTextBox4.TabIndex = 18;
            // 
            // placeOfBirthTextBox5
            // 
            this.placeOfBirthTextBox5.Location = new System.Drawing.Point(865, 402);
            this.placeOfBirthTextBox5.Name = "placeOfBirthTextBox5";
            this.placeOfBirthTextBox5.Size = new System.Drawing.Size(288, 39);
            this.placeOfBirthTextBox5.TabIndex = 19;
            // 
            // whenIssuedDateTimePicker1
            // 
            this.whenIssuedDateTimePicker1.Location = new System.Drawing.Point(865, 291);
            this.whenIssuedDateTimePicker1.Name = "whenIssuedDateTimePicker1";
            this.whenIssuedDateTimePicker1.Size = new System.Drawing.Size(288, 39);
            this.whenIssuedDateTimePicker1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1325, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Фактический адрес проживания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1325, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Телефон";
            // 
            // actualAddresstextBox6
            // 
            this.actualAddresstextBox6.Location = new System.Drawing.Point(1704, 47);
            this.actualAddresstextBox6.Name = "actualAddresstextBox6";
            this.actualAddresstextBox6.Size = new System.Drawing.Size(288, 39);
            this.actualAddresstextBox6.TabIndex = 23;
            // 
            // phoneNumberTextBox7
            // 
            this.phoneNumberTextBox7.Location = new System.Drawing.Point(1704, 107);
            this.phoneNumberTextBox7.Name = "phoneNumberTextBox7";
            this.phoneNumberTextBox7.Size = new System.Drawing.Size(288, 39);
            this.phoneNumberTextBox7.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.forJobCheckBox3);
            this.panel1.Controls.Add(this.forVisaCheckBox2);
            this.panel1.Controls.Add(this.internPassCheckBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1325, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 200);
            this.panel1.TabIndex = 25;
            // 
            // forJobCheckBox3
            // 
            this.forJobCheckBox3.AutoSize = true;
            this.forJobCheckBox3.Location = new System.Drawing.Point(29, 140);
            this.forJobCheckBox3.Name = "forJobCheckBox3";
            this.forJobCheckBox3.Size = new System.Drawing.Size(451, 36);
            this.forJobCheckBox3.TabIndex = 29;
            this.forJobCheckBox3.Text = "Оформление разрешения на работу";
            this.forJobCheckBox3.UseVisualStyleBackColor = true;
            // 
            // forVisaCheckBox2
            // 
            this.forVisaCheckBox2.AutoSize = true;
            this.forVisaCheckBox2.Location = new System.Drawing.Point(29, 98);
            this.forVisaCheckBox2.Name = "forVisaCheckBox2";
            this.forVisaCheckBox2.Size = new System.Drawing.Size(254, 36);
            this.forVisaCheckBox2.TabIndex = 28;
            this.forVisaCheckBox2.Text = "Оформление визы";
            this.forVisaCheckBox2.UseVisualStyleBackColor = true;
            // 
            // internPassCheckBox1
            // 
            this.internPassCheckBox1.AutoSize = true;
            this.internPassCheckBox1.Location = new System.Drawing.Point(29, 56);
            this.internPassCheckBox1.Name = "internPassCheckBox1";
            this.internPassCheckBox1.Size = new System.Drawing.Size(372, 36);
            this.internPassCheckBox1.TabIndex = 27;
            this.internPassCheckBox1.Text = "Оформление загранпаспорта";
            this.internPassCheckBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, -8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Запрос на услугу:";
            // 
            // signUpButton1
            // 
            this.signUpButton1.Location = new System.Drawing.Point(1325, 402);
            this.signUpButton1.Name = "signUpButton1";
            this.signUpButton1.Size = new System.Drawing.Size(667, 46);
            this.signUpButton1.TabIndex = 26;
            this.signUpButton1.Text = "ЗАПИСАТЬСЯ";
            this.signUpButton1.UseVisualStyleBackColor = true;
            this.signUpButton1.Click += new System.EventHandler(this.signUpButton1_Click);
            // 
            // tableDataGridView1
            // 
            this.tableDataGridView1.AllowUserToAddRows = false;
            this.tableDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameColumn1,
            this.nameColumn1,
            this.middleNameColumn1,
            this.dateOfBirthColumn1,
            this.actualAddressColumn1,
            this.phoneNumberColumn1,
            this.internPassColumn1,
            this.visaColumn1,
            this.forJobColumn1});
            this.tableDataGridView1.Location = new System.Drawing.Point(21, 486);
            this.tableDataGridView1.Name = "tableDataGridView1";
            this.tableDataGridView1.RowHeadersWidth = 82;
            this.tableDataGridView1.RowTemplate.Height = 41;
            this.tableDataGridView1.Size = new System.Drawing.Size(1887, 370);
            this.tableDataGridView1.TabIndex = 27;
            this.tableDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // surnameColumn1
            // 
            this.surnameColumn1.HeaderText = "Фамилия";
            this.surnameColumn1.MinimumWidth = 10;
            this.surnameColumn1.Name = "surnameColumn1";
            this.surnameColumn1.Width = 200;
            // 
            // nameColumn1
            // 
            this.nameColumn1.HeaderText = "Имя";
            this.nameColumn1.MinimumWidth = 10;
            this.nameColumn1.Name = "nameColumn1";
            this.nameColumn1.Width = 200;
            // 
            // middleNameColumn1
            // 
            this.middleNameColumn1.HeaderText = "Отчество";
            this.middleNameColumn1.MinimumWidth = 10;
            this.middleNameColumn1.Name = "middleNameColumn1";
            this.middleNameColumn1.Width = 200;
            // 
            // dateOfBirthColumn1
            // 
            this.dateOfBirthColumn1.HeaderText = "Дата рождения";
            this.dateOfBirthColumn1.MinimumWidth = 10;
            this.dateOfBirthColumn1.Name = "dateOfBirthColumn1";
            this.dateOfBirthColumn1.Width = 200;
            // 
            // actualAddressColumn1
            // 
            this.actualAddressColumn1.HeaderText = "Адрес проживания";
            this.actualAddressColumn1.MinimumWidth = 10;
            this.actualAddressColumn1.Name = "actualAddressColumn1";
            this.actualAddressColumn1.Width = 200;
            // 
            // phoneNumberColumn1
            // 
            this.phoneNumberColumn1.HeaderText = "Телефон";
            this.phoneNumberColumn1.MinimumWidth = 10;
            this.phoneNumberColumn1.Name = "phoneNumberColumn1";
            this.phoneNumberColumn1.Width = 200;
            // 
            // internPassColumn1
            // 
            this.internPassColumn1.HeaderText = "Загранник";
            this.internPassColumn1.MinimumWidth = 10;
            this.internPassColumn1.Name = "internPassColumn1";
            this.internPassColumn1.Width = 200;
            // 
            // visaColumn1
            // 
            this.visaColumn1.HeaderText = "Виза";
            this.visaColumn1.MinimumWidth = 10;
            this.visaColumn1.Name = "visaColumn1";
            this.visaColumn1.Width = 200;
            // 
            // forJobColumn1
            // 
            this.forJobColumn1.HeaderText = "Разрешение на работу";
            this.forJobColumn1.MinimumWidth = 10;
            this.forJobColumn1.Name = "forJobColumn1";
            this.forJobColumn1.Width = 200;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2066, 40);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "Меню";
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.writeToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(103, 36);
            this.menuToolStripMenuItem1.Text = "Меню";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(217, 44);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(217, 44);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(217, 44);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(217, 44);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(217, 44);
            this.writeToolStripMenuItem.Text = "Write";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(217, 44);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2066, 886);
            this.Controls.Add(this.tableDataGridView1);
            this.Controls.Add(this.signUpButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.phoneNumberTextBox7);
            this.Controls.Add(this.actualAddresstextBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.whenIssuedDateTimePicker1);
            this.Controls.Add(this.placeOfBirthTextBox5);
            this.Controls.Add(this.addressTextBox4);
            this.Controls.Add(this.issuedByWhomTextBox3);
            this.Controls.Add(this.numberTextBox2);
            this.Controls.Add(this.seriesTextBox1);
            this.Controls.Add(this.placeOfBirthLabel7);
            this.Controls.Add(this.addressLabel6);
            this.Controls.Add(this.whenIssuedLabel5);
            this.Controls.Add(this.issuedByWhomLabel4);
            this.Controls.Add(this.numberLabel3);
            this.Controls.Add(this.seriesLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthDayLabel4);
            this.Controls.Add(this.middleNameLabel3);
            this.Controls.Add(this.nameLabel2);
            this.Controls.Add(this.surmaneLabel1);
            this.Controls.Add(this.birthDayDateTimePicker1);
            this.Controls.Add(this.middleNameTextBox3);
            this.Controls.Add(this.nameTextBox2);
            this.Controls.Add(this.surnameTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "МФЦ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox surnameTextBox1;
        private TextBox nameTextBox2;
        private TextBox middleNameTextBox3;
        private DateTimePicker birthDayDateTimePicker1;
        private Label surmaneLabel1;
        private Label nameLabel2;
        private Label middleNameLabel3;
        private Label birthDayLabel4;
        private Label label1;
        private Label seriesLabel2;
        private Label numberLabel3;
        private Label issuedByWhomLabel4;
        private Label whenIssuedLabel5;
        private Label addressLabel6;
        private Label placeOfBirthLabel7;
        private TextBox seriesTextBox1;
        private TextBox numberTextBox2;
        private TextBox issuedByWhomTextBox3;
        private TextBox addressTextBox4;
        private TextBox placeOfBirthTextBox5;
        private DateTimePicker whenIssuedDateTimePicker1;
        private Label label2;
        private Label label3;
        private TextBox actualAddresstextBox6;
        private TextBox phoneNumberTextBox7;
        private Panel panel1;
        private CheckBox forJobCheckBox3;
        private CheckBox forVisaCheckBox2;
        private CheckBox internPassCheckBox1;
        private Label label4;
        private Button signUpButton1;
        private DataGridView tableDataGridView1;
        private DataGridViewTextBoxColumn surnameColumn1;
        private DataGridViewTextBoxColumn nameColumn1;
        private DataGridViewTextBoxColumn middleNameColumn1;
        private DataGridViewTextBoxColumn dateOfBirthColumn1;
        private DataGridViewTextBoxColumn actualAddressColumn1;
        private DataGridViewTextBoxColumn phoneNumberColumn1;
        private DataGridViewTextBoxColumn internPassColumn1;
        private DataGridViewTextBoxColumn visaColumn1;
        private DataGridViewTextBoxColumn forJobColumn1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem writeToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
    }
}