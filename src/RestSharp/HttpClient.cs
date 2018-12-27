using System;
using System.Net;

namespace RestSharp {

    /// <summary>
    /// Implementation of HttpClient
    /// </summary>
    public class HttpClient {
        private WebRequest webRequest;
        private List<string> acceptedTypes;
        private Uri url{get; private set; }

        /// <summary>
        ///  Allowing of redirects
        /// </summary>
        public bool FollowRedirects { get; set; }

        /// <summary>
        /// UserAgent for requeststo use for requests made by this client instance
        /// </summary>
        public string UserAgent { get; set; }

        private static readonly string[] JsonContentTypes =
        {
            "application/json", "text/json", "text/x-json", "text/javascript", "*+json"
        };

        public HttpClient(url string){
            acceptedTypes = new List<string>();
            url = new Uri(url);

        }

        public HttpClient(Uri url){
            acceptedTypes = new List<string>();
            url = url;

        }

        /// <summary>
        /// Do provides executing of the request
        //  with defined type 
        /// </summary>
        public T Do<T>(IRestRequest request) {
            var result = request.Execute();
        }

        /// <summary>
        /// Do provides executing of the request
        /// </summary>
        public IRestResponse Do(IRestRequest request) {
            var result = request.Execute();
        }

        public Task<IRestResponse<T>> DoAsync(IRestRequest request) {}

    }
}