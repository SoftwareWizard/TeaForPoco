using System.Collections.Generic;
using SoftwareWizard.TeaForPoco.SampleEnum;

namespace SoftwareWizard.TeaForPoco.SampleDto
{
    public class TextResourcesDto
    {
        public Dictionary<string, Dictionary<string, string>> TextResources { get; set; }

        public string Language { get; private set; }

        public TextResourcesDto(Language lang)
        {
            Language = lang.ToString();
            TextResources = new Dictionary<string, Dictionary<string, string>>();
        }
    }
}
