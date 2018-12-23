using System.Collections.Generic;

namespace RestSharp {

    /// <summary>
    /// Representation of rest request
    /// </summary>
    public class RestRequest: IRestRequest {
        private string Url { get; private set; }
        private Dictionary<string, string> parameters;
        private Dictionary<string, string> headers;
        public RestRequest(url string) {
            Url = url;
            parameters = new Dictionary<string, string>();
            headers = new Dictionary<string, string>();
        }

        /// <summary>
        /// Adding of the Parameters in the case of POST request
        /// </summary>
        public void AddParameter(string name, string value) {
            parameters.Add(name, value);
        }

        /// <summary>
        /// Adding of the Header on request
        /// </summary>
        public void AddHeader(string name, string value) {
            parameters.Add(name, value);
        }

    } 
}