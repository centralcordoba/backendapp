using Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiAppPet.Privates
{
    public class ShoppingActions
    {
        public static List<Shopping> SearchProductBuys(List<Shopping> lstProducts)
        {
            List<Shopping> lstShopping = new List<Shopping>();

            foreach (var item in lstProducts)
            {
                ShoppingRepository repository = new ShoppingRepository();
                List<Shopping> lstBuys = new List<Shopping>();
                lstBuys = repository.GetShoppingByIdUserAndTrolley(item.Id_Trolley);


                if (repository.GetShoppingByIdUserAndTrolley(item.Id_Trolley).Count == 0)
                {
                    lstShopping.Add(item);
                }
            }
            return lstShopping;
        }
    }
}
