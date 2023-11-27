using Raylib_cs;

namespace NadezdaUI.Gui.Framework.Lib;

/// <summary>
/// Keyboardlib class provides convenient access to keyboard related functionality.
/// </summary>
public static class Keyboardlib {
    /// <summary>
    /// Checks if a specific keyboard key is currently being pressed down.
    /// </summary>
    /// <param name="key">The keyboard key to check.</param>
    /// <returns>A boolean value indicating whether the key is being pressed down.</returns>
    public static CBool IsKeyDown(KeyboardKey key) {
        return Raylib.IsKeyDown(key.ToRaylib());
    }

    /// <summary>
    /// Gets the ASCII value of the key being pressed on the keyboard.
    /// </summary>
    /// <returns>
    /// The ASCII value of the key being pressed. If no key is being pressed,
    /// 0 is returned.
    /// </returns>
    public static int GetCharPressed() {
        return Raylib.GetCharPressed();
    }

    /// <summary>
    /// Retrieves the key code for the most recently pressed key.
    /// </summary>
    /// <returns>The key code for the most recently pressed key.</returns>
    public static int GetKeyPressed() {
        return Raylib.GetKeyPressed();
    }
}