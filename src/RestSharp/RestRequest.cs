using System.Collections.Generic;
using System.IO;

namespace RestSharp {

    /// <summary>
    /// Representation of rest request
    /// </summary>
    public class RestRequest: IRestRequest {
        private Methods method;
        private Dictionary<string, string> parameters = new Dictionary<string, string>();
        private Dictionary<string, string> headers = new Dictionary<string, string>();
        private Dictionary<string, string> files = new Dictionary<string, string>();
        private Dictionary<string, string> urlAttributes = new Dictionary<string, string>();
        private List<FileAttribute> uploadedFiles = new List<FileAttribute>();
        private string url;
        public RestRequest(Methods method) {
            method = method;
        }

        public RestRequest(string url) {
            url = url;
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
            headers.Add(name, value);
        }

        /// <summary>
        /// Adding of url attributes like ?key=value
        /// </summary>
        public void AddUrlAttribute(string key, string value) {
            urlAttributes.Add(key, value);
        }

        /// <summary>
        /// Adding of the file path on request
        /// </summary>
        public void AddFile(string name, string value) {
            files.Add(name, value);
        }

        /// <summary>
        /// ReadFile provides reading of the file
        /// </summary>
        private byte[] ReadFile(string path){
            return File.ReadAllBytes(path);
        }

        /// <summary>
        /// PrepareFiles defines preparation of files for upload
        /// </summary>
        private void PrepareFiles() {
            foreach(KeyValuePair<string, string> entry in files) {
                uploadedFiles.Add(
                    new FileAttribute{
                        Name = entry.Value,
                        Writer = s => {
                             using (var file = new StreamReader(new FileStream(path, FileMode.Open)))
                            {
                                file.BaseStream.CopyTo(s);
                            }
                        },
                    }
                );
            }
        }

        public IRestResponse Do(IRestRequest request){
            if (this.method == Methods.GET) {

            }
        }

    } 
}