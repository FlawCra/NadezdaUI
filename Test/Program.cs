// See https://aka.ms/new-console-template for more information

using Nadezda.Gui.Framework.Controls;
using Nadezda.Gui.Framework.Units;
using Raylib_cs;

#if DEBUG
bool isDbg = true;
#else
bool isDbg = false;
#endif


Window w = new Window(Color.DARKGRAY, new Rectangle(0, 0, 1280, 720), debug: isDbg, title: "NadezdaUI");
Label l = new Label(new Rectangle(50,50,0,0), "Example", Color.WHITE, fsize:FontSize.Large);
Button b = new Button(new Rectangle(50, 200, 300, 50), "Button", Color.BLUE);
TextBox tb = new TextBox(new Rectangle(50, 400, 500, 20), 40, Color.BLUE);
int test = 0;
b.OnClick += (sender) => {
    test++;
    sender.Text = "Clicked " + test + " times";
};
w.Controls.Add(l);
w.Controls.Add(b);
w.Controls.Add(tb);
w.Show();
