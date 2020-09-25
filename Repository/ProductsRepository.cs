using Dapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Repository
{
    public class ProductsRepository
    {
        string conn = "Data Source=DESKTOP-S1UKRBH\\SQLEXPRESS;Initial Catalog=RAM;Integrated Security=True";

        

        public List<Products> GetAllProductsPendent()
        {            
            using (SqlConnection db = new SqlConnection(conn))
            {
                try
                {
                    db.Open();                    
                    return db.Query<Products>("GetAllProducts", commandType: CommandType.StoredProcedure).AsList();
                }
                catch (Exception ex)
                {
                    string test = ex.ToString();
                    throw;
                }

            }
        }

        public string AddProducts(Products dataProduct)
        {
            string codOperation = string.Empty;

            using (SqlConnection db = new SqlConnection(conn))
            {
                try
                {
                    db.Open();
                    var parameters = new DynamicParameters();

                    parameters.Add("@Id_Detail_Product", dataProduct.Id_Category_Products);
                    parameters.Add("@Id_Product",dataProduct.Id_Product);
                    parameters.Add("@Id_Category_Products",dataProduct.Id_Category_Products);
                    parameters.Add("@Amount",dataProduct.Price_Buy);
                    parameters.Add("@Id_User","testUser");
                    db.Execute("SaveBuys", parameters, commandType: CommandType.StoredProcedure);
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
