using Raylib_cs;
using System.Numerics;

namespace NadezdaUI.Gui.Framework.Lib;

/// <summary>
/// A utility class for geometric calculations.
/// </summary>
public class Geolib {
    /// <summary>
    /// Checks if a point collides with a rectangle.
    /// </summary>
    /// <param name="point">The point to check.</param>
    /// <param name="rec">The rectangle to check.</param>
    /// <returns>True if there is a collision, false otherwise.</returns>
    public static CBool CheckCollisionPointRec(Vector2 point, Rectangle rec) {
        return Raylib.CheckCollisionPointRec(point, rec.ToRaylib());
    }
}