using Raylib_cs;
using System.Numerics;

namespace Nadezda.Gui.Framework.Lib; 

public class Geolib {
    public static CBool CheckCollisionPointRec(Vector2 point, Rectangle rec) {
        return Raylib.CheckCollisionPointRec(point, rec.ToRaylib());
    }
}