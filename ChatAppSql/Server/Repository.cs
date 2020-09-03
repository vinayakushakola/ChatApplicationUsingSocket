using Server.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Server
{
    public class Repository
    {
        private SqlConnection conn;
        private static int statusCode;
        private static int userPresent;
        public Repository()
        {

        }
        /// <summary>
        /// Sql Connection
        /// </summary>
        private void SQLConnection()
        {
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            conn = new SqlConnection(sqlConnectionString);
        }

        public int Registration(RegistrationRequest userDetails)
        {
            try
            {
                SQLConnection();
                using (SqlCommand cmd = new SqlCommand("spAddUser", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", userDetails.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", userDetails.LastName);
                    cmd.Parameters.AddWithValue("@Email", userDetails.Email);
                    cmd.Parameters.AddWithValue("@UserName", userDetails.UserName);
                    cmd.Parameters.AddWithValue("@Password", userDetails.Password);
                    cmd.Parameters.AddWithValue("@IsOnline", false);
                    cmd.Parameters.AddWithValue("@ActionType", "Registration");

                    SqlParameter CandidatePresentParameter = cmd.Parameters.Add("@EmailPresent", System.Data.SqlDbType.Int);
                    CandidatePresentParameter.Direction = System.Data.ParameterDirection.ReturnValue;

                    SqlParameter cmdExecuteSuccess = cmd.Parameters.Add("@return_value", System.Data.SqlDbType.Int);
                    cmdExecuteSuccess.Direction = System.Data.ParameterDirection.ReturnValue;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    userPresent = Convert.ToInt32(cmd.Parameters["@EmailPresent"].Value);
                    statusCode = Convert.ToInt32(cmd.Parameters["@return_value"].Value);

                    if (userPresent == -1)
                        return userPresent;
                    else if(userPresent == -2)
                        return userPresent;
                    else if(statusCode == 0)
                        return statusCode;
                    return -3;
                };
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Login(LoginRequest loginDetails)
        {
            try
            {
                SQLConnection();
                using (SqlCommand cmd = new SqlCommand("spLogin", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", loginDetails.UserName);
                    cmd.Parameters.AddWithValue("@Password", loginDetails.Password);
                    cmd.Parameters.AddWithValue("@ActionType", "Login");

                    SqlParameter CandidatePresentParameter = cmd.Parameters.Add("@UserPresent", System.Data.SqlDbType.Int);
                    CandidatePresentParameter.Direction = System.Data.ParameterDirection.ReturnValue;

                    SqlParameter cmdExecuteSuccess = cmd.Parameters.Add("@return_value", System.Data.SqlDbType.Int);
                    cmdExecuteSuccess.Direction = System.Data.ParameterDirection.ReturnValue;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    userPresent = Convert.ToInt32(cmd.Parameters["@UserPresent"].Value);
                    statusCode = Convert.ToInt32(cmd.Parameters["@return_value"].Value);
                };
                if (userPresent == -1)
                    return userPresent;
                else if (statusCode == 0)
                    return statusCode;
                return statusCode;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int LogOut(string userName)
        {
            try
            {
                SQLConnection();
                using (SqlCommand cmd = new SqlCommand("spLogOut", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@ActionType", "LogOut");

                    conn.Open();
                    statusCode = cmd.ExecuteNonQuery();
                };
                return statusCode;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddSentMessageDetails(MessageRequest message)
        {
            try
            {
                SQLConnection();
                using (SqlCommand cmd = new SqlCommand("spAddSentMessageDetails", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SenderName", message.SenderName);
                    cmd.Parameters.AddWithValue("@ReceiverName", message.ReceiverName);
                    cmd.Parameters.AddWithValue("@Message", message.Message);

                    conn.Open();
                    int statusCode = cmd.ExecuteNonQuery();
                };
                return statusCode;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<MessageRequest> GetUserMessagesByReceiverName(string senderName, string receiverName)
        {
            try
            {
                SQLConnection();

                List<MessageRequest> messages = new List<MessageRequest>();
                using (SqlCommand cmd = new SqlCommand("spGetUserMessages", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SenderName", senderName);
                    cmd.Parameters.AddWithValue("@ReceiverName", receiverName);

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        MessageRequest msg = new MessageRequest
                        {
                            SenderName = dr["SenderName"].ToString(),
                            ReceiverName = dr["ReceiverName"].ToString(),
                            Message = dr["Message"].ToString()
                        };
                        messages.Add(msg);
                    }
                };
                return messages;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<string> ListOfOnlineUsers(string userName)
        {
            try
            {
                List<string> onlineUsers = null;
                SQLConnection();
                using (SqlCommand cmd = new SqlCommand("spListOfOnlineUsers", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", userName);

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    onlineUsers = new List<string>();
                    while (dr.Read())
                    {
                        onlineUsers.Add(dr["FirstName"].ToString());
                    }
                };
                return onlineUsers;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
