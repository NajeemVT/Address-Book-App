using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookDTO.DTO
{
    public class AddressBookDto
    {
        private string contactId;

        public string ContactId
        {
            get { return contactId; }
            set { contactId = value; }
        }

        private string contactName;

        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        private int mobile;
        public int Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
