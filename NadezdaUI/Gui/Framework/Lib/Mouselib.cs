using Raylib_cs;
using System.Numerics;

namespace NadezdaUI.Gui.Framework.Lib;

/// <summary>
/// This class provides functions for interacting with the mouse.
/// </summary>
public class Mouselib {
    /// <summary>
    /// Checks if a mouse button is currently being pressed down.
    /// </summary>
    /// <param name="mb">The mouse button to check.</param>
    /// <returns>Returns true if the specified mouse button is being pressed down; otherwise, returns false.</returns>
    public static CBool IsMouseButtonDown(MouseButton mb) {
        return Raylib.IsMouseButtonDown(mb.ToRaylib());
    }

    /// <summary>
    /// Checks if the specified mouse button has been released.
    /// </summary>
    /// <param name="mb">The mouse button to check.</param>
    /// <returns>
    /// Returns a boolean value indicating whether the mouse button has been released or not.
    /// </returns>
    public static CBool IsMouseButtonReleased(MouseButton mb) {
        return Raylib.IsMouseButtonReleased(mb.ToRaylib());
    }

    /// <summary>
    /// Retrieves the current mouse position relative to the window.
    /// </summary>
    /// <returns>A Vector2 representing the mouse position.</returns>
    public static Vector2 GetMousePosition() {
        return Raylib.GetMousePosition();
    }

    /// <summary>
    /// Sets the mouse cursor to the specified <paramref name="cursor" />.
    /// </summary>
    /// <param name="cursor">The cursor type to set.</param>
    /// <remarks>
    /// This method converts the <paramref name="cursor" /> to the Raylib cursor type and sets it as the mouse cursor.
    /// </remarks>
    public static void SetMouseCursor(MouseCursor cursor) {
        Raylib.SetMouseCursor(cursor.ToRaylib());
    }
}