using System;
using System.Net;
using System.Collections;
namespace RestSharp {

    public class Http: IHttp {

        private List<string> Cookies {get; private set; }
        protected bool HasCookies => Cookies.Any();

        public Http() {

        }

        private CreateWebRequest(Uri uri) => WebRequest.Create(uri);
    }
}