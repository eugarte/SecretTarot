using System.Collections.Generic;

namespace SecretTarot.Module.Cms.ViewModels
{
    public class SpaceBarWidgetComponentVm
    {
        public long Id { get; set; }

        public string WidgetName { get; set; }

        public List<SpaceBarWidgetSetting> Items { get; set; }
    }
}
