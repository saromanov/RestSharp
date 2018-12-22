namespace RestSharp {

    /// <summary>
    /// Representation of rest request
    /// </summary>
    public class RestRequest: IRestRequest {
        private string Url { get; private set; }
        public RestRequest(url string) {
            Url = url;
        }
    } 
}