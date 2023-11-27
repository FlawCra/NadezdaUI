using NadezdaUI.Gui.Framework.Lib;

namespace NadezdaUI.Gui.Framework.Utils;

/// <summary>
/// This class provides utility methods for working with colors.
/// </summary>
public class ColorUtil
{

    /// <summary>
    /// Lerps between two colors based on a given value.
    /// </summary>
    /// <param name="a">The starting color.</param>
    /// <param name="b">The ending color.</param>
    /// <param name="t">The interpolation value between 0 and 1.</param>
    /// <returns>The interpolated color value.</returns>
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