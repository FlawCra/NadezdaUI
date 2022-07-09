using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadezda.Gui.Framework.Controls
{
    public class Window : Control
    {
        public string Title { get; private set; }

        public Color BackgroundColor { get; private set; }

        public override Rectangle Rectangle { get; set; }
        public override List<Control> Controls { get; set; } = new List<Control>();

        private bool _debug = false;

        protected Window(Color bg, Rectangle rectangle, string title = "NadezdaUI Window", bool debug = false) {
            Title = title;
            Rectangle = rectangle;
            BackgroundColor = bg;
            _debug = debug;
        }

        public void Show()
        {   
            Raylib.SetConfigFlags(ConfigFlags.FLAG_WINDOW_RESIZABLE);
            Raylib.InitWindow((int)Rectangle.width, (int)Rectangle.height, Title);

            while (!Raylib.WindowShouldClose())
            {
                Update();
                Render();
            }

            Raylib.CloseWindow();
        }

        public void SetSize(Rectangle rec) {
            this.Rectangle = rec;
            Raylib.SetWindowSize((int)rec.width, (int)rec.height);
        }
        public override void Render()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(BackgroundColor);

            foreach (Control c in Controls)
            {
                c.Render();
            }

            if(_debug)
            {
                Raylib.DrawFPS(0,0);
            }

            Raylib.EndDrawing();
        }

        public override void Update()
        {
            foreach (Control c in Controls)
            {
                c.Update();
            }
        }
    }
}
