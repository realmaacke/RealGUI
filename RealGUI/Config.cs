using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealGUI.RealGUI
{
    public static class Config
    {
        public static string w_title = "Application";
        public static int w_width = 1336;
        public static int w_height = 960;




        // buttons
        public static Vector2 nav_btn_size = new Vector2(80, 60);
        public static int navOffset { get; } = 5;


        // Colors
        public static Color GreyHover = new Color(46, 46, 46);
        public static Color DefaultNavColor = Color.Gray;

        public static Color NavColor = Color.Black;
    }
}
