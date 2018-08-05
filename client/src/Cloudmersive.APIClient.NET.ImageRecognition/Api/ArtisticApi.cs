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

namespace Cloudmersive.APIClient.NET.ImageRecognition.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IArtisticApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Transform an image into an artistic painting automatically
        /// </summary>
        /// <remarks>
        /// Uses machine learning to automatically transform an image into an artistic painting.  Due to depth of AI processing, depending on image size this operation can take up to 20 seconds.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.ImageRecognition.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="style">The style of the painting to apply.  To start, try \&quot;udnie\&quot; a painting style.  Possible values are: \&quot;udnie\&quot;, \&quot;wave\&quot;, \&quot;la_muse\&quot;, \&quot;rain_princess\&quot;.</param>
        /// <param name="imageFile">Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.</param>
        /// <returns>Object</returns>
        Object ArtisticPainting (string style, System.IO.Stream imageFile);

        /// <summary>
        /// Transform an image into an artistic painting automatically
        /// </summary>
        /// <remarks>
        /// Uses machine learning to automatically transform an image into an artistic painting.  Due to depth of AI processing, depending on image size this operation can take up to 20 seconds.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.ImageRecognition.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="style">The style of the painting to apply.  To start, try \&quot;udnie\&quot; a painting style.  Possible values are: \&quot;udnie\&quot;, \&quot;wave\&quot;, \&quot;la_muse\&quot;, \&quot;rain_princess\&quot;.</param>
        /// <param name="imageFile">Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ArtisticPaintingWithHttpInfo (string style, System.IO.Stream imageFile);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Transform an image into an artistic painting automatically
        /// </summary>
        /// <remarks>
        /// Uses machine learning to automatically transform an image into an artistic painting.  Due to depth of AI processing, depending on image size this operation can take up to 20 seconds.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.ImageRecognition.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="style">The style of the painting to apply.  To start, try \&quot;udnie\&quot; a painting style.  Possible values are: \&quot;udnie\&quot;, \&quot;wave\&quot;, \&quot;la_muse\&quot;, \&quot;rain_princess\&quot;.</param>
        /// <param name="imageFile">Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ArtisticPaintingAsync (string style, System.IO.Stream imageFile);

        /// <summary>
        /// Transform an image into an artistic painting automatically
        /// </summary>
        /// <remarks>
        /// Uses machine learning to automatically transform an image into an artistic painting.  Due to depth of AI processing, depending on image size this operation can take up to 20 seconds.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.ImageRecognition.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="style">The style of the painting to apply.  To start, try \&quot;udnie\&quot; a painting style.  Possible values are: \&quot;udnie\&quot;, \&quot;wave\&quot;, \&quot;la_muse\&quot;, \&quot;rain_princess\&quot;.</param>
        /// <param name="imageFile">Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ArtisticPaintingAsyncWithHttpInfo (string style, System.IO.Stream imageFile);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ArtisticApi : IArtisticApi
    {
        private Cloudmersive.APIClient.NET.ImageRecognition.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtisticApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ArtisticApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Cloudmersive.APIClient.NET.ImageRecognition.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtisticApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ArtisticApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
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
        public Configuration Configuration {get; set;}

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
        /// Transform an image into an artistic painting automatically Uses machine learning to automatically transform an image into an artistic painting.  Due to depth of AI processing, depending on image size this operation can take up to 20 seconds.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.ImageRecognition.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="style">The style of the painting to apply.  To start, try \&quot;udnie\&quot; a painting style.  Possible values are: \&quot;udnie\&quot;, \&quot;wave\&quot;, \&quot;la_muse\&quot;, \&quot;rain_princess\&quot;.</param>
        /// <param name="imageFile">Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.</param>
        /// <returns>Object</returns>
        public Object ArtisticPainting (string style, System.IO.Stream imageFile)
        {
             ApiResponse<Object> localVarResponse = ArtisticPaintingWithHttpInfo(style, imageFile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Transform an image into an artistic painting automatically Uses machine learning to automatically transform an image into an artistic painting.  Due to depth of AI processing, depending on image size this operation can take up to 20 seconds.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.ImageRecognition.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="style">The style of the painting to apply.  To start, try \&quot;udnie\&quot; a painting style.  Possible values are: \&quot;udnie\&quot;, \&quot;wave\&quot;, \&quot;la_muse\&quot;, \&quot;rain_princess\&quot;.</param>
        /// <param name="imageFile">Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ArtisticPaintingWithHttpInfo (string style, System.IO.Stream imageFile)
        {
            // verify the required parameter 'style' is set
            if (style == null)
                throw new ApiException(400, "Missing required parameter 'style' when calling ArtisticApi->ArtisticPainting");
            // verify the required parameter 'imageFile' is set
            if (imageFile == null)
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling ArtisticApi->ArtisticPainting");

            var localVarPath = "/image/artistic/painting/{style}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/octet-stream"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (style != null) localVarPathParams.Add("style", Configuration.ApiClient.ParameterToString(style)); // path parameter
            if (imageFile != null) localVarFileParams.Add("imageFile", Configuration.ApiClient.ParameterToFile("imageFile", imageFile));

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ArtisticPainting", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Transform an image into an artistic painting automatically Uses machine learning to automatically transform an image into an artistic painting.  Due to depth of AI processing, depending on image size this operation can take up to 20 seconds.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.ImageRecognition.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="style">The style of the painting to apply.  To start, try \&quot;udnie\&quot; a painting style.  Possible values are: \&quot;udnie\&quot;, \&quot;wave\&quot;, \&quot;la_muse\&quot;, \&quot;rain_princess\&quot;.</param>
        /// <param name="imageFile">Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ArtisticPaintingAsync (string style, System.IO.Stream imageFile)
        {
             ApiResponse<Object> localVarResponse = await ArtisticPaintingAsyncWithHttpInfo(style, imageFile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Transform an image into an artistic painting automatically Uses machine learning to automatically transform an image into an artistic painting.  Due to depth of AI processing, depending on image size this operation can take up to 20 seconds.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.ImageRecognition.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="style">The style of the painting to apply.  To start, try \&quot;udnie\&quot; a painting style.  Possible values are: \&quot;udnie\&quot;, \&quot;wave\&quot;, \&quot;la_muse\&quot;, \&quot;rain_princess\&quot;.</param>
        /// <param name="imageFile">Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ArtisticPaintingAsyncWithHttpInfo (string style, System.IO.Stream imageFile)
        {
            // verify the required parameter 'style' is set
            if (style == null)
                throw new ApiException(400, "Missing required parameter 'style' when calling ArtisticApi->ArtisticPainting");
            // verify the required parameter 'imageFile' is set
            if (imageFile == null)
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling ArtisticApi->ArtisticPainting");

            var localVarPath = "/image/artistic/painting/{style}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/octet-stream"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (style != null) localVarPathParams.Add("style", Configuration.ApiClient.ParameterToString(style)); // path parameter
            if (imageFile != null) localVarFileParams.Add("imageFile", Configuration.ApiClient.ParameterToFile("imageFile", imageFile));

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ArtisticPainting", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

    }
}
