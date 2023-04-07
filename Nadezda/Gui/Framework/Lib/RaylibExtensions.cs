using Raylib_cs;

namespace Nadezda.Gui.Framework.Lib; 

public static class RaylibExtensions {
    public static Raylib_cs.Color ToRaylib(this Color color) {
        return new Raylib_cs.Color(color.r, color.g, color.b, color.a);
    }

    public static Raylib_cs.MouseButton ToRaylib(this MouseButton mb) {
        return (Raylib_cs.MouseButton)mb;
    }
    
    public static Raylib_cs.MouseCursor ToRaylib(this MouseCursor mb) {
        return (Raylib_cs.MouseCursor)mb;
    }
    
    public static Raylib_cs.ConfigFlags ToRaylib(this ConfigFlags cf) {
        return (Raylib_cs.ConfigFlags)cf;
    }
    
    public static Raylib_cs.Rectangle ToRaylib(this Rectangle rec) 
    {
        return new Raylib_cs.Rectangle(rec.x, rec.y, rec.width, rec.height);
    }
    
    public static Raylib_cs.KeyboardKey ToRaylib(this KeyboardKey key) {
        return (Raylib_cs.KeyboardKey)key;
    }
}