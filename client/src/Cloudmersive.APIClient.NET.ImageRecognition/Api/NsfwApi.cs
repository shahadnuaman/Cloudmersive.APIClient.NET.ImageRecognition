/* 
 * imageapi
 *
 * Image Recognition and Processing APIs let you use Machine Learning to recognize and process images, and also perform useful image modification operations.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Cloudmersive.APIClient.NET.ImageRecognition.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INsfwApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Not safe for work (NSFW) racy content classification
        /// </summary>
        /// <remarks>
        /// Classify an image into Not Safe For Work (NSFW)/Porn/Racy content and Safe Content.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.ImageRecognition.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFile">Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.</param>
        /// <returns>NsfwResult</returns>
        NsfwResult NsfwClassify (System.IO.Stream imageFile);

        /// <summary>
        /// Not safe for work (NSFW) racy content classification
        /// </summary>
        /// <remarks>
        /// Classify an image into Not Safe For Work (NSFW)/Porn/Racy content and Safe Content.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.ImageRecognition.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFile">Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.</param>
        /// <returns>ApiResponse of NsfwResult</returns>
        ApiResponse<NsfwResult> NsfwClassifyWithHttpInfo (System.IO.Stream imageFile);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Not safe for work (NSFW) racy content classification
        /// </summary>
        /// <remarks>
        /// Classify an image into Not Safe For Work (NSFW)/Porn/Racy content and Safe Content.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.ImageRecognition.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFile">Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.</param>
        /// <returns>Task of NsfwResult</returns>
        System.Threading.Tasks.Task<NsfwResult> NsfwClassifyAsync (System.IO.Stream imageFile);

        /// <summary>
        /// Not safe for work (NSFW) racy content classification
        /// </summary>
        /// <remarks>
        /// Classify an image into Not Safe For Work (NSFW)/Porn/Racy content and Safe Content.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.ImageRecognition.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFile">Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.</param>
        /// <returns>Task of ApiResponse (NsfwResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<NsfwResult>> NsfwClassifyAsyncWithHttpInfo (System.IO.Stream imageFile);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NsfwApi : INsfwApi
    {
        private Cloudmersive.APIClient.NET.ImageRecognition.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NsfwApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NsfwApi(String basePath)
        {
            this.Configuration = new Cloudmersive.APIClient.NET.ImageRecognition.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Cloudmersive.APIClient.NET.ImageRecognition.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NsfwApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NsfwApi(Cloudmersive.APIClient.NET.ImageRecognition.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Cloudmersive.APIClient.NET.ImageRecognition.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Cloudmersive.APIClient.NET.ImageRecognition.Client.Configuration.DefaultExceptionFactory;
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
        public Cloudmersive.APIClient.NET.ImageRecognition.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Cloudmersive.APIClient.NET.ImageRecognition.Client.ExceptionFactory ExceptionFactory
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
        /// Not safe for work (NSFW) racy content classification Classify an image into Not Safe For Work (NSFW)/Porn/Racy content and Safe Content.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.ImageRecognition.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFile">Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.</param>
        /// <returns>NsfwResult</returns>
        public NsfwResult NsfwClassify (System.IO.Stream imageFile)
        {
             ApiResponse<NsfwResult> localVarResponse = NsfwClassifyWithHttpInfo(imageFile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Not safe for work (NSFW) racy content classification Classify an image into Not Safe For Work (NSFW)/Porn/Racy content and Safe Content.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.ImageRecognition.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFile">Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.</param>
        /// <returns>ApiResponse of NsfwResult</returns>
        public ApiResponse< NsfwResult > NsfwClassifyWithHttpInfo (System.IO.Stream imageFile)
        {
            // verify the required parameter 'imageFile' is set
            if (imageFile == null)
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling NsfwApi->NsfwClassify");

            var localVarPath = "/image/nsfw/classify";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (imageFile != null) localVarFileParams.Add("imageFile", this.Configuration.ApiClient.ParameterToFile("imageFile", imageFile));

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NsfwClassify", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<NsfwResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NsfwResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NsfwResult)));
        }

        /// <summary>
        /// Not safe for work (NSFW) racy content classification Classify an image into Not Safe For Work (NSFW)/Porn/Racy content and Safe Content.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.ImageRecognition.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFile">Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.</param>
        /// <returns>Task of NsfwResult</returns>
        public async System.Threading.Tasks.Task<NsfwResult> NsfwClassifyAsync (System.IO.Stream imageFile)
        {
             ApiResponse<NsfwResult> localVarResponse = await NsfwClassifyAsyncWithHttpInfo(imageFile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Not safe for work (NSFW) racy content classification Classify an image into Not Safe For Work (NSFW)/Porn/Racy content and Safe Content.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.ImageRecognition.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFile">Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.</param>
        /// <returns>Task of ApiResponse (NsfwResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NsfwResult>> NsfwClassifyAsyncWithHttpInfo (System.IO.Stream imageFile)
        {
            // verify the required parameter 'imageFile' is set
            if (imageFile == null)
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling NsfwApi->NsfwClassify");

            var localVarPath = "/image/nsfw/classify";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (imageFile != null) localVarFileParams.Add("imageFile", this.Configuration.ApiClient.ParameterToFile("imageFile", imageFile));

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NsfwClassify", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<NsfwResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NsfwResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NsfwResult)));
        }

    }
}
