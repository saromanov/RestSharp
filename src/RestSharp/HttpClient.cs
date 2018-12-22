namespace RestSharp {
    public class HttpClient {
        private WebRequest webRequest;
        public HttpClient(){
            
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
        public Do(IRestRequest request) {
            var result = request.Execute();
        }
    }
}