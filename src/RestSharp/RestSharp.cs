using System.Net;
using System;
using System.Net;
namespace RestSharp {

    public class RestSharp {

        private Uri uri;
        public RestSharp(string urlString) {
            this.uri = new Uri(urlString);
        }

        public RestSharp(Uri uri) {
            this.uri = uri;
        }

        /// <summary>
        /// Creating of the Post request
        /// </summary>
        /// <param name="req">Instance of the RestRequest</param>
        public bool Post(RestRequest req) {
            return true;
        }
    }
}