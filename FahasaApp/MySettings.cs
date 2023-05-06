using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahasaApp
{
    public class MySettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        public ShoppingCart shoppingCart
        {
            get { return (ShoppingCart)this["shoppingCart"]; }
            set { this["shoppingCart"] = value; }
        }

    }


}
