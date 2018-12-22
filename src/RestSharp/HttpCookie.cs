namespace RestSharp {
    
    /// <summary>
    /// Representation of an HTTP cookie
    /// </summary>
    public class HttpCookie {

        /// <summary>
        /// Check if cookie is expired
        /// </summary>
        public bool Expired { get;set; }

        /// <summary>
        /// Path on cookie
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Version of Cookie
        /// </summary>
        public string Version { get; set; }
    }
}