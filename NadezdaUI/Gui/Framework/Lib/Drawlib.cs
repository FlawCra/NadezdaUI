using NadezdaUI.Gui.Framework.Utils;
using NadezdaUI.Gui.Framework.Units;
using Raylib_cs;

namespace NadezdaUI.Gui.Framework.Lib;

/// <summary>
/// Provides utility methods for drawing shapes and text using Raylib.
/// </summary>
public class Drawlib {
    /// Draws a rounded rectangle on the screen with the given parameters. </summary> <param name="rec">The rectangle to be drawn.</param>
    /// <param name="roundness">The roundness factor of the corners. The higher the value, the more rounded the corners.</param>
    /// <param name="segments">The number of segments to be used for drawing the rounded corners.</param>
    /// <param name="color">The color of the rounded rectangle.</param>
    /// <returns>None</returns>
    public static void DrawRectangleRounded(Rectangle rec, float roundness, int segments, Color color) {
        Raylib.DrawRectangleRounded(rec.ToRaylib(), roundness, segments, color.ToRaylib());
    }

    /// <summary>
    /// Draws a rectangle with rounded edges using line segments.
    /// </summary>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="roundness">The roundness or curvature of the edges.</param>
    /// <param name="segments">The number of line segments used to create the rounded edges.</param>
    /// <param name="lineThick">The thickness of the lines used to draw.</param>
    /// <param name="color">The color of the lines.</param>
    public static void DrawRectangleRoundedLines(Rectangle rec, float roundness, int segments, float lineThick, Color color) {
        Raylib.DrawRectangleRoundedLines(rec.ToRaylib(), roundness, segments, lineThick, color.ToRaylib());
    }

    /// <summary>
    /// Draws text on the screen at the specified position with the specified font size
    /// and color.
    /// </summary>
    /// <param name="text">The text to be drawn.</param>
    /// <param name="posX">The X-coordinate of the position where the text should be drawn.</param>
    /// <param name="posY">The Y-coordinate of the position where the text should be drawn.</param>
    /// <param name="fontSize">The font size of the text.</param>
    /// <param name="color">The color of the text.</param>
    public static void DrawText(string text, int posX, int posY, FontSize fontSize, Color color) {
        Raylib.DrawText(text, posX, posY, fontSize.Value, color.ToRaylib());
    }

    /// <summary>
    /// Draw a rectangle on the screen with specified position, size, and color.
    /// </summary>
    /// <param name="posX">The X position of the top-left corner of the rectangle.</param>
    /// <param name="posY">The Y position of the top-left corner of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color">The color of the rectangle.</param>
    public static void DrawRectangle(int posX, int posY, int width, int height, Color color) {
        Raylib.DrawRectangle(posX, posY, width, height, color.ToRaylib());
    }

    /// <summary>
    /// Draws the outline of a rectangle on the screen.
    /// </summary>
    /// <param name="posX">The x-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="posY">The y-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color">The color of the rectangle's outline.</param>
    public static void DrawRectangleLines(int posX, int posY, int width, int height, Color color) {
        Raylib.DrawRectangleLines(posX, posY, width, height, color.ToRaylib());
    }
}