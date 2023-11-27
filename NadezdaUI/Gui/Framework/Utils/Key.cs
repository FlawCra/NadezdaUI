using System.Collections.Specialized;

namespace NadezdaUI.Gui.Framework.Utils;

/// <summary>
/// Represents a key with a character value.
/// </summary>
public class Key
{
    private string String = "";

    private char Char;

    /// <summary>
    /// Represents a Key object.
    /// </summary>
    /// <param name="keyCode">The code of the key.</param>
    public Key(int keyCode)
    {
        this.Char = (char)keyCode;
        this.String = this.Char.ToString();
    }

    /// <summary>
    /// Overrides the ToString() method of the object class.
    /// </summary>
    /// <returns>The string representation of the current object.</returns>
    public override string ToString()
    {
        return this.String;
    }
}