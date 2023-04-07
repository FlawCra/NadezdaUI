namespace Nadezda.Gui.Framework.Lib; 

public enum PixelFormat
{
    /// <summary>8 bit per pixel (no alpha)</summary>
    PIXELFORMAT_UNCOMPRESSED_GRAYSCALE = 1,
    /// <summary>8*2 bpp (2 channels)</summary>
    PIXELFORMAT_UNCOMPRESSED_GRAY_ALPHA = 2,
    /// <summary>16 bpp</summary>
    PIXELFORMAT_UNCOMPRESSED_R5G6B5 = 3,
    /// <summary>24 bpp</summary>
    PIXELFORMAT_UNCOMPRESSED_R8G8B8 = 4,
    /// <summary>16 bpp (1 bit alpha)</summary>
    PIXELFORMAT_UNCOMPRESSED_R5G5B5A1 = 5,
    /// <summary>16 bpp (4 bit alpha)</summary>
    PIXELFORMAT_UNCOMPRESSED_R4G4B4A4 = 6,
    /// <summary>32 bpp</summary>
    PIXELFORMAT_UNCOMPRESSED_R8G8B8A8 = 7,
    /// <summary>32 bpp (1 channel - float)</summary>
    PIXELFORMAT_UNCOMPRESSED_R32 = 8,
    /// <summary>32*3 bpp (3 channels - float)</summary>
    PIXELFORMAT_UNCOMPRESSED_R32G32B32 = 9,
    /// <summary>32*4 bpp (4 channels - float)</summary>
    PIXELFORMAT_UNCOMPRESSED_R32G32B32A32 = 10, // 0x0000000A
    /// <summary>4 bpp (no alpha)</summary>
    PIXELFORMAT_COMPRESSED_DXT1_RGB = 11, // 0x0000000B
    /// <summary>4 bpp (1 bit alpha)</summary>
    PIXELFORMAT_COMPRESSED_DXT1_RGBA = 12, // 0x0000000C
    /// <summary>8 bpp</summary>
    PIXELFORMAT_COMPRESSED_DXT3_RGBA = 13, // 0x0000000D
    /// <summary>8 bpp</summary>
    PIXELFORMAT_COMPRESSED_DXT5_RGBA = 14, // 0x0000000E
    /// <summary>4 bpp</summary>
    PIXELFORMAT_COMPRESSED_ETC1_RGB = 15, // 0x0000000F
    /// <summary>4 bpp</summary>
    PIXELFORMAT_COMPRESSED_ETC2_RGB = 16, // 0x00000010
    /// <summary>8 bpp</summary>
    PIXELFORMAT_COMPRESSED_ETC2_EAC_RGBA = 17, // 0x00000011
    /// <summary>4 bpp</summary>
    PIXELFORMAT_COMPRESSED_PVRT_RGB = 18, // 0x00000012
    /// <summary>4 bpp</summary>
    PIXELFORMAT_COMPRESSED_PVRT_RGBA = 19, // 0x00000013
    /// <summary>8 bpp</summary>
    PIXELFORMAT_COMPRESSED_ASTC_4x4_RGBA = 20, // 0x00000014
    /// <summary>2 bpp</summary>
    PIXELFORMAT_COMPRESSED_ASTC_8x8_RGBA = 21, // 0x00000015
}