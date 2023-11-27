namespace NadezdaUI.Gui.Framework.Lib;

/// <summary>
/// Configuration flags for the program.
/// </summary>
[Flags]
public enum ConfigFlags : uint
{
    /// <summary>Set to try enabling V-Sync on GPU</summary>
    FLAG_VSYNC_HINT = 64, // 0x00000040
    /// <summary>Set to run program in fullscreen</summary>
    FLAG_FULLSCREEN_MODE = 2,
    /// <summary>Set to allow resizable window</summary>
    FLAG_WINDOW_RESIZABLE = 4,
    /// <summary>Set to disable window decoration (frame and buttons)</summary>
    FLAG_WINDOW_UNDECORATED = 8,
    /// <summary>Set to hide window</summary>
    FLAG_WINDOW_HIDDEN = 128, // 0x00000080
    /// <summary>Set to minimize window (iconify)</summary>
    FLAG_WINDOW_MINIMIZED = 512, // 0x00000200
    /// <summary>Set to maximize window (expanded to monitor)</summary>
    FLAG_WINDOW_MAXIMIZED = 1024, // 0x00000400
    /// <summary>Set to window non focused</summary>
    FLAG_WINDOW_UNFOCUSED = 2048, // 0x00000800
    /// <summary>Set to window always on top</summary>
    FLAG_WINDOW_TOPMOST = 4096, // 0x00001000
    /// <summary>Set to allow windows running while minimized</summary>
    FLAG_WINDOW_ALWAYS_RUN = 256, // 0x00000100
    /// <summary>Set to allow transparent framebuffer</summary>
    FLAG_WINDOW_TRANSPARENT = 16, // 0x00000010
    /// <summary>Set to support HighDPI</summary>
    FLAG_WINDOW_HIGHDPI = 8192, // 0x00002000
    /// <summary>
    /// Set to support mouse passthrough, only supported when FLAG_WINDOW_UNDECORATED
    /// </summary>
    FLAG_WINDOW_MOUSE_PASSTHROUGH = 16384, // 0x00004000
    /// <summary>Set to try enabling MSAA 4X</summary>
    FLAG_MSAA_4X_HINT = 32, // 0x00000020
    /// <summary>Set to try enabling interlaced video format (for V3D)</summary>
    FLAG_INTERLACED_HINT = 65536, // 0x00010000
}