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
    /// SetFlowRunStateRequest
    /// </summary>
    [DataContract(Name = "SetFlowRunStateRequest")]
    public partial class SetFlowRunStateRequest : IEquatable<SetFlowRunStateRequest>, IValidatableObject
    {
                /// <summary>
        /// Initializes a new instance of the <see cref="SetFlowRunStateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SetFlowRunStateRequest() { }
        

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public StateCreate State { get; set; }

        /// <summary>
        /// If false, orchestration rules will be applied that may alter or prevent the state transition. If True, orchestration rules are not applied.
        /// </summary>
        /// <value>If false, orchestration rules will be applied that may alter or prevent the state transition. If True, orchestration rules are not applied.</value>
        [DataMember(Name = "force", EmitDefaultValue = true)]
        public bool? Force { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SetFlowRunStateRequest {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Force: ").Append(Force).Append("\n");
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
            return this.Equals(input as SetFlowRunStateRequest);
        }

        /// <summary>
        /// Returns true if SetFlowRunStateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SetFlowRunStateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetFlowRunStateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Force == input.Force ||
                    this.Force.Equals(input.Force)
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
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Force.GetHashCode();
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
