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
    /// ResetConcurrencyLimitByTagRequest
    /// </summary>
    [DataContract(Name = "ResetConcurrencyLimitByTagRequest")]
    public partial class ResetConcurrencyLimitByTagRequest : IEquatable<ResetConcurrencyLimitByTagRequest>, IValidatableObject
    {
                

        /// <summary>
        /// Manual override for active concurrency limit slots.
        /// </summary>
        /// <value>Manual override for active concurrency limit slots.</value>
        [DataMember(Name = "slot_override", EmitDefaultValue = false)]
        public List<Guid>? SlotOverride { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResetConcurrencyLimitByTagRequest {\n");
            sb.Append("  SlotOverride: ").Append(SlotOverride).Append("\n");
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
            return this.Equals(input as ResetConcurrencyLimitByTagRequest);
        }

        /// <summary>
        /// Returns true if ResetConcurrencyLimitByTagRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ResetConcurrencyLimitByTagRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResetConcurrencyLimitByTagRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SlotOverride == input.SlotOverride ||
                    this.SlotOverride != null &&
                    input.SlotOverride != null &&
                    this.SlotOverride.SequenceEqual(input.SlotOverride)
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
                if (this.SlotOverride != null)
                {
                    hashCode = (hashCode * 59) + this.SlotOverride.GetHashCode();
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