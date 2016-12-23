using System.Collections.Generic;

namespace SoftwareWizard.TeaForPoco.SampleDto
{
    public class WebRequestDto
    {
        public Dictionary<string,string> Headers { get; set; }

        public string ContentType { get; set; }

        public string Method { get; set; }

        public string Body { get; set; }

        public WebRequestDto()
        {
            Headers = new Dictionary<string, string>();
        }
    }
}