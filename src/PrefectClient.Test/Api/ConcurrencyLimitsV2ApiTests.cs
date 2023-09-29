/*
 * Prefect API Client for .NET
 *
 * For more information, visit: https://github.com/rpeden/prefect-client-dotnet
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using PrefectClient.Client;
using PrefectClient.Api;
// uncomment below to import models
//using PrefectClient.Model;

namespace PrefectClient.Test.Api
{
    /// <summary>
    ///  Class for testing ConcurrencyLimitsV2Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ConcurrencyLimitsV2ApiTests : IDisposable
    {
        private ConcurrencyLimitsV2Api instance;

        public ConcurrencyLimitsV2ApiTests()
        {
            instance = new ConcurrencyLimitsV2Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConcurrencyLimitsV2Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ConcurrencyLimitsV2Api
            //Assert.IsType<ConcurrencyLimitsV2Api>(instance);
        }

        /// <summary>
        /// Test BulkDecrementActiveSlots
        /// </summary>
        [Fact]
        public void BulkDecrementActiveSlotsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BulkDecrementActiveSlotsRequest bulkDecrementActiveSlotsRequest = null;
            //var response = instance.BulkDecrementActiveSlots(bulkDecrementActiveSlotsRequest);
            //Assert.IsType<List<MinimalConcurrencyLimitResponse>>(response);
        }

        /// <summary>
        /// Test BulkIncrementActiveSlots
        /// </summary>
        [Fact]
        public void BulkIncrementActiveSlotsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BulkIncrementActiveSlotsRequest bulkIncrementActiveSlotsRequest = null;
            //var response = instance.BulkIncrementActiveSlots(bulkIncrementActiveSlotsRequest);
            //Assert.IsType<List<MinimalConcurrencyLimitResponse>>(response);
        }

        /// <summary>
        /// Test CreateConcurrencyLimitV2
        /// </summary>
        [Fact]
        public void CreateConcurrencyLimitV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ConcurrencyLimitV2Create concurrencyLimitV2Create = null;
            //var response = instance.CreateConcurrencyLimitV2(concurrencyLimitV2Create);
            //Assert.IsType<ConcurrencyLimitV2>(response);
        }

        /// <summary>
        /// Test DeleteConcurrencyLimitV2
        /// </summary>
        [Fact]
        public void DeleteConcurrencyLimitV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IdOrName idOrName = null;
            //instance.DeleteConcurrencyLimitV2(idOrName);
        }

        /// <summary>
        /// Test ReadAllConcurrencyLimitsV2
        /// </summary>
        [Fact]
        public void ReadAllConcurrencyLimitsV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReadAllConcurrencyLimitsV2Request readAllConcurrencyLimitsV2Request = null;
            //var response = instance.ReadAllConcurrencyLimitsV2(readAllConcurrencyLimitsV2Request);
            //Assert.IsType<List<ConcurrencyLimitV2>>(response);
        }

        /// <summary>
        /// Test ReadConcurrencyLimitV2
        /// </summary>
        [Fact]
        public void ReadConcurrencyLimitV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IdOrName idOrName = null;
            //var response = instance.ReadConcurrencyLimitV2(idOrName);
            //Assert.IsType<ConcurrencyLimitV2>(response);
        }

        /// <summary>
        /// Test UpdateConcurrencyLimitV2
        /// </summary>
        [Fact]
        public void UpdateConcurrencyLimitV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IdOrName idOrName = null;
            //ConcurrencyLimitV2Update concurrencyLimitV2Update = null;
            //instance.UpdateConcurrencyLimitV2(idOrName, concurrencyLimitV2Update);
        }
    }
}
