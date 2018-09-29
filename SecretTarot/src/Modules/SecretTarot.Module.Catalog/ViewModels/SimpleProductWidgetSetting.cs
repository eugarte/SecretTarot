using System.Collections.Generic;

namespace SecretTarot.Module.Catalog.ViewModels
{
    public class SimpleProductWidgetSetting
    {
        public IList<ProductLinkVm> Products { get; set; } = new List<ProductLinkVm>();
    }
}
