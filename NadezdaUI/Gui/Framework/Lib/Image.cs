namespace NadezdaUI.Gui.Framework.Lib;

/// <summary>
/// Represents an image with raw data, width, height, mipmap levels, and data format.
/// </summary>
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