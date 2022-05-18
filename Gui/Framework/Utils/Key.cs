namespace Nadezda.Gui.Framework.Utils
{
    public class Key
    {
        private String String = "";
        
        private Dictionary<int, string> KeyMap = new Dictionary<int, String>();
        

        public Key(int keyCode)
        {
            KeyMap.Add(0, "0");
            KeyMap.Add(1, "1");
            KeyMap.Add(2, "2");
            KeyMap.Add(3, "3");
            
            switch(keyCode)
            {
                case (int)UnicodeKeys.a:
                    this.String = "a";
                    break;
                case (int)UnicodeKeys.b:
                    this.String = "b";
                    break;
                case (int)UnicodeKeys.c:
                    this.String = "c";
                    break;
                case (int)UnicodeKeys.d:
                    this.String = "d";
                    break;
                case (int)UnicodeKeys.e:
                    this.String = "e";
                    break;
                case (int)UnicodeKeys.f:
                    this.String = "f";
                    break;
                case (int)UnicodeKeys.g:
                    this.String = "g";
                    break;
                case (int)UnicodeKeys.h:
                    this.String = "h";
                    break;
                case (int)UnicodeKeys.i:
                    this.String = "i";
                    break;
                case (int)UnicodeKeys.j:
                    this.String = "j";
                    break;
                case (int)UnicodeKeys.k:
                    this.String = "k";
                    break;
                case (int)UnicodeKeys.l:
                    this.String = "l";
                    break;
                case (int)UnicodeKeys.m:
                    this.String = "m";
                    break;
                case (int)UnicodeKeys.n:
                    this.String = "n";
                    break;
                case (int)UnicodeKeys.o:
                    this.String = "o";
                    break;
                case (int)UnicodeKeys.p:
                    this.String = "p";
                    break;
                case (int)UnicodeKeys.q:
                    this.String = "q";
                    break;
                case (int)UnicodeKeys.r:
                    this.String = "r";
                    break;
                case (int)UnicodeKeys.s:
                    this.String = "s";
                    break;
                case (int)UnicodeKeys.t:
                    this.String = "t";
                    break;
                case (int)UnicodeKeys.u:
                    this.String = "u";
                    break;
                case (int)UnicodeKeys.v:
                    this.String = "v";
                    break;
                case (int)UnicodeKeys.w:
                    this.String = "w";
                    break;
                case (int)UnicodeKeys.x:
                    this.String = "x";
                    break;
                case (int)UnicodeKeys.y:
                    this.String = "y";
                    break;
                case (int)UnicodeKeys.z:
                    this.String = "z";
                    break;
            }
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
