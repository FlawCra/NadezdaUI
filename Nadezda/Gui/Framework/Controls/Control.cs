using Nadezda.Gui.Framework.Lib;

namespace Nadezda.Gui.Framework.Controls;

public abstract class Control
{
    public abstract Rectangle Rectangle { get; set; }

    public abstract List<Control> Controls { get; set; }

    protected Control()
    {

    }

    public abstract void Update();

    public abstract void Render();
}
