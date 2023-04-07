using Nadezda.Gui.Framework.Lib;
using Nadezda.Gui.Framework.Units;

namespace Nadezda.Gui.Framework.Controls;

public class Label : Control
{
    public override Rectangle Rectangle { get; set; }

    public override List<Control> Controls { get; set; } = new List<Control>();

    public string Text;
    private FontSize FontSize;
    private Color Color;

    public Label(Rectangle rec, string text, Color col, FontSize? fsize = null)
    {
        Rectangle = rec;
        Text = text;
        FontSize = fsize ?? FontSize.Medium;
        Color = col;
    }

    public override void Render()
    {
        Drawlib.DrawText(Text, (int)Rectangle.x, (int)Rectangle.y, FontSize, Color);
    }

    public override void Update()
    {

    }
}