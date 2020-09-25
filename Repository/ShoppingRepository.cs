using Dapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Repository
{
    
    public class ShoppingRepository
    {
        string conn = "Data Source=DESKTOP-S1UKRBH\\SQLEXPRESS;Initial Catalog=RAM;Integrated Security=True";


        public List<Shopping> GetShoppingByIdUserAndTrolley(int Id_Troller)
        {
            using (SqlConnection db = new SqlConnection(conn))
            {
                try
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id_Trolley", Id_Troller);
                    db.Open();
                    return db.Query<Shopping>("GetShoppinByUserByTrolley", parameters, commandType: CommandType.StoredProcedure).AsList();
                }
                catch (Exception ex)
                {
                    string test = ex.ToString();
                    throw;
                }

            }
        }


        public List<Shopping> GetShoppingByIdUser(string id)
        {
            using (SqlConnection db = new SqlConnection(conn))
            {
                try
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id_User", id);
                    db.Open();
                    return db.Query<Shopping>("GetShoppinByUser", parameters, commandType: CommandType.StoredProcedure).AsList();
                }
                catch (Exception ex)
                {
                    string test = ex.ToString();
                    throw;
                }

            }
        }

        public string ShoppingPays(ShoppingPay shoppingPays)
        {
            string codOperation = string.Empty;
            using (SqlConnection db = new SqlConnection(conn))
            {
                try
                {                   
                        var parameters = new DynamicParameters();
                        parameters.Add("@Id_Trolley", shoppingPays.Id_Trolley);
                        parameters.Add("@Id_User", shoppingPays.Id_User);
                        parameters.Add("@Id_State", shoppingPays.Id_State);
                        parameters.Add("@Id_Method_Pay", shoppingPays.Id_Method_Pay);
                        parameters.Add("@AddressClient", shoppingPays.AddressClient);
                        parameters.Add("@Telephone", shoppingPays.Telephone);
                        parameters.Add("@Neighborhood", shoppingPays.Neighborhood);
                    db.Open();
                        db.Execute("SavePaysShopping", parameters, commandType: CommandType.StoredProcedure);
                    
                    return codOperation = "accept";
                }
                catch (Exception ex)
                {
                    codOperation = "cancel" + ex.ToString();
                    throw;
                }

            }
        }

        public string DeleteShoppingById(int id)
        {
            string codOperation = string.Empty;
            using (SqlConnection db = new SqlConnection(conn))
            {
                try
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id_Trolley", id);
                    db.Open();
                    db.Execute("UpdateTrolleyCancel", parameters, commandType: CommandType.StoredProcedure);
                    return codOperation = "accept";
                }
                catch (Exception ex)
                {
                    codOperation = "cancel" + ex.ToString();
                    throw;
                }

            }
        }
    }
}
