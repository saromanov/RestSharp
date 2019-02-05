using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;
namespace RestSharp {

    public class Http{

        private List<string> Cookies {get; private set; }
        protected bool HasCookies => Cookies.Any();

        public Http() {

        }

        private WebRequest CreateWebRequest(Uri uri) => WebRequest.Create(uri);
    }
}