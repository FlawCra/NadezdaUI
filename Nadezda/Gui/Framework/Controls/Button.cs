using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nadezda.Gui.Framework.Utils;
using Nadezda.Gui.Framework.Units;

namespace Nadezda.Gui.Framework.Controls
{
    public class Button : Control
    {
        public override Rectangle Rectangle { get; set; }

        public override List<Control> Controls { get; set; }

        public string Text;

        public FontSize FontSize;

        private Color Color;

        public Action<Button> OnClick;

        public Button(Rectangle rec, string text, Color col, FontSize fsize = FontSize.Medium)
        {
            Rectangle = rec;
            Text = text;
            Color = col;
            FontSize = fsize;
        }

        public override async void Render()
        {
            Raylib.DrawRectangleRounded(Rectangle, 5, 32, Color);
            if(IsHovering() && Raylib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_LEFT))
            {
                Raylib.DrawRectangleRoundedLines(Rectangle, 5, 32, 5, ColorUtils.Lerp(Color, Color.BLACK, 0.25f));
            } else if(IsHovering())
            {
                Raylib.DrawRectangleRoundedLines(Rectangle, 5, 32, 5, ColorUtils.Lerp(Color, Color.BLACK, 0.75f));
            }
            Raylib.DrawText(Text, (int)Rectangle.x + (int)(Rectangle.width / 2 - Raylib.MeasureTextEx(Raylib.GetFontDefault(), Text, (int)FontSize, 1).X / 2), (int)Rectangle.y + (int)(Rectangle.height / 2 - Raylib.MeasureTextEx(Raylib.GetFontDefault(), Text, (int)FontSize, 1).Y / 2), (int)FontSize, ColorUtils.Lerp(Color, Color.WHITE, 0.75f));
        }

        public override void Update()
        {
            if(IsHovering())
            {
                if(Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    if (OnClick != null)
                    {
                        OnClick(this);
                    }
                }
            }
        }

        public bool IsHovering()
        {
            Rectangle mousePos = new Rectangle(Raylib.GetMousePosition().X, Raylib.GetMousePosition().Y,0,0);           // Get the position of the mouse
            if (mousePos.x >= Rectangle.x && mousePos.x <= (Rectangle.x + Rectangle.width))
            {
                if (mousePos.y >= Rectangle.y && mousePos.y <= Rectangle.y + Rectangle.height)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
