namespace RestSharp{

    public interface IRestResponse {

        /// <summary>
        /// Content Length
        /// </summary>
        long ContentLength { get; set; }


        /// <summary>
        /// MIME content type
        /// </summary>
        string ContentType { get; set; }
    }
}