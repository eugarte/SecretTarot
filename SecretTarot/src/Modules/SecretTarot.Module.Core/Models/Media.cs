using SecretTarot.Infrastructure.Models;

namespace SecretTarot.Module.Core.Models
{
    public class Media : EntityBase
    {
        public string Caption { get; set; }

        public int FileSize { get; set; }

        public string FileName { get; set; }

        public MediaType MediaType { get; set; }
    }
}
