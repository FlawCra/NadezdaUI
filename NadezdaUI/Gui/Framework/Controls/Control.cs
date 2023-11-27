using NadezdaUI.Gui.Framework.Lib;

namespace NadezdaUI.Gui.Framework.Controls;

/// <summary>
/// Represents a base class for various controls in a graphical user interface.
/// </summary>
public abstract class Control
{
    public abstract Rectangle Rectangle { get; set; }

    public abstract List<Control> Controls { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Control"/> class.
    /// </summary>
    /// <remarks>
    /// This constructor is declared as protected to prevent instantiation of the <see cref="Control"/> class.
    /// It is used as a base constructor for derived classes.
    /// </remarks>
    protected Control()
    {

    }

    /// <summary>
    /// Updates the object's state.
    /// </summary>
    public abstract void Update();

    /// <summary>
    /// Renders the object on the screen.
    /// </summary>
    public abstract void Render();
}
