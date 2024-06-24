using System;
using System.Text.Json.Serialization;

namespace SujaySarma.Data.Health.Types
{
    /// <summary>
    /// Provides a range of dates with time
    /// </summary>
    public class DateTimeRange
    {
        /// <summary>
        /// Start of the range
        /// </summary>
        [JsonPropertyName("from")]
        public DateTimeUtc From { get; set; }

        /// <summary>
        /// End of the slot
        /// </summary>
        [JsonPropertyName("to")]
        public DateTimeUtc To { get; set; }

        /// <summary>
        /// Initialise
        /// </summary>
        public DateTimeRange()
        {
            From = new DateTimeUtc();
            To = From;
        }

        /// <summary>
        /// Checks if the provided <paramref name="datetime"/> is within the range of this instance.
        /// </summary>
        /// <param name="datetime">A UTC DateTime value to test</param>
        /// <returns>True if the provided <paramref name="datetime"/> is in range</returns>
        public bool InRange(DateTimeUtc datetime)
        {
            if ((From >= datetime) && (To <= datetime))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the provided <paramref name="datetime"/> is within the range of this instance.
        /// </summary>
        /// <param name="datetime">A DateTime value to test</param>
        /// <returns>True if the provided <paramref name="datetime"/> is in range</returns>
        public bool InRange(DateTime datetime)
        {
            DateTimeUtc utc = datetime;
            return InRange(utc);
        }
    }
}
