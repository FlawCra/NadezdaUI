using Nadezda.Gui.Framework.Units;
using Nadezda.Gui.Framework.Utils;
using Raylib_cs;

namespace Nadezda.Gui.Framework.Lib; 

public class Drawlib {
    public static void DrawRectangleRounded(Rectangle rec, float roundness, int segments, Color color) {
        Raylib.DrawRectangleRounded(rec.ToRaylib(), roundness, segments, color.ToRaylib());
    }

    public static void DrawRectangleRoundedLines(Rectangle rec, float roundness, int segments, float lineThick, Color color) {
        Raylib.DrawRectangleRoundedLines(rec.ToRaylib(), roundness, segments, lineThick, color.ToRaylib());
    }

    public static void DrawText(string text, int posX, int posY, FontSize fontSize, Color color) {
        Raylib.DrawText(text, posX, posY, fontSize.Value, color.ToRaylib());
    }

    public static void DrawRectangle(int posX, int posY, int width, int height, Color color) {
        Raylib.DrawRectangle(posX, posY, width, height, color.ToRaylib());
    }

    public static void DrawRectangleLines(int posX, int posY, int width, int height, Color color) {
        Raylib.DrawRectangleLines(posX, posY, width, height, color.ToRaylib());
    }
}