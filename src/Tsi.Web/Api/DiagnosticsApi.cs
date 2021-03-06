/* 
 * Tigerpaw API Method Reference
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 18.2.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Tsi.Web.Client;
using Tsi.Web.Model;

namespace Tsi.Web.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDiagnosticsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TsiWebResponse</returns>
        TsiWebResponse DiagnosticsDatabaseVersion ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TsiWebResponse</returns>
        ApiResponse<TsiWebResponse> DiagnosticsDatabaseVersionWithHttpInfo ();
        /// <summary>
        /// Returns the database version and license information.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TsiWebProductInformation</returns>
        TsiWebProductInformation DiagnosticsGetProductInformation ();

        /// <summary>
        /// Returns the database version and license information.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TsiWebProductInformation</returns>
        ApiResponse<TsiWebProductInformation> DiagnosticsGetProductInformationWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TsiWebResponse</returns>
        TsiWebResponse DiagnosticsValidateUser ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TsiWebResponse</returns>
        ApiResponse<TsiWebResponse> DiagnosticsValidateUserWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TsiWebResponse</returns>
        System.Threading.Tasks.Task<TsiWebResponse> DiagnosticsDatabaseVersionAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TsiWebResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TsiWebResponse>> DiagnosticsDatabaseVersionAsyncWithHttpInfo ();
        /// <summary>
        /// Returns the database version and license information.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TsiWebProductInformation</returns>
        System.Threading.Tasks.Task<TsiWebProductInformation> DiagnosticsGetProductInformationAsync ();

        /// <summary>
        /// Returns the database version and license information.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TsiWebProductInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<TsiWebProductInformation>> DiagnosticsGetProductInformationAsyncWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TsiWebResponse</returns>
        System.Threading.Tasks.Task<TsiWebResponse> DiagnosticsValidateUserAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TsiWebResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TsiWebResponse>> DiagnosticsValidateUserAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DiagnosticsApi : IDiagnosticsApi
    {
        private Tsi.Web.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DiagnosticsApi(String basePath)
        {
            this.Configuration = new Tsi.Web.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Tsi.Web.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DiagnosticsApi(Tsi.Web.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Tsi.Web.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Tsi.Web.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Tsi.Web.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Tsi.Web.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TsiWebResponse</returns>
        public TsiWebResponse DiagnosticsDatabaseVersion ()
        {
             ApiResponse<TsiWebResponse> localVarResponse = DiagnosticsDatabaseVersionWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TsiWebResponse</returns>
        public ApiResponse< TsiWebResponse > DiagnosticsDatabaseVersionWithHttpInfo ()
        {

            var localVarPath = "/api/diagnostics/database/version";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DiagnosticsDatabaseVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TsiWebResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TsiWebResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TsiWebResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TsiWebResponse</returns>
        public async System.Threading.Tasks.Task<TsiWebResponse> DiagnosticsDatabaseVersionAsync ()
        {
             ApiResponse<TsiWebResponse> localVarResponse = await DiagnosticsDatabaseVersionAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TsiWebResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TsiWebResponse>> DiagnosticsDatabaseVersionAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/diagnostics/database/version";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DiagnosticsDatabaseVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TsiWebResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TsiWebResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TsiWebResponse)));
        }

        /// <summary>
        /// Returns the database version and license information. 
        /// </summary>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TsiWebProductInformation</returns>
        public TsiWebProductInformation DiagnosticsGetProductInformation ()
        {
             ApiResponse<TsiWebProductInformation> localVarResponse = DiagnosticsGetProductInformationWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the database version and license information. 
        /// </summary>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TsiWebProductInformation</returns>
        public ApiResponse< TsiWebProductInformation > DiagnosticsGetProductInformationWithHttpInfo ()
        {

            var localVarPath = "/api/diagnostics/productInformation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DiagnosticsGetProductInformation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TsiWebProductInformation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TsiWebProductInformation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TsiWebProductInformation)));
        }

        /// <summary>
        /// Returns the database version and license information. 
        /// </summary>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TsiWebProductInformation</returns>
        public async System.Threading.Tasks.Task<TsiWebProductInformation> DiagnosticsGetProductInformationAsync ()
        {
             ApiResponse<TsiWebProductInformation> localVarResponse = await DiagnosticsGetProductInformationAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns the database version and license information. 
        /// </summary>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TsiWebProductInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TsiWebProductInformation>> DiagnosticsGetProductInformationAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/diagnostics/productInformation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DiagnosticsGetProductInformation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TsiWebProductInformation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TsiWebProductInformation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TsiWebProductInformation)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TsiWebResponse</returns>
        public TsiWebResponse DiagnosticsValidateUser ()
        {
             ApiResponse<TsiWebResponse> localVarResponse = DiagnosticsValidateUserWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TsiWebResponse</returns>
        public ApiResponse< TsiWebResponse > DiagnosticsValidateUserWithHttpInfo ()
        {

            var localVarPath = "/api/diagnostics/validate/user";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DiagnosticsValidateUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TsiWebResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TsiWebResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TsiWebResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TsiWebResponse</returns>
        public async System.Threading.Tasks.Task<TsiWebResponse> DiagnosticsValidateUserAsync ()
        {
             ApiResponse<TsiWebResponse> localVarResponse = await DiagnosticsValidateUserAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Tsi.Web.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TsiWebResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TsiWebResponse>> DiagnosticsValidateUserAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/diagnostics/validate/user";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DiagnosticsValidateUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TsiWebResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TsiWebResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TsiWebResponse)));
        }

    }
}
