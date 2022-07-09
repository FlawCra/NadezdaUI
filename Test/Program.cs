// See https://aka.ms/new-console-template for more information

using Nadezda.Gui.Framework.Controls;
using Nadezda.Gui.Framework.Units;
using Raylib_cs;

#if DEBUG
bool isDbg = true;
#else
bool isDbg = false;
#endif

Window w = new CustomWindow(isDbg);
w.Show();
