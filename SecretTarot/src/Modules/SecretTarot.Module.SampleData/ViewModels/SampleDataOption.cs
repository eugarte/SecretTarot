using System.Collections.Generic;

namespace SecretTarot.Module.SampleData.ViewModels
{
    public class SampleDataOption
    {
        public string Industry { get; set; }

        public IList<string> AvailableIndustries { get; set; } = new List<string>();
    }
}
