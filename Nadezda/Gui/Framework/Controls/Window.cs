using Nadezda.Gui.Framework.Lib;

namespace Nadezda.Gui.Framework.Controls;

public class Window : Control
{
    public string Title { get; private set; }

    public Color BackgroundColor { get; private set; }

    public override Rectangle Rectangle { get; set; }
    public override List<Control> Controls { get; set; } = new List<Control>();
    
    public Action<Window> OnClose;

    private bool _debug = false;

    protected Window(Color bg, Rectangle rectangle, string title = "NadezdaUI Window", bool debug = false)
    {
        Title = title;
        Rectangle = rectangle;
        BackgroundColor = bg;
        _debug = debug;
    }

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

    public void SetSize(Rectangle rec)
    {
        this.Rectangle = rec;
        Windowlib.SetWindowSize((int)rec.width, (int)rec.height);
    }
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

    public override void Update()
    {
        foreach (Control c in Controls)
        {
            c.Update();
        }
    }
}