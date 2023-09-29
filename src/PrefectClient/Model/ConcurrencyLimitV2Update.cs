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
    /// Data used by the Prefect REST API to update a v2 concurrency limit.
    /// </summary>
    [DataContract(Name = "ConcurrencyLimitV2Update")]
    public partial class ConcurrencyLimitV2Update : IEquatable<ConcurrencyLimitV2Update>, IValidatableObject
    {
                

        /// <summary>
        /// Whether the concurrency limit is active.
        /// </summary>
        /// <value>Whether the concurrency limit is active.</value>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool? Active { get; set; }

        /// <summary>
        /// The name of the concurrency limit.
        /// </summary>
        /// <value>The name of the concurrency limit.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string? Name { get; set; }

        /// <summary>
        /// The concurrency limit.
        /// </summary>
        /// <value>The concurrency limit.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The number of active slots.
        /// </summary>
        /// <value>The number of active slots.</value>
        [DataMember(Name = "active_slots", EmitDefaultValue = false)]
        public int? ActiveSlots { get; set; }

        /// <summary>
        /// The number of denied slots.
        /// </summary>
        /// <value>The number of denied slots.</value>
        [DataMember(Name = "denied_slots", EmitDefaultValue = false)]
        public int? DeniedSlots { get; set; }

        /// <summary>
        /// The decay rate for active slots when used as a rate limit.
        /// </summary>
        /// <value>The decay rate for active slots when used as a rate limit.</value>
        [DataMember(Name = "slot_decay_per_second", EmitDefaultValue = false)]
        public decimal? SlotDecayPerSecond { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConcurrencyLimitV2Update {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  ActiveSlots: ").Append(ActiveSlots).Append("\n");
            sb.Append("  DeniedSlots: ").Append(DeniedSlots).Append("\n");
            sb.Append("  SlotDecayPerSecond: ").Append(SlotDecayPerSecond).Append("\n");
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
            return this.Equals(input as ConcurrencyLimitV2Update);
        }

        /// <summary>
        /// Returns true if ConcurrencyLimitV2Update instances are equal
        /// </summary>
        /// <param name="input">Instance of ConcurrencyLimitV2Update to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConcurrencyLimitV2Update input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.ActiveSlots == input.ActiveSlots ||
                    this.ActiveSlots.Equals(input.ActiveSlots)
                ) && 
                (
                    this.DeniedSlots == input.DeniedSlots ||
                    this.DeniedSlots.Equals(input.DeniedSlots)
                ) && 
                (
                    this.SlotDecayPerSecond == input.SlotDecayPerSecond ||
                    this.SlotDecayPerSecond.Equals(input.SlotDecayPerSecond)
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
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Limit.GetHashCode();
                hashCode = (hashCode * 59) + this.ActiveSlots.GetHashCode();
                hashCode = (hashCode * 59) + this.DeniedSlots.GetHashCode();
                hashCode = (hashCode * 59) + this.SlotDecayPerSecond.GetHashCode();
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
