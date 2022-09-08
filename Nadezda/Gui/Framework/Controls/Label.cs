using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nadezda.Gui.Framework.Units;

namespace Nadezda.Gui.Framework.Controls
{
    public class Label : Control
    {
        public override Rectangle Rectangle { get; set; }

        public override List<Control> Controls { get; set; } = new List<Control>();

        private string Text;
        private FontSize FontSize;
        private Color Color;

        public Label(Rectangle rec, string text, Color col, FontSize fsize = FontSize.Medium)
        {
            Rectangle = rec;
            Text = text;
            FontSize = fsize;
            Color = col;
        }

        public override void Render()
        {
            Raylib.DrawText(Text, (int)Rectangle.x, (int)Rectangle.y, (int)FontSize, Color);
        }

        public override void Update()
        {

        }
    }
}
