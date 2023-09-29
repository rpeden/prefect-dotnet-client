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
    /// Describes various attributes that detail the state of a flow or task run, including cache settings, pause configurations, and associated run IDs.
    /// </summary>
    [DataContract(Name = "StateDetails")]
    public partial class StateDetails : IEquatable<StateDetails>, IValidatableObject
    {
                

        /// <summary>
        /// Gets or Sets FlowRunId
        /// </summary>
        [DataMember(Name = "flow_run_id", EmitDefaultValue = false)]
        public Guid? FlowRunId { get; set; }

        /// <summary>
        /// Gets or Sets TaskRunId
        /// </summary>
        [DataMember(Name = "task_run_id", EmitDefaultValue = false)]
        public Guid? TaskRunId { get; set; }

        /// <summary>
        /// Gets or Sets ChildFlowRunId
        /// </summary>
        [DataMember(Name = "child_flow_run_id", EmitDefaultValue = false)]
        public Guid? ChildFlowRunId { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledTime
        /// </summary>
        [DataMember(Name = "scheduled_time", EmitDefaultValue = false)]
        public DateTime? ScheduledTime { get; set; }

        /// <summary>
        /// Gets or Sets CacheKey
        /// </summary>
        [DataMember(Name = "cache_key", EmitDefaultValue = false)]
        public string? CacheKey { get; set; }

        /// <summary>
        /// Gets or Sets CacheExpiration
        /// </summary>
        [DataMember(Name = "cache_expiration", EmitDefaultValue = false)]
        public DateTime? CacheExpiration { get; set; }

        /// <summary>
        /// Gets or Sets UntrackableResult
        /// </summary>
        [DataMember(Name = "untrackable_result", EmitDefaultValue = true)]
        public bool? UntrackableResult { get; set; }

        /// <summary>
        /// Gets or Sets PauseTimeout
        /// </summary>
        [DataMember(Name = "pause_timeout", EmitDefaultValue = false)]
        public DateTime? PauseTimeout { get; set; }

        /// <summary>
        /// Gets or Sets PauseReschedule
        /// </summary>
        [DataMember(Name = "pause_reschedule", EmitDefaultValue = true)]
        public bool? PauseReschedule { get; set; }

        /// <summary>
        /// Gets or Sets PauseKey
        /// </summary>
        [DataMember(Name = "pause_key", EmitDefaultValue = false)]
        public string? PauseKey { get; set; }

        /// <summary>
        /// Gets or Sets RefreshCache
        /// </summary>
        [DataMember(Name = "refresh_cache", EmitDefaultValue = true)]
        public bool? RefreshCache { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StateDetails {\n");
            sb.Append("  FlowRunId: ").Append(FlowRunId).Append("\n");
            sb.Append("  TaskRunId: ").Append(TaskRunId).Append("\n");
            sb.Append("  ChildFlowRunId: ").Append(ChildFlowRunId).Append("\n");
            sb.Append("  ScheduledTime: ").Append(ScheduledTime).Append("\n");
            sb.Append("  CacheKey: ").Append(CacheKey).Append("\n");
            sb.Append("  CacheExpiration: ").Append(CacheExpiration).Append("\n");
            sb.Append("  UntrackableResult: ").Append(UntrackableResult).Append("\n");
            sb.Append("  PauseTimeout: ").Append(PauseTimeout).Append("\n");
            sb.Append("  PauseReschedule: ").Append(PauseReschedule).Append("\n");
            sb.Append("  PauseKey: ").Append(PauseKey).Append("\n");
            sb.Append("  RefreshCache: ").Append(RefreshCache).Append("\n");
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
            return this.Equals(input as StateDetails);
        }

        /// <summary>
        /// Returns true if StateDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of StateDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FlowRunId == input.FlowRunId ||
                    (this.FlowRunId != null &&
                    this.FlowRunId.Equals(input.FlowRunId))
                ) && 
                (
                    this.TaskRunId == input.TaskRunId ||
                    (this.TaskRunId != null &&
                    this.TaskRunId.Equals(input.TaskRunId))
                ) && 
                (
                    this.ChildFlowRunId == input.ChildFlowRunId ||
                    (this.ChildFlowRunId != null &&
                    this.ChildFlowRunId.Equals(input.ChildFlowRunId))
                ) && 
                (
                    this.ScheduledTime == input.ScheduledTime ||
                    (this.ScheduledTime != null &&
                    this.ScheduledTime.Equals(input.ScheduledTime))
                ) && 
                (
                    this.CacheKey == input.CacheKey ||
                    (this.CacheKey != null &&
                    this.CacheKey.Equals(input.CacheKey))
                ) && 
                (
                    this.CacheExpiration == input.CacheExpiration ||
                    (this.CacheExpiration != null &&
                    this.CacheExpiration.Equals(input.CacheExpiration))
                ) && 
                (
                    this.UntrackableResult == input.UntrackableResult ||
                    this.UntrackableResult.Equals(input.UntrackableResult)
                ) && 
                (
                    this.PauseTimeout == input.PauseTimeout ||
                    (this.PauseTimeout != null &&
                    this.PauseTimeout.Equals(input.PauseTimeout))
                ) && 
                (
                    this.PauseReschedule == input.PauseReschedule ||
                    this.PauseReschedule.Equals(input.PauseReschedule)
                ) && 
                (
                    this.PauseKey == input.PauseKey ||
                    (this.PauseKey != null &&
                    this.PauseKey.Equals(input.PauseKey))
                ) && 
                (
                    this.RefreshCache == input.RefreshCache ||
                    this.RefreshCache.Equals(input.RefreshCache)
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
                if (this.FlowRunId != null)
                {
                    hashCode = (hashCode * 59) + this.FlowRunId.GetHashCode();
                }
                if (this.TaskRunId != null)
                {
                    hashCode = (hashCode * 59) + this.TaskRunId.GetHashCode();
                }
                if (this.ChildFlowRunId != null)
                {
                    hashCode = (hashCode * 59) + this.ChildFlowRunId.GetHashCode();
                }
                if (this.ScheduledTime != null)
                {
                    hashCode = (hashCode * 59) + this.ScheduledTime.GetHashCode();
                }
                if (this.CacheKey != null)
                {
                    hashCode = (hashCode * 59) + this.CacheKey.GetHashCode();
                }
                if (this.CacheExpiration != null)
                {
                    hashCode = (hashCode * 59) + this.CacheExpiration.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UntrackableResult.GetHashCode();
                if (this.PauseTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.PauseTimeout.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PauseReschedule.GetHashCode();
                if (this.PauseKey != null)
                {
                    hashCode = (hashCode * 59) + this.PauseKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RefreshCache.GetHashCode();
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
