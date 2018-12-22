using System.Collections.Generic;

namespace RestSharp {

    /// <summary>
    /// Representation of rest request
    /// </summary>
    public class RestRequest: IRestRequest {
        private string Url { get; private set; }
        private Dictionary<string, string> parameters;
        public RestRequest(url string) {
            Url = url;
            parameters = new Dictionary<string, string>();
        }

        /// <summary>
        /// Adding of the Parameters in the case of POST request
        /// </summary>
        public void AddHeader(string name, string value) {
            parameters.Add(name, value);
        }
    } 
}