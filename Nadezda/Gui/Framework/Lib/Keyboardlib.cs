using Raylib_cs;

namespace Nadezda.Gui.Framework.Lib; 

public class Keyboardlib {
    public static CBool IsKeyDown(KeyboardKey key) {
        return Raylib.IsKeyDown(key.ToRaylib());
    }

    public static int GetCharPressed() {
        return Raylib.GetCharPressed();
    }

    public static int GetKeyPressed() {
        return Raylib.GetKeyPressed();
    }
}