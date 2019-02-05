using System;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace RestSharp {

    /// <summary>
    /// Implementation of HttpClient
    /// </summary>
    public class HttpClientInner {
        
        private WebRequest webRequest;
        private List<string> acceptedTypes;
        private Uri url{get; }

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

        public HttpClientInner(string urlString){
            acceptedTypes = new List<string>();
            url = new Uri(urlString);

        }

        public HttpClientInner(Uri url){
            acceptedTypes = new List<string>();
            url = url;

        }

        /// <summary>
        /// Do provides executing of the request
        /// </summary>
        public IRestResponse Do(Methods method, IRestRequest request) {
            var result = request.Execute();
            return null;
        }

        public Task<IRestResponse> DoAsync(IRestRequest request) {
            return null;
        }

    }
}