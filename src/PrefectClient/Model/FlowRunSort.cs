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
    /// Defines flow run sorting options.
    /// </summary>
    /// <value>Defines flow run sorting options.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlowRunSort
    {
        /// <summary>
        /// Enum IdDescending for value: ID_DESC
        /// </summary>
        [EnumMember(Value = "ID_DESC")]
        IdDescending = 1,

        /// <summary>
        /// Enum StartTimeAscending for value: START_TIME_ASC
        /// </summary>
        [EnumMember(Value = "START_TIME_ASC")]
        StartTimeAscending = 2,

        /// <summary>
        /// Enum StartTimeDescending for value: START_TIME_DESC
        /// </summary>
        [EnumMember(Value = "START_TIME_DESC")]
        StartTimeDescending = 3,

        /// <summary>
        /// Enum ExpectedStartTimeAscending for value: EXPECTED_START_TIME_ASC
        /// </summary>
        [EnumMember(Value = "EXPECTED_START_TIME_ASC")]
        ExpectedStartTimeAscending = 4,

        /// <summary>
        /// Enum ExpectedStartTimeDescending for value: EXPECTED_START_TIME_DESC
        /// </summary>
        [EnumMember(Value = "EXPECTED_START_TIME_DESC")]
        ExpectedStartTimeDescending = 5,

        /// <summary>
        /// Enum NameAscending for value: NAME_ASC
        /// </summary>
        [EnumMember(Value = "NAME_ASC")]
        NameAscending = 6,

        /// <summary>
        /// Enum NameDescending for value: NAME_DESC
        /// </summary>
        [EnumMember(Value = "NAME_DESC")]
        NameDescending = 7,

        /// <summary>
        /// Enum NextScheduledStartTimeAscending for value: NEXT_SCHEDULED_START_TIME_ASC
        /// </summary>
        [EnumMember(Value = "NEXT_SCHEDULED_START_TIME_ASC")]
        NextScheduledStartTimeAscending = 8,

        /// <summary>
        /// Enum EndTimeDescending for value: END_TIME_DESC
        /// </summary>
        [EnumMember(Value = "END_TIME_DESC")]
        EndTimeDescending = 9
    }

}
