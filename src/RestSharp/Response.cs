namespace RestSharp {


    public abstract class AbstractResponse {

        /// <summary>
        ///     HTTP response code
        /// </summary>
        public int StatusCode { get; set; }

        public bool Success => StatusCode >= 200 && StatusCode <= 299; 
    }

    public class Response<T>: AbstractResponse {
         private readonly Func<T> deserializer;
         private readonly T deserializerContent;
    }

    public T GetContent()
    {
        this.deserializedContent = this.deserializer();
        return this.deserializerContent;
    }

    /// <summary>
    /// ResponseUri
    /// </summary>
    public Uri ResponseUri { get; set; }

    /// <summary>
    /// Server
    /// </summary>
    public string Server { get; set; }
}