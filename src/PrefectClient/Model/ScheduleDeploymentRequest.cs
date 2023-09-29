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
    /// ScheduleDeploymentRequest
    /// </summary>
    [DataContract(Name = "ScheduleDeploymentRequest")]
    public partial class ScheduleDeploymentRequest : IEquatable<ScheduleDeploymentRequest>, IValidatableObject
    {
                

        /// <summary>
        /// The earliest date to schedule
        /// </summary>
        /// <value>The earliest date to schedule</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The latest date to schedule
        /// </summary>
        /// <value>The latest date to schedule</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Runs will be scheduled until at least this long after the `start_time`
        /// </summary>
        /// <value>Runs will be scheduled until at least this long after the &#x60;start_time&#x60;</value>
        [DataMember(Name = "min_time", EmitDefaultValue = false)]
        public decimal? MinTime { get; set; }

        /// <summary>
        /// The minimum number of runs to schedule
        /// </summary>
        /// <value>The minimum number of runs to schedule</value>
        [DataMember(Name = "min_runs", EmitDefaultValue = false)]
        public int? MinRuns { get; set; }

        /// <summary>
        /// The maximum number of runs to schedule
        /// </summary>
        /// <value>The maximum number of runs to schedule</value>
        [DataMember(Name = "max_runs", EmitDefaultValue = false)]
        public int? MaxRuns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScheduleDeploymentRequest {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  MinTime: ").Append(MinTime).Append("\n");
            sb.Append("  MinRuns: ").Append(MinRuns).Append("\n");
            sb.Append("  MaxRuns: ").Append(MaxRuns).Append("\n");
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
            return this.Equals(input as ScheduleDeploymentRequest);
        }

        /// <summary>
        /// Returns true if ScheduleDeploymentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleDeploymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleDeploymentRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.MinTime == input.MinTime ||
                    this.MinTime.Equals(input.MinTime)
                ) && 
                (
                    this.MinRuns == input.MinRuns ||
                    this.MinRuns.Equals(input.MinRuns)
                ) && 
                (
                    this.MaxRuns == input.MaxRuns ||
                    this.MaxRuns.Equals(input.MaxRuns)
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
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MinTime.GetHashCode();
                hashCode = (hashCode * 59) + this.MinRuns.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxRuns.GetHashCode();
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
