/*
 * Prefect API Client for .NET
 *
 * For more information, visit: https://github.com/rpeden/prefect-client-dotnet
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = PrefectClient.Client.FileParameter;
using OpenAPIDateConverter = PrefectClient.Client.OpenAPIDateConverter;

namespace PrefectClient.Model
{
    /// <summary>
    /// RRule schedule, based on the iCalendar standard\\n([RFC 5545](https://datatracker.ietf.org/doc/html/rfc5545)) as\\nimplemented in `dateutils.rrule`.\\n\\nRRules are appropriate for any kind of calendar-date manipulation, including\\nirregular intervals, repetition, exclusions, week day or day-of-month\\nadjustments, and more.\\n\\nNote that as a calendar-oriented standard, `RRuleSchedules` are sensitive to\\nto the initial timezone provided. A 9am daily schedule with a daylight saving\\ntime-aware start date will maintain a local 9am time through DST boundaries;\\na 9am daily schedule with a UTC start date will maintain a 9am UTC time.\\n\\nArgs:\\n    rrule (str): a valid RRule string\\n    timezone (str, optional): a valid timezone string
    /// </summary>
    [DataContract(Name = "RRuleSchedule")]
    public partial class RRuleSchedule : IEquatable<RRuleSchedule>, IValidatableObject
    {
                /// <summary>
        /// Initializes a new instance of the <see cref="RRuleSchedule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RRuleSchedule() { }
        

        /// <summary>
        /// Gets or Sets Rrule
        /// </summary>
        [DataMember(Name = "rrule", IsRequired = true, EmitDefaultValue = true)]
        public string? Rrule { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        /// <example>America/New_York</example>
        [DataMember(Name = "timezone", EmitDefaultValue = false)]
        public string? Timezone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RRuleSchedule {\n");
            sb.Append("  Rrule: ").Append(Rrule).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RRuleSchedule);
        }

        /// <summary>
        /// Returns true if RRuleSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of RRuleSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RRuleSchedule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Rrule == input.Rrule ||
                    (this.Rrule != null &&
                    this.Rrule.Equals(input.Rrule))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Rrule != null)
                {
                    hashCode = (hashCode * 59) + this.Rrule.GetHashCode();
                }
                if (this.Timezone != null)
                {
                    hashCode = (hashCode * 59) + this.Timezone.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
