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
    /// Data used by the Prefect REST API to create a flow run notification policy.
    /// </summary>
    [DataContract(Name = "FlowRunNotificationPolicyCreate")]
    public partial class FlowRunNotificationPolicyCreate : IEquatable<FlowRunNotificationPolicyCreate>, IValidatableObject
    {
                

        /// <summary>
        /// Whether the policy is currently active
        /// </summary>
        /// <value>Whether the policy is currently active</value>
        [DataMember(Name = "is_active", EmitDefaultValue = true)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// The flow run states that trigger notifications
        /// </summary>
        /// <value>The flow run states that trigger notifications</value>
        [DataMember(Name = "state_names", EmitDefaultValue = false)]
        public List<string>? StateNames { get; set; }

        /// <summary>
        /// The flow run tags that trigger notifications (set [] to disable)
        /// </summary>
        /// <value>The flow run tags that trigger notifications (set [] to disable)</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string>? Tags { get; set; }

        /// <summary>
        /// The block document ID used for sending notifications
        /// </summary>
        /// <value>The block document ID used for sending notifications</value>
        [DataMember(Name = "block_document_id", EmitDefaultValue = false)]
        public Guid? BlockDocumentId { get; set; }

        /// <summary>
        /// A templatable notification message. Use {braces} to add variables. Valid variables include: 'flow_id', 'flow_name', 'flow_run_id', 'flow_run_name', 'flow_run_notification_policy_id', 'flow_run_parameters', 'flow_run_state_message', 'flow_run_state_name', 'flow_run_state_timestamp', 'flow_run_state_type', 'flow_run_url'
        /// </summary>
        /// <value>A templatable notification message. Use {braces} to add variables. Valid variables include: &#39;flow_id&#39;, &#39;flow_name&#39;, &#39;flow_run_id&#39;, &#39;flow_run_name&#39;, &#39;flow_run_notification_policy_id&#39;, &#39;flow_run_parameters&#39;, &#39;flow_run_state_message&#39;, &#39;flow_run_state_name&#39;, &#39;flow_run_state_timestamp&#39;, &#39;flow_run_state_type&#39;, &#39;flow_run_url&#39;</value>
        /// <example>Flow run {flow_run_name} with id {flow_run_id} entered state {flow_run_state_name}.</example>
        [DataMember(Name = "message_template", EmitDefaultValue = false)]
        public string? MessageTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlowRunNotificationPolicyCreate {\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  StateNames: ").Append(StateNames).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  BlockDocumentId: ").Append(BlockDocumentId).Append("\n");
            sb.Append("  MessageTemplate: ").Append(MessageTemplate).Append("\n");
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
            return this.Equals(input as FlowRunNotificationPolicyCreate);
        }

        /// <summary>
        /// Returns true if FlowRunNotificationPolicyCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of FlowRunNotificationPolicyCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowRunNotificationPolicyCreate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.StateNames == input.StateNames ||
                    this.StateNames != null &&
                    input.StateNames != null &&
                    this.StateNames.SequenceEqual(input.StateNames)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.BlockDocumentId == input.BlockDocumentId ||
                    (this.BlockDocumentId != null &&
                    this.BlockDocumentId.Equals(input.BlockDocumentId))
                ) && 
                (
                    this.MessageTemplate == input.MessageTemplate ||
                    (this.MessageTemplate != null &&
                    this.MessageTemplate.Equals(input.MessageTemplate))
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
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
                if (this.StateNames != null)
                {
                    hashCode = (hashCode * 59) + this.StateNames.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.BlockDocumentId != null)
                {
                    hashCode = (hashCode * 59) + this.BlockDocumentId.GetHashCode();
                }
                if (this.MessageTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.MessageTemplate.GetHashCode();
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
