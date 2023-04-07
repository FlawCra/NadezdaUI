using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadezda.Gui.Framework.Units;

public class FontSize
{
    private FontSize(int value) { Value = value; }
    public int Value { get; set; }
    
    public static FontSize Small => new FontSize(14);
    public static FontSize Medium => new FontSize(20);
    public static FontSize Large => new FontSize(26);
}