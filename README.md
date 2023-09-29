# PrefectClient - A C# library for the Prefect REST API

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project. It focuses on endpoints available in both Prefect open source and Prefect cloud, and does not yet support cloud-only API endpoints. Although it's written in C#, it should also work well in F# and VB.NET.

- API version: 0.1.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported
- .NET Core/.NET >=1.0 
- .NET Framework >=4.6
- Mono/Xamarin

<a id="dependencies"></a>
## Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

If needed, you can use NuGet to obtain the latest version of the packages:
```
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```
<a id="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`), or build it in Visual Studio.

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using PrefectClient.Api;
using PrefectClient.Client;
using PrefectClient.Model;
```
<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
var c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

### Connections
Each `Api` class will create an instance of HttpClient. It will use that for the entire lifecycle and dispose it when called the Dispose method.

To better manage the connections it's a common practice to reuse the HttpClient and HttpClientHandler (see [here](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net) for details). To use your own HttpClient instance just pass it to the ApiClass constructor.

```csharp
HttpClientHandler yourHandler = new HttpClientHandler();
HttpClient yourHttpClient = new HttpClient(yourHandler);
var api = new YourApiClass(yourHttpClient, yourHandler);
```

If you want to use an HttpClient and don't have access to the handler, for example in a DI context in Asp.net Core when using IHttpClientFactory:

```csharp
HttpClient yourHttpClient = new HttpClient();
var api = new YourApiClass(yourHttpClient);
```
You'll lose some configuration settings, the features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings. You need to either manually handle those in your setup of the HttpClient or they won't be available.

Here an example of DI setup in a sample web project:

```csharp
services.AddHttpClient<YourApiClass>(httpClient =>
   new PetApi(httpClient));
```


<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using PrefectClient.Api;
using PrefectClient.Client;
using PrefectClient.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            var apiInstance = new AdminApi("http://localhost:4200/api");
            var clearDatabaseRequest = new ClearDatabaseRequest();

            try
            {
                // Clear Database
                apiInstance.ClearDatabase(clearDatabaseRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdminApi.ClearDatabase: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to */api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AdminApi* | [**ClearDatabase**](docs/AdminApi.md#cleardatabase) | **POST** /admin/database/clear | Clear Database
*AdminApi* | [**CreateDatabase**](docs/AdminApi.md#createdatabase) | **POST** /admin/database/create | Create Database
*AdminApi* | [**DropDatabase**](docs/AdminApi.md#dropdatabase) | **POST** /admin/database/drop | Drop Database
*AdminApi* | [**ReadSettings**](docs/AdminApi.md#readsettings) | **GET** /admin/settings | Read Settings
*AdminApi* | [**ReadVersion**](docs/AdminApi.md#readversion) | **GET** /admin/version | Read Version
*ArtifactsApi* | [**CountArtifacts**](docs/ArtifactsApi.md#countartifacts) | **POST** /artifacts/count | Count Artifacts
*ArtifactsApi* | [**CountLatestArtifacts**](docs/ArtifactsApi.md#countlatestartifacts) | **POST** /artifacts/latest/count | Count Latest Artifacts
*ArtifactsApi* | [**CreateArtifact**](docs/ArtifactsApi.md#createartifact) | **POST** /artifacts/ | Create Artifact
*ArtifactsApi* | [**DeleteArtifact**](docs/ArtifactsApi.md#deleteartifact) | **DELETE** /artifacts/{id} | Delete Artifact
*ArtifactsApi* | [**ReadArtifact**](docs/ArtifactsApi.md#readartifact) | **GET** /artifacts/{id} | Read Artifact
*ArtifactsApi* | [**ReadArtifacts**](docs/ArtifactsApi.md#readartifacts) | **POST** /artifacts/filter | Read Artifacts
*ArtifactsApi* | [**ReadLatestArtifact**](docs/ArtifactsApi.md#readlatestartifact) | **GET** /artifacts/{key}/latest | Read Latest Artifact
*ArtifactsApi* | [**ReadLatestArtifacts**](docs/ArtifactsApi.md#readlatestartifacts) | **POST** /artifacts/latest/filter | Read Latest Artifacts
*ArtifactsApi* | [**UpdateArtifact**](docs/ArtifactsApi.md#updateartifact) | **PATCH** /artifacts/{id} | Update Artifact
*BlockCapabilitiesApi* | [**ReadAvailableBlockCapabilities**](docs/BlockCapabilitiesApi.md#readavailableblockcapabilities) | **GET** /block_capabilities/ | Read Available Block Capabilities
*BlockDocumentsApi* | [**CreateBlockDocument**](docs/BlockDocumentsApi.md#createblockdocument) | **POST** /block_documents/ | Create Block Document
*BlockDocumentsApi* | [**DeleteBlockDocument**](docs/BlockDocumentsApi.md#deleteblockdocument) | **DELETE** /block_documents/{id} | Delete Block Document
*BlockDocumentsApi* | [**ReadBlockDocumentById**](docs/BlockDocumentsApi.md#readblockdocumentbyid) | **GET** /block_documents/{id} | Read Block Document By Id
*BlockDocumentsApi* | [**ReadBlockDocumentByNameForBlockType**](docs/BlockDocumentsApi.md#readblockdocumentbynameforblocktype) | **GET** /block_types/slug/{slug}/block_documents/name/{block_document_name} | Read Block Document By Name For Block Type
*BlockDocumentsApi* | [**ReadBlockDocuments**](docs/BlockDocumentsApi.md#readblockdocuments) | **POST** /block_documents/filter | Read Block Documents
*BlockDocumentsApi* | [**ReadBlockDocumentsForBlockType**](docs/BlockDocumentsApi.md#readblockdocumentsforblocktype) | **GET** /block_types/slug/{slug}/block_documents | Read Block Documents For Block Type
*BlockDocumentsApi* | [**UpdateBlockDocumentData**](docs/BlockDocumentsApi.md#updateblockdocumentdata) | **PATCH** /block_documents/{id} | Update Block Document Data
*BlockSchemasApi* | [**CreateBlockSchema**](docs/BlockSchemasApi.md#createblockschema) | **POST** /block_schemas/ | Create Block Schema
*BlockSchemasApi* | [**DeleteBlockSchema**](docs/BlockSchemasApi.md#deleteblockschema) | **DELETE** /block_schemas/{id} | Delete Block Schema
*BlockSchemasApi* | [**ReadBlockSchemaByChecksum**](docs/BlockSchemasApi.md#readblockschemabychecksum) | **GET** /block_schemas/checksum/{checksum} | Read Block Schema By Checksum
*BlockSchemasApi* | [**ReadBlockSchemaById**](docs/BlockSchemasApi.md#readblockschemabyid) | **GET** /block_schemas/{id} | Read Block Schema By Id
*BlockSchemasApi* | [**ReadBlockSchemas**](docs/BlockSchemasApi.md#readblockschemas) | **POST** /block_schemas/filter | Read Block Schemas
*BlockTypesApi* | [**CreateBlockType**](docs/BlockTypesApi.md#createblocktype) | **POST** /block_types/ | Create Block Type
*BlockTypesApi* | [**DeleteBlockType**](docs/BlockTypesApi.md#deleteblocktype) | **DELETE** /block_types/{id} | Delete Block Type
*BlockTypesApi* | [**InstallSystemBlockTypes**](docs/BlockTypesApi.md#installsystemblocktypes) | **POST** /block_types/install_system_block_types | Install System Block Types
*BlockTypesApi* | [**ReadBlockDocumentByNameForBlockType**](docs/BlockTypesApi.md#readblockdocumentbynameforblocktype) | **GET** /block_types/slug/{slug}/block_documents/name/{block_document_name} | Read Block Document By Name For Block Type
*BlockTypesApi* | [**ReadBlockDocumentByNameForBlockType_0**](docs/BlockTypesApi.md#readblockdocumentbynameforblocktype_0) | **GET** /block_types/slug/{slug}/block_documents/name/{block_document_name} | Read Block Document By Name For Block Type
*BlockTypesApi* | [**ReadBlockDocumentsForBlockType**](docs/BlockTypesApi.md#readblockdocumentsforblocktype) | **GET** /block_types/slug/{slug}/block_documents | Read Block Documents For Block Type
*BlockTypesApi* | [**ReadBlockDocumentsForBlockType_0**](docs/BlockTypesApi.md#readblockdocumentsforblocktype_0) | **GET** /block_types/slug/{slug}/block_documents | Read Block Documents For Block Type
*BlockTypesApi* | [**ReadBlockTypeById**](docs/BlockTypesApi.md#readblocktypebyid) | **GET** /block_types/{id} | Read Block Type By Id
*BlockTypesApi* | [**ReadBlockTypeBySlug**](docs/BlockTypesApi.md#readblocktypebyslug) | **GET** /block_types/slug/{slug} | Read Block Type By Slug
*BlockTypesApi* | [**ReadBlockTypes**](docs/BlockTypesApi.md#readblocktypes) | **POST** /block_types/filter | Read Block Types
*BlockTypesApi* | [**UpdateBlockType**](docs/BlockTypesApi.md#updateblocktype) | **PATCH** /block_types/{id} | Update Block Type
*CollectionsApi* | [**ReadViewContent**](docs/CollectionsApi.md#readviewcontent) | **GET** /collections/views/{view} | Read View Content
*ConcurrencyLimitsApi* | [**CreateConcurrencyLimit**](docs/ConcurrencyLimitsApi.md#createconcurrencylimit) | **POST** /concurrency_limits/ | Create Concurrency Limit
*ConcurrencyLimitsApi* | [**DeleteConcurrencyLimit**](docs/ConcurrencyLimitsApi.md#deleteconcurrencylimit) | **DELETE** /concurrency_limits/{id} | Delete Concurrency Limit
*ConcurrencyLimitsApi* | [**DeleteConcurrencyLimitByTag**](docs/ConcurrencyLimitsApi.md#deleteconcurrencylimitbytag) | **DELETE** /concurrency_limits/tag/{tag} | Delete Concurrency Limit By Tag
*ConcurrencyLimitsApi* | [**ReadConcurrencyLimit**](docs/ConcurrencyLimitsApi.md#readconcurrencylimit) | **GET** /concurrency_limits/{id} | Read Concurrency Limit
*ConcurrencyLimitsApi* | [**ReadConcurrencyLimitByTag**](docs/ConcurrencyLimitsApi.md#readconcurrencylimitbytag) | **GET** /concurrency_limits/tag/{tag} | Read Concurrency Limit By Tag
*ConcurrencyLimitsApi* | [**ReadConcurrencyLimits**](docs/ConcurrencyLimitsApi.md#readconcurrencylimits) | **POST** /concurrency_limits/filter | Read Concurrency Limits
*ConcurrencyLimitsApi* | [**ResetConcurrencyLimitByTag**](docs/ConcurrencyLimitsApi.md#resetconcurrencylimitbytag) | **POST** /concurrency_limits/tag/{tag}/reset | Reset Concurrency Limit By Tag
*ConcurrencyLimitsV2Api* | [**BulkDecrementActiveSlots**](docs/ConcurrencyLimitsV2Api.md#bulkdecrementactiveslots) | **POST** /v2/concurrency_limits/decrement | Bulk Decrement Active Slots
*ConcurrencyLimitsV2Api* | [**BulkIncrementActiveSlots**](docs/ConcurrencyLimitsV2Api.md#bulkincrementactiveslots) | **POST** /v2/concurrency_limits/increment | Bulk Increment Active Slots
*ConcurrencyLimitsV2Api* | [**CreateConcurrencyLimitV2**](docs/ConcurrencyLimitsV2Api.md#createconcurrencylimitv2) | **POST** /v2/concurrency_limits/ | Create Concurrency Limit V2
*ConcurrencyLimitsV2Api* | [**DeleteConcurrencyLimitV2**](docs/ConcurrencyLimitsV2Api.md#deleteconcurrencylimitv2) | **DELETE** /v2/concurrency_limits/{id_or_name} | Delete Concurrency Limit V2
*ConcurrencyLimitsV2Api* | [**ReadAllConcurrencyLimitsV2**](docs/ConcurrencyLimitsV2Api.md#readallconcurrencylimitsv2) | **POST** /v2/concurrency_limits/filter | Read All Concurrency Limits V2
*ConcurrencyLimitsV2Api* | [**ReadConcurrencyLimitV2**](docs/ConcurrencyLimitsV2Api.md#readconcurrencylimitv2) | **GET** /v2/concurrency_limits/{id_or_name} | Read Concurrency Limit V2
*ConcurrencyLimitsV2Api* | [**UpdateConcurrencyLimitV2**](docs/ConcurrencyLimitsV2Api.md#updateconcurrencylimitv2) | **PATCH** /v2/concurrency_limits/{id_or_name} | Update Concurrency Limit V2
*DeploymentsApi* | [**CountDeployments**](docs/DeploymentsApi.md#countdeployments) | **POST** /deployments/count | Count Deployments
*DeploymentsApi* | [**CreateDeployment**](docs/DeploymentsApi.md#createdeployment) | **POST** /deployments/ | Create Deployment
*DeploymentsApi* | [**CreateFlowRunFromDeployment**](docs/DeploymentsApi.md#createflowrunfromdeployment) | **POST** /deployments/{id}/create_flow_run | Create Flow Run From Deployment
*DeploymentsApi* | [**DeleteDeployment**](docs/DeploymentsApi.md#deletedeployment) | **DELETE** /deployments/{id} | Delete Deployment
*DeploymentsApi* | [**ReadDeployment**](docs/DeploymentsApi.md#readdeployment) | **GET** /deployments/{id} | Read Deployment
*DeploymentsApi* | [**ReadDeploymentByName**](docs/DeploymentsApi.md#readdeploymentbyname) | **GET** /deployments/name/{flow_name}/{deployment_name} | Read Deployment By Name
*DeploymentsApi* | [**ReadDeployments**](docs/DeploymentsApi.md#readdeployments) | **POST** /deployments/filter | Read Deployments
*DeploymentsApi* | [**ScheduleDeployment**](docs/DeploymentsApi.md#scheduledeployment) | **POST** /deployments/{id}/schedule | Schedule Deployment
*DeploymentsApi* | [**SetScheduleActive**](docs/DeploymentsApi.md#setscheduleactive) | **POST** /deployments/{id}/set_schedule_active | Set Schedule Active
*DeploymentsApi* | [**SetScheduleInactive**](docs/DeploymentsApi.md#setscheduleinactive) | **POST** /deployments/{id}/set_schedule_inactive | Set Schedule Inactive
*DeploymentsApi* | [**UpdateDeployment**](docs/DeploymentsApi.md#updatedeployment) | **PATCH** /deployments/{id} | Update Deployment
*DeploymentsApi* | [**WorkQueueCheckForDeployment**](docs/DeploymentsApi.md#workqueuecheckfordeployment) | **GET** /deployments/{id}/work_queue_check | Work Queue Check For Deployment
*FlowRunNotificationPoliciesApi* | [**CreateFlowRunNotificationPolicy**](docs/FlowRunNotificationPoliciesApi.md#createflowrunnotificationpolicy) | **POST** /flow_run_notification_policies/ | Create Flow Run Notification Policy
*FlowRunNotificationPoliciesApi* | [**DeleteFlowRunNotificationPolicy**](docs/FlowRunNotificationPoliciesApi.md#deleteflowrunnotificationpolicy) | **DELETE** /flow_run_notification_policies/{id} | Delete Flow Run Notification Policy
*FlowRunNotificationPoliciesApi* | [**ReadFlowRunNotificationPolicies**](docs/FlowRunNotificationPoliciesApi.md#readflowrunnotificationpolicies) | **POST** /flow_run_notification_policies/filter | Read Flow Run Notification Policies
*FlowRunNotificationPoliciesApi* | [**ReadFlowRunNotificationPolicy**](docs/FlowRunNotificationPoliciesApi.md#readflowrunnotificationpolicy) | **GET** /flow_run_notification_policies/{id} | Read Flow Run Notification Policy
*FlowRunNotificationPoliciesApi* | [**UpdateFlowRunNotificationPolicy**](docs/FlowRunNotificationPoliciesApi.md#updateflowrunnotificationpolicy) | **PATCH** /flow_run_notification_policies/{id} | Update Flow Run Notification Policy
*FlowRunStatesApi* | [**ReadFlowRunState**](docs/FlowRunStatesApi.md#readflowrunstate) | **GET** /flow_run_states/{id} | Read Flow Run State
*FlowRunStatesApi* | [**ReadFlowRunStates**](docs/FlowRunStatesApi.md#readflowrunstates) | **GET** /flow_run_states/ | Read Flow Run States
*FlowRunsApi* | [**AverageFlowRunLateness**](docs/FlowRunsApi.md#averageflowrunlateness) | **POST** /flow_runs/lateness | Average Flow Run Lateness
*FlowRunsApi* | [**CountFlowRuns**](docs/FlowRunsApi.md#countflowruns) | **POST** /flow_runs/count | Count Flow Runs
*FlowRunsApi* | [**CreateFlowRun**](docs/FlowRunsApi.md#createflowrun) | **POST** /flow_runs/ | Create Flow Run
*FlowRunsApi* | [**DeleteFlowRun**](docs/FlowRunsApi.md#deleteflowrun) | **DELETE** /flow_runs/{id} | Delete Flow Run
*FlowRunsApi* | [**FlowRunHistory**](docs/FlowRunsApi.md#flowrunhistory) | **POST** /flow_runs/history | Flow Run History
*FlowRunsApi* | [**ReadFlowRun**](docs/FlowRunsApi.md#readflowrun) | **GET** /flow_runs/{id} | Read Flow Run
*FlowRunsApi* | [**ReadFlowRunGraph**](docs/FlowRunsApi.md#readflowrungraph) | **GET** /flow_runs/{id}/graph | Read Flow Run Graph
*FlowRunsApi* | [**ReadFlowRunHistory**](docs/FlowRunsApi.md#readflowrunhistory) | **POST** /ui/flow_runs/history | Read Flow Run History
*FlowRunsApi* | [**ReadFlowRuns**](docs/FlowRunsApi.md#readflowruns) | **POST** /flow_runs/filter | Read Flow Runs
*FlowRunsApi* | [**ResumeFlowRun**](docs/FlowRunsApi.md#resumeflowrun) | **POST** /flow_runs/{id}/resume | Resume Flow Run
*FlowRunsApi* | [**SetFlowRunState**](docs/FlowRunsApi.md#setflowrunstate) | **POST** /flow_runs/{id}/set_state | Set Flow Run State
*FlowRunsApi* | [**UpdateFlowRun**](docs/FlowRunsApi.md#updateflowrun) | **PATCH** /flow_runs/{id} | Update Flow Run
*FlowsApi* | [**CountFlows**](docs/FlowsApi.md#countflows) | **POST** /flows/count | Count Flows
*FlowsApi* | [**CreateFlow**](docs/FlowsApi.md#createflow) | **POST** /flows/ | Create Flow
*FlowsApi* | [**DeleteFlow**](docs/FlowsApi.md#deleteflow) | **DELETE** /flows/{id} | Delete Flow
*FlowsApi* | [**ReadFlow**](docs/FlowsApi.md#readflow) | **GET** /flows/{id} | Read Flow
*FlowsApi* | [**ReadFlowByName**](docs/FlowsApi.md#readflowbyname) | **GET** /flows/name/{name} | Read Flow By Name
*FlowsApi* | [**ReadFlows**](docs/FlowsApi.md#readflows) | **POST** /flows/filter | Read Flows
*FlowsApi* | [**UpdateFlow**](docs/FlowsApi.md#updateflow) | **PATCH** /flows/{id} | Update Flow
*LogsApi* | [**CreateLogs**](docs/LogsApi.md#createlogs) | **POST** /logs/ | Create Logs
*LogsApi* | [**ReadLogs**](docs/LogsApi.md#readlogs) | **POST** /logs/filter | Read Logs
*RootApi* | [**HealthCheck**](docs/RootApi.md#healthcheck) | **GET** /health | Health Check
*RootApi* | [**Hello**](docs/RootApi.md#hello) | **GET** /hello | Hello
*RootApi* | [**OrionInfo**](docs/RootApi.md#orioninfo) | **GET** /version | Orion Info
*RootApi* | [**PerformReadinessCheck**](docs/RootApi.md#performreadinesscheck) | **GET** /ready | Perform Readiness Check
*SavedSearchesApi* | [**CreateSavedSearch**](docs/SavedSearchesApi.md#createsavedsearch) | **PUT** /saved_searches/ | Create Saved Search
*SavedSearchesApi* | [**DeleteSavedSearch**](docs/SavedSearchesApi.md#deletesavedsearch) | **DELETE** /saved_searches/{id} | Delete Saved Search
*SavedSearchesApi* | [**ReadSavedSearch**](docs/SavedSearchesApi.md#readsavedsearch) | **GET** /saved_searches/{id} | Read Saved Search
*SavedSearchesApi* | [**ReadSavedSearches**](docs/SavedSearchesApi.md#readsavedsearches) | **POST** /saved_searches/filter | Read Saved Searches
*TaskRunStatesApi* | [**ReadTaskRunState**](docs/TaskRunStatesApi.md#readtaskrunstate) | **GET** /task_run_states/{id} | Read Task Run State
*TaskRunStatesApi* | [**ReadTaskRunStates**](docs/TaskRunStatesApi.md#readtaskrunstates) | **GET** /task_run_states/ | Read Task Run States
*TaskRunsApi* | [**CountTaskRuns**](docs/TaskRunsApi.md#counttaskruns) | **POST** /task_runs/count | Count Task Runs
*TaskRunsApi* | [**CreateTaskRun**](docs/TaskRunsApi.md#createtaskrun) | **POST** /task_runs/ | Create Task Run
*TaskRunsApi* | [**DeleteTaskRun**](docs/TaskRunsApi.md#deletetaskrun) | **DELETE** /task_runs/{id} | Delete Task Run
*TaskRunsApi* | [**ReadDashboardTaskRunCounts**](docs/TaskRunsApi.md#readdashboardtaskruncounts) | **POST** /ui/task_runs/dashboard/counts | Read Dashboard Task Run Counts
*TaskRunsApi* | [**ReadTaskRun**](docs/TaskRunsApi.md#readtaskrun) | **GET** /task_runs/{id} | Read Task Run
*TaskRunsApi* | [**ReadTaskRuns**](docs/TaskRunsApi.md#readtaskruns) | **POST** /task_runs/filter | Read Task Runs
*TaskRunsApi* | [**SetTaskRunState**](docs/TaskRunsApi.md#settaskrunstate) | **POST** /task_runs/{id}/set_state | Set Task Run State
*TaskRunsApi* | [**TaskRunHistory**](docs/TaskRunsApi.md#taskrunhistory) | **POST** /task_runs/history | Task Run History
*TaskRunsApi* | [**UpdateTaskRun**](docs/TaskRunsApi.md#updatetaskrun) | **PATCH** /task_runs/{id} | Update Task Run
*UIApi* | [**ReadDashboardTaskRunCounts**](docs/UIApi.md#readdashboardtaskruncounts) | **POST** /ui/task_runs/dashboard/counts | Read Dashboard Task Run Counts
*UIApi* | [**ReadFlowRunHistory**](docs/UIApi.md#readflowrunhistory) | **POST** /ui/flow_runs/history | Read Flow Run History
*VariablesApi* | [**CountVariables**](docs/VariablesApi.md#countvariables) | **POST** /variables/count | Count Variables
*VariablesApi* | [**CreateVariable**](docs/VariablesApi.md#createvariable) | **POST** /variables/ | Create Variable
*VariablesApi* | [**DeleteVariable**](docs/VariablesApi.md#deletevariable) | **DELETE** /variables/{id} | Delete Variable
*VariablesApi* | [**DeleteVariableByName**](docs/VariablesApi.md#deletevariablebyname) | **DELETE** /variables/name/{name} | Delete Variable By Name
*VariablesApi* | [**ReadVariable**](docs/VariablesApi.md#readvariable) | **GET** /variables/{id} | Read Variable
*VariablesApi* | [**ReadVariableByName**](docs/VariablesApi.md#readvariablebyname) | **GET** /variables/name/{name} | Read Variable By Name
*VariablesApi* | [**ReadVariables**](docs/VariablesApi.md#readvariables) | **POST** /variables/filter | Read Variables
*VariablesApi* | [**UpdateVariable**](docs/VariablesApi.md#updatevariable) | **PATCH** /variables/{id} | Update Variable
*VariablesApi* | [**UpdateVariableByName**](docs/VariablesApi.md#updatevariablebyname) | **PATCH** /variables/name/{name} | Update Variable By Name
*WorkPoolsApi* | [**CreateWorkPool**](docs/WorkPoolsApi.md#createworkpool) | **POST** /work_pools/ | Create Work Pool
*WorkPoolsApi* | [**CreateWorkPoolWorkQueue**](docs/WorkPoolsApi.md#createworkpoolworkqueue) | **POST** /work_pools/{work_pool_name}/queues | Create Work Queue
*WorkPoolsApi* | [**DeleteWorkPool**](docs/WorkPoolsApi.md#deleteworkpool) | **DELETE** /work_pools/{name} | Delete Work Pool
*WorkPoolsApi* | [**DeleteWorkPoolWorkQueue**](docs/WorkPoolsApi.md#deleteworkpoolworkqueue) | **DELETE** /work_pools/{work_pool_name}/queues/{name} | Delete Work Queue
*WorkPoolsApi* | [**GetScheduledFlowRuns**](docs/WorkPoolsApi.md#getscheduledflowruns) | **POST** /work_pools/{name}/get_scheduled_flow_runs | Get Scheduled Flow Runs
*WorkPoolsApi* | [**ReadWorkPool**](docs/WorkPoolsApi.md#readworkpool) | **GET** /work_pools/{name} | Read Work Pool
*WorkPoolsApi* | [**ReadWorkPoolWorkQueue**](docs/WorkPoolsApi.md#readworkpoolworkqueue) | **GET** /work_pools/{work_pool_name}/queues/{name} | Read Work Queue
*WorkPoolsApi* | [**ReadWorkPoolWorkQueues**](docs/WorkPoolsApi.md#readworkpoolworkqueues) | **POST** /work_pools/{work_pool_name}/queues/filter | Read Work Queues
*WorkPoolsApi* | [**ReadWorkPools**](docs/WorkPoolsApi.md#readworkpools) | **POST** /work_pools/filter | Read Work Pools
*WorkPoolsApi* | [**ReadWorkers**](docs/WorkPoolsApi.md#readworkers) | **POST** /work_pools/{work_pool_name}/workers/filter | Read Workers
*WorkPoolsApi* | [**UpdateWorkPool**](docs/WorkPoolsApi.md#updateworkpool) | **PATCH** /work_pools/{name} | Update Work Pool
*WorkPoolsApi* | [**UpdateWorkPoolWorkQueue**](docs/WorkPoolsApi.md#updateworkpoolworkqueue) | **PATCH** /work_pools/{work_pool_name}/queues/{name} | Update Work Queue
*WorkPoolsApi* | [**WorkerHeartbeat**](docs/WorkPoolsApi.md#workerheartbeat) | **POST** /work_pools/{work_pool_name}/workers/heartbeat | Worker Heartbeat
*WorkQueuesApi* | [**CreateWorkQueue**](docs/WorkQueuesApi.md#createworkqueue) | **POST** /work_queues/ | Create Work Queue
*WorkQueuesApi* | [**DeleteWorkQueue**](docs/WorkQueuesApi.md#deleteworkqueue) | **DELETE** /work_queues/{id} | Delete Work Queue
*WorkQueuesApi* | [**ReadWorkQueue**](docs/WorkQueuesApi.md#readworkqueue) | **GET** /work_queues/{id} | Read Work Queue
*WorkQueuesApi* | [**ReadWorkQueueByName**](docs/WorkQueuesApi.md#readworkqueuebyname) | **GET** /work_queues/name/{name} | Read Work Queue By Name
*WorkQueuesApi* | [**ReadWorkQueueRuns**](docs/WorkQueuesApi.md#readworkqueueruns) | **POST** /work_queues/{id}/get_runs | Read Work Queue Runs
*WorkQueuesApi* | [**ReadWorkQueueStatus**](docs/WorkQueuesApi.md#readworkqueuestatus) | **GET** /work_queues/{id}/status | Read Work Queue Status
*WorkQueuesApi* | [**ReadWorkQueues**](docs/WorkQueuesApi.md#readworkqueues) | **POST** /work_queues/filter | Read Work Queues
*WorkQueuesApi* | [**UpdateWorkQueue**](docs/WorkQueuesApi.md#updateworkqueue) | **PATCH** /work_queues/{id} | Update Work Queue


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.Artifact](docs/Artifact.md)
 - [Model.ArtifactCollection](docs/ArtifactCollection.md)
 - [Model.ArtifactCollectionFilter](docs/ArtifactCollectionFilter.md)
 - [Model.ArtifactCollectionFilterFlowRunId](docs/ArtifactCollectionFilterFlowRunId.md)
 - [Model.ArtifactCollectionFilterKey](docs/ArtifactCollectionFilterKey.md)
 - [Model.ArtifactCollectionFilterLatestId](docs/ArtifactCollectionFilterLatestId.md)
 - [Model.ArtifactCollectionFilterTaskRunId](docs/ArtifactCollectionFilterTaskRunId.md)
 - [Model.ArtifactCollectionFilterType](docs/ArtifactCollectionFilterType.md)
 - [Model.ArtifactCollectionSort](docs/ArtifactCollectionSort.md)
 - [Model.ArtifactCreate](docs/ArtifactCreate.md)
 - [Model.ArtifactFilter](docs/ArtifactFilter.md)
 - [Model.ArtifactFilterFlowRunId](docs/ArtifactFilterFlowRunId.md)
 - [Model.ArtifactFilterId](docs/ArtifactFilterId.md)
 - [Model.ArtifactFilterKey](docs/ArtifactFilterKey.md)
 - [Model.ArtifactFilterTaskRunId](docs/ArtifactFilterTaskRunId.md)
 - [Model.ArtifactFilterType](docs/ArtifactFilterType.md)
 - [Model.ArtifactSort](docs/ArtifactSort.md)
 - [Model.ArtifactUpdate](docs/ArtifactUpdate.md)
 - [Model.AverageFlowRunLatenessRequest](docs/AverageFlowRunLatenessRequest.md)
 - [Model.BlockDocument](docs/BlockDocument.md)
 - [Model.BlockDocumentCreate](docs/BlockDocumentCreate.md)
 - [Model.BlockDocumentFilter](docs/BlockDocumentFilter.md)
 - [Model.BlockDocumentFilterBlockTypeId](docs/BlockDocumentFilterBlockTypeId.md)
 - [Model.BlockDocumentFilterId](docs/BlockDocumentFilterId.md)
 - [Model.BlockDocumentFilterIsAnonymous](docs/BlockDocumentFilterIsAnonymous.md)
 - [Model.BlockDocumentFilterName](docs/BlockDocumentFilterName.md)
 - [Model.BlockDocumentUpdate](docs/BlockDocumentUpdate.md)
 - [Model.BlockSchema](docs/BlockSchema.md)
 - [Model.BlockSchemaCreate](docs/BlockSchemaCreate.md)
 - [Model.BlockSchemaFilter](docs/BlockSchemaFilter.md)
 - [Model.BlockSchemaFilterBlockTypeId](docs/BlockSchemaFilterBlockTypeId.md)
 - [Model.BlockSchemaFilterCapabilities](docs/BlockSchemaFilterCapabilities.md)
 - [Model.BlockSchemaFilterId](docs/BlockSchemaFilterId.md)
 - [Model.BlockSchemaFilterVersion](docs/BlockSchemaFilterVersion.md)
 - [Model.BlockType](docs/BlockType.md)
 - [Model.BlockTypeCreate](docs/BlockTypeCreate.md)
 - [Model.BlockTypeFilter](docs/BlockTypeFilter.md)
 - [Model.BlockTypeFilterName](docs/BlockTypeFilterName.md)
 - [Model.BlockTypeFilterSlug](docs/BlockTypeFilterSlug.md)
 - [Model.BlockTypeUpdate](docs/BlockTypeUpdate.md)
 - [Model.BulkDecrementActiveSlotsRequest](docs/BulkDecrementActiveSlotsRequest.md)
 - [Model.BulkIncrementActiveSlotsRequest](docs/BulkIncrementActiveSlotsRequest.md)
 - [Model.ClearDatabaseRequest](docs/ClearDatabaseRequest.md)
 - [Model.ConcurrencyLimit](docs/ConcurrencyLimit.md)
 - [Model.ConcurrencyLimitCreate](docs/ConcurrencyLimitCreate.md)
 - [Model.ConcurrencyLimitV2](docs/ConcurrencyLimitV2.md)
 - [Model.ConcurrencyLimitV2Create](docs/ConcurrencyLimitV2Create.md)
 - [Model.ConcurrencyLimitV2Update](docs/ConcurrencyLimitV2Update.md)
 - [Model.Constant](docs/Constant.md)
 - [Model.CountArtifactsRequest](docs/CountArtifactsRequest.md)
 - [Model.CountDeploymentsRequest](docs/CountDeploymentsRequest.md)
 - [Model.CountFlowRunsRequest](docs/CountFlowRunsRequest.md)
 - [Model.CountFlowsRequest](docs/CountFlowsRequest.md)
 - [Model.CountLatestArtifactsRequest](docs/CountLatestArtifactsRequest.md)
 - [Model.CountTaskRunsRequest](docs/CountTaskRunsRequest.md)
 - [Model.CountVariablesRequest](docs/CountVariablesRequest.md)
 - [Model.CreateDatabaseRequest](docs/CreateDatabaseRequest.md)
 - [Model.CreatedBy](docs/CreatedBy.md)
 - [Model.CronSchedule](docs/CronSchedule.md)
 - [Model.DependencyResult](docs/DependencyResult.md)
 - [Model.DeploymentCreate](docs/DeploymentCreate.md)
 - [Model.DeploymentFilter](docs/DeploymentFilter.md)
 - [Model.DeploymentFilterId](docs/DeploymentFilterId.md)
 - [Model.DeploymentFilterIsScheduleActive](docs/DeploymentFilterIsScheduleActive.md)
 - [Model.DeploymentFilterName](docs/DeploymentFilterName.md)
 - [Model.DeploymentFilterTags](docs/DeploymentFilterTags.md)
 - [Model.DeploymentFilterWorkQueueName](docs/DeploymentFilterWorkQueueName.md)
 - [Model.DeploymentFlowRunCreate](docs/DeploymentFlowRunCreate.md)
 - [Model.DeploymentResponse](docs/DeploymentResponse.md)
 - [Model.DeploymentSort](docs/DeploymentSort.md)
 - [Model.DeploymentUpdate](docs/DeploymentUpdate.md)
 - [Model.Details](docs/Details.md)
 - [Model.DropDatabaseRequest](docs/DropDatabaseRequest.md)
 - [Model.Flow](docs/Flow.md)
 - [Model.FlowCreate](docs/FlowCreate.md)
 - [Model.FlowFilter](docs/FlowFilter.md)
 - [Model.FlowFilterId](docs/FlowFilterId.md)
 - [Model.FlowFilterName](docs/FlowFilterName.md)
 - [Model.FlowFilterTags](docs/FlowFilterTags.md)
 - [Model.FlowRun](docs/FlowRun.md)
 - [Model.FlowRunCreate](docs/FlowRunCreate.md)
 - [Model.FlowRunFilter](docs/FlowRunFilter.md)
 - [Model.FlowRunFilterDeploymentId](docs/FlowRunFilterDeploymentId.md)
 - [Model.FlowRunFilterExpectedStartTime](docs/FlowRunFilterExpectedStartTime.md)
 - [Model.FlowRunFilterFlowVersion](docs/FlowRunFilterFlowVersion.md)
 - [Model.FlowRunFilterId](docs/FlowRunFilterId.md)
 - [Model.FlowRunFilterIdempotencyKey](docs/FlowRunFilterIdempotencyKey.md)
 - [Model.FlowRunFilterName](docs/FlowRunFilterName.md)
 - [Model.FlowRunFilterNextScheduledStartTime](docs/FlowRunFilterNextScheduledStartTime.md)
 - [Model.FlowRunFilterParentTaskRunId](docs/FlowRunFilterParentTaskRunId.md)
 - [Model.FlowRunFilterStartTime](docs/FlowRunFilterStartTime.md)
 - [Model.FlowRunFilterState](docs/FlowRunFilterState.md)
 - [Model.FlowRunFilterStateName](docs/FlowRunFilterStateName.md)
 - [Model.FlowRunFilterStateType](docs/FlowRunFilterStateType.md)
 - [Model.FlowRunFilterTags](docs/FlowRunFilterTags.md)
 - [Model.FlowRunFilterWorkQueueName](docs/FlowRunFilterWorkQueueName.md)
 - [Model.FlowRunHistoryRequest](docs/FlowRunHistoryRequest.md)
 - [Model.FlowRunNotificationPolicy](docs/FlowRunNotificationPolicy.md)
 - [Model.FlowRunNotificationPolicyCreate](docs/FlowRunNotificationPolicyCreate.md)
 - [Model.FlowRunNotificationPolicyFilter](docs/FlowRunNotificationPolicyFilter.md)
 - [Model.FlowRunNotificationPolicyFilterIsActive](docs/FlowRunNotificationPolicyFilterIsActive.md)
 - [Model.FlowRunNotificationPolicyUpdate](docs/FlowRunNotificationPolicyUpdate.md)
 - [Model.FlowRunPolicy](docs/FlowRunPolicy.md)
 - [Model.FlowRunResponse](docs/FlowRunResponse.md)
 - [Model.FlowRunSort](docs/FlowRunSort.md)
 - [Model.FlowRunUpdate](docs/FlowRunUpdate.md)
 - [Model.FlowSort](docs/FlowSort.md)
 - [Model.FlowUpdate](docs/FlowUpdate.md)
 - [Model.GetScheduledFlowRunsRequest](docs/GetScheduledFlowRunsRequest.md)
 - [Model.HTTPValidationError](docs/HTTPValidationError.md)
 - [Model.HistoryResponse](docs/HistoryResponse.md)
 - [Model.HistoryResponseState](docs/HistoryResponseState.md)
 - [Model.IdOrName](docs/IdOrName.md)
 - [Model.IntervalSchedule](docs/IntervalSchedule.md)
 - [Model.LocationInner](docs/LocationInner.md)
 - [Model.Log](docs/Log.md)
 - [Model.LogCreate](docs/LogCreate.md)
 - [Model.LogFilter](docs/LogFilter.md)
 - [Model.LogFilterFlowRunId](docs/LogFilterFlowRunId.md)
 - [Model.LogFilterLevel](docs/LogFilterLevel.md)
 - [Model.LogFilterTaskRunId](docs/LogFilterTaskRunId.md)
 - [Model.LogFilterTimestamp](docs/LogFilterTimestamp.md)
 - [Model.LogSort](docs/LogSort.md)
 - [Model.MinimalConcurrencyLimitResponse](docs/MinimalConcurrencyLimitResponse.md)
 - [Model.Operator](docs/Operator.md)
 - [Model.OrchestrationResult](docs/OrchestrationResult.md)
 - [Model.Parameter](docs/Parameter.md)
 - [Model.PrefectFlowDefaultRetryDelaySeconds](docs/PrefectFlowDefaultRetryDelaySeconds.md)
 - [Model.PrefectTaskDefaultRetryDelaySeconds](docs/PrefectTaskDefaultRetryDelaySeconds.md)
 - [Model.QueueFilter](docs/QueueFilter.md)
 - [Model.RRuleSchedule](docs/RRuleSchedule.md)
 - [Model.ReadAllConcurrencyLimitsV2Request](docs/ReadAllConcurrencyLimitsV2Request.md)
 - [Model.ReadArtifactsRequest](docs/ReadArtifactsRequest.md)
 - [Model.ReadBlockDocumentsRequest](docs/ReadBlockDocumentsRequest.md)
 - [Model.ReadBlockSchemasRequest](docs/ReadBlockSchemasRequest.md)
 - [Model.ReadBlockTypesRequest](docs/ReadBlockTypesRequest.md)
 - [Model.ReadConcurrencyLimitsRequest](docs/ReadConcurrencyLimitsRequest.md)
 - [Model.ReadDashboardTaskRunCountsRequest](docs/ReadDashboardTaskRunCountsRequest.md)
 - [Model.ReadDeploymentsRequest](docs/ReadDeploymentsRequest.md)
 - [Model.ReadFlowRunHistoryRequest](docs/ReadFlowRunHistoryRequest.md)
 - [Model.ReadFlowRunNotificationPoliciesRequest](docs/ReadFlowRunNotificationPoliciesRequest.md)
 - [Model.ReadFlowRunsRequest](docs/ReadFlowRunsRequest.md)
 - [Model.ReadFlowsRequest](docs/ReadFlowsRequest.md)
 - [Model.ReadLatestArtifactsRequest](docs/ReadLatestArtifactsRequest.md)
 - [Model.ReadLogsRequest](docs/ReadLogsRequest.md)
 - [Model.ReadSavedSearchesRequest](docs/ReadSavedSearchesRequest.md)
 - [Model.ReadTaskRunsRequest](docs/ReadTaskRunsRequest.md)
 - [Model.ReadVariablesRequest](docs/ReadVariablesRequest.md)
 - [Model.ReadWorkPoolsRequest](docs/ReadWorkPoolsRequest.md)
 - [Model.ReadWorkQueueRunsRequest](docs/ReadWorkQueueRunsRequest.md)
 - [Model.ReadWorkQueuesRequest](docs/ReadWorkQueuesRequest.md)
 - [Model.ReadWorkersRequest](docs/ReadWorkersRequest.md)
 - [Model.ResetConcurrencyLimitByTagRequest](docs/ResetConcurrencyLimitByTagRequest.md)
 - [Model.RetryDelay](docs/RetryDelay.md)
 - [Model.SavedSearch](docs/SavedSearch.md)
 - [Model.SavedSearchCreate](docs/SavedSearchCreate.md)
 - [Model.SavedSearchFilter](docs/SavedSearchFilter.md)
 - [Model.Schedule](docs/Schedule.md)
 - [Model.ScheduleDeploymentRequest](docs/ScheduleDeploymentRequest.md)
 - [Model.SetFlowRunStateRequest](docs/SetFlowRunStateRequest.md)
 - [Model.SetStateStatus](docs/SetStateStatus.md)
 - [Model.SetTaskRunStateRequest](docs/SetTaskRunStateRequest.md)
 - [Model.Settings](docs/Settings.md)
 - [Model.SimpleFlowRun](docs/SimpleFlowRun.md)
 - [Model.State](docs/State.md)
 - [Model.StateAbortDetails](docs/StateAbortDetails.md)
 - [Model.StateAcceptDetails](docs/StateAcceptDetails.md)
 - [Model.StateCreate](docs/StateCreate.md)
 - [Model.StateDetails](docs/StateDetails.md)
 - [Model.StateRejectDetails](docs/StateRejectDetails.md)
 - [Model.StateType](docs/StateType.md)
 - [Model.StateWaitDetails](docs/StateWaitDetails.md)
 - [Model.TaskInputsInner](docs/TaskInputsInner.md)
 - [Model.TaskRun](docs/TaskRun.md)
 - [Model.TaskRunCount](docs/TaskRunCount.md)
 - [Model.TaskRunCreate](docs/TaskRunCreate.md)
 - [Model.TaskRunFilter](docs/TaskRunFilter.md)
 - [Model.TaskRunFilterId](docs/TaskRunFilterId.md)
 - [Model.TaskRunFilterName](docs/TaskRunFilterName.md)
 - [Model.TaskRunFilterStartTime](docs/TaskRunFilterStartTime.md)
 - [Model.TaskRunFilterState](docs/TaskRunFilterState.md)
 - [Model.TaskRunFilterStateName](docs/TaskRunFilterStateName.md)
 - [Model.TaskRunFilterStateType](docs/TaskRunFilterStateType.md)
 - [Model.TaskRunFilterSubFlowRuns](docs/TaskRunFilterSubFlowRuns.md)
 - [Model.TaskRunFilterTags](docs/TaskRunFilterTags.md)
 - [Model.TaskRunHistoryRequest](docs/TaskRunHistoryRequest.md)
 - [Model.TaskRunPolicy](docs/TaskRunPolicy.md)
 - [Model.TaskRunResult](docs/TaskRunResult.md)
 - [Model.TaskRunSort](docs/TaskRunSort.md)
 - [Model.TaskRunUpdate](docs/TaskRunUpdate.md)
 - [Model.UpdatedBy](docs/UpdatedBy.md)
 - [Model.ValidationError](docs/ValidationError.md)
 - [Model.Variable](docs/Variable.md)
 - [Model.VariableCreate](docs/VariableCreate.md)
 - [Model.VariableFilter](docs/VariableFilter.md)
 - [Model.VariableFilterId](docs/VariableFilterId.md)
 - [Model.VariableFilterName](docs/VariableFilterName.md)
 - [Model.VariableFilterTags](docs/VariableFilterTags.md)
 - [Model.VariableFilterValue](docs/VariableFilterValue.md)
 - [Model.VariableSort](docs/VariableSort.md)
 - [Model.VariableUpdate](docs/VariableUpdate.md)
 - [Model.WorkPool](docs/WorkPool.md)
 - [Model.WorkPoolCreate](docs/WorkPoolCreate.md)
 - [Model.WorkPoolFilter](docs/WorkPoolFilter.md)
 - [Model.WorkPoolFilterId](docs/WorkPoolFilterId.md)
 - [Model.WorkPoolFilterName](docs/WorkPoolFilterName.md)
 - [Model.WorkPoolFilterType](docs/WorkPoolFilterType.md)
 - [Model.WorkPoolUpdate](docs/WorkPoolUpdate.md)
 - [Model.WorkQueue](docs/WorkQueue.md)
 - [Model.WorkQueueCreate](docs/WorkQueueCreate.md)
 - [Model.WorkQueueFilter](docs/WorkQueueFilter.md)
 - [Model.WorkQueueFilterId](docs/WorkQueueFilterId.md)
 - [Model.WorkQueueFilterName](docs/WorkQueueFilterName.md)
 - [Model.WorkQueueHealthPolicy](docs/WorkQueueHealthPolicy.md)
 - [Model.WorkQueueResponse](docs/WorkQueueResponse.md)
 - [Model.WorkQueueStatusDetail](docs/WorkQueueStatusDetail.md)
 - [Model.WorkQueueUpdate](docs/WorkQueueUpdate.md)
 - [Model.Worker](docs/Worker.md)
 - [Model.WorkerFilter](docs/WorkerFilter.md)
 - [Model.WorkerFilterLastHeartbeatTime](docs/WorkerFilterLastHeartbeatTime.md)
 - [Model.WorkerFlowRunResponse](docs/WorkerFlowRunResponse.md)
 - [Model.WorkerHeartbeatRequest](docs/WorkerHeartbeatRequest.md)