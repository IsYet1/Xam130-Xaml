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
    }
}
