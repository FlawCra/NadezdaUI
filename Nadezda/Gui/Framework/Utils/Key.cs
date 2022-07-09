using System.Collections.Specialized;

namespace Nadezda.Gui.Framework.Utils
{
    public class Key
    {
        private String String = "";

        private char Char;
        
        public Key(int keyCode)
        {
            this.Char = (char)keyCode;
            this.String = this.Char.ToString();
        }

        public override string ToString()
        {
            return this.String;
        }
    }

    public class KeyMap
    {
        
        
    }
}
