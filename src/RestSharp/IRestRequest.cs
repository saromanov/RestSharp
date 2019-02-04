using System;
using System.IO;
using System.Net;

namespace RestSharp {

    public interface IRestRequest {
        /// <summary>
        /// Serialization of JSON body
        /// </summary>
        ISerializable JsonSerializer { get; set; }
    }
}