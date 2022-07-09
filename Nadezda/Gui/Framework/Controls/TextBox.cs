using Nadezda.Gui.Framework.Units;
using Nadezda.Gui.Framework.Utils;
using Raylib_cs;

namespace Nadezda.Gui.Framework.Controls
{
    public class TextBox : Control
    {

        public override Rectangle Rectangle { get; set; }
        public override List<Control> Controls { get; set; } = new List<Control>();
        private DeltaTime blinkDeltaTime;
        private DeltaTime deleteDeltaTime;
        private Color Color;
        private FontSize FontSize;
        private int MaxInputChars = 0;
        private bool MouseOnText = false;
        public string Text = "";


        public TextBox(Rectangle rec, int maxinputchars, Color col, FontSize fsize = FontSize.Medium)
        {
            Rectangle = rec;
            MaxInputChars = maxinputchars;
            Color = col;
            FontSize = fsize;
            blinkDeltaTime = DeltaTime.CreatePoint();
            deleteDeltaTime = DeltaTime.CreatePoint();
        }

        public override void Update()
        {
            MouseOnText = Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), Rectangle);

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
                    if (key != 259 && Text.Length < MaxInputChars)
                    {
                        Text += new Key(key).ToString();
                    }

                    key = Raylib.GetCharPressed();  // Check next character in the queue
                }

                if(!Raylib.IsKeyDown(KeyboardKey.KEY_BACKSPACE)) return;
                if(Text.Length <= 0 || deleteDeltaTime.GetDeltaTime().Milliseconds <= 50) return;
                
                Text = Text.Remove(Text.Length - 1, 1);
                deleteDeltaTime = DeltaTime.CreatePoint();
            }
            else Raylib.SetMouseCursor(MouseCursor.MOUSE_CURSOR_DEFAULT);
        }

        public override void Render()
        {
            Raylib.DrawRectangle((int)Rectangle.x, (int)Rectangle.y, (int)Rectangle.width, (int)Rectangle.height, ColorUtils.Lerp(Color, Color.BLACK, 0.25f));
            Raylib.DrawRectangle((int)Rectangle.x+2, (int)Rectangle.y+2, (int)Rectangle.width-4, (int)Rectangle.height-4, Color.WHITE);
            Raylib.DrawRectangleLines((int)Rectangle.x, (int)Rectangle.y, (int)Rectangle.width, (int)Rectangle.height, MouseOnText ? Color : Color.DARKGRAY);

            Raylib.DrawText(Text, (int)Rectangle.x + 2, (int)Rectangle.y + 2, (int)FontSize , Color.BLACK);

            if(!MouseOnText) return;
            if(Text.Length >= MaxInputChars) return;
            
            // Draw blinking underscore char
            if (blinkDeltaTime.GetDeltaTime().Milliseconds > 500)
            {
                Raylib.DrawText("_", (int)Rectangle.x + 2 + Raylib.MeasureText(Text, (int)FontSize), (int)Rectangle.y + 2, (int)FontSize, Color);
            } else if(blinkDeltaTime.GetDeltaTime().Milliseconds > 1000)
            {
                blinkDeltaTime = DeltaTime.CreatePoint();
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
