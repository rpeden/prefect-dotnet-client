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
    /// An ORM representation of a work queue
    /// </summary>
    [DataContract(Name = "WorkQueue")]
    public partial class WorkQueue : IEquatable<WorkQueue>, IValidatableObject
    {
                /// <summary>
        /// Initializes a new instance of the <see cref="WorkQueue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkQueue() { }
        

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
        /// The name of the work queue.
        /// </summary>
        /// <value>The name of the work queue.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string? Name { get; set; }

        /// <summary>
        /// An optional description for the work queue.
        /// </summary>
        /// <value>An optional description for the work queue.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string? Description { get; set; }

        /// <summary>
        /// Whether or not the work queue is paused.
        /// </summary>
        /// <value>Whether or not the work queue is paused.</value>
        [DataMember(Name = "is_paused", EmitDefaultValue = true)]
        public bool? IsPaused { get; set; }

        /// <summary>
        /// An optional concurrency limit for the work queue.
        /// </summary>
        /// <value>An optional concurrency limit for the work queue.</value>
        [DataMember(Name = "concurrency_limit", EmitDefaultValue = false)]
        public int? ConcurrencyLimit { get; set; }

        /// <summary>
        /// The queue's priority. Lower values are higher priority (1 is the highest).
        /// </summary>
        /// <value>The queue&#39;s priority. Lower values are higher priority (1 is the highest).</value>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The work pool with which the queue is associated.
        /// </summary>
        /// <value>The work pool with which the queue is associated.</value>
        [DataMember(Name = "work_pool_id", EmitDefaultValue = false)]
        public Guid? WorkPoolId { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public QueueFilter Filter { get; set; }

        /// <summary>
        /// The last time an agent polled this queue for work.
        /// </summary>
        /// <value>The last time an agent polled this queue for work.</value>
        [DataMember(Name = "last_polled", EmitDefaultValue = false)]
        public DateTime? LastPolled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkQueue {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsPaused: ").Append(IsPaused).Append("\n");
            sb.Append("  ConcurrencyLimit: ").Append(ConcurrencyLimit).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  WorkPoolId: ").Append(WorkPoolId).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  LastPolled: ").Append(LastPolled).Append("\n");
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
            return this.Equals(input as WorkQueue);
        }

        /// <summary>
        /// Returns true if WorkQueue instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkQueue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkQueue input)
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
                    this.IsPaused == input.IsPaused ||
                    this.IsPaused.Equals(input.IsPaused)
                ) && 
                (
                    this.ConcurrencyLimit == input.ConcurrencyLimit ||
                    this.ConcurrencyLimit.Equals(input.ConcurrencyLimit)
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.WorkPoolId == input.WorkPoolId ||
                    (this.WorkPoolId != null &&
                    this.WorkPoolId.Equals(input.WorkPoolId))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.LastPolled == input.LastPolled ||
                    (this.LastPolled != null &&
                    this.LastPolled.Equals(input.LastPolled))
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
                hashCode = (hashCode * 59) + this.IsPaused.GetHashCode();
                hashCode = (hashCode * 59) + this.ConcurrencyLimit.GetHashCode();
                hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                if (this.WorkPoolId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkPoolId.GetHashCode();
                }
                if (this.Filter != null)
                {
                    hashCode = (hashCode * 59) + this.Filter.GetHashCode();
                }
                if (this.LastPolled != null)
                {
                    hashCode = (hashCode * 59) + this.LastPolled.GetHashCode();
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

            // Priority (int) minimum
            if (this.Priority < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Priority, must be a value greater than or equal to 1.", new [] { "Priority" });
            }

            yield break;
        }
    }

}
