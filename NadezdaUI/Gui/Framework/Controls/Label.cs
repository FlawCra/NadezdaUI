using NadezdaUI.Gui.Framework.Lib;
using NadezdaUI.Gui.Framework.Units;

namespace NadezdaUI.Gui.Framework.Controls;

/// <summary>
/// Represents a label control that displays text.
/// </summary>
public class Label : Control
{
    public override Rectangle Rectangle { get; set; }

    public override List<Control> Controls { get; set; } = new List<Control>();

    public string Text;
    private FontSize FontSize;
    private Color Color;

    /// <summary>
    /// Initializes a new instance of the <see cref="Label"/> class.
    /// </summary>
    /// <param name="rec">The rectangle to define the position and size of the label.</param>
    /// <param name="text">The text to display on the label.</param>
    /// <param name="col">The color of the label.</param>
    /// <param name="fsize">The font size of the label. If not provided, the default font size will be used.</param>
    public Label(Rectangle rec, string text, Color col, FontSize? fsize = null)
    {
        Rectangle = rec;
        Text = text;
        FontSize = fsize ?? FontSize.Medium;
        Color = col;
    }

    /// <summary>
    /// Renders the text on the screen.
    /// </summary>
    public override void Render()
    {
        Drawlib.DrawText(Text, (int)Rectangle.x, (int)Rectangle.y, FontSize, Color);
    }

    /// <summary>
    /// Updates the object. This method should be implemented in derived classes to provide custom behavior.
    /// </summary>
    public override void Update()
    {

    }
}