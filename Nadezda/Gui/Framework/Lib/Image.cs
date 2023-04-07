namespace Nadezda.Gui.Framework.Lib; 

public struct Image
{
    /// <summary>Image raw data</summary>
    public unsafe void* data;
    /// <summary>Image base width</summary>
    public int width;
    /// <summary>Image base height</summary>
    public int height;
    /// <summary>Mipmap levels, 1 by default</summary>
    public int mipmaps;
    /// <summary>Data format (PixelFormat type)</summary>
    public PixelFormat format;
}