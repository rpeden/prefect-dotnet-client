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
    /// Sets limits for late runs and polling frequency to gauge queue health.
    /// </summary>
    [DataContract(Name = "WorkQueueHealthPolicy")]
    public partial class WorkQueueHealthPolicy : IEquatable<WorkQueueHealthPolicy>, IValidatableObject
    {
                

        /// <summary>
        /// The maximum number of late runs in the work queue before it is deemed unhealthy. Defaults to `0`.
        /// </summary>
        /// <value>The maximum number of late runs in the work queue before it is deemed unhealthy. Defaults to &#x60;0&#x60;.</value>
        [DataMember(Name = "maximum_late_runs", EmitDefaultValue = false)]
        public int? MaximumLateRuns { get; set; }

        /// <summary>
        /// The maximum number of time in seconds elapsed since work queue has been polled before it is deemed unhealthy. Defaults to `60`.
        /// </summary>
        /// <value>The maximum number of time in seconds elapsed since work queue has been polled before it is deemed unhealthy. Defaults to &#x60;60&#x60;.</value>
        [DataMember(Name = "maximum_seconds_since_last_polled", EmitDefaultValue = false)]
        public int? MaximumSecondsSinceLastPolled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkQueueHealthPolicy {\n");
            sb.Append("  MaximumLateRuns: ").Append(MaximumLateRuns).Append("\n");
            sb.Append("  MaximumSecondsSinceLastPolled: ").Append(MaximumSecondsSinceLastPolled).Append("\n");
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
            return this.Equals(input as WorkQueueHealthPolicy);
        }

        /// <summary>
        /// Returns true if WorkQueueHealthPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkQueueHealthPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkQueueHealthPolicy input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaximumLateRuns == input.MaximumLateRuns ||
                    this.MaximumLateRuns.Equals(input.MaximumLateRuns)
                ) && 
                (
                    this.MaximumSecondsSinceLastPolled == input.MaximumSecondsSinceLastPolled ||
                    this.MaximumSecondsSinceLastPolled.Equals(input.MaximumSecondsSinceLastPolled)
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
                hashCode = (hashCode * 59) + this.MaximumLateRuns.GetHashCode();
                hashCode = (hashCode * 59) + this.MaximumSecondsSinceLastPolled.GetHashCode();
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
