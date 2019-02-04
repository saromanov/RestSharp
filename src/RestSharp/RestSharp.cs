using System.Net;
using System;

namespace RestSharp {

    class RestSharp {

        private Uri uri;
        public RestSharp(string url) {
            url = new Uri(url);
        }

        public RestSharp(Uri uri) {
            uri = uri;
        }

        /// <summary>
        /// Creating of the Post request
        /// </summary>
        /// <param name="req">Instance of the RestRequest</param>
        public Post(RestRequest req) {

        }
    }
}