using System.Net;
using System;
using System.Net;
namespace RestSharp {

    public class RestSharp {

        private Uri uri;
        private HttpClientInner client;
        public RestSharp(string urlString) {
            this.uri = new Uri(urlString);
            this.client = new HttpClientInner("");
        }

        public RestSharp(Uri uri) {
            this.uri = uri;
        }

        /// <summary>
        /// Creating of the Post request
        /// </summary>
        /// <param name="req">Instance of the RestRequest</param>
        public IRestResponse Post(RestRequest req) {
            return client.Do(Methods.POST, req);
        }

        /// <summary>
        /// Creating of the Get request
        /// </summary>
        /// <param name="req">Instance of the RestRequest</param>
        public IRestResponse Get(RestRequest req) {
            return client.Do(Methods.GET, req);
        }
    }
}