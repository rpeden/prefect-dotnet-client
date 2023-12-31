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
    ///  Class for testing TaskRunsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TaskRunsApiTests : IDisposable
    {
        private TaskRunsApi instance;

        public TaskRunsApiTests()
        {
            instance = new TaskRunsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TaskRunsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TaskRunsApi
            //Assert.IsType<TaskRunsApi>(instance);
        }

        /// <summary>
        /// Test CountTaskRuns
        /// </summary>
        [Fact]
        public void CountTaskRunsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CountTaskRunsRequest countTaskRunsRequest = null;
            //var response = instance.CountTaskRuns(countTaskRunsRequest);
            //Assert.IsType<int>(response);
        }

        /// <summary>
        /// Test CreateTaskRun
        /// </summary>
        [Fact]
        public void CreateTaskRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TaskRunCreate taskRunCreate = null;
            //var response = instance.CreateTaskRun(taskRunCreate);
            //Assert.IsType<TaskRun>(response);
        }

        /// <summary>
        /// Test DeleteTaskRun
        /// </summary>
        [Fact]
        public void DeleteTaskRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.DeleteTaskRun(id);
        }

        /// <summary>
        /// Test ReadDashboardTaskRunCounts
        /// </summary>
        [Fact]
        public void ReadDashboardTaskRunCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReadDashboardTaskRunCountsRequest readDashboardTaskRunCountsRequest = null;
            //var response = instance.ReadDashboardTaskRunCounts(readDashboardTaskRunCountsRequest);
            //Assert.IsType<List<TaskRunCount>>(response);
        }

        /// <summary>
        /// Test ReadTaskRun
        /// </summary>
        [Fact]
        public void ReadTaskRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.ReadTaskRun(id);
            //Assert.IsType<TaskRun>(response);
        }

        /// <summary>
        /// Test ReadTaskRuns
        /// </summary>
        [Fact]
        public void ReadTaskRunsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReadTaskRunsRequest readTaskRunsRequest = null;
            //var response = instance.ReadTaskRuns(readTaskRunsRequest);
            //Assert.IsType<List<TaskRun>>(response);
        }

        /// <summary>
        /// Test SetTaskRunState
        /// </summary>
        [Fact]
        public void SetTaskRunStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //SetTaskRunStateRequest setTaskRunStateRequest = null;
            //var response = instance.SetTaskRunState(id, setTaskRunStateRequest);
            //Assert.IsType<OrchestrationResult>(response);
        }

        /// <summary>
        /// Test TaskRunHistory
        /// </summary>
        [Fact]
        public void TaskRunHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TaskRunHistoryRequest taskRunHistoryRequest = null;
            //var response = instance.TaskRunHistory(taskRunHistoryRequest);
            //Assert.IsType<List<HistoryResponse>>(response);
        }

        /// <summary>
        /// Test UpdateTaskRun
        /// </summary>
        [Fact]
        public void UpdateTaskRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //TaskRunUpdate taskRunUpdate = null;
            //instance.UpdateTaskRun(id, taskRunUpdate);
        }
    }
}
