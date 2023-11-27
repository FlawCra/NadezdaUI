using NadezdaUI.Gui.Framework.Units;
using Raylib_cs;
using System.Numerics;

namespace NadezdaUI.Gui.Framework.Lib;

/// <summary>
/// Provides methods for measuring text using fonts.
/// </summary>
public class Fontlib {
    /// <summary>
    /// Measures the width in pixels of a given text using a specific font size.
    /// </summary>
    /// <param name="text">The text to measure.</param>
    /// <param name="fontSize">The font size to use.</param>
    /// <returns>The width in pixels of the measured text.</returns>
    public static int MeasureText(string text, FontSize fontSize) {
        return Raylib.MeasureText(text, fontSize.Value);
    }

    /// <summary>
    /// Measures the size of a rendered text using the given font, text content, font size
    /// and spacing.
    /// </summary>
    /// <param name="font">The font used to render the text.</param>
    /// <param name="text">The content of the text to measure.</param>
    /// <param name="fontSize">The font size to apply to the text.</param>
    /// <param name="spacing">The additional spacing between characters.</param>
    /// <returns>The size of the rendered text in a Vector2 object.</returns>
    public static Vector2 MeasureTextEx(Font font, string text, FontSize fontSize, float spacing) {
        return Raylib.MeasureTextEx(font, text, fontSize.Value, spacing);
    }

    /// <summary>
    /// Retrieves the default font used by Raylib.
    /// </summary>
    /// <returns>The default font instance.</returns>
    public static Font GetFontDefault() {
        return Raylib.GetFontDefault();
    }
}