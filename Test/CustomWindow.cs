using NadezdaUI.Gui.Framework.Controls;
using NadezdaUI.Gui.Framework.Lib;
using NadezdaUI.Gui.Framework.Units;

public class CustomWindow : Window
{
    public CustomWindow(bool dbg) : base(new Color(35, 35, 35, (int)byte.MaxValue), new Rectangle(0, 0, 1280, 720), "NadezdaUI Test", dbg)
    {
        Label l = new Label(new Rectangle(50, 50, 0, 0), "Example", Color.WHITE, fsize: FontSize.Large);
        Button b = new Button(new Rectangle(50, 200, 300, 50), "Button", Color.BLUE);
        TextBox tb = new TextBox(new Rectangle(50, 400, 500, 20), 40, Color.BLUE, fsize: FontSize.Medium);
        int test = 0;
        b.OnClick += (sender) =>
        {
            test++;
            sender.Text = "Clicked " + test + " times";
        };
        base.Controls.Add(l);
        base.Controls.Add(b);
        base.Controls.Add(tb);
    }
}
