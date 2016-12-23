using System.Collections.Generic;

namespace SoftwareWizard.TeaForPoco.SampleDto
{
    public class SearchResultDto
    {
        public int NumResult { get; set; }

        public IEnumerable<Dictionary<string, string>> Results { get; set; }
    }
}