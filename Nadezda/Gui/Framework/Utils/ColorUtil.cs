
using Nadezda.Gui.Framework.Lib;

namespace Nadezda.Gui.Framework.Utils;

public class ColorUtil
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