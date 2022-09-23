namespace AddressBookPL
{
    partial class AddressBook
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnUpdateContact = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.addressBookDataSet = new AddressBookPL.AddressBookDataSet();
            this.addressBookDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressBookDataSet1 = new AddressBookPL.AddressBookDataSet1();
            this.addressbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.address_bookTableAdapter = new AddressBookPL.AddressBookDataSet1TableAdapters.address_bookTableAdapter();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelInsert = new System.Windows.Forms.Panel();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.lblSearchUpdate = new System.Windows.Forms.Label();
            this.cmbContactID = new System.Windows.Forms.ComboBox();
            this.lblMessage3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUpdAddress = new System.Windows.Forms.TextBox();
            this.radioUpdFemale = new System.Windows.Forms.RadioButton();
            this.radioUpdMale = new System.Windows.Forms.RadioButton();
            this.cmbUpdState = new System.Windows.Forms.ComboBox();
            this.txtUpdMobile = new System.Windows.Forms.TextBox();
            this.txtUpdEmail = new System.Windows.Forms.TextBox();
            this.txtUpdName = new System.Windows.Forms.TextBox();
            this.txtUpdContactId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtContactId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressbookBindingSource)).BeginInit();
            this.panelHome.SuspendLayout();
            this.panelInsert.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.panelSideMenu.Controls.Add(this.panelSubMenu);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 576);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenu.Controls.Add(this.btnUpdateContact);
            this.panelSubMenu.Controls.Add(this.btnAddContact);
            this.panelSubMenu.Controls.Add(this.btnHome);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 95);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(250, 165);
            this.panelSubMenu.TabIndex = 1;
            // 
            // btnUpdateContact
            // 
            this.btnUpdateContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateContact.FlatAppearance.BorderSize = 0;
            this.btnUpdateContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.btnUpdateContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateContact.ForeColor = System.Drawing.Color.Silver;
            this.btnUpdateContact.Location = new System.Drawing.Point(0, 111);
            this.btnUpdateContact.Name = "btnUpdateContact";
            this.btnUpdateContact.Padding = new System.Windows.Forms.Padding(10);
            this.btnUpdateContact.Size = new System.Drawing.Size(250, 53);
            this.btnUpdateContact.TabIndex = 2;
            this.btnUpdateContact.Text = "Update Contact";
            this.btnUpdateContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateContact.UseVisualStyleBackColor = true;
            this.btnUpdateContact.Click += new System.EventHandler(this.btnUpdateContact_Click);
            // 
            // btnAddContact
            // 
            this.btnAddContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddContact.FlatAppearance.BorderSize = 0;
            this.btnAddContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.btnAddContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContact.ForeColor = System.Drawing.Color.Silver;
            this.btnAddContact.Location = new System.Drawing.Point(0, 57);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Padding = new System.Windows.Forms.Padding(10);
            this.btnAddContact.Size = new System.Drawing.Size(250, 54);
            this.btnAddContact.TabIndex = 1;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Silver;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10);
            this.btnHome.Size = new System.Drawing.Size(250, 57);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "View Contacts";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 95);
            this.panel1.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(48)))), ((int)(((byte)(124)))));
            this.lblHeading.Location = new System.Drawing.Point(28, 31);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(196, 33);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Address Book";
            // 
            // addressBookDataSet
            // 
            this.addressBookDataSet.DataSetName = "AddressBookDataSet";
            this.addressBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressBookDataSetBindingSource
            // 
            this.addressBookDataSetBindingSource.DataSource = this.addressBookDataSet;
            this.addressBookDataSetBindingSource.Position = 0;
            // 
            // addressBookDataSet1
            // 
            this.addressBookDataSet1.DataSetName = "AddressBookDataSet1";
            this.addressBookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressbookBindingSource
            // 
            this.addressbookBindingSource.DataMember = "address_book";
            this.addressbookBindingSource.DataSource = this.addressBookDataSet1;
            // 
            // address_bookTableAdapter
            // 
            this.address_bookTableAdapter.ClearBeforeFill = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Silver;
            this.lblSearch.Location = new System.Drawing.Point(29, 69);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(96, 24);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search By";
            // 
            // cmbOption
            // 
            this.cmbOption.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Items.AddRange(new object[] {
            "Contact ID",
            "Contact Name",
            "Email",
            "Mobile",
            "State",
            "Gender"});
            this.cmbOption.Location = new System.Drawing.Point(143, 72);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(168, 24);
            this.cmbOption.TabIndex = 1;
            this.cmbOption.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsTab = true;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HideSelection = false;
            this.txtSearch.Location = new System.Drawing.Point(343, 72);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(316, 24);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblMessage.Location = new System.Drawing.Point(227, 48);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 24);
            this.lblMessage.TabIndex = 4;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelHome.Controls.Add(this.panelInsert);
            this.panelHome.Controls.Add(this.dgvContacts);
            this.panelHome.Controls.Add(this.txtSearch);
            this.panelHome.Controls.Add(this.cmbOption);
            this.panelHome.Controls.Add(this.lblSearch);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(250, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(702, 576);
            this.panelHome.TabIndex = 1;
            // 
            // panelInsert
            // 
            this.panelInsert.Controls.Add(this.panelUpdate);
            this.panelInsert.Controls.Add(this.label3);
            this.panelInsert.Controls.Add(this.btnClear);
            this.panelInsert.Controls.Add(this.btnSave);
            this.panelInsert.Controls.Add(this.label1);
            this.panelInsert.Controls.Add(this.txtAddress);
            this.panelInsert.Controls.Add(this.radioFemale);
            this.panelInsert.Controls.Add(this.radioMale);
            this.panelInsert.Controls.Add(this.cmbState);
            this.panelInsert.Controls.Add(this.txtMobile);
            this.panelInsert.Controls.Add(this.txtEmail);
            this.panelInsert.Controls.Add(this.txtName);
            this.panelInsert.Controls.Add(this.txtContactId);
            this.panelInsert.Controls.Add(this.label8);
            this.panelInsert.Controls.Add(this.label7);
            this.panelInsert.Controls.Add(this.label6);
            this.panelInsert.Controls.Add(this.label5);
            this.panelInsert.Controls.Add(this.label4);
            this.panelInsert.Controls.Add(this.label2);
            this.panelInsert.Controls.Add(this.label9);
            this.panelInsert.Controls.Add(this.lblMessage2);
            this.panelInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInsert.Location = new System.Drawing.Point(0, 0);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(702, 576);
            this.panelInsert.TabIndex = 7;
            this.panelInsert.Visible = false;
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.btnDelete);
            this.panelUpdate.Controls.Add(this.lblSearchUpdate);
            this.panelUpdate.Controls.Add(this.cmbContactID);
            this.panelUpdate.Controls.Add(this.lblMessage3);
            this.panelUpdate.Controls.Add(this.label11);
            this.panelUpdate.Controls.Add(this.btnUpdate);
            this.panelUpdate.Controls.Add(this.lblMessage);
            this.panelUpdate.Controls.Add(this.label12);
            this.panelUpdate.Controls.Add(this.label13);
            this.panelUpdate.Controls.Add(this.txtUpdAddress);
            this.panelUpdate.Controls.Add(this.radioUpdFemale);
            this.panelUpdate.Controls.Add(this.radioUpdMale);
            this.panelUpdate.Controls.Add(this.cmbUpdState);
            this.panelUpdate.Controls.Add(this.txtUpdMobile);
            this.panelUpdate.Controls.Add(this.txtUpdEmail);
            this.panelUpdate.Controls.Add(this.txtUpdName);
            this.panelUpdate.Controls.Add(this.txtUpdContactId);
            this.panelUpdate.Controls.Add(this.label14);
            this.panelUpdate.Controls.Add(this.label15);
            this.panelUpdate.Controls.Add(this.label16);
            this.panelUpdate.Controls.Add(this.label17);
            this.panelUpdate.Controls.Add(this.label18);
            this.panelUpdate.Controls.Add(this.label19);
            this.panelUpdate.Controls.Add(this.label20);
            this.panelUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUpdate.Location = new System.Drawing.Point(0, 0);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(702, 576);
            this.panelUpdate.TabIndex = 22;
            this.panelUpdate.Visible = false;
            // 
            // lblSearchUpdate
            // 
            this.lblSearchUpdate.AutoSize = true;
            this.lblSearchUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchUpdate.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblSearchUpdate.Location = new System.Drawing.Point(131, 92);
            this.lblSearchUpdate.Name = "lblSearchUpdate";
            this.lblSearchUpdate.Size = new System.Drawing.Size(135, 20);
            this.lblSearchUpdate.TabIndex = 44;
            this.lblSearchUpdate.Text = "Select Contact ID";
            // 
            // cmbContactID
            // 
            this.cmbContactID.FormattingEnabled = true;
            this.cmbContactID.Location = new System.Drawing.Point(317, 92);
            this.cmbContactID.Name = "cmbContactID";
            this.cmbContactID.Size = new System.Drawing.Size(102, 24);
            this.cmbContactID.TabIndex = 43;
            this.cmbContactID.SelectedIndexChanged += new System.EventHandler(this.cmbContactID_SelectedIndexChanged);
            // 
            // lblMessage3
            // 
            this.lblMessage3.AutoSize = true;
            this.lblMessage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblMessage3.Location = new System.Drawing.Point(245, 48);
            this.lblMessage3.Name = "lblMessage3";
            this.lblMessage3.Size = new System.Drawing.Size(0, 24);
            this.lblMessage3.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label11.Location = new System.Drawing.Point(325, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 24);
            this.label11.TabIndex = 41;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdate.Location = new System.Drawing.Point(480, 510);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 40);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label12.Location = new System.Drawing.Point(201, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 24);
            this.label12.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(48)))), ((int)(((byte)(124)))));
            this.label13.Location = new System.Drawing.Point(233, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 29);
            this.label13.TabIndex = 38;
            this.label13.Text = "Update Contact";
            // 
            // txtUpdAddress
            // 
            this.txtUpdAddress.Location = new System.Drawing.Point(259, 406);
            this.txtUpdAddress.Multiline = true;
            this.txtUpdAddress.Name = "txtUpdAddress";
            this.txtUpdAddress.Size = new System.Drawing.Size(242, 81);
            this.txtUpdAddress.TabIndex = 37;
            // 
            // radioUpdFemale
            // 
            this.radioUpdFemale.AutoSize = true;
            this.radioUpdFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUpdFemale.ForeColor = System.Drawing.Color.Silver;
            this.radioUpdFemale.Location = new System.Drawing.Point(347, 369);
            this.radioUpdFemale.Name = "radioUpdFemale";
            this.radioUpdFemale.Size = new System.Drawing.Size(75, 22);
            this.radioUpdFemale.TabIndex = 36;
            this.radioUpdFemale.Text = "Female";
            this.radioUpdFemale.UseVisualStyleBackColor = true;
            // 
            // radioUpdMale
            // 
            this.radioUpdMale.AutoSize = true;
            this.radioUpdMale.Checked = true;
            this.radioUpdMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUpdMale.ForeColor = System.Drawing.Color.Silver;
            this.radioUpdMale.Location = new System.Drawing.Point(259, 369);
            this.radioUpdMale.Name = "radioUpdMale";
            this.radioUpdMale.Size = new System.Drawing.Size(58, 22);
            this.radioUpdMale.TabIndex = 35;
            this.radioUpdMale.TabStop = true;
            this.radioUpdMale.Text = "Male";
            this.radioUpdMale.UseVisualStyleBackColor = true;
            // 
            // cmbUpdState
            // 
            this.cmbUpdState.FormattingEnabled = true;
            this.cmbUpdState.Items.AddRange(new object[] {
            "KERALA",
            "TAMILNADU",
            "KARNADAKA",
            "ANDRA RPRADESH",
            "MADHYA PRADHESH",
            "JAMMU& KASHMIR",
            "DELHI",
            "GUJRATH",
            "GOA",
            "HIMAJAL PRADESH"});
            this.cmbUpdState.Location = new System.Drawing.Point(259, 320);
            this.cmbUpdState.Name = "cmbUpdState";
            this.cmbUpdState.Size = new System.Drawing.Size(242, 24);
            this.cmbUpdState.TabIndex = 34;
            // 
            // txtUpdMobile
            // 
            this.txtUpdMobile.Location = new System.Drawing.Point(259, 286);
            this.txtUpdMobile.Name = "txtUpdMobile";
            this.txtUpdMobile.Size = new System.Drawing.Size(242, 22);
            this.txtUpdMobile.TabIndex = 33;
            // 
            // txtUpdEmail
            // 
            this.txtUpdEmail.Location = new System.Drawing.Point(259, 241);
            this.txtUpdEmail.Name = "txtUpdEmail";
            this.txtUpdEmail.Size = new System.Drawing.Size(242, 22);
            this.txtUpdEmail.TabIndex = 32;
            // 
            // txtUpdName
            // 
            this.txtUpdName.Location = new System.Drawing.Point(259, 188);
            this.txtUpdName.Name = "txtUpdName";
            this.txtUpdName.Size = new System.Drawing.Size(242, 22);
            this.txtUpdName.TabIndex = 31;
            // 
            // txtUpdContactId
            // 
            this.txtUpdContactId.Enabled = false;
            this.txtUpdContactId.Location = new System.Drawing.Point(259, 139);
            this.txtUpdContactId.Name = "txtUpdContactId";
            this.txtUpdContactId.Size = new System.Drawing.Size(242, 22);
            this.txtUpdContactId.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(133, 407);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Address";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(133, 369);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Gender";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Silver;
            this.label16.Location = new System.Drawing.Point(133, 329);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "State";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Silver;
            this.label17.Location = new System.Drawing.Point(136, 288);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 20);
            this.label17.TabIndex = 25;
            this.label17.Text = "Mobile";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Silver;
            this.label18.Location = new System.Drawing.Point(136, 241);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 20);
            this.label18.TabIndex = 24;
            this.label18.Text = "Email";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Silver;
            this.label19.Location = new System.Drawing.Point(133, 188);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 20);
            this.label19.TabIndex = 23;
            this.label19.Text = "Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Silver;
            this.label20.Location = new System.Drawing.Point(133, 139);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 20);
            this.label20.TabIndex = 22;
            this.label20.Text = "Contact ID";
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblMessage2.Location = new System.Drawing.Point(227, 69);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(0, 24);
            this.lblMessage2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(351, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 20;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SlateGray;
            this.btnClear.Location = new System.Drawing.Point(373, 493);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 40);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave.Location = new System.Drawing.Point(494, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 40);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(48)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add New Contact";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(285, 387);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(242, 81);
            this.txtAddress.TabIndex = 16;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFemale.ForeColor = System.Drawing.Color.Silver;
            this.radioFemale.Location = new System.Drawing.Point(373, 352);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(75, 22);
            this.radioFemale.TabIndex = 15;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Checked = true;
            this.radioMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMale.ForeColor = System.Drawing.Color.Silver;
            this.radioMale.Location = new System.Drawing.Point(285, 352);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(58, 22);
            this.radioMale.TabIndex = 14;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "KERALA",
            "TAMILNADU",
            "KARNADAKA",
            "ANDRA RPRADESH",
            "MADHYA PRADHESH",
            "JAMMU& KASHMIR",
            "DELHI",
            "GUJRATH",
            "GOA",
            "HIMAJAL PRADESH"});
            this.cmbState.Location = new System.Drawing.Point(285, 303);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(229, 24);
            this.cmbState.TabIndex = 13;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(285, 269);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(229, 22);
            this.txtMobile.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(285, 224);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(242, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(285, 171);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 22);
            this.txtName.TabIndex = 9;
            // 
            // txtContactId
            // 
            this.txtContactId.Location = new System.Drawing.Point(285, 122);
            this.txtContactId.Name = "txtContactId";
            this.txtContactId.Size = new System.Drawing.Size(242, 22);
            this.txtContactId.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(159, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(159, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(159, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(162, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mobile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(162, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(159, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(159, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Contact ID";
            // 
            // dgvContacts
            // 
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvContacts.Location = new System.Drawing.Point(33, 137);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.Size = new System.Drawing.Size(626, 396);
            this.dgvContacts.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Location = new System.Drawing.Point(347, 510);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 40);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 576);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "AddressBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddressBook";
            this.Load += new System.EventHandler(this.AddressBook_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressbookBindingSource)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panelInsert.ResumeLayout(false);
            this.panelInsert.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.BindingSource addressBookDataSetBindingSource;
        private AddressBookDataSet addressBookDataSet;
        private AddressBookDataSet1 addressBookDataSet1;
        private System.Windows.Forms.BindingSource addressbookBindingSource;
        private AddressBookDataSet1TableAdapters.address_bookTableAdapter address_bookTableAdapter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Panel panelInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContactId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateContact;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Label lblMessage3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUpdAddress;
        private System.Windows.Forms.RadioButton radioUpdFemale;
        private System.Windows.Forms.RadioButton radioUpdMale;
        private System.Windows.Forms.ComboBox cmbUpdState;
        private System.Windows.Forms.TextBox txtUpdMobile;
        private System.Windows.Forms.TextBox txtUpdEmail;
        private System.Windows.Forms.TextBox txtUpdName;
        private System.Windows.Forms.TextBox txtUpdContactId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblSearchUpdate;
        private System.Windows.Forms.ComboBox cmbContactID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnDelete;
    }
}