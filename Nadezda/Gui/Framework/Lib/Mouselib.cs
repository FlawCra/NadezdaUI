using Raylib_cs;
using System.Numerics;

namespace Nadezda.Gui.Framework.Lib; 

public class Mouselib {
    public static CBool IsMouseButtonDown(MouseButton mb) {
        return Raylib.IsMouseButtonDown(mb.ToRaylib());
    }

    public static CBool IsMouseButtonReleased(MouseButton mb) {
        return Raylib.IsMouseButtonReleased(mb.ToRaylib());
    }

    public static Vector2 GetMousePosition() {
        return Raylib.GetMousePosition();
    }

    public static void SetMouseCursor(MouseCursor cursor) {
        Raylib.SetMouseCursor(cursor.ToRaylib());
    }
}