using Nadezda.Gui.Framework.Units;
using Raylib_cs;
using System.Numerics;

namespace Nadezda.Gui.Framework.Lib; 

public class Fontlib {
    public static int MeasureText(string text, FontSize fontSize) {
        return Raylib.MeasureText(text, fontSize.Value);
    }
    
    public static Vector2 MeasureTextEx(Font font, string text, FontSize fontSize, float spacing) {
        return Raylib.MeasureTextEx(font, text, fontSize.Value, spacing);
    }

    public static Font GetFontDefault() {
        return Raylib.GetFontDefault();
    }
}