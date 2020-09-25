using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Entities;

namespace Repository
{
    public class UsersRepository
    {
        string conn = "Data Source=DESKTOP-S1UKRBH\\SQLEXPRESS;Initial Catalog=RAM;Integrated Security=True";

        //555dssdffddddsssddd
        public List<Users> GetUsuarios()
        {
            List<Users> lstusers = new List<Users>();

            using (SqlConnection db = new SqlConnection(conn))
            {
                try
                {
                    db.Open();
                    string readSp = "GetAllUsers";
                    return db.Query<Users>(readSp, commandType: CommandType.StoredProcedure).AsList();
                }
                catch (Exception ex)
                {
                    string test = ex.ToString();
                    throw;
                }

            }

        }

        public Users PostUsersLogin(Users user)
        {
            Users userObject = new Users();
            using (SqlConnection db = new SqlConnection(conn))
            {                
                try
                {
                    db.Open();                    
                    string readSp = "PostUsersLogin";
                    var userlogin =  db.Query<Users>(readSp, commandType: CommandType.StoredProcedure);
                    if (userlogin!= null)
                    {
                        userObject = userlogin.FirstOrDefault();
                    }
                    
                }
                catch (Exception ex)
                {

                    throw;
                }
                return userObject;
            }

        }
    }
}
