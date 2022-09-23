using System;
using System.Collections.Generic;
using System.Text;
using AddressBookBLL.AddressBL;
using AddressBookDTO.DTO;
using AddressBookDSL.AddressDL;
using System.Data;

namespace AddressBookBLL.AddressBL
{
    public class AddressBLL
    {
        public static int AddressInsert(AddressBookDto addressBook)
        {
            int output = 0;
            try
            {
              

                output = AddressDSL.AddressInsert(addressBook);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : StudentMarkBl:StudentInsertMark : " + ex.Message.ToString());
            }

            return output;

        }

        public static DataSet GetContactsLike(string likeName,string searchOption)
        {

            DataSet dsContacts = null;
            try
            {

                dsContacts = AddressDSL.GetContactsLike(likeName,searchOption);


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : AddressBLL:GetContactsLike : " + ex.Message.ToString());
            }

            return dsContacts;
        }

        public static DataSet GetContactIds()
        {


            DataSet dsContactIds = null;
            try
            {
                dsContactIds = AddressDSL.GetContactIds();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : AddressBookDSL:GetContactIds : " + ex.Message.ToString());
            }


            return dsContactIds;
        }


        public static AddressBookDto GetContactsByIds(string contactId)
        {

            AddressBookDto addressBook = null;
            try
            {
                addressBook = AddressDSL.GetContactsByIds(contactId);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : AddressBLL:GetContactsByIds : " + ex.Message.ToString());
            }


            return addressBook;
        }

        public static int ContactUpdate(AddressBookDto addressBook)
        {
            int output = 0;

            try
            {

                output = AddressDSL.ContactUpdate(addressBook);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : AddressBLL:ContactUpdate : " + ex.Message.ToString());
            }


            return output;

        }

        public static int ContactDelete(string key)
        {
            int output = 0;

            try
            {

                output = AddressDSL.ContactDelete(key);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : AddressBLL:ContactDelete : " + ex.Message.ToString());
            }


            return output;

        }



    }
}
