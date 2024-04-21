namespace Hi_Tech_Order_Management_System.GUI
{
    partial class ManagementForm
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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.tabControlEmployee = new System.Windows.Forms.TabControl();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxlistEmp_Cstm = new System.Windows.Forms.ComboBox();
            this.labelMessageSearch = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelmsgUser = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.listViewUser = new System.Windows.Forms.ListView();
            this.columnHeaderUserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmployeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelmsgSelect = new System.Windows.Forms.Label();
            this.comboBoxCustomer_Employee = new System.Windows.Forms.ComboBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxUserID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxEmpID = new System.Windows.Forms.ComboBox();
            this.comboBoxJobId = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.labelJobID = new System.Windows.Forms.Label();
            this.labelSearchEmp = new System.Windows.Forms.Label();
            this.labelmsgEmp = new System.Windows.Forms.Label();
            this.buttonEmpList = new System.Windows.Forms.Button();
            this.listViewEmployee = new System.Windows.Forms.ListView();
            this.columnHeaderEmpID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmpEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderJobID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEmpSearch = new System.Windows.Forms.Button();
            this.textBoxEmpSearch = new System.Windows.Forms.TextBox();
            this.comboBoxEmpSearch = new System.Windows.Forms.ComboBox();
            this.labelEmpSearch = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelEmployeeEmail = new System.Windows.Forms.Label();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.textBoxEmployeeEmail = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonEmpSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEmpDel = new System.Windows.Forms.Button();
            this.buttonEmpUpdate = new System.Windows.Forms.Button();
            this.tabControlEmployee.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(39, 308);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(170, 22);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(39, 254);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(170, 22);
            this.textBoxUserPassword.TabIndex = 4;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(39, 202);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(170, 22);
            this.textBoxUsername.TabIndex = 5;
            // 
            // tabControlEmployee
            // 
            this.tabControlEmployee.Controls.Add(this.tabPageUser);
            this.tabControlEmployee.Controls.Add(this.tabPage2);
            this.tabControlEmployee.Location = new System.Drawing.Point(-4, 12);
            this.tabControlEmployee.Name = "tabControlEmployee";
            this.tabControlEmployee.SelectedIndex = 0;
            this.tabControlEmployee.Size = new System.Drawing.Size(840, 583);
            this.tabControlEmployee.TabIndex = 6;
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.label1);
            this.tabPageUser.Controls.Add(this.comboBoxlistEmp_Cstm);
            this.tabPageUser.Controls.Add(this.labelMessageSearch);
            this.tabPageUser.Controls.Add(this.labelMessage);
            this.tabPageUser.Controls.Add(this.labelmsgUser);
            this.tabPageUser.Controls.Add(this.buttonExit);
            this.tabPageUser.Controls.Add(this.buttonList);
            this.tabPageUser.Controls.Add(this.listViewUser);
            this.tabPageUser.Controls.Add(this.buttonSearch);
            this.tabPageUser.Controls.Add(this.textBoxSearch);
            this.tabPageUser.Controls.Add(this.comboBoxSearch);
            this.tabPageUser.Controls.Add(this.labelSearch);
            this.tabPageUser.Controls.Add(this.buttonDelete);
            this.tabPageUser.Controls.Add(this.buttonUpdate);
            this.tabPageUser.Controls.Add(this.buttonSave);
            this.tabPageUser.Controls.Add(this.labelmsgSelect);
            this.tabPageUser.Controls.Add(this.comboBoxCustomer_Employee);
            this.tabPageUser.Controls.Add(this.labelPassword);
            this.tabPageUser.Controls.Add(this.labelUsername);
            this.tabPageUser.Controls.Add(this.labelEmail);
            this.tabPageUser.Controls.Add(this.labelUserID);
            this.tabPageUser.Controls.Add(this.textBoxEmail);
            this.tabPageUser.Controls.Add(this.textBoxUsername);
            this.tabPageUser.Controls.Add(this.textBoxUserPassword);
            this.tabPageUser.Controls.Add(this.groupBox1);
            this.tabPageUser.Controls.Add(this.groupBox2);
            this.tabPageUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageUser.Location = new System.Drawing.Point(4, 25);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(832, 554);
            this.tabPageUser.TabIndex = 0;
            this.tabPageUser.Text = "User Management";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "*Select ID and add the info to update in Add";
            // 
            // comboBoxlistEmp_Cstm
            // 
            this.comboBoxlistEmp_Cstm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxlistEmp_Cstm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxlistEmp_Cstm.FormattingEnabled = true;
            this.comboBoxlistEmp_Cstm.Items.AddRange(new object[] {
            "EmployeeID",
            "CustomerID"});
            this.comboBoxlistEmp_Cstm.Location = new System.Drawing.Point(39, 419);
            this.comboBoxlistEmp_Cstm.Name = "comboBoxlistEmp_Cstm";
            this.comboBoxlistEmp_Cstm.Size = new System.Drawing.Size(170, 24);
            this.comboBoxlistEmp_Cstm.TabIndex = 28;
            // 
            // labelMessageSearch
            // 
            this.labelMessageSearch.AutoSize = true;
            this.labelMessageSearch.Location = new System.Drawing.Point(607, 65);
            this.labelMessageSearch.Name = "labelMessageSearch";
            this.labelMessageSearch.Size = new System.Drawing.Size(129, 16);
            this.labelMessageSearch.TabIndex = 27;
            this.labelMessageSearch.Text = "Message to Show";
            this.labelMessageSearch.Visible = false;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(36, 446);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(129, 16);
            this.labelMessage.TabIndex = 26;
            this.labelMessage.Text = "Message to Show";
            this.labelMessage.Visible = false;
            // 
            // labelmsgUser
            // 
            this.labelmsgUser.AutoSize = true;
            this.labelmsgUser.Location = new System.Drawing.Point(36, 331);
            this.labelmsgUser.Name = "labelmsgUser";
            this.labelmsgUser.Size = new System.Drawing.Size(178, 16);
            this.labelmsgUser.TabIndex = 25;
            this.labelmsgUser.Text = "*(ex. aaron@yahoo.com)";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(705, 495);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 24;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(273, 148);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(75, 23);
            this.buttonList.TabIndex = 23;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // listViewUser
            // 
            this.listViewUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUserID,
            this.columnHeaderUsername,
            this.columnHeaderPassword,
            this.columnHeaderEmail,
            this.columnHeaderEmployeeID,
            this.columnHeaderCustomerID});
            this.listViewUser.GridLines = true;
            this.listViewUser.HideSelection = false;
            this.listViewUser.Location = new System.Drawing.Point(273, 177);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(507, 312);
            this.listViewUser.TabIndex = 22;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderUserID
            // 
            this.columnHeaderUserID.Text = "UserID";
            // 
            // columnHeaderUsername
            // 
            this.columnHeaderUsername.Text = "Username";
            this.columnHeaderUsername.Width = 133;
            // 
            // columnHeaderPassword
            // 
            this.columnHeaderPassword.Text = "Password";
            this.columnHeaderPassword.Width = 141;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 152;
            // 
            // columnHeaderEmployeeID
            // 
            this.columnHeaderEmployeeID.Text = "EmployeeID";
            this.columnHeaderEmployeeID.Width = 96;
            // 
            // columnHeaderCustomerID
            // 
            this.columnHeaderCustomerID.Text = "CustomerID";
            this.columnHeaderCustomerID.Width = 84;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(610, 148);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 21;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(610, 103);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(170, 22);
            this.textBoxSearch.TabIndex = 20;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "UserID",
            "Username"});
            this.comboBoxSearch.Location = new System.Drawing.Point(610, 39);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(170, 24);
            this.comboBoxSearch.TabIndex = 19;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(512, 42);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(78, 16);
            this.labelSearch.TabIndex = 18;
            this.labelSearch.Text = "Search By";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(334, 62);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(235, 62);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(76, 482);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelmsgSelect
            // 
            this.labelmsgSelect.AutoSize = true;
            this.labelmsgSelect.Location = new System.Drawing.Point(36, 386);
            this.labelmsgSelect.Name = "labelmsgSelect";
            this.labelmsgSelect.Size = new System.Drawing.Size(198, 16);
            this.labelmsgSelect.TabIndex = 13;
            this.labelmsgSelect.Text = "*Select employee/customer";
            // 
            // comboBoxCustomer_Employee
            // 
            this.comboBoxCustomer_Employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomer_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomer_Employee.FormattingEnabled = true;
            this.comboBoxCustomer_Employee.Items.AddRange(new object[] {
            "EmployeeID",
            "CustomerID"});
            this.comboBoxCustomer_Employee.Location = new System.Drawing.Point(39, 359);
            this.comboBoxCustomer_Employee.Name = "comboBoxCustomer_Employee";
            this.comboBoxCustomer_Employee.Size = new System.Drawing.Size(170, 24);
            this.comboBoxCustomer_Employee.TabIndex = 12;
            this.comboBoxCustomer_Employee.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomer_Employee_SelectedIndexChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(36, 235);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(75, 16);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(36, 183);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(78, 16);
            this.labelUsername.TabIndex = 9;
            this.labelUsername.Text = "Username";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(36, 289);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 16);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(36, 43);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(55, 16);
            this.labelUserID.TabIndex = 6;
            this.labelUserID.Text = "UserID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxUserID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 103);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update/Delete";
            // 
            // comboBoxUserID
            // 
            this.comboBoxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserID.FormattingEnabled = true;
            this.comboBoxUserID.Items.AddRange(new object[] {
            "EmployeeID",
            "CustomerID"});
            this.comboBoxUserID.Location = new System.Drawing.Point(10, 39);
            this.comboBoxUserID.Name = "comboBoxUserID";
            this.comboBoxUserID.Size = new System.Drawing.Size(170, 24);
            this.comboBoxUserID.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "**Select ID to Delete";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(29, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 356);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxEmpID);
            this.tabPage2.Controls.Add(this.comboBoxJobId);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.labelJobID);
            this.tabPage2.Controls.Add(this.labelSearchEmp);
            this.tabPage2.Controls.Add(this.labelmsgEmp);
            this.tabPage2.Controls.Add(this.buttonEmpList);
            this.tabPage2.Controls.Add(this.listViewEmployee);
            this.tabPage2.Controls.Add(this.buttonEmpSearch);
            this.tabPage2.Controls.Add(this.textBoxEmpSearch);
            this.tabPage2.Controls.Add(this.comboBoxEmpSearch);
            this.tabPage2.Controls.Add(this.labelEmpSearch);
            this.tabPage2.Controls.Add(this.labelLastName);
            this.tabPage2.Controls.Add(this.labelFirstName);
            this.tabPage2.Controls.Add(this.labelEmployeeEmail);
            this.tabPage2.Controls.Add(this.labelEmployeeID);
            this.tabPage2.Controls.Add(this.textBoxEmployeeEmail);
            this.tabPage2.Controls.Add(this.textBoxFirstName);
            this.tabPage2.Controls.Add(this.textBoxLastName);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(832, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxEmpID
            // 
            this.comboBoxEmpID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpID.FormattingEnabled = true;
            this.comboBoxEmpID.Location = new System.Drawing.Point(45, 65);
            this.comboBoxEmpID.Name = "comboBoxEmpID";
            this.comboBoxEmpID.Size = new System.Drawing.Size(170, 24);
            this.comboBoxEmpID.TabIndex = 55;
            // 
            // comboBoxJobId
            // 
            this.comboBoxJobId.FormattingEnabled = true;
            this.comboBoxJobId.Location = new System.Drawing.Point(45, 399);
            this.comboBoxJobId.Name = "comboBoxJobId";
            this.comboBoxJobId.Size = new System.Drawing.Size(170, 24);
            this.comboBoxJobId.TabIndex = 54;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(735, 508);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 53;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelJobID
            // 
            this.labelJobID.AutoSize = true;
            this.labelJobID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJobID.Location = new System.Drawing.Point(42, 380);
            this.labelJobID.Name = "labelJobID";
            this.labelJobID.Size = new System.Drawing.Size(48, 16);
            this.labelJobID.TabIndex = 52;
            this.labelJobID.Text = "JobID";
            // 
            // labelSearchEmp
            // 
            this.labelSearchEmp.AutoSize = true;
            this.labelSearchEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchEmp.Location = new System.Drawing.Point(607, 78);
            this.labelSearchEmp.Name = "labelSearchEmp";
            this.labelSearchEmp.Size = new System.Drawing.Size(129, 16);
            this.labelSearchEmp.TabIndex = 50;
            this.labelSearchEmp.Text = "Message to Show";
            this.labelSearchEmp.Visible = false;
            // 
            // labelmsgEmp
            // 
            this.labelmsgEmp.AutoSize = true;
            this.labelmsgEmp.Location = new System.Drawing.Point(42, 345);
            this.labelmsgEmp.Name = "labelmsgEmp";
            this.labelmsgEmp.Size = new System.Drawing.Size(151, 16);
            this.labelmsgEmp.TabIndex = 48;
            this.labelmsgEmp.Text = "(ex. aaron@yahoo.com)";
            // 
            // buttonEmpList
            // 
            this.buttonEmpList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpList.Location = new System.Drawing.Point(273, 161);
            this.buttonEmpList.Name = "buttonEmpList";
            this.buttonEmpList.Size = new System.Drawing.Size(75, 23);
            this.buttonEmpList.TabIndex = 47;
            this.buttonEmpList.Text = "List";
            this.buttonEmpList.UseVisualStyleBackColor = true;
            this.buttonEmpList.Click += new System.EventHandler(this.buttonEmpList_Click);
            // 
            // listViewEmployee
            // 
            this.listViewEmployee.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderEmpID,
            this.columnHeaderFirstName,
            this.columnHeaderLastName,
            this.columnHeaderEmpEmail,
            this.columnHeaderJobID});
            this.listViewEmployee.GridLines = true;
            this.listViewEmployee.HideSelection = false;
            this.listViewEmployee.Location = new System.Drawing.Point(273, 190);
            this.listViewEmployee.Name = "listViewEmployee";
            this.listViewEmployee.Size = new System.Drawing.Size(537, 312);
            this.listViewEmployee.TabIndex = 46;
            this.listViewEmployee.UseCompatibleStateImageBehavior = false;
            this.listViewEmployee.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderEmpID
            // 
            this.columnHeaderEmpID.Text = "EmployeeID";
            this.columnHeaderEmpID.Width = 116;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "First Name";
            this.columnHeaderFirstName.Width = 133;
            // 
            // columnHeaderLastName
            // 
            this.columnHeaderLastName.Text = "Last Name";
            this.columnHeaderLastName.Width = 141;
            // 
            // columnHeaderEmpEmail
            // 
            this.columnHeaderEmpEmail.Text = "Email";
            this.columnHeaderEmpEmail.Width = 152;
            // 
            // columnHeaderJobID
            // 
            this.columnHeaderJobID.Text = "JobID";
            this.columnHeaderJobID.Width = 96;
            // 
            // buttonEmpSearch
            // 
            this.buttonEmpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpSearch.Location = new System.Drawing.Point(651, 161);
            this.buttonEmpSearch.Name = "buttonEmpSearch";
            this.buttonEmpSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonEmpSearch.TabIndex = 45;
            this.buttonEmpSearch.Text = "Search";
            this.buttonEmpSearch.UseVisualStyleBackColor = true;
            this.buttonEmpSearch.Click += new System.EventHandler(this.buttonEmpSearch_Click);
            // 
            // textBoxEmpSearch
            // 
            this.textBoxEmpSearch.Location = new System.Drawing.Point(610, 116);
            this.textBoxEmpSearch.Name = "textBoxEmpSearch";
            this.textBoxEmpSearch.Size = new System.Drawing.Size(170, 22);
            this.textBoxEmpSearch.TabIndex = 44;
            // 
            // comboBoxEmpSearch
            // 
            this.comboBoxEmpSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpSearch.FormattingEnabled = true;
            this.comboBoxEmpSearch.Items.AddRange(new object[] {
            "EmployeeID",
            "First Name or Last Name"});
            this.comboBoxEmpSearch.Location = new System.Drawing.Point(610, 52);
            this.comboBoxEmpSearch.Name = "comboBoxEmpSearch";
            this.comboBoxEmpSearch.Size = new System.Drawing.Size(170, 24);
            this.comboBoxEmpSearch.TabIndex = 43;
            this.comboBoxEmpSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpSearch_SelectedIndexChanged);
            // 
            // labelEmpSearch
            // 
            this.labelEmpSearch.AutoSize = true;
            this.labelEmpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpSearch.Location = new System.Drawing.Point(512, 55);
            this.labelEmpSearch.Name = "labelEmpSearch";
            this.labelEmpSearch.Size = new System.Drawing.Size(78, 16);
            this.labelEmpSearch.TabIndex = 42;
            this.labelEmpSearch.Text = "Search By";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(42, 249);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(81, 16);
            this.labelLastName.TabIndex = 35;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(42, 197);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(82, 16);
            this.labelFirstName.TabIndex = 34;
            this.labelFirstName.Text = "First Name";
            // 
            // labelEmployeeEmail
            // 
            this.labelEmployeeEmail.AutoSize = true;
            this.labelEmployeeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeEmail.Location = new System.Drawing.Point(42, 303);
            this.labelEmployeeEmail.Name = "labelEmployeeEmail";
            this.labelEmployeeEmail.Size = new System.Drawing.Size(46, 16);
            this.labelEmployeeEmail.TabIndex = 33;
            this.labelEmployeeEmail.Text = "Email";
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeID.Location = new System.Drawing.Point(42, 46);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(92, 16);
            this.labelEmployeeID.TabIndex = 32;
            this.labelEmployeeID.Text = "EmployeeID";
            // 
            // textBoxEmployeeEmail
            // 
            this.textBoxEmployeeEmail.Location = new System.Drawing.Point(45, 322);
            this.textBoxEmployeeEmail.Name = "textBoxEmployeeEmail";
            this.textBoxEmployeeEmail.Size = new System.Drawing.Size(170, 22);
            this.textBoxEmployeeEmail.TabIndex = 29;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(45, 216);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(170, 22);
            this.textBoxFirstName.TabIndex = 31;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(45, 268);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(170, 22);
            this.textBoxLastName.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonEmpSave);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 321);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add";
            // 
            // buttonEmpSave
            // 
            this.buttonEmpSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpSave.Location = new System.Drawing.Point(66, 287);
            this.buttonEmpSave.Name = "buttonEmpSave";
            this.buttonEmpSave.Size = new System.Drawing.Size(75, 23);
            this.buttonEmpSave.TabIndex = 39;
            this.buttonEmpSave.Text = "Save";
            this.buttonEmpSave.UseVisualStyleBackColor = true;
            this.buttonEmpSave.Click += new System.EventHandler(this.buttonEmpSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.buttonEmpDel);
            this.groupBox4.Controls.Add(this.buttonEmpUpdate);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(27, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 112);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update/Delete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "**Select ID to Delete";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "*Select ID and add the info to update in Add";
            // 
            // buttonEmpDel
            // 
            this.buttonEmpDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpDel.Location = new System.Drawing.Point(302, 40);
            this.buttonEmpDel.Name = "buttonEmpDel";
            this.buttonEmpDel.Size = new System.Drawing.Size(75, 23);
            this.buttonEmpDel.TabIndex = 41;
            this.buttonEmpDel.Text = "Delete";
            this.buttonEmpDel.UseVisualStyleBackColor = true;
            this.buttonEmpDel.Click += new System.EventHandler(this.buttonEmpDel_Click);
            // 
            // buttonEmpUpdate
            // 
            this.buttonEmpUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpUpdate.Location = new System.Drawing.Point(221, 40);
            this.buttonEmpUpdate.Name = "buttonEmpUpdate";
            this.buttonEmpUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonEmpUpdate.TabIndex = 40;
            this.buttonEmpUpdate.Text = "Update";
            this.buttonEmpUpdate.UseVisualStyleBackColor = true;
            this.buttonEmpUpdate.Click += new System.EventHandler(this.buttonEmpUpdate_Click);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 630);
            this.Controls.Add(this.tabControlEmployee);
            this.Name = "ManagementForm";
            this.Text = "ManagementForm";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.tabControlEmployee.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            this.tabPageUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TabControl tabControlEmployee;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.ComboBox comboBoxCustomer_Employee;
        private System.Windows.Forms.Label labelmsgSelect;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelmsgUser;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelMessageSearch;
        private System.Windows.Forms.ColumnHeader columnHeaderUserID;
        private System.Windows.Forms.ColumnHeader columnHeaderUsername;
        private System.Windows.Forms.ColumnHeader columnHeaderPassword;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderEmployeeID;
        private System.Windows.Forms.ColumnHeader columnHeaderCustomerID;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labelJobID;
        private System.Windows.Forms.Label labelSearchEmp;
        private System.Windows.Forms.Label labelmsgEmp;
        private System.Windows.Forms.Button buttonEmpList;
        private System.Windows.Forms.ListView listViewEmployee;
        private System.Windows.Forms.ColumnHeader columnHeaderEmpID;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastName;
        private System.Windows.Forms.ColumnHeader columnHeaderEmpEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderJobID;
        private System.Windows.Forms.Button buttonEmpSearch;
        private System.Windows.Forms.TextBox textBoxEmpSearch;
        private System.Windows.Forms.ComboBox comboBoxEmpSearch;
        private System.Windows.Forms.Label labelEmpSearch;
        private System.Windows.Forms.Button buttonEmpDel;
        private System.Windows.Forms.Button buttonEmpUpdate;
        private System.Windows.Forms.Button buttonEmpSave;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelEmployeeEmail;
        private System.Windows.Forms.Label labelEmployeeID;
        private System.Windows.Forms.TextBox textBoxEmployeeEmail;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxlistEmp_Cstm;
        private System.Windows.Forms.ComboBox comboBoxJobId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEmpID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}