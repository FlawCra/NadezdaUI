using System.Runtime.CompilerServices;

namespace NadezdaUI.Gui.Framework.Lib;

/// <summary>
/// Represents a rectangle with coordinates (x, y) and dimensions (width, height).
/// </summary>
public struct Rectangle
{
    public float x;
    public float y;
    public float width;
    public float height;

    /// <summary>
    /// Initializes a new instance of the Rectangle class with the specified position and dimensions.
    /// </summary>
    /// <param name="x">The x-coordinate of the rectangle's top-left corner.</param>
    /// <param name="y">The y-coordinate of the rectangle's top-left corner.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    public Rectangle(float x, float y, float width, float height)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    /// <summary>
    /// Converts the current instance to its string representation.
    /// </summary>
    /// <returns>
    /// A string that represents the current instance.
    /// </returns>
    public override string ToString()
    {
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 4);
        interpolatedStringHandler.AppendLiteral("{X:");
        interpolatedStringHandler.AppendFormatted(this.x);
        interpolatedStringHandler.AppendLiteral(" Y:");
        interpolatedStringHandler.AppendFormatted(this.y);
        interpolatedStringHandler.AppendLiteral(" Width:");
        interpolatedStringHandler.AppendFormatted(this.width);
        interpolatedStringHandler.AppendLiteral(" Height:");
        interpolatedStringHandler.AppendFormatted(this.height);
        interpolatedStringHandler.AppendLiteral("}");
        return interpolatedStringHandler.ToStringAndClear();
    }
}