using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadezda.Gui.Framework.Controls
{
    public abstract class Control
    {
        public abstract Rectangle Rectangle { get; }

        public abstract List<Control> Controls { get; set; }

        public Control()
        {

        }

        public abstract void Update();

        public abstract void Render();
    }
}
