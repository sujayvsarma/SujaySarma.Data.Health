using System;
using System.Text.Json.Serialization;

namespace SujaySarma.Data.Health.Types
{
    /// <summary>
    /// Maps together a <see cref="DayOfWeek"/> and a range of times.
    /// </summary>
    public class DayOfWeekTimeslot
    {
        /// <summary>
        /// Day of week
        /// </summary>
        [JsonPropertyName("weekday")]
        public DayOfWeek Weekday { get; set; }

        /// <summary>
        /// Start time of the slot
        /// </summary>
        [JsonPropertyName("startTime")]
        public TimeOnly From { get; set; }

        /// <summary>
        /// End time of the slot
        /// </summary>
        [JsonPropertyName("to")]
        public TimeOnly To { get; set; }

        /// <summary>
        /// Initialise
        /// </summary>
        public DayOfWeekTimeslot()
        {
            Weekday = DayOfWeek.Sunday;
            From = new TimeOnly(0, 0, 0);
            To = new TimeOnly(23, 59, 59);
        }

        /// <summary>
        /// Check if the provided day of week and time are in the range of this slot
        /// </summary>
        /// <param name="dow">Day of Week</param>
        /// <param name="time">Time value</param>
        /// <returns>True if <paramref name="dow"/> matches Weekday and <paramref name="time"/> is between From and To</returns>
        public bool InRange(DayOfWeek dow, TimeOnly time)
        {
            if ((dow == Weekday) && ((From <= time) && (To >= time)))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Check if the provided day of week and time are in the range of this slot
        /// </summary>
        /// <param name="datetime">DateTime value</param>
        /// <returns>True if <paramref name="datetime"/> is between From and To</returns>
        public bool InRange(DateTime datetime)
        {
            TimeOnly time = new TimeOnly(datetime.Ticks);
            if ((datetime.DayOfWeek == Weekday) && ((From <= time) && (To >= time)))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Check if the provided day of week and time are in the range of this slot
        /// </summary>
        /// <param name="datetime">DateTime value</param>
        /// <returns>True if <paramref name="datetime"/> is between From and To</returns>
        public bool InRange(DateTimeUtc datetime)
        {
            TimeOnly time = datetime.Time;
            if ((datetime.DayOfWeek == Weekday) && ((From <= time) && (To >= time)))
            {
                return true;
            }

            return false;
        }
    }
}
