using System;
using System.IO;
using System.Net;
using System.Runtime;
using System.Runtime.Serialization;

namespace RestSharp {

    public interface IRestRequest {
        /// <summary>
        /// Serialization of JSON body
        /// </summary>
        ISerializable JsonSerializer { get; set; }
    }
}