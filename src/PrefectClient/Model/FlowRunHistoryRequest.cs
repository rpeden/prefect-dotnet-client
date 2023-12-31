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
    /// FlowRunHistoryRequest
    /// </summary>
    [DataContract(Name = "FlowRunHistoryRequest")]
    public partial class FlowRunHistoryRequest : IEquatable<FlowRunHistoryRequest>, IValidatableObject
    {
                /// <summary>
        /// Initializes a new instance of the <see cref="FlowRunHistoryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlowRunHistoryRequest() { }
        

        /// <summary>
        /// The history's start time.
        /// </summary>
        /// <value>The history&#39;s start time.</value>
        [DataMember(Name = "history_start", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? HistoryStart { get; set; }

        /// <summary>
        /// The history's end time.
        /// </summary>
        /// <value>The history&#39;s end time.</value>
        [DataMember(Name = "history_end", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? HistoryEnd { get; set; }

        /// <summary>
        /// The size of each history interval, in seconds. Must be at least 1 second.
        /// </summary>
        /// <value>The size of each history interval, in seconds. Must be at least 1 second.</value>
        [DataMember(Name = "history_interval_seconds", IsRequired = true, EmitDefaultValue = true)]
        public decimal? HistoryIntervalSeconds { get; set; }

        /// <summary>
        /// Gets or Sets Flows
        /// </summary>
        [DataMember(Name = "flows", EmitDefaultValue = false)]
        public FlowFilter Flows { get; set; }

        /// <summary>
        /// Gets or Sets FlowRuns
        /// </summary>
        [DataMember(Name = "flow_runs", EmitDefaultValue = false)]
        public FlowRunFilter FlowRuns { get; set; }

        /// <summary>
        /// Gets or Sets TaskRuns
        /// </summary>
        [DataMember(Name = "task_runs", EmitDefaultValue = false)]
        public TaskRunFilter TaskRuns { get; set; }

        /// <summary>
        /// Gets or Sets Deployments
        /// </summary>
        [DataMember(Name = "deployments", EmitDefaultValue = false)]
        public DeploymentFilter Deployments { get; set; }

        /// <summary>
        /// Gets or Sets WorkPools
        /// </summary>
        [DataMember(Name = "work_pools", EmitDefaultValue = false)]
        public WorkPoolFilter WorkPools { get; set; }

        /// <summary>
        /// Gets or Sets WorkQueues
        /// </summary>
        [DataMember(Name = "work_queues", EmitDefaultValue = false)]
        public WorkQueueFilter WorkQueues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlowRunHistoryRequest {\n");
            sb.Append("  HistoryStart: ").Append(HistoryStart).Append("\n");
            sb.Append("  HistoryEnd: ").Append(HistoryEnd).Append("\n");
            sb.Append("  HistoryIntervalSeconds: ").Append(HistoryIntervalSeconds).Append("\n");
            sb.Append("  Flows: ").Append(Flows).Append("\n");
            sb.Append("  FlowRuns: ").Append(FlowRuns).Append("\n");
            sb.Append("  TaskRuns: ").Append(TaskRuns).Append("\n");
            sb.Append("  Deployments: ").Append(Deployments).Append("\n");
            sb.Append("  WorkPools: ").Append(WorkPools).Append("\n");
            sb.Append("  WorkQueues: ").Append(WorkQueues).Append("\n");
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
            return this.Equals(input as FlowRunHistoryRequest);
        }

        /// <summary>
        /// Returns true if FlowRunHistoryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FlowRunHistoryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowRunHistoryRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HistoryStart == input.HistoryStart ||
                    (this.HistoryStart != null &&
                    this.HistoryStart.Equals(input.HistoryStart))
                ) && 
                (
                    this.HistoryEnd == input.HistoryEnd ||
                    (this.HistoryEnd != null &&
                    this.HistoryEnd.Equals(input.HistoryEnd))
                ) && 
                (
                    this.HistoryIntervalSeconds == input.HistoryIntervalSeconds ||
                    this.HistoryIntervalSeconds.Equals(input.HistoryIntervalSeconds)
                ) && 
                (
                    this.Flows == input.Flows ||
                    (this.Flows != null &&
                    this.Flows.Equals(input.Flows))
                ) && 
                (
                    this.FlowRuns == input.FlowRuns ||
                    (this.FlowRuns != null &&
                    this.FlowRuns.Equals(input.FlowRuns))
                ) && 
                (
                    this.TaskRuns == input.TaskRuns ||
                    (this.TaskRuns != null &&
                    this.TaskRuns.Equals(input.TaskRuns))
                ) && 
                (
                    this.Deployments == input.Deployments ||
                    (this.Deployments != null &&
                    this.Deployments.Equals(input.Deployments))
                ) && 
                (
                    this.WorkPools == input.WorkPools ||
                    (this.WorkPools != null &&
                    this.WorkPools.Equals(input.WorkPools))
                ) && 
                (
                    this.WorkQueues == input.WorkQueues ||
                    (this.WorkQueues != null &&
                    this.WorkQueues.Equals(input.WorkQueues))
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
                if (this.HistoryStart != null)
                {
                    hashCode = (hashCode * 59) + this.HistoryStart.GetHashCode();
                }
                if (this.HistoryEnd != null)
                {
                    hashCode = (hashCode * 59) + this.HistoryEnd.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HistoryIntervalSeconds.GetHashCode();
                if (this.Flows != null)
                {
                    hashCode = (hashCode * 59) + this.Flows.GetHashCode();
                }
                if (this.FlowRuns != null)
                {
                    hashCode = (hashCode * 59) + this.FlowRuns.GetHashCode();
                }
                if (this.TaskRuns != null)
                {
                    hashCode = (hashCode * 59) + this.TaskRuns.GetHashCode();
                }
                if (this.Deployments != null)
                {
                    hashCode = (hashCode * 59) + this.Deployments.GetHashCode();
                }
                if (this.WorkPools != null)
                {
                    hashCode = (hashCode * 59) + this.WorkPools.GetHashCode();
                }
                if (this.WorkQueues != null)
                {
                    hashCode = (hashCode * 59) + this.WorkQueues.GetHashCode();
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
