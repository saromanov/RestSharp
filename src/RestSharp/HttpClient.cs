namespace RestSharp {

    /// <summary>
    /// Implementation of HttpClient
    /// </summary>
    public class HttpClient {
        private WebRequest webRequest;
        private List<string> acceptedTypes;

        private static readonly string[] JsonContentTypes =
        {
            "application/json", "text/json", "text/x-json", "text/javascript", "*+json"
        };

        public HttpClient(){
            acceptedTypes = new List<string>();

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
    }
}