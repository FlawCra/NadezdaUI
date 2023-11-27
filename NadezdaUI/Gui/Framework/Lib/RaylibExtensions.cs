using Raylib_cs;

namespace NadezdaUI.Gui.Framework.Lib;

/// <summary>
/// Provides extension methods for converting colors, mouse buttons, mouse cursors, config flags, rectangles, and keyboard keys to Raylib types
/// .
/// </summary>
public static class RaylibExtensions {
    /// <summary>
    /// Converts a Color object to a Raylib_cs.Color object.
    /// </summary>
    /// <param name="color">The Color object to convert.</param>
    /// <returns>A Raylib_cs.Color object with the same RGBA values as the input Color object.</returns>
    public static Raylib_cs.Color ToRaylib(this Color color) {
        return new Raylib_cs.Color(color.r, color.g, color.b, color.a);
    }

    /// <summary>
    /// Converts a MouseButton enum value to the corresponding Raylib_cs.MouseButton enum value.
    /// </summary>
    /// <param name="mb">The MouseButton enum value to convert.</param>
    /// <returns>The corresponding Raylib_cs.MouseButton enum value.</returns>
    public static Raylib_cs.MouseButton ToRaylib(this MouseButton mb) {
        return (Raylib_cs.MouseButton)mb;
    }

    /// <summary>
    /// Converts a MouseCursor enum value to the equivalent Raylib MouseCursor enum value.
    /// </summary>
    /// <param name="mb">The MouseCursor enum value to be converted.</param>
    /// <returns>The equivalent Raylib MouseCursor enum value.</returns>
    public static Raylib_cs.MouseCursor ToRaylib(this MouseCursor mb) {
        return (Raylib_cs.MouseCursor)mb;
    }

    /// <summary>
    /// Converts a <see cref="ConfigFlags"/> enumeration value to a <see cref="Raylib_cs.ConfigFlags"/> value.
    /// </summary>
    /// <param name="cf">The <see cref="ConfigFlags"/> enumeration value to convert.</param>
    /// <returns>The converted <see cref="Raylib_cs.ConfigFlags"/> value.</returns>
    public static Raylib_cs.ConfigFlags ToRaylib(this ConfigFlags cf) {
        return (Raylib_cs.ConfigFlags)cf;
    }

    /// <summary>
    /// Extension method to convert a Rectangle object to a Raylib_cs.Rectangle object. </summary>
    /// <param name="rec">The Rectangle object to convert.</param>
    /// <returns>A Raylib_cs.Rectangle object representing the same dimensions as the original Rectangle.</returns>
    public static Raylib_cs.Rectangle ToRaylib(this Rectangle rec)
    {
        return new Raylib_cs.Rectangle(rec.x, rec.y, rec.width, rec.height);
    }

    /// <summary>
    /// Converts a custom KeyboardKey enum to Raylib's KeyboardKey enum.
    /// </summary>
    /// <param name="key">The custom KeyboardKey enum value to be converted.</param>
    /// <returns>The equivalent Raylib_cs.KeyboardKey enum value.</returns>
    public static Raylib_cs.KeyboardKey ToRaylib(this KeyboardKey key) {
        return (Raylib_cs.KeyboardKey)key;
    }
}