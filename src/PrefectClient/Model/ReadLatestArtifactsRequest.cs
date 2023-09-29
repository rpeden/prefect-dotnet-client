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
    /// ReadLatestArtifactsRequest
    /// </summary>
    [DataContract(Name = "ReadLatestArtifactsRequest")]
    public partial class ReadLatestArtifactsRequest : IEquatable<ReadLatestArtifactsRequest>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets Sort
        /// </summary>  ArtifactCollectionSort
        [DataMember(Name = "sort", EmitDefaultValue = false)]
        public ArtifactCollectionSort? Sort { get; set; }
        

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        public int? Offset { get; set; }

        /// <summary>
        /// Gets or Sets Artifacts
        /// </summary>
        [DataMember(Name = "artifacts", EmitDefaultValue = false)]
        public ArtifactCollectionFilter Artifacts { get; set; }

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
        /// Gets or Sets Flows
        /// </summary>
        [DataMember(Name = "flows", EmitDefaultValue = false)]
        public FlowFilter Flows { get; set; }

        /// <summary>
        /// Gets or Sets Deployments
        /// </summary>
        [DataMember(Name = "deployments", EmitDefaultValue = false)]
        public DeploymentFilter Deployments { get; set; }

        /// <summary>
        /// Defaults to PREFECT_API_DEFAULT_LIMIT if not provided.
        /// </summary>
        /// <value>Defaults to PREFECT_API_DEFAULT_LIMIT if not provided.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int? Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadLatestArtifactsRequest {\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Artifacts: ").Append(Artifacts).Append("\n");
            sb.Append("  FlowRuns: ").Append(FlowRuns).Append("\n");
            sb.Append("  TaskRuns: ").Append(TaskRuns).Append("\n");
            sb.Append("  Flows: ").Append(Flows).Append("\n");
            sb.Append("  Deployments: ").Append(Deployments).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(input as ReadLatestArtifactsRequest);
        }

        /// <summary>
        /// Returns true if ReadLatestArtifactsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadLatestArtifactsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadLatestArtifactsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Sort == input.Sort ||
                    this.Sort.Equals(input.Sort)
                ) && 
                (
                    this.Offset == input.Offset ||
                    this.Offset.Equals(input.Offset)
                ) && 
                (
                    this.Artifacts == input.Artifacts ||
                    (this.Artifacts != null &&
                    this.Artifacts.Equals(input.Artifacts))
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
                    this.Flows == input.Flows ||
                    (this.Flows != null &&
                    this.Flows.Equals(input.Flows))
                ) && 
                (
                    this.Deployments == input.Deployments ||
                    (this.Deployments != null &&
                    this.Deployments.Equals(input.Deployments))
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
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
                hashCode = (hashCode * 59) + this.Sort.GetHashCode();
                hashCode = (hashCode * 59) + this.Offset.GetHashCode();
                if (this.Artifacts != null)
                {
                    hashCode = (hashCode * 59) + this.Artifacts.GetHashCode();
                }
                if (this.FlowRuns != null)
                {
                    hashCode = (hashCode * 59) + this.FlowRuns.GetHashCode();
                }
                if (this.TaskRuns != null)
                {
                    hashCode = (hashCode * 59) + this.TaskRuns.GetHashCode();
                }
                if (this.Flows != null)
                {
                    hashCode = (hashCode * 59) + this.Flows.GetHashCode();
                }
                if (this.Deployments != null)
                {
                    hashCode = (hashCode * 59) + this.Deployments.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Limit.GetHashCode();
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
            // Offset (int) minimum
            if (this.Offset < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Offset, must be a value greater than or equal to 0.", new [] { "Offset" });
            }

            yield break;
        }
    }

}
