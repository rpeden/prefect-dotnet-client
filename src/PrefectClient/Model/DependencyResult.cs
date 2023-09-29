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
    /// Represents the result of a dependency in a workflow, capturing various metadata and states.  Contains details such as unique identifier, associated upstream dependencies, runtime states, time metrics, and whether the result is trackable or not.
    /// </summary>
    [DataContract(Name = "DependencyResult")]
    public partial class DependencyResult : IEquatable<DependencyResult>, IValidatableObject
    {
                /// <summary>
        /// Initializes a new instance of the <see cref="DependencyResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DependencyResult() { }
        

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or Sets UpstreamDependencies
        /// </summary>
        [DataMember(Name = "upstream_dependencies", IsRequired = true, EmitDefaultValue = true)]
        public List<TaskRunResult> UpstreamDependencies { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public State State { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedStartTime
        /// </summary>
        [DataMember(Name = "expected_start_time", EmitDefaultValue = false)]
        public DateTime? ExpectedStartTime { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or Sets TotalRunTime
        /// </summary>
        [DataMember(Name = "total_run_time", EmitDefaultValue = false)]
        public decimal? TotalRunTime { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedRunTime
        /// </summary>
        [DataMember(Name = "estimated_run_time", EmitDefaultValue = false)]
        public decimal? EstimatedRunTime { get; set; }

        /// <summary>
        /// Gets or Sets UntrackableResult
        /// </summary>
        [DataMember(Name = "untrackable_result", IsRequired = true, EmitDefaultValue = true)]
        public bool? UntrackableResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DependencyResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UpstreamDependencies: ").Append(UpstreamDependencies).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ExpectedStartTime: ").Append(ExpectedStartTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  TotalRunTime: ").Append(TotalRunTime).Append("\n");
            sb.Append("  EstimatedRunTime: ").Append(EstimatedRunTime).Append("\n");
            sb.Append("  UntrackableResult: ").Append(UntrackableResult).Append("\n");
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
            return this.Equals(input as DependencyResult);
        }

        /// <summary>
        /// Returns true if DependencyResult instances are equal
        /// </summary>
        /// <param name="input">Instance of DependencyResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DependencyResult input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.UpstreamDependencies == input.UpstreamDependencies ||
                    this.UpstreamDependencies != null &&
                    input.UpstreamDependencies != null &&
                    this.UpstreamDependencies.SequenceEqual(input.UpstreamDependencies)
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.ExpectedStartTime == input.ExpectedStartTime ||
                    (this.ExpectedStartTime != null &&
                    this.ExpectedStartTime.Equals(input.ExpectedStartTime))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.TotalRunTime == input.TotalRunTime ||
                    this.TotalRunTime.Equals(input.TotalRunTime)
                ) && 
                (
                    this.EstimatedRunTime == input.EstimatedRunTime ||
                    this.EstimatedRunTime.Equals(input.EstimatedRunTime)
                ) && 
                (
                    this.UntrackableResult == input.UntrackableResult ||
                    this.UntrackableResult.Equals(input.UntrackableResult)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.UpstreamDependencies != null)
                {
                    hashCode = (hashCode * 59) + this.UpstreamDependencies.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.ExpectedStartTime != null)
                {
                    hashCode = (hashCode * 59) + this.ExpectedStartTime.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalRunTime.GetHashCode();
                hashCode = (hashCode * 59) + this.EstimatedRunTime.GetHashCode();
                hashCode = (hashCode * 59) + this.UntrackableResult.GetHashCode();
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
