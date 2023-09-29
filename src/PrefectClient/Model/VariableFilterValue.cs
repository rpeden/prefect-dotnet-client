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
    /// Filter by `Variable.value`.
    /// </summary>
    [DataContract(Name = "VariableFilterValue")]
    public partial class VariableFilterValue : IEquatable<VariableFilterValue>, IValidatableObject
    {
                

        /// <summary>
        /// A list of variables value to include
        /// </summary>
        /// <value>A list of variables value to include</value>
        [DataMember(Name = "any_", EmitDefaultValue = false)]
        public List<string>? Any { get; set; }

        /// <summary>
        /// A string to match variable value against. This can include SQL wildcard characters like `%` and `_`.
        /// </summary>
        /// <value>A string to match variable value against. This can include SQL wildcard characters like &#x60;%&#x60; and &#x60;_&#x60;.</value>
        /// <example>my-value-%</example>
        [DataMember(Name = "like_", EmitDefaultValue = false)]
        public string? Like { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VariableFilterValue {\n");
            sb.Append("  Any: ").Append(Any).Append("\n");
            sb.Append("  Like: ").Append(Like).Append("\n");
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
            return this.Equals(input as VariableFilterValue);
        }

        /// <summary>
        /// Returns true if VariableFilterValue instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableFilterValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableFilterValue input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Any == input.Any ||
                    this.Any != null &&
                    input.Any != null &&
                    this.Any.SequenceEqual(input.Any)
                ) && 
                (
                    this.Like == input.Like ||
                    (this.Like != null &&
                    this.Like.Equals(input.Like))
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
                if (this.Any != null)
                {
                    hashCode = (hashCode * 59) + this.Any.GetHashCode();
                }
                if (this.Like != null)
                {
                    hashCode = (hashCode * 59) + this.Like.GetHashCode();
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