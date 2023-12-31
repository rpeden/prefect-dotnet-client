/*
 * Prefect API Client for .NET
 *
 * For more information, visit: https://github.com/rpeden/prefect-client-dotnet
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using PrefectClient.Client;
using PrefectClient.Model;

namespace PrefectClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUIApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Read Dashboard Task Run Counts
        /// </summary>
        /// <exception cref="PrefectClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readDashboardTaskRunCountsRequest"></param>
        /// <returns>List&lt;TaskRunCount&gt;</returns>
        List<TaskRunCount> ReadDashboardTaskRunCounts(ReadDashboardTaskRunCountsRequest readDashboardTaskRunCountsRequest);

        /// <summary>
        /// Read Dashboard Task Run Counts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PrefectClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readDashboardTaskRunCountsRequest"></param>
        /// <returns>ApiResponse of List&lt;TaskRunCount&gt;</returns>
        ApiResponse<List<TaskRunCount>> ReadDashboardTaskRunCountsWithHttpInfo(ReadDashboardTaskRunCountsRequest readDashboardTaskRunCountsRequest);
        /// <summary>
        /// Read Flow Run History
        /// </summary>
        /// <exception cref="PrefectClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readFlowRunHistoryRequest"> (optional)</param>
        /// <returns>List&lt;SimpleFlowRun&gt;</returns>
        List<SimpleFlowRun> ReadFlowRunHistory(ReadFlowRunHistoryRequest readFlowRunHistoryRequest = default(ReadFlowRunHistoryRequest));

        /// <summary>
        /// Read Flow Run History
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PrefectClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readFlowRunHistoryRequest"> (optional)</param>
        /// <returns>ApiResponse of List&lt;SimpleFlowRun&gt;</returns>
        ApiResponse<List<SimpleFlowRun>> ReadFlowRunHistoryWithHttpInfo(ReadFlowRunHistoryRequest readFlowRunHistoryRequest = default(ReadFlowRunHistoryRequest));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUIApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Read Dashboard Task Run Counts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PrefectClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readDashboardTaskRunCountsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;TaskRunCount&gt;</returns>
        System.Threading.Tasks.Task<List<TaskRunCount>> ReadDashboardTaskRunCountsAsync(ReadDashboardTaskRunCountsRequest readDashboardTaskRunCountsRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Read Dashboard Task Run Counts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PrefectClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readDashboardTaskRunCountsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;TaskRunCount&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TaskRunCount>>> ReadDashboardTaskRunCountsWithHttpInfoAsync(ReadDashboardTaskRunCountsRequest readDashboardTaskRunCountsRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Read Flow Run History
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PrefectClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readFlowRunHistoryRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;SimpleFlowRun&gt;</returns>
        System.Threading.Tasks.Task<List<SimpleFlowRun>> ReadFlowRunHistoryAsync(ReadFlowRunHistoryRequest readFlowRunHistoryRequest = default(ReadFlowRunHistoryRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Read Flow Run History
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PrefectClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readFlowRunHistoryRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;SimpleFlowRun&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SimpleFlowRun>>> ReadFlowRunHistoryWithHttpInfoAsync(ReadFlowRunHistoryRequest readFlowRunHistoryRequest = default(ReadFlowRunHistoryRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUIApi : IUIApiSync, IUIApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UIApi : IDisposable, IUIApi
    {
        private PrefectClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UIApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public UIApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UIApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public UIApi(string basePath)
        {
            this.Configuration = PrefectClient.Client.Configuration.MergeConfigurations(
                PrefectClient.Client.GlobalConfiguration.Instance,
                new PrefectClient.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new PrefectClient.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = PrefectClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UIApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public UIApi(PrefectClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = PrefectClient.Client.Configuration.MergeConfigurations(
                PrefectClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new PrefectClient.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = PrefectClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UIApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public UIApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UIApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public UIApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = PrefectClient.Client.Configuration.MergeConfigurations(
                PrefectClient.Client.GlobalConfiguration.Instance,
                new PrefectClient.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new PrefectClient.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = PrefectClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UIApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public UIApi(HttpClient client, PrefectClient.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = PrefectClient.Client.Configuration.MergeConfigurations(
                PrefectClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new PrefectClient.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = PrefectClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UIApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public UIApi(PrefectClient.Client.ISynchronousClient client, PrefectClient.Client.IAsynchronousClient asyncClient, PrefectClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = PrefectClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public PrefectClient.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public PrefectClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public PrefectClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PrefectClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public PrefectClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Read Dashboard Task Run Counts 
        /// </summary>
        /// <exception cref="PrefectClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readDashboardTaskRunCountsRequest"></param>
        /// <returns>List&lt;TaskRunCount&gt;</returns>
        public List<TaskRunCount> ReadDashboardTaskRunCounts(ReadDashboardTaskRunCountsRequest readDashboardTaskRunCountsRequest)
        {
            PrefectClient.Client.ApiResponse<List<TaskRunCount>> localVarResponse = ReadDashboardTaskRunCountsWithHttpInfo(readDashboardTaskRunCountsRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Read Dashboard Task Run Counts 
        /// </summary>
        /// <exception cref="PrefectClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readDashboardTaskRunCountsRequest"></param>
        /// <returns>ApiResponse of List&lt;TaskRunCount&gt;</returns>
        public PrefectClient.Client.ApiResponse<List<TaskRunCount>> ReadDashboardTaskRunCountsWithHttpInfo(ReadDashboardTaskRunCountsRequest readDashboardTaskRunCountsRequest)
        {
            // verify the required parameter 'readDashboardTaskRunCountsRequest' is set
            if (readDashboardTaskRunCountsRequest == null)
                throw new PrefectClient.Client.ApiException(400, "Missing required parameter 'readDashboardTaskRunCountsRequest' when calling UIApi->ReadDashboardTaskRunCounts");

            PrefectClient.Client.RequestOptions localVarRequestOptions = new PrefectClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = PrefectClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = PrefectClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = readDashboardTaskRunCountsRequest;


            // make the HTTP request
            var localVarResponse = this.Client.Post<List<TaskRunCount>>("/ui/task_runs/dashboard/counts", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReadDashboardTaskRunCounts", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Read Dashboard Task Run Counts 
        /// </summary>
        /// <exception cref="PrefectClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readDashboardTaskRunCountsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;TaskRunCount&gt;</returns>
        public async System.Threading.Tasks.Task<List<TaskRunCount>> ReadDashboardTaskRunCountsAsync(ReadDashboardTaskRunCountsRequest readDashboardTaskRunCountsRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            PrefectClient.Client.ApiResponse<List<TaskRunCount>> localVarResponse = await ReadDashboardTaskRunCountsWithHttpInfoAsync(readDashboardTaskRunCountsRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Read Dashboard Task Run Counts 
        /// </summary>
        /// <exception cref="PrefectClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readDashboardTaskRunCountsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;TaskRunCount&gt;)</returns>
        public async System.Threading.Tasks.Task<PrefectClient.Client.ApiResponse<List<TaskRunCount>>> ReadDashboardTaskRunCountsWithHttpInfoAsync(ReadDashboardTaskRunCountsRequest readDashboardTaskRunCountsRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'readDashboardTaskRunCountsRequest' is set
            if (readDashboardTaskRunCountsRequest == null)
                throw new PrefectClient.Client.ApiException(400, "Missing required parameter 'readDashboardTaskRunCountsRequest' when calling UIApi->ReadDashboardTaskRunCounts");


            PrefectClient.Client.RequestOptions localVarRequestOptions = new PrefectClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = PrefectClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = PrefectClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = readDashboardTaskRunCountsRequest;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<List<TaskRunCount>>("/ui/task_runs/dashboard/counts", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReadDashboardTaskRunCounts", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Read Flow Run History 
        /// </summary>
        /// <exception cref="PrefectClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readFlowRunHistoryRequest"> (optional)</param>
        /// <returns>List&lt;SimpleFlowRun&gt;</returns>
        public List<SimpleFlowRun> ReadFlowRunHistory(ReadFlowRunHistoryRequest readFlowRunHistoryRequest = default(ReadFlowRunHistoryRequest))
        {
            PrefectClient.Client.ApiResponse<List<SimpleFlowRun>> localVarResponse = ReadFlowRunHistoryWithHttpInfo(readFlowRunHistoryRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Read Flow Run History 
        /// </summary>
        /// <exception cref="PrefectClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readFlowRunHistoryRequest"> (optional)</param>
        /// <returns>ApiResponse of List&lt;SimpleFlowRun&gt;</returns>
        public PrefectClient.Client.ApiResponse<List<SimpleFlowRun>> ReadFlowRunHistoryWithHttpInfo(ReadFlowRunHistoryRequest readFlowRunHistoryRequest = default(ReadFlowRunHistoryRequest))
        {
            PrefectClient.Client.RequestOptions localVarRequestOptions = new PrefectClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = PrefectClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = PrefectClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = readFlowRunHistoryRequest;


            // make the HTTP request
            var localVarResponse = this.Client.Post<List<SimpleFlowRun>>("/ui/flow_runs/history", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReadFlowRunHistory", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Read Flow Run History 
        /// </summary>
        /// <exception cref="PrefectClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readFlowRunHistoryRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;SimpleFlowRun&gt;</returns>
        public async System.Threading.Tasks.Task<List<SimpleFlowRun>> ReadFlowRunHistoryAsync(ReadFlowRunHistoryRequest readFlowRunHistoryRequest = default(ReadFlowRunHistoryRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            PrefectClient.Client.ApiResponse<List<SimpleFlowRun>> localVarResponse = await ReadFlowRunHistoryWithHttpInfoAsync(readFlowRunHistoryRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Read Flow Run History 
        /// </summary>
        /// <exception cref="PrefectClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readFlowRunHistoryRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;SimpleFlowRun&gt;)</returns>
        public async System.Threading.Tasks.Task<PrefectClient.Client.ApiResponse<List<SimpleFlowRun>>> ReadFlowRunHistoryWithHttpInfoAsync(ReadFlowRunHistoryRequest readFlowRunHistoryRequest = default(ReadFlowRunHistoryRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            PrefectClient.Client.RequestOptions localVarRequestOptions = new PrefectClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = PrefectClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = PrefectClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = readFlowRunHistoryRequest;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<List<SimpleFlowRun>>("/ui/flow_runs/history", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReadFlowRunHistory", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
