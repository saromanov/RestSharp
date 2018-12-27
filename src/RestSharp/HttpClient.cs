namespace RestSharp {

    /// <summary>
    /// Implementation of HttpClient
    /// </summary>
    public class HttpClient {
        private WebRequest webRequest;
        private List<string> acceptedTypes;
        private string url{get; private set; }

        private static readonly string[] JsonContentTypes =
        {
            "application/json", "text/json", "text/x-json", "text/javascript", "*+json"
        };

        public HttpClient(url string){
            acceptedTypes = new List<string>();
            url = url;

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