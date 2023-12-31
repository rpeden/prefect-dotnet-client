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
    /// Defines deployment sorting options.
    /// </summary>
    /// <value>Defines deployment sorting options.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeploymentSort
    {
        /// <summary>
        /// Enum CreatedDescending for value: CREATED_DESC
        /// </summary>
        [EnumMember(Value = "CREATED_DESC")]
        CreatedDescending = 1,

        /// <summary>
        /// Enum UpdatedDescending for value: UPDATED_DESC
        /// </summary>
        [EnumMember(Value = "UPDATED_DESC")]
        UpdatedDescending = 2,

        /// <summary>
        /// Enum NameAscending for value: NAME_ASC
        /// </summary>
        [EnumMember(Value = "NAME_ASC")]
        NameAscending = 3,

        /// <summary>
        /// Enum NameDescending for value: NAME_DESC
        /// </summary>
        [EnumMember(Value = "NAME_DESC")]
        NameDescending = 4
    }

}
