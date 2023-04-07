using Nadezda.Gui.Framework.Lib;
using Nadezda.Gui.Framework.Utils;
using Nadezda.Gui.Framework.Units;
using System.Numerics;

namespace Nadezda.Gui.Framework.Controls;

public class Button : Control
{
    public override Rectangle Rectangle { get; set; }

    public override List<Control> Controls { get; set; } = new List<Control>();

    public string Text;

    public FontSize FontSize;

    private Color Color;

    public Action<Button> OnClick;

    public Button(Rectangle rec, string text, Color col, FontSize? fsize = null)
    {
        Rectangle = rec;
        Text = text;
        Color = col;
        FontSize = fsize ?? FontSize.Medium;
    }

    public override void Render()
    {
        Drawlib.DrawRectangleRounded(Rectangle, 5, 32, Color);
        if(IsHovering() && Mouselib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_LEFT))
        {
            Drawlib.DrawRectangleRoundedLines(Rectangle, 5, 32, 5, ColorUtil.Lerp(Color, Color.BLACK, 0.25f));
        } else if(IsHovering())
        {
            Drawlib.DrawRectangleRoundedLines(Rectangle, 5, 32, 5, ColorUtil.Lerp(Color, Color.BLACK, 0.75f));
        }
        Drawlib.DrawText(Text, (int)Rectangle.x + (int)(Rectangle.width / 2 - Fontlib.MeasureTextEx(Fontlib.GetFontDefault(), Text, FontSize, 1).X / 2), (int)Rectangle.y + (int)(Rectangle.height / 2 - Fontlib.MeasureTextEx(Fontlib.GetFontDefault(), Text, FontSize, 1).Y / 2), FontSize, ColorUtil.Lerp(Color, Color.WHITE, 0.75f));
    }

    public override void Update()
    {
        if(!IsHovering()) return;
        if(!Mouselib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON)) return;
        if(OnClick != null)
        {
            OnClick(this);
        }
    }

    private bool IsHovering() {
        Vector2 mousePos = Mouselib.GetMousePosition();
        if(!(mousePos.X >= Rectangle.x) || !(mousePos.X <= (Rectangle.x + Rectangle.width))) return false;
        return mousePos.Y >= Rectangle.y && mousePos.Y <= Rectangle.y + Rectangle.height;

    }
}