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
    ///  Class for testing WorkQueuesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WorkQueuesApiTests : IDisposable
    {
        private WorkQueuesApi instance;

        public WorkQueuesApiTests()
        {
            instance = new WorkQueuesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WorkQueuesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WorkQueuesApi
            //Assert.IsType<WorkQueuesApi>(instance);
        }

        /// <summary>
        /// Test CreateWorkQueue
        /// </summary>
        [Fact]
        public void CreateWorkQueueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WorkQueueCreate workQueueCreate = null;
            //var response = instance.CreateWorkQueue(workQueueCreate);
            //Assert.IsType<WorkQueueResponse>(response);
        }

        /// <summary>
        /// Test DeleteWorkQueue
        /// </summary>
        [Fact]
        public void DeleteWorkQueueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.DeleteWorkQueue(id);
        }

        /// <summary>
        /// Test ReadWorkQueue
        /// </summary>
        [Fact]
        public void ReadWorkQueueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.ReadWorkQueue(id);
            //Assert.IsType<WorkQueueResponse>(response);
        }

        /// <summary>
        /// Test ReadWorkQueueByName
        /// </summary>
        [Fact]
        public void ReadWorkQueueByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.ReadWorkQueueByName(name);
            //Assert.IsType<WorkQueueResponse>(response);
        }

        /// <summary>
        /// Test ReadWorkQueueRuns
        /// </summary>
        [Fact]
        public void ReadWorkQueueRunsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //bool? xPrefectUi = null;
            //ReadWorkQueueRunsRequest readWorkQueueRunsRequest = null;
            //var response = instance.ReadWorkQueueRuns(id, xPrefectUi, readWorkQueueRunsRequest);
            //Assert.IsType<List<FlowRunResponse>>(response);
        }

        /// <summary>
        /// Test ReadWorkQueueStatus
        /// </summary>
        [Fact]
        public void ReadWorkQueueStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.ReadWorkQueueStatus(id);
            //Assert.IsType<WorkQueueStatusDetail>(response);
        }

        /// <summary>
        /// Test ReadWorkQueues
        /// </summary>
        [Fact]
        public void ReadWorkQueuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReadWorkQueuesRequest readWorkQueuesRequest = null;
            //var response = instance.ReadWorkQueues(readWorkQueuesRequest);
            //Assert.IsType<List<WorkQueueResponse>>(response);
        }

        /// <summary>
        /// Test UpdateWorkQueue
        /// </summary>
        [Fact]
        public void UpdateWorkQueueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //WorkQueueUpdate workQueueUpdate = null;
            //instance.UpdateWorkQueue(id, workQueueUpdate);
        }
    }
}
