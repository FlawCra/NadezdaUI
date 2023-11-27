namespace NadezdaUI.Gui.Framework.Utils;

/// <summary>
/// Represents a class for calculating the time difference between two points.
/// </summary>
public class DeltaTime
{
    DateTime FirstTime;
    /// <summary>
    /// Creates a new instance of the DeltaTime class with the current time as the value of the FirstTime property.
    /// </summary>
    /// <returns>A new instance of the DeltaTime class.</returns>
    public static DeltaTime CreatePoint()
    {
        return new DeltaTime { FirstTime = DateTime.Now };
    }
    /// <summary>
    /// Calculates the time difference between the current time and the stored start time.
    /// </summary>
    /// <returns>
    /// The time difference as a TimeSpan object.
    /// If the start time is null, returns a TimeSpan representing 1/60 of a second (60 FPS).
    /// </returns>
    public TimeSpan GetDeltaTime()
    {

        if(FirstTime != null)
        {

            return DateTime.Now - FirstTime;
        }
        return TimeSpan.FromSeconds(1 / 60); //If null then return 60 FPS.
    }
}