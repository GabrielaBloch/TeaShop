using Microsoft.AspNetCore.Mvc.Rendering;

namespace TeaShop.Helper
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Client = "Klient";


        public static List<SelectListItem> GetRolesForDropDown()
        {
            return new List<SelectListItem>
                {
                    new SelectListItem{Value=Helper.Admin,Text=Helper.Admin},
                    new SelectListItem{Value=Helper.Client,Text=Helper.Client}
                };
        }

    }
}
