using Nadezda.Gui.Framework.Lib;
using Nadezda.Gui.Framework.Units;
using Nadezda.Gui.Framework.Utils;

namespace Nadezda.Gui.Framework.Controls;

public class TextBox : Control
{

    public override Rectangle Rectangle { get; set; }
    public override List<Control> Controls { get; set; } = new List<Control>();
    private DeltaTime _blinkDeltaTime;
    private DeltaTime _deleteDeltaTime;
    private Color _color;
    private FontSize FontSize;
    private int MaxInputChars = 0;
    private bool MouseOnText = false;
    public string Text = "";
    private string RenderedText = "";


    public TextBox(Rectangle rec, int maxinputchars, Color col, FontSize? fsize = null)
    {
        Rectangle = rec;
        MaxInputChars = maxinputchars;
        _color = col;
        FontSize = fsize ?? FontSize.Medium;
        _blinkDeltaTime = DeltaTime.CreatePoint();
        _deleteDeltaTime = DeltaTime.CreatePoint();
    }

    public override void Update()
    {
        MouseOnText = Geolib.CheckCollisionPointRec(Mouselib.GetMousePosition(), Rectangle);

        if(MouseOnText)
        {
            // Set the window's cursor to the I-Beam
            Mouselib.SetMouseCursor(MouseCursor.MOUSE_CURSOR_IBEAM);

            // Get char pressed (unicode character) on the queue
            int key = Keyboardlib.GetCharPressed();

            // Check if more characters have been pressed on the same frame
            while (key > 0)
            {
                // NOTE: Only allow keys in range [32..125]
                if(key != 259 && Text.Length < MaxInputChars)
                {
                    Text += new Key(key).ToString();
                }

                key = Keyboardlib.GetCharPressed(); // Check next character in the queue
            }

            if(!Keyboardlib.IsKeyDown(KeyboardKey.KEY_BACKSPACE)) return;
            if(Text.Length <= 0 || _deleteDeltaTime.GetDeltaTime().Milliseconds <= 50) return;

            Text = Text.Remove(Text.Length - 1, 1);
            _deleteDeltaTime = DeltaTime.CreatePoint();
        } else Mouselib.SetMouseCursor(MouseCursor.MOUSE_CURSOR_DEFAULT);
    }

    public override void Render()
    {
        Drawlib.DrawRectangle((int)Rectangle.x, (int)Rectangle.y, (int)Rectangle.width, (int)Rectangle.height, ColorUtil.Lerp(_color, Color.BLACK, 0.25f));
        Drawlib.DrawRectangle((int)Rectangle.x + 2, (int)Rectangle.y + 2, (int)Rectangle.width - 4, (int)Rectangle.height - 4, Color.WHITE);
        Drawlib.DrawRectangleLines((int)Rectangle.x, (int)Rectangle.y, (int)Rectangle.width, (int)Rectangle.height, MouseOnText ? _color : Color.DARKGRAY);

        Drawlib.DrawText(Text, (int)Rectangle.x + 2, (int)Rectangle.y + 2, FontSize, Color.BLACK);

        if(!MouseOnText) return;
        if(Text.Length >= MaxInputChars) return;

        // Draw blinking underscore char
        if(_blinkDeltaTime.GetDeltaTime().Milliseconds > 500)
        {
            Drawlib.DrawText("_", (int)Rectangle.x + 2 + Fontlib.MeasureText(Text, FontSize), (int)Rectangle.y + 2, FontSize, _color);
        } else if(_blinkDeltaTime.GetDeltaTime().Milliseconds > 1000)
        {
            _blinkDeltaTime = DeltaTime.CreatePoint();
        }

    }

    private bool IsAnyKeyPressed()
    {
        bool keyPressed = false;
        int key = Keyboardlib.GetKeyPressed();

        if((key >= 32) && (key <= 126)) keyPressed = true;

        return keyPressed;
    }

    private string KeycodeToChar(int keyCode)
    {
        return ((char)keyCode).ToString();
    }
}