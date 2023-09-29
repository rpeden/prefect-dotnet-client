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
    /// AverageFlowRunLatenessRequest
    /// </summary>
    [DataContract(Name = "AverageFlowRunLatenessRequest")]
    public partial class AverageFlowRunLatenessRequest : IEquatable<AverageFlowRunLatenessRequest>, IValidatableObject
    {
                

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
        /// Gets or Sets WorkPoolQueues
        /// </summary>
        [DataMember(Name = "work_pool_queues", EmitDefaultValue = false)]
        public WorkQueueFilter WorkPoolQueues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AverageFlowRunLatenessRequest {\n");
            sb.Append("  Flows: ").Append(Flows).Append("\n");
            sb.Append("  FlowRuns: ").Append(FlowRuns).Append("\n");
            sb.Append("  TaskRuns: ").Append(TaskRuns).Append("\n");
            sb.Append("  Deployments: ").Append(Deployments).Append("\n");
            sb.Append("  WorkPools: ").Append(WorkPools).Append("\n");
            sb.Append("  WorkPoolQueues: ").Append(WorkPoolQueues).Append("\n");
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
            return this.Equals(input as AverageFlowRunLatenessRequest);
        }

        /// <summary>
        /// Returns true if AverageFlowRunLatenessRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AverageFlowRunLatenessRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AverageFlowRunLatenessRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.WorkPoolQueues == input.WorkPoolQueues ||
                    (this.WorkPoolQueues != null &&
                    this.WorkPoolQueues.Equals(input.WorkPoolQueues))
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
                if (this.WorkPoolQueues != null)
                {
                    hashCode = (hashCode * 59) + this.WorkPoolQueues.GetHashCode();
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