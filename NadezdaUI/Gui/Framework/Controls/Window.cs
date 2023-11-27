using NadezdaUI.Gui.Framework.Lib;

namespace NadezdaUI.Gui.Framework.Controls;

/// <summary>
/// Represents a Window control that can be displayed on a screen.
/// </summary>
public class Window : Control
{
    public string Title { get; private set; }

    public Color BackgroundColor { get; private set; }

    public override Rectangle Rectangle { get; set; }
    public override List<Control> Controls { get; set; } = new List<Control>();
    
    public Action<Window> OnClose;

    private bool _debug = false;

    /// <summary>
    /// Initializes a new instance of the Window class with the specified background
    /// color, rectangle, title, and debug mode.
    /// </summary>
    /// <param name="bg">The background color of the window.</param>
    /// <param name="rectangle">The dimensions of the window.</param>
    /// <param name="title">The title of the window. Default value is "NadezdaUI Window".</param>
    /// <param name="debug">Indicates whether the window is in debug mode. Default value is false.</param>
    protected Window(Color bg, Rectangle rectangle, string title = "NadezdaUI Window", bool debug = false)
    {
        Title = title;
        Rectangle = rectangle;
        BackgroundColor = bg;
        _debug = debug;
    }

    /// <summary>
    /// Shows the window and runs the game loop until the window is closed.
    /// </summary>
    public void Show()
    {
        Windowlib.SetConfigFlags(ConfigFlags.FLAG_WINDOW_RESIZABLE);
        Windowlib.InitWindow((int)Rectangle.width, (int)Rectangle.height, Title);

        while (!Windowlib.WindowShouldClose())
        {
            Update();
            Render();
        }

        if(OnClose != null)
        {
            OnClose(this);
        }
        Windowlib.CloseWindow();
    }

    /// <summary>
    /// Sets the size of the window based on the provided rectangle.
    /// </summary>
    /// <param name="rec">The rectangle representing the new window size.</param>
    public void SetSize(Rectangle rec)
    {
        this.Rectangle = rec;
        Windowlib.SetWindowSize((int)rec.width, (int)rec.height);
    }
    /// <summary>
    /// Renders the window and its controls.
    /// </summary>
    public override void Render()
    {
        Windowlib.BeginDrawing();
        Windowlib.ClearBackground(BackgroundColor);

        foreach (Control c in Controls)
        {
            c.Render();
        }

        if(_debug)
        {
            Windowlib.DrawFPS(0, 0);
        }

        Windowlib.EndDrawing();
    }

    /// <summary>
    /// Updates all controls in the container recursively.
    /// </summary>
    public override void Update()
    {
        foreach (Control c in Controls)
        {
            c.Update();
        }
    }
}