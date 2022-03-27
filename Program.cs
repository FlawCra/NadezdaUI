using Nadezda.Gui.Framework.Controls;
using Nadezda.Gui.Framework.Units;
using Raylib_cs;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Nadezda
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();

        private static IntPtr DllImportResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            switch(libraryName)
            {
                case "kernel32.dll":
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        return NativeLibrary.Load("kernel32.dll", assembly, searchPath);
                    }
                    break;
            }

            // Otherwise, fallback to default import resolver.
            return IntPtr.Zero;
        }

        public static void Main()
        {
            NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), DllImportResolver);
#if DEBUG
            bool isDbg = true;
#else
            bool isDbg = false;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                try
                {
                    FreeConsole();
                } catch(Exception) { }
                
            }
            
#endif


            Window w = new Window(Color.DARKGRAY, new Rectangle(0, 0, 1280, 720), debug: isDbg, title: "NadezdaUI");
            Label l = new Label(new Rectangle(50,50,0,0), "Example", Color.WHITE, fsize:FontSize.Large);
            Button b = new Button(new Rectangle(50, 200, 300, 50), "Button", Color.BLUE);
            int test = 0;
            b.OnClick += (sender) => {
                test++;
                sender.Text = "Clicked " + test + " times";
            };
            w.Controls.Add(l);
            w.Controls.Add(b);
            w.Show();
        }
    }
}