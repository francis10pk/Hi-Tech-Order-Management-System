namespace Hi_Tech_Order_Management_System.GUI
{
    partial class SalesForms
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.textBoxCustName = new System.Windows.Forms.TextBox();
            this.textBoxCustFax = new System.Windows.Forms.TextBox();
            this.textBoxCustCredit = new System.Windows.Forms.TextBox();
            this.textBoxCustPostal = new System.Windows.Forms.TextBox();
            this.textBoxCustCity = new System.Windows.Forms.TextBox();
            this.textBoxCustPhone = new System.Windows.Forms.TextBox();
            this.textBoxCustStreet = new System.Windows.Forms.TextBox();
            this.labelCustID = new System.Windows.Forms.Label();
            this.labelCustName = new System.Windows.Forms.Label();
            this.labelCustCity = new System.Windows.Forms.Label();
            this.labelCustStreet = new System.Windows.Forms.Label();
            this.labelCustPostal = new System.Windows.Forms.Label();
            this.labelCustFax = new System.Windows.Forms.Label();
            this.labelCustPhone = new System.Windows.Forms.Label();
            this.labelCustCredit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewCustomer = new System.Windows.Forms.ListView();
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PostalCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreditLimit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxIDCust = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(52, 507);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.Location = new System.Drawing.Point(252, 507);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(149, 507);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(357, 81);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonList
            // 
            this.buttonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.Location = new System.Drawing.Point(702, 48);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(75, 23);
            this.buttonList.TabIndex = 4;
            this.buttonList.Text = "List All";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // textBoxCustName
            // 
            this.textBoxCustName.Location = new System.Drawing.Point(208, 102);
            this.textBoxCustName.Name = "textBoxCustName";
            this.textBoxCustName.Size = new System.Drawing.Size(100, 22);
            this.textBoxCustName.TabIndex = 5;
            // 
            // textBoxCustFax
            // 
            this.textBoxCustFax.Location = new System.Drawing.Point(208, 374);
            this.textBoxCustFax.Name = "textBoxCustFax";
            this.textBoxCustFax.Size = new System.Drawing.Size(100, 22);
            this.textBoxCustFax.TabIndex = 6;
            // 
            // textBoxCustCredit
            // 
            this.textBoxCustCredit.Location = new System.Drawing.Point(208, 435);
            this.textBoxCustCredit.Name = "textBoxCustCredit";
            this.textBoxCustCredit.Size = new System.Drawing.Size(100, 22);
            this.textBoxCustCredit.TabIndex = 7;
            // 
            // textBoxCustPostal
            // 
            this.textBoxCustPostal.Location = new System.Drawing.Point(208, 256);
            this.textBoxCustPostal.Name = "textBoxCustPostal";
            this.textBoxCustPostal.Size = new System.Drawing.Size(100, 22);
            this.textBoxCustPostal.TabIndex = 9;
            // 
            // textBoxCustCity
            // 
            this.textBoxCustCity.Location = new System.Drawing.Point(208, 200);
            this.textBoxCustCity.Name = "textBoxCustCity";
            this.textBoxCustCity.Size = new System.Drawing.Size(100, 22);
            this.textBoxCustCity.TabIndex = 10;
            // 
            // textBoxCustPhone
            // 
            this.textBoxCustPhone.Location = new System.Drawing.Point(208, 315);
            this.textBoxCustPhone.Name = "textBoxCustPhone";
            this.textBoxCustPhone.Size = new System.Drawing.Size(100, 22);
            this.textBoxCustPhone.TabIndex = 11;
            // 
            // textBoxCustStreet
            // 
            this.textBoxCustStreet.Location = new System.Drawing.Point(208, 151);
            this.textBoxCustStreet.Name = "textBoxCustStreet";
            this.textBoxCustStreet.Size = new System.Drawing.Size(100, 22);
            this.textBoxCustStreet.TabIndex = 12;
            // 
            // labelCustID
            // 
            this.labelCustID.AutoSize = true;
            this.labelCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustID.Location = new System.Drawing.Point(84, 58);
            this.labelCustID.Name = "labelCustID";
            this.labelCustID.Size = new System.Drawing.Size(22, 16);
            this.labelCustID.TabIndex = 13;
            this.labelCustID.Text = "ID";
            // 
            // labelCustName
            // 
            this.labelCustName.AutoSize = true;
            this.labelCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustName.Location = new System.Drawing.Point(83, 102);
            this.labelCustName.Name = "labelCustName";
            this.labelCustName.Size = new System.Drawing.Size(48, 16);
            this.labelCustName.TabIndex = 14;
            this.labelCustName.Text = "Name";
            // 
            // labelCustCity
            // 
            this.labelCustCity.AutoSize = true;
            this.labelCustCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustCity.Location = new System.Drawing.Point(84, 200);
            this.labelCustCity.Name = "labelCustCity";
            this.labelCustCity.Size = new System.Drawing.Size(33, 16);
            this.labelCustCity.TabIndex = 15;
            this.labelCustCity.Text = "City";
            // 
            // labelCustStreet
            // 
            this.labelCustStreet.AutoSize = true;
            this.labelCustStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustStreet.Location = new System.Drawing.Point(84, 151);
            this.labelCustStreet.Name = "labelCustStreet";
            this.labelCustStreet.Size = new System.Drawing.Size(48, 16);
            this.labelCustStreet.TabIndex = 16;
            this.labelCustStreet.Text = "Street";
            // 
            // labelCustPostal
            // 
            this.labelCustPostal.AutoSize = true;
            this.labelCustPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustPostal.Location = new System.Drawing.Point(84, 259);
            this.labelCustPostal.Name = "labelCustPostal";
            this.labelCustPostal.Size = new System.Drawing.Size(92, 16);
            this.labelCustPostal.TabIndex = 17;
            this.labelCustPostal.Text = "Postal Code";
            // 
            // labelCustFax
            // 
            this.labelCustFax.AutoSize = true;
            this.labelCustFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustFax.Location = new System.Drawing.Point(84, 374);
            this.labelCustFax.Name = "labelCustFax";
            this.labelCustFax.Size = new System.Drawing.Size(32, 16);
            this.labelCustFax.TabIndex = 18;
            this.labelCustFax.Text = "Fax";
            // 
            // labelCustPhone
            // 
            this.labelCustPhone.AutoSize = true;
            this.labelCustPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustPhone.Location = new System.Drawing.Point(83, 315);
            this.labelCustPhone.Name = "labelCustPhone";
            this.labelCustPhone.Size = new System.Drawing.Size(51, 16);
            this.labelCustPhone.TabIndex = 19;
            this.labelCustPhone.Text = "Phone";
            // 
            // labelCustCredit
            // 
            this.labelCustCredit.AutoSize = true;
            this.labelCustCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustCredit.Location = new System.Drawing.Point(84, 435);
            this.labelCustCredit.Name = "labelCustCredit";
            this.labelCustCredit.Size = new System.Drawing.Size(80, 16);
            this.labelCustCredit.TabIndex = 21;
            this.labelCustCredit.Text = "CreditLimit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "ex.(123)456-7890";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "ex. A1A 1A1";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(702, 507);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 25;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "by ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Search Customer";
            // 
            // listViewCustomer
            // 
            this.listViewCustomer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerID,
            this.Name,
            this.Street,
            this.City,
            this.PostalCode,
            this.Fax,
            this.CreditLimit});
            this.listViewCustomer.GridLines = true;
            this.listViewCustomer.HideSelection = false;
            this.listViewCustomer.Location = new System.Drawing.Point(408, 110);
            this.listViewCustomer.Name = "listViewCustomer";
            this.listViewCustomer.Size = new System.Drawing.Size(380, 347);
            this.listViewCustomer.TabIndex = 29;
            this.listViewCustomer.UseCompatibleStateImageBehavior = false;
            this.listViewCustomer.View = System.Windows.Forms.View.Details;
            // 
            // CustomerID
            // 
            this.CustomerID.Text = "CustomerID";
            this.CustomerID.Width = 117;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            // 
            // Street
            // 
            this.Street.Text = "Street";
            // 
            // City
            // 
            this.City.Text = "City";
            // 
            // PostalCode
            // 
            this.PostalCode.Text = "Postal Code";
            this.PostalCode.Width = 82;
            // 
            // Fax
            // 
            this.Fax.Text = "Fax";
            // 
            // CreditLimit
            // 
            this.CreditLimit.Text = "Credit Limit";
            // 
            // comboBoxIDCust
            // 
            this.comboBoxIDCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIDCust.FormattingEnabled = true;
            this.comboBoxIDCust.Location = new System.Drawing.Point(208, 51);
            this.comboBoxIDCust.Name = "comboBoxIDCust";
            this.comboBoxIDCust.Size = new System.Drawing.Size(100, 24);
            this.comboBoxIDCust.TabIndex = 30;
            // 
            // SalesForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.comboBoxIDCust);
            this.Controls.Add(this.listViewCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCustCredit);
            this.Controls.Add(this.labelCustPhone);
            this.Controls.Add(this.labelCustFax);
            this.Controls.Add(this.labelCustPostal);
            this.Controls.Add(this.labelCustStreet);
            this.Controls.Add(this.labelCustCity);
            this.Controls.Add(this.labelCustName);
            this.Controls.Add(this.labelCustID);
            this.Controls.Add(this.textBoxCustStreet);
            this.Controls.Add(this.textBoxCustPhone);
            this.Controls.Add(this.textBoxCustCity);
            this.Controls.Add(this.textBoxCustPostal);
            this.Controls.Add(this.textBoxCustCredit);
            this.Controls.Add(this.textBoxCustFax);
            this.Controls.Add(this.textBoxCustName);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Name = "SalesForms";
            this.Text = "Customer Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.TextBox textBoxCustName;
        private System.Windows.Forms.TextBox textBoxCustFax;
        private System.Windows.Forms.TextBox textBoxCustCredit;
        private System.Windows.Forms.TextBox textBoxCustPostal;
        private System.Windows.Forms.TextBox textBoxCustCity;
        private System.Windows.Forms.TextBox textBoxCustPhone;
        private System.Windows.Forms.TextBox textBoxCustStreet;
        private System.Windows.Forms.Label labelCustID;
        private System.Windows.Forms.Label labelCustName;
        private System.Windows.Forms.Label labelCustCity;
        private System.Windows.Forms.Label labelCustStreet;
        private System.Windows.Forms.Label labelCustPostal;
        private System.Windows.Forms.Label labelCustFax;
        private System.Windows.Forms.Label labelCustPhone;
        private System.Windows.Forms.Label labelCustCredit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewCustomer;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Street;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader PostalCode;
        private System.Windows.Forms.ColumnHeader Fax;
        private System.Windows.Forms.ColumnHeader CreditLimit;
        private System.Windows.Forms.ComboBox comboBoxIDCust;
    }
}