using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SujaySarma.Data.Health.Constants
{
    /// <summary>
    /// Type of capability claim
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EnumCapabilityClaimTypes
    {
        /// <summary>
        /// Unknown or not provided
        /// </summary>
        [Display(Name = "Unknown", Description = "Unknown or not provided")]
        Unknown = 0,

        /// <summary>
        /// Is a qualification or degree
        /// </summary>
        [Display(Name = "Qualification", Description = "A degree, diploma or certification")]
        Qualification,

        /// <summary>
        /// Is an unqualified skill (eg: communication, listening)
        /// </summary>
        [Display(Name = "Skill", Description = "Inherrent capability or skill of practitioner")]
        Skill,

        /// <summary>
        /// Is an offered service
        /// </summary>
        [Display(Name = "Service offered", Description = "Services offered")]
        ServiceOffered,

        /// <summary>
        /// Service was offered in the past, adding to experience of the claimant
        /// </summary>
        [Display(Name = "Historical experience", Description = "Past experience of practitioner or claimant")]
        HistoricalExperience,
    }
}
