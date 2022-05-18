using Nadezda.Gui.Framework.Utils;
using Raylib_cs;

namespace Nadezda.Gui.Framework.Controls
{
    public class TextBox : Control
    {

        public override Rectangle Rectangle { get; set; }
        public override List<Control> Controls { get; set; }
        private DeltaTime blinkDeltaTime;
        private DeltaTime deleteDeltaTime;
        private Color Color;
        private int FramesCounter = 0;
        private int MaxInputChars = 0;
        private bool MouseOnText = false;
        public string Text = "";

        public TextBox(Rectangle rec, int maxinputchars, Color col)
        {
            Rectangle = rec;
            MaxInputChars = maxinputchars;
            Color = col;
            blinkDeltaTime = DeltaTime.CreatePoint();
            deleteDeltaTime = DeltaTime.CreatePoint();
        }

        public override void Update()
        {
            if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), Rectangle)) MouseOnText = true;
            else MouseOnText = false;
            
            if (MouseOnText)
            {
                // Set the window's cursor to the I-Beam
                Raylib.SetMouseCursor(MouseCursor.MOUSE_CURSOR_IBEAM);

                // Get char pressed (unicode character) on the queue
                int key = Raylib.GetCharPressed();

                // Check if more characters have been pressed on the same frame
                while (key > 0)
                {
                    // NOTE: Only allow keys in range [32..125]
                    if (!(key == 259) && Text.Length < MaxInputChars)
                    {
                        Console.WriteLine(key);
                        Text += new Key(key).ToString();
                        Console.WriteLine(Text);
                    }

                    key = Raylib.GetCharPressed();  // Check next character in the queue
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_BACKSPACE))
                {
                    if(Text.Length > 0 && deleteDeltaTime.GetDeltaTime().Milliseconds > 50) {
                        Text = Text.Remove(Text.Length - 1, 1);
                        deleteDeltaTime = DeltaTime.CreatePoint();
                    }
                }
            }
            else Raylib.SetMouseCursor(MouseCursor.MOUSE_CURSOR_DEFAULT);
        }

        public override void Render()
        {
            Raylib.DrawRectangle((int)Rectangle.x, (int)Rectangle.y, (int)Rectangle.width, (int)Rectangle.height, ColorUtils.Lerp(Color, Color.BLACK, 0.25f));
            Raylib.DrawRectangle((int)Rectangle.x+2, (int)Rectangle.y+2, (int)Rectangle.width-4, (int)Rectangle.height-4, Color.WHITE);
            if (MouseOnText) Raylib.DrawRectangleLines((int)Rectangle.x, (int)Rectangle.y, (int)Rectangle.width, (int)Rectangle.height, Color.RED);
            else Raylib.DrawRectangleLines((int)Rectangle.x, (int)Rectangle.y, (int)Rectangle.width, (int)Rectangle.height, Color.DARKGRAY);

            Raylib.DrawText(Text, (int)Rectangle.x + 2, (int)Rectangle.y + 2, 20, Color.BLACK);
            
            if (MouseOnText)
            {
                if (Text.Length < MaxInputChars)
                {
                    // Draw blinking underscore char
                    if (blinkDeltaTime.GetDeltaTime().Milliseconds > 500)
                    {
                        Raylib.DrawText("_", (int)Rectangle.x + 2 + Raylib.MeasureText(Text, 20), (int)Rectangle.y + 2, 20, Color.MAROON);
                    } else if(blinkDeltaTime.GetDeltaTime().Milliseconds > 1000)
                    {
                        blinkDeltaTime = DeltaTime.CreatePoint();
                    }
                }
            }

        }
        
        private bool IsAnyKeyPressed()
        {
            bool keyPressed = false;
            int key = Raylib.GetKeyPressed();

            if ((key >= 32) && (key <= 126)) keyPressed = true;

            return keyPressed;
        }
        
        private string KeycodeToChar(int keyCode) 
        { 
            return ((char)keyCode).ToString();
        }
    }
}
