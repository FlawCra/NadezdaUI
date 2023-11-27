namespace NadezdaUI.Gui.Framework.Lib;

/// <summary>
/// Represents a 2D texture in OpenGL.
/// </summary>
public struct Texture2D
{
    /// <summary>OpenGL texture id</summary>
    public uint id;
    /// <summary>Texture base width</summary>
    public int width;
    /// <summary>Texture base height</summary>
    public int height;
    /// <summary>Mipmap levels, 1 by default</summary>
    public int mipmaps;
    /// <summary>Data format (PixelFormat type)</summary>
    public PixelFormat format;
}