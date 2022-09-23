using AddressBookBLL.AddressBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressBookDTO.DTO;
using System.Text.RegularExpressions;

namespace AddressBookPL
{ 
    public partial class AddressBook : Form
    {
        string searchOption;
		
        public AddressBook()
        {
            InitializeComponent();
        }

        private void AddressBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addressBookDataSet1.address_book' table. You can move, or remove it, as needed.
           // this.address_bookTableAdapter.Fill(this.addressBookDataSet1.address_book);
        }


		private void btnHome_Click(object sender, EventArgs e)
		{
            panelInsert.Visible = false;
            panelUpdate.Visible = false;
            panelHome.Visible = true;
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            panelInsert.Visible = true;
        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
           
            panelUpdate.Visible = true;
            DataSet dsContactIds = null;
            try
            {
                dsContactIds = AddressBLL.GetContactIds();
                if (dsContactIds != null)
                {
                    cmbContactID.DataSource = dsContactIds.Tables[0];
                    cmbContactID.ValueMember = "contact_id";
                    cmbContactID.DisplayMember = "contact_id";
                }
                else
                {
                    lblMessage3.Text = "No Contacts Available!";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        } 

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            DataSet dsContacts = null;
            try
            {
                string nameLike = txtSearch.Text;
                dsContacts = AddressBLL.GetContactsLike(nameLike, searchOption);
                if (dsContacts != null)
                {
                   dgvContacts.DataSource= dsContacts.Tables[0];
                }
                else
                {
                    lblMessage.Text = "No Contacts Available!";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchOption = cmbOption.Text;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            AddressBookDto addressBook = null;
            int output = 0;
            if (InsertionFormValidation())
            {
                try
                {
                    addressBook = new AddressBookDto();
                    addressBook.ContactId = txtContactId.Text;
                    addressBook.ContactName = txtName.Text;

                    addressBook.Email = txtEmail.Text;
                    addressBook.State = cmbState.Text;
                    addressBook.Mobile = Convert.ToInt32(txtMobile.Text);
                    if (radioMale.Checked == true)
                    {
                        addressBook.Gender = "Male";
                    }
                    else
                    {
                        addressBook.Gender = "Female";
                    }
                    addressBook.Address = txtAddress.Text;

                    output = AddressBLL.AddressInsert(addressBook);

                    if (output > 0)
                    {

                        lblMessage2.Text = "Details Added Successfully!";

                    }
                    else
                    {
                        lblMessage2.Text = "Failed! Please Try Again.";
                    }

                }
                catch (Exception ex)
                {
                    lblMessage2.Text = ex.Message.ToString();
                }
            }
        }
     
        private void ClearControl()
        {
            txtContactId.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            cmbState.Text = "";
            radioMale.Checked = true;
            txtAddress.Text = "";
            lblMessage.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void LoadContactIds()
        {
            DataSet dsContactIds = null;
            try
            {
                dsContactIds = AddressBLL.GetContactIds();
                if (dsContactIds != null)
                {
                    cmbContactID.DataSource = dsContactIds.Tables[0];
                    cmbContactID.ValueMember = "contact_id";
                    cmbContactID.DisplayMember = "contact_id";
                }
                else
                {
                    lblMessage3.Text = "No Contacts Available!";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }

        }

        private void cmbContactID_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddressBookDto addressBook = null;
            try
            {
                addressBook = AddressBLL.GetContactsByIds(cmbContactID.Text);
                if (addressBook != null)
                {
                    txtUpdContactId.Text = addressBook.ContactId;
                    txtUpdName.Text = addressBook.ContactName;
                    txtUpdAddress.Text = addressBook.Address;
                    cmbUpdState.Text = addressBook.State;
                    txtUpdEmail.Text = addressBook.Email;
                    txtUpdMobile.Text = addressBook.Mobile.ToString();
                    if (addressBook.Gender == "Male")
                    {
                        radioUpdMale.Checked = true;
                    }
                    else
                    {
                        radioUpdFemale.Checked = true;
                    }
                }

            }
            catch (Exception ex)
            {
                lblMessage3.Text = ex.Message.ToString();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddressBookDto addressBook = null;
            int output = 0;
            if (UpdateFormValidation())
            {
                try
                {
                    addressBook = new AddressBookDto();
                    addressBook.ContactId = txtUpdContactId.Text;
                    addressBook.ContactName = txtUpdName.Text;

                    addressBook.Email = txtUpdEmail.Text;
                    addressBook.State = cmbUpdState.Text;
                    addressBook.Mobile = Convert.ToInt32(txtUpdMobile.Text);
                    if (radioUpdMale.Checked == true)
                    {
                        addressBook.Gender = "Male";
                    }
                    else
                    {
                        addressBook.Gender = "Female";
                    }
                    addressBook.Address = txtUpdAddress.Text;

                    output = AddressBLL.ContactUpdate(addressBook);

                    if (output > 0)
                    {
                        LoadContactIds();
                        lblMessage3.Text = "Updated Successfully.";
                    }
                }

                catch (FormatException ex)
                {
                    lblMessage3.Text = "Kindly Enter a Numeric Value";
                }
                catch (Exception ex)
                {
                    lblMessage3.Text = ex.Message.ToString();
                }
            }
        }

        private bool InsertionFormValidation()
        {
            bool flag = true;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(txtEmail.Text);
            if (txtContactId.Text == ""|| txtName.Text == "" || txtEmail.Text == "" || txtMobile.Text == "" || txtAddress.Text == "" || cmbState.Text=="")
            {
                lblMessage2.Text = "Please fill all the required fields.";
                flag = false;
            }
            else if(!(radioMale.Checked || radioFemale.Checked))
            {
                lblMessage2.Text = "Please select your gender.";
                flag = false;
            }
            else if (txtMobile.Text.Length!=10|| !int.TryParse(txtMobile.Text, out int result))
            {
                lblMessage2.Text = "Invalid Mobile Number.";
                flag = false;
            }
            else if (!match.Success)
            {
                lblMessage2.Text = "Invalid Email Address.";
                flag = false;
            }
            return flag;
        }

        private bool UpdateFormValidation()
        {
            bool flag = true;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(txtEmail.Text);

            if (txtUpdName.Text == "" || txtUpdEmail.Text == "" || txtUpdMobile.Text == "" || txtUpdAddress.Text == "" || cmbUpdState.Text == "")
            {
                lblMessage3.Text = "Please fill all the required fields.";
                flag = false;
            }
            else if (!(radioUpdMale.Checked || radioUpdFemale.Checked))
            {
                lblMessage3.Text = "Please select your gender.";
                flag = false;
            }
            else if (txtUpdMobile.Text.Length != 10 || !int.TryParse(txtUpdMobile.Text, out int result))
            {
                lblMessage3.Text = "Invalid Mobile Number.";
                flag = false;
            }
            else if (!match.Success)
            {
                lblMessage3.Text = "Invalid Email Address.";
                flag = false;
            }
            return flag;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string key;
            int output;
            key = txtUpdContactId.Text;

            output = AddressBLL.ContactDelete(key);

            if (output>0)
            {
                 LoadContactIds();
                 lblMessage3.Text = "Deleted Successfully.";
            }
            else
            {
               LoadContactIds();
                lblMessage3.Text = "Deleted Operation Failed.";
            }
        }
    }
}
