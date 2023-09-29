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
    /// An ORM representation of a work pool
    /// </summary>
    [DataContract(Name = "WorkPool")]
    public partial class WorkPool : IEquatable<WorkPool>, IValidatableObject
    {
                /// <summary>
        /// Initializes a new instance of the <see cref="WorkPool" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkPool() { }
        

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name = "updated", EmitDefaultValue = false)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The name of the work pool.
        /// </summary>
        /// <value>The name of the work pool.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the work pool.
        /// </summary>
        /// <value>A description of the work pool.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string? Description { get; set; }

        /// <summary>
        /// The work pool type.
        /// </summary>
        /// <value>The work pool type.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string? Type { get; set; }

        /// <summary>
        /// The work pool's base job template.
        /// </summary>
        /// <value>The work pool&#39;s base job template.</value>
        [DataMember(Name = "base_job_template", EmitDefaultValue = false)]
        public Object? BaseJobTemplate { get; set; }

        /// <summary>
        /// Pausing the work pool stops the delivery of all work.
        /// </summary>
        /// <value>Pausing the work pool stops the delivery of all work.</value>
        [DataMember(Name = "is_paused", EmitDefaultValue = true)]
        public bool? IsPaused { get; set; }

        /// <summary>
        /// A concurrency limit for the work pool.
        /// </summary>
        /// <value>A concurrency limit for the work pool.</value>
        [DataMember(Name = "concurrency_limit", EmitDefaultValue = false)]
        public int? ConcurrencyLimit { get; set; }

        /// <summary>
        /// The id of the pool's default queue.
        /// </summary>
        /// <value>The id of the pool&#39;s default queue.</value>
        [DataMember(Name = "default_queue_id", EmitDefaultValue = false)]
        public Guid? DefaultQueueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkPool {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BaseJobTemplate: ").Append(BaseJobTemplate).Append("\n");
            sb.Append("  IsPaused: ").Append(IsPaused).Append("\n");
            sb.Append("  ConcurrencyLimit: ").Append(ConcurrencyLimit).Append("\n");
            sb.Append("  DefaultQueueId: ").Append(DefaultQueueId).Append("\n");
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
            return this.Equals(input as WorkPool);
        }

        /// <summary>
        /// Returns true if WorkPool instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkPool to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPool input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.BaseJobTemplate == input.BaseJobTemplate ||
                    (this.BaseJobTemplate != null &&
                    this.BaseJobTemplate.Equals(input.BaseJobTemplate))
                ) && 
                (
                    this.IsPaused == input.IsPaused ||
                    this.IsPaused.Equals(input.IsPaused)
                ) && 
                (
                    this.ConcurrencyLimit == input.ConcurrencyLimit ||
                    this.ConcurrencyLimit.Equals(input.ConcurrencyLimit)
                ) && 
                (
                    this.DefaultQueueId == input.DefaultQueueId ||
                    (this.DefaultQueueId != null &&
                    this.DefaultQueueId.Equals(input.DefaultQueueId))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.Updated != null)
                {
                    hashCode = (hashCode * 59) + this.Updated.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.BaseJobTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.BaseJobTemplate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsPaused.GetHashCode();
                hashCode = (hashCode * 59) + this.ConcurrencyLimit.GetHashCode();
                if (this.DefaultQueueId != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultQueueId.GetHashCode();
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
            // ConcurrencyLimit (int) minimum
            if (this.ConcurrencyLimit < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConcurrencyLimit, must be a value greater than or equal to 0.", new [] { "ConcurrencyLimit" });
            }

            yield break;
        }
    }

}