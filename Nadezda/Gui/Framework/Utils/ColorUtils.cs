using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nadezda.Gui.Framework.Units;

namespace Nadezda.Gui.Framework.Utils
{

    public class ColorUtils
    {

        public static Color Lerp(Color a, Color b, float t)
        {
            return new Color(
                (int)Math.Round(a.r + (b.r - a.r) * t),
                (int)Math.Round(a.g + (b.g - a.g) * t),
                (int)Math.Round(a.b + (b.b - a.b) * t),
                (int)Math.Round(a.a + (b.a - a.a) * t)
            );
        }

    }

}