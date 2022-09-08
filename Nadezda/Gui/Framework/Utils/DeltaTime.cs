namespace Nadezda.Gui.Framework.Utils
{
    public class DeltaTime
    {
        DateTime FirstTime;
        public static DeltaTime CreatePoint()
        {
            return new DeltaTime() { FirstTime = DateTime.Now };
        }
        public TimeSpan GetDeltaTime()
        {

            if (FirstTime != null)
            {

                return DateTime.Now - FirstTime;
            }
            return TimeSpan.FromSeconds(1 / 60); //If null then return 60 FPS.
        }
    }
}
