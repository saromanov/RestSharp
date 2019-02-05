using System.Net;
using System;
using System.Net;
namespace RestSharp {

    public class RestSharp {

        private Uri uri;
        private HttpClient client;
        public RestSharp(string urlString) {
            this.uri = new Uri(urlString);
            this.client = new HttpClient("");
        }

        public RestSharp(Uri uri) {
            this.uri = uri;
        }

        /// <summary>
        /// Creating of the Post request
        /// </summary>
        /// <param name="req">Instance of the RestRequest</param>
        public bool Post(RestRequest req) {
            var response = client.Do(req);
            return true;
        }
    }
}