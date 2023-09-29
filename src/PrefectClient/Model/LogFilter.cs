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
    /// Filter logs. Only logs matching all criteria will be returned
    /// </summary>
    [DataContract(Name = "LogFilter")]
    public partial class LogFilter : IEquatable<LogFilter>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets FilterOperator
        /// </summary>  Operator
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public Operator? FilterOperator { get; set; }
        

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public LogFilterLevel Level { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public LogFilterTimestamp Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets FlowRunId
        /// </summary>
        [DataMember(Name = "flow_run_id", EmitDefaultValue = false)]
        public LogFilterFlowRunId FlowRunId { get; set; }

        /// <summary>
        /// Gets or Sets TaskRunId
        /// </summary>
        [DataMember(Name = "task_run_id", EmitDefaultValue = false)]
        public LogFilterTaskRunId TaskRunId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogFilter {\n");
            sb.Append("  FilterOperator: ").Append(FilterOperator).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  FlowRunId: ").Append(FlowRunId).Append("\n");
            sb.Append("  TaskRunId: ").Append(TaskRunId).Append("\n");
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
            return this.Equals(input as LogFilter);
        }

        /// <summary>
        /// Returns true if LogFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of LogFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogFilter input)
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
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.FlowRunId == input.FlowRunId ||
                    (this.FlowRunId != null &&
                    this.FlowRunId.Equals(input.FlowRunId))
                ) && 
                (
                    this.TaskRunId == input.TaskRunId ||
                    (this.TaskRunId != null &&
                    this.TaskRunId.Equals(input.TaskRunId))
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
                if (this.Level != null)
                {
                    hashCode = (hashCode * 59) + this.Level.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                if (this.FlowRunId != null)
                {
                    hashCode = (hashCode * 59) + this.FlowRunId.GetHashCode();
                }
                if (this.TaskRunId != null)
                {
                    hashCode = (hashCode * 59) + this.TaskRunId.GetHashCode();
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