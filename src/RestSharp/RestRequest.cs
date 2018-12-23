using System.Collections.Generic;
using System.IO;

namespace RestSharp {

    /// <summary>
    /// Representation of rest request
    /// </summary>
    public class RestRequest: IRestRequest {
        private string Url { get; private set; }
        private Dictionary<string, string> parameters;
        private Dictionary<string, string> headers;
        private Dictionary<string, string> files;
        public RestRequest(url string) {
            Url = url;
            parameters = new Dictionary<string, string>();
            headers = new Dictionary<string, string>();
            files = new Dictionary<string, string>();
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

        /// <summary>
        /// Adding of the file path on request
        /// </summary>
        public void AddFile(string name, string value) {
            parameters.Add(name, value);
        }

        /// <summary>
        /// ReadFile provides reading of the file
        /// </summary>
        private []byte ReadFile(path string){
            return File.ReadAllBytes(path);
        }

    } 
}