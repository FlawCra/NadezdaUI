using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadezdaUI.Gui.Framework.Units;

/// <summary>
/// Represents the font size.
/// </summary>
public class FontSize
{
    /// The FontSize class represents a specific font size.
    private FontSize(int value) {
        Value = value;
    }
    public int Value { get; set; }
    
    public static FontSize Small => new FontSize(14);
    public static FontSize Medium => new FontSize(20);
    public static FontSize Large => new FontSize(26);
}