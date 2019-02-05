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
        public bool Post(RestRequest req) {
            var response = client.Do(Methods.POST, req);
            return true;
        }
    }
}