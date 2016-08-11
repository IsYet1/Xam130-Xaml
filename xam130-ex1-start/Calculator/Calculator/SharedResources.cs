using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public static class SharedResources
    {
        public static Color OpButtonBkColor
        {
            get
            {
                var color = Color.Navy;
                color = Color.FromRgb(0xff, 0xa5, 0);
                return color;
            }
        }

        public static Color NumberButtonBkColor {
            get
            {
                var color = Color.Yellow;
                //color = Color.White;
                return color;
            }
        }
        public static Color NumberButtonTextColor
        {
            get
            {
                var color = Color.Purple;
                //color = Color.Black;
                return color;
            }
        }
        public static double NumberButtonFontSize
        {
            get
            {
                var fontSize = 60;
                //fontSize = 36;
                return fontSize;
            }
        }
        public static int ButtonBorderRadius
        {
            get
            {
                var borderRadius = 50;
                //borderRadius = 0;
                return borderRadius;
            }
        }
    }
}
