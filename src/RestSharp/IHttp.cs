using System;
using System.Net;
using System.IO;

namespace RestSharp {
    public interface IHttp {
        HttpWebRequest Get();
        HttpWebRequest Post();
        HttpWebRequest Patch();
        HttpWebRequest Delete();
    }
}