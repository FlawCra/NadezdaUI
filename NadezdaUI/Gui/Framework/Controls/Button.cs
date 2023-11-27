using NadezdaUI.Gui.Framework.Lib;
using NadezdaUI.Gui.Framework.Units;
using NadezdaUI.Gui.Framework.Utils;
using System.Numerics;

namespace NadezdaUI.Gui.Framework.Controls;

/// <summary>
/// Represents a button control.
/// </summary>
public class Button : Control
{
    public override Rectangle Rectangle { get; set; }

    public override List<Control> Controls { get; set; } = new List<Control>();

    public string Text;

    public FontSize FontSize;

    private Color Color;

    public Action<Button>? OnClick;

    /// <summary>
    /// Represents a button control with a specified rectangle, text, color, and optional font size.
    /// </summary>
    /// <param name="rec">The rectangle that defines the button position and size.</param>
    /// <param name="text">The text displayed on the button.</param>
    /// <param name="col">The color of the button.</param>
    /// <param name="fsize">The optional font size of the button text. If not specified, the default size is Medium.</param>
    public Button(Rectangle rec, string text, Color col, FontSize? fsize = null)
    {
        Rectangle = rec;
        Text = text;
        Color = col;
        FontSize = fsize ?? FontSize.Medium;
    }

    /// <summary>
    /// Renders the button.
    /// </summary>
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

    /// <summary>
    /// Updates the state of the object.
    /// </summary>
    public override void Update()
    {
        if(!IsHovering()) return;
        if(!Mouselib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON)) return;
        if(OnClick != null)
        {
            OnClick(this);
        }
    }

    /// <summary>
    /// Check if the mouse cursor is hovering over a given rectangle.
    /// </summary>
    /// <returns>
    /// A boolean value indicating whether the cursor is hovering over the rectangle.
    /// </returns>
    private bool IsHovering() {
        Vector2 mousePos = Mouselib.GetMousePosition();
        if(!(mousePos.X >= Rectangle.x) || !(mousePos.X <= (Rectangle.x + Rectangle.width))) return false;
        return mousePos.Y >= Rectangle.y && mousePos.Y <= Rectangle.y + Rectangle.height;

    }
}