using System.Collections.Generic;
using SecretTarot.Module.Core.ViewModels;

namespace SecretTarot.Module.Cms.ViewModels
{
    public class SpaceBarWidgetForm : WidgetFormBase
    {
        public IList<SpaceBarWidgetSetting> Items = new List<SpaceBarWidgetSetting>();
    }
}
