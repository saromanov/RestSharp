using System;
using System.IO;
using System.Net;
using RestSharp.Serializers;

namespace RestSharp {

    public interface IRestRequest {
        /// <summary>
        /// Serialization of JSON body
        /// </summary>
        ISerializable JsonSerializer { get; set; }
    }
}