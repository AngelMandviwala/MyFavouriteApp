using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavouriteMobileApp
{
    public class UserProfile
    {
        public string Name { get; set; }

        public string Icon { get; set; }

        public UserProfile(string name)//string icon
        {
            Name = name;
            //Icon = icon;
        }


    }
}
