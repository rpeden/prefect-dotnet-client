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
    ///  Class for testing FlowsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FlowsApiTests : IDisposable
    {
        private FlowsApi instance;

        public FlowsApiTests()
        {
            instance = new FlowsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FlowsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FlowsApi
            //Assert.IsType<FlowsApi>(instance);
        }

        /// <summary>
        /// Test CountFlows
        /// </summary>
        [Fact]
        public void CountFlowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CountFlowsRequest countFlowsRequest = null;
            //var response = instance.CountFlows(countFlowsRequest);
            //Assert.IsType<int>(response);
        }

        /// <summary>
        /// Test CreateFlow
        /// </summary>
        [Fact]
        public void CreateFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FlowCreate flowCreate = null;
            //var response = instance.CreateFlow(flowCreate);
            //Assert.IsType<Flow>(response);
        }

        /// <summary>
        /// Test DeleteFlow
        /// </summary>
        [Fact]
        public void DeleteFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.DeleteFlow(id);
        }

        /// <summary>
        /// Test ReadFlow
        /// </summary>
        [Fact]
        public void ReadFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.ReadFlow(id);
            //Assert.IsType<Flow>(response);
        }

        /// <summary>
        /// Test ReadFlowByName
        /// </summary>
        [Fact]
        public void ReadFlowByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.ReadFlowByName(name);
            //Assert.IsType<Flow>(response);
        }

        /// <summary>
        /// Test ReadFlows
        /// </summary>
        [Fact]
        public void ReadFlowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReadFlowsRequest readFlowsRequest = null;
            //var response = instance.ReadFlows(readFlowsRequest);
            //Assert.IsType<List<Flow>>(response);
        }

        /// <summary>
        /// Test UpdateFlow
        /// </summary>
        [Fact]
        public void UpdateFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //FlowUpdate flowUpdate = null;
            //instance.UpdateFlow(id, flowUpdate);
        }
    }
}
