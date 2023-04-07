using Raylib_cs;

namespace Nadezda.Gui.Framework.Lib; 

public class Windowlib {
    public static void SetConfigFlags(ConfigFlags cf) {
        Raylib.SetConfigFlags(cf.ToRaylib());
    }

    public static void InitWindow(int width, int height, string title) {
        Raylib.InitWindow(width, height, title);
    }
    
    public static CBool WindowShouldClose() {
        return Raylib.WindowShouldClose();
    }
    
    public static void CloseWindow() {
        Raylib.CloseWindow();
    }

    public static void SetWindowSize(int width, int height) {
        Raylib.SetWindowSize(width, height);
    }

    public static void BeginDrawing() {
        Raylib.BeginDrawing();
    }

    public static void ClearBackground(Color color) {
        Raylib.ClearBackground(color.ToRaylib());
    }

    public static void DrawFPS(int posX, int posY) {
        Raylib.DrawFPS(posX, posY);
    }

    public static void EndDrawing() {
        Raylib.EndDrawing();
    }
}