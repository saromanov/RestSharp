using System.IO;

namespace RestSharp {

    public class FileAttribute {

        /// <summary>
        /// Name is a name of the file
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ContentType of the file
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Data of file
        /// </summary>
        public Action<Stream> Writer { get; set; }
    }
}