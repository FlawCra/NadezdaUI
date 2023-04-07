using System.Runtime.CompilerServices;

namespace Nadezda.Gui.Framework.Lib; 

public struct Rectangle
{
    public float x;
    public float y;
    public float width;
    public float height;

    public Rectangle(float x, float y, float width, float height)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    public override string ToString()
    {
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 4);
        interpolatedStringHandler.AppendLiteral("{X:");
        interpolatedStringHandler.AppendFormatted<float>(this.x);
        interpolatedStringHandler.AppendLiteral(" Y:");
        interpolatedStringHandler.AppendFormatted<float>(this.y);
        interpolatedStringHandler.AppendLiteral(" Width:");
        interpolatedStringHandler.AppendFormatted<float>(this.width);
        interpolatedStringHandler.AppendLiteral(" Height:");
        interpolatedStringHandler.AppendFormatted<float>(this.height);
        interpolatedStringHandler.AppendLiteral("}");
        return interpolatedStringHandler.ToStringAndClear();
    }
}