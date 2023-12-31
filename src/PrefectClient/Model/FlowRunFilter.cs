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
    /// Filter flow runs. Only flow runs matching all criteria will be returned
    /// </summary>
    [DataContract(Name = "FlowRunFilter")]
    public partial class FlowRunFilter : IEquatable<FlowRunFilter>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets FilterOperator
        /// </summary>  Operator
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public Operator? FilterOperator { get; set; }
        

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public FlowRunFilterId Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public FlowRunFilterName Name { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public FlowRunFilterTags Tags { get; set; }

        /// <summary>
        /// Gets or Sets DeploymentId
        /// </summary>
        [DataMember(Name = "deployment_id", EmitDefaultValue = false)]
        public FlowRunFilterDeploymentId DeploymentId { get; set; }

        /// <summary>
        /// Gets or Sets WorkQueueName
        /// </summary>
        [DataMember(Name = "work_queue_name", EmitDefaultValue = false)]
        public FlowRunFilterWorkQueueName WorkQueueName { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public FlowRunFilterState State { get; set; }

        /// <summary>
        /// Gets or Sets FlowVersion
        /// </summary>
        [DataMember(Name = "flow_version", EmitDefaultValue = false)]
        public FlowRunFilterFlowVersion FlowVersion { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public FlowRunFilterStartTime StartTime { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedStartTime
        /// </summary>
        [DataMember(Name = "expected_start_time", EmitDefaultValue = false)]
        public FlowRunFilterExpectedStartTime ExpectedStartTime { get; set; }

        /// <summary>
        /// Gets or Sets NextScheduledStartTime
        /// </summary>
        [DataMember(Name = "next_scheduled_start_time", EmitDefaultValue = false)]
        public FlowRunFilterNextScheduledStartTime NextScheduledStartTime { get; set; }

        /// <summary>
        /// Gets or Sets ParentTaskRunId
        /// </summary>
        [DataMember(Name = "parent_task_run_id", EmitDefaultValue = false)]
        public FlowRunFilterParentTaskRunId ParentTaskRunId { get; set; }

        /// <summary>
        /// Gets or Sets IdempotencyKey
        /// </summary>
        [DataMember(Name = "idempotency_key", EmitDefaultValue = false)]
        public FlowRunFilterIdempotencyKey IdempotencyKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlowRunFilter {\n");
            sb.Append("  FilterOperator: ").Append(FilterOperator).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
            sb.Append("  WorkQueueName: ").Append(WorkQueueName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  ExpectedStartTime: ").Append(ExpectedStartTime).Append("\n");
            sb.Append("  NextScheduledStartTime: ").Append(NextScheduledStartTime).Append("\n");
            sb.Append("  ParentTaskRunId: ").Append(ParentTaskRunId).Append("\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
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
            return this.Equals(input as FlowRunFilter);
        }

        /// <summary>
        /// Returns true if FlowRunFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of FlowRunFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowRunFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FilterOperator == input.FilterOperator ||
                    this.FilterOperator.Equals(input.FilterOperator)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.DeploymentId == input.DeploymentId ||
                    (this.DeploymentId != null &&
                    this.DeploymentId.Equals(input.DeploymentId))
                ) && 
                (
                    this.WorkQueueName == input.WorkQueueName ||
                    (this.WorkQueueName != null &&
                    this.WorkQueueName.Equals(input.WorkQueueName))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.FlowVersion == input.FlowVersion ||
                    (this.FlowVersion != null &&
                    this.FlowVersion.Equals(input.FlowVersion))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.ExpectedStartTime == input.ExpectedStartTime ||
                    (this.ExpectedStartTime != null &&
                    this.ExpectedStartTime.Equals(input.ExpectedStartTime))
                ) && 
                (
                    this.NextScheduledStartTime == input.NextScheduledStartTime ||
                    (this.NextScheduledStartTime != null &&
                    this.NextScheduledStartTime.Equals(input.NextScheduledStartTime))
                ) && 
                (
                    this.ParentTaskRunId == input.ParentTaskRunId ||
                    (this.ParentTaskRunId != null &&
                    this.ParentTaskRunId.Equals(input.ParentTaskRunId))
                ) && 
                (
                    this.IdempotencyKey == input.IdempotencyKey ||
                    (this.IdempotencyKey != null &&
                    this.IdempotencyKey.Equals(input.IdempotencyKey))
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
                hashCode = (hashCode * 59) + this.FilterOperator.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.DeploymentId != null)
                {
                    hashCode = (hashCode * 59) + this.DeploymentId.GetHashCode();
                }
                if (this.WorkQueueName != null)
                {
                    hashCode = (hashCode * 59) + this.WorkQueueName.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.FlowVersion != null)
                {
                    hashCode = (hashCode * 59) + this.FlowVersion.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.ExpectedStartTime != null)
                {
                    hashCode = (hashCode * 59) + this.ExpectedStartTime.GetHashCode();
                }
                if (this.NextScheduledStartTime != null)
                {
                    hashCode = (hashCode * 59) + this.NextScheduledStartTime.GetHashCode();
                }
                if (this.ParentTaskRunId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentTaskRunId.GetHashCode();
                }
                if (this.IdempotencyKey != null)
                {
                    hashCode = (hashCode * 59) + this.IdempotencyKey.GetHashCode();
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
