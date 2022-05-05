using System.Collections.Generic;

namespace TdTutor.Models
{
    public class Response
    {
        int CodeResponse { get; set; }
        public List<string> Message { get; set; }
        public string Name { get; set; }
    }
}