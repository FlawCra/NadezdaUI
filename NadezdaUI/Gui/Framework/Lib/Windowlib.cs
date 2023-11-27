using Raylib_cs;

namespace NadezdaUI.Gui.Framework.Lib; 

public class Windowlib {
    /// <summary>
    /// Sets the configuration flags for Raylib.
    /// </summary>
    /// <param name="cf">The configuration flags to be set.</param>
    public static void SetConfigFlags(ConfigFlags cf) {
        Raylib.SetConfigFlags(cf.ToRaylib());
    }

    /// <summary>
    /// Initializes the window with the specified width, height, and title.
    /// </summary>
    /// <param name="width">The width of the window.</param>
    /// <param name="height">The height of the window.</param>
    /// <param name="title">The title of the window.</param>
    public static void InitWindow(int width, int height, string title) {
        Raylib.InitWindow(width, height, title);
    }

    /// <summary>
    /// Determines whether the application window should close.
    /// </summary>
    /// <returns>
    /// <c>true</c> if the window should close; otherwise, <c>false</c>.
    /// </returns>
    public static CBool WindowShouldClose() {
        return Raylib.WindowShouldClose();
    }

    /// <summary>
    /// Closes the current window.
    /// </summary>
    public static void CloseWindow() {
        Raylib.CloseWindow();
    }

    /// <summary>
    /// Sets the size of the game window.
    /// </summary>
    /// <param name="width">The desired width of the window.</param>
    /// <param name="height">The desired height of the window.</param>
    public static void SetWindowSize(int width, int height) {
        Raylib.SetWindowSize(width, height);
    }

    /// <summary>
    /// Begins the drawing process.
    /// </summary>
    public static void BeginDrawing() {
        Raylib.BeginDrawing();
    }

    /// <summary>
    /// Clears the background of the current rendering target with the specified color.
    /// </summary>
    /// <param name="color">The color to clear the background with.</param>
    public static void ClearBackground(Color color) {
        Raylib.ClearBackground(color.ToRaylib());
    }

    /// <summary>
    /// Draws the frames per second (FPS) counter at the specified position.
    /// </summary>
    /// <param name="posX">The x-coordinate of the position where the FPS counter should be drawn.</param>
    /// <param name="posY">The y-coordinate of the position where the FPS counter should be drawn.</param>
    public static void DrawFPS(int posX, int posY) {
        Raylib.DrawFPS(posX, posY);
    }

    /// <summary>
    /// Ends the current drawing frame, presenting the content on the screen.
    /// This method needs to be called once you finish rendering all the elements for the current frame.
    /// </summary>
    public static void EndDrawing() {
        Raylib.EndDrawing();
    }
}