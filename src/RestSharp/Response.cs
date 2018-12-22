namespace RestSharp {
    public class Response<T> {
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