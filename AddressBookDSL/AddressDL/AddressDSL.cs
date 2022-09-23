using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using AddressBookDSL.Helper;
using AddressBookDTO.DTO;

namespace AddressBookDSL.AddressDL
{
    public class AddressDSL
    {
        public static int AddressInsert(AddressBookDto addressBook)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {

                sql = "insert into address_book(contact_id,name,gender,email,phone,address) values(";
                sql = sql + "'" + addressBook.ContactId + "',";
                sql = sql + "'" + addressBook.ContactName + "',";
                sql = sql + "'" + addressBook.Gender + "',";
                sql = sql + "'" + addressBook.Email + "',";
                sql = sql + addressBook.Mobile + ",";            
                sql = sql + "'" + addressBook.Address + "')";

                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);
                output = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error:StudentMarkDao:StudentMarkInsert:" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

            return output;
        }

        public static DataSet GetContactsLike(string likeName,string searchOption)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsContacts = null;   
            try
            {
                string option="";
                if (searchOption == "Contact ID")
                {
                    option = "contact_id";
                }
                else if (searchOption == "Contact Name")
                {
                    option = "name";
                }
                else if (searchOption == "Email")
                {
                    option = "email";
                }
                else if (searchOption == "Mobile")
                {
                    option = "mobile";
                }
                else if (searchOption == "State")
                {
                    option = "state";
                }
                else if (searchOption == "Gender")
                {
                    option = "gender";
                    option = "gender";
                }
                if (option == "")
                {
                     sql = "select * from address_book where name like '"+likeName+"%'";
                }
                else
                {
                    sql = "select * from address_book where " + option + " like '" + likeName + "%'";
                }
               
                con = DBHelper.GetConnection();
                con.Open();
                dsContacts = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsContacts);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : AddressDSL:GetContactsLike : " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return dsContacts;
        }

        public static DataSet GetContactIds()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsContactIds = null;
            try
            {
                sql = "select contact_id from address_book";
                con = DBHelper.GetConnection();
                con.Open();
                dsContactIds = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsContactIds);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : AddressBookDSL:GetContactIds : " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return dsContactIds;
        }

        public static AddressBookDto GetContactsByIds(string contactId)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsContacts = null;
            AddressBookDto addressBook = null;
            try
            {
                sql = "select * from address_book where contact_id='" + contactId + "'";
                con = DBHelper.GetConnection();
                con.Open();
                dsContacts = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsContacts);
                Object[] Data = null;
                if (dsContacts.Tables[0].Rows.Count > 0)
                {
                    Data = dsContacts.Tables[0].Rows[0].ItemArray;
                    addressBook = new AddressBookDto();
                    addressBook.ContactId = Data[0].ToString();
                    addressBook.ContactName = Data[1].ToString();
                    addressBook.Gender = Data[2].ToString();
                    addressBook.Email = Data[3].ToString();
                    addressBook.Mobile = Convert.ToInt32(Data[4].ToString());
                    addressBook.Address = Data[5].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : StudentMarkDao:GetStudentByIds : " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return addressBook;
        }

        public static int ContactUpdate(AddressBookDto addressBook)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                sql = "update address_book set ";
                sql = sql + "contact_id='" + addressBook.ContactId + "',";
                sql = sql + "name='" + addressBook.ContactName + "',";
                sql = sql + "gender='" + addressBook.Gender + "',";
                sql = sql + "email='" + addressBook.Email + "',";
                sql = sql +"phone="+ addressBook.Mobile + ",";
                sql = sql + "address='" + addressBook.Address + "' where contact_id='" + addressBook.ContactId + "'";

                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);
                output = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : AddressDSL:ContactUpdate : " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;
        }

        public static int ContactDelete(string key)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                sql = "delete from address_book where contact_id='" + key+"'";       
                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);
                output = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : AddressDSL:ContactDelete : " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;
        }
    }
}
