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
    /// Data used by the Prefect REST API to update a work pool.
    /// </summary>
    [DataContract(Name = "WorkPoolUpdate")]
    public partial class WorkPoolUpdate : IEquatable<WorkPoolUpdate>, IValidatableObject
    {
                

        /// <summary>
        /// A description of the work pool.
        /// </summary>
        /// <value>A description of the work pool.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string? Description { get; set; }

        /// <summary>
        /// Pausing the work pool stops the delivery of all work.
        /// </summary>
        /// <value>Pausing the work pool stops the delivery of all work.</value>
        [DataMember(Name = "is_paused", EmitDefaultValue = true)]
        public bool? IsPaused { get; set; }

        /// <summary>
        /// The work pool's base job template.
        /// </summary>
        /// <value>The work pool&#39;s base job template.</value>
        [DataMember(Name = "base_job_template", EmitDefaultValue = false)]
        public Object? BaseJobTemplate { get; set; }

        /// <summary>
        /// A concurrency limit for the work pool.
        /// </summary>
        /// <value>A concurrency limit for the work pool.</value>
        [DataMember(Name = "concurrency_limit", EmitDefaultValue = false)]
        public int? ConcurrencyLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkPoolUpdate {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsPaused: ").Append(IsPaused).Append("\n");
            sb.Append("  BaseJobTemplate: ").Append(BaseJobTemplate).Append("\n");
            sb.Append("  ConcurrencyLimit: ").Append(ConcurrencyLimit).Append("\n");
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
            return this.Equals(input as WorkPoolUpdate);
        }

        /// <summary>
        /// Returns true if WorkPoolUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkPoolUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPoolUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsPaused == input.IsPaused ||
                    this.IsPaused.Equals(input.IsPaused)
                ) && 
                (
                    this.BaseJobTemplate == input.BaseJobTemplate ||
                    (this.BaseJobTemplate != null &&
                    this.BaseJobTemplate.Equals(input.BaseJobTemplate))
                ) && 
                (
                    this.ConcurrencyLimit == input.ConcurrencyLimit ||
                    this.ConcurrencyLimit.Equals(input.ConcurrencyLimit)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsPaused.GetHashCode();
                if (this.BaseJobTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.BaseJobTemplate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ConcurrencyLimit.GetHashCode();
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
            // ConcurrencyLimit (int) minimum
            if (this.ConcurrencyLimit < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConcurrencyLimit, must be a value greater than or equal to 0.", new [] { "ConcurrencyLimit" });
            }

            yield break;
        }
    }

}