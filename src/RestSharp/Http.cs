using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;
namespace RestSharp {

    public class Http{

        private List<string> Cookies {get; }
        protected bool HasCookies => Cookies.Count > 0;

        public Http() {

        }

        private WebRequest CreateWebRequest(Uri uri) => WebRequest.Create(uri);
    }
}