using System.Collections.Generic;
using SecretTarot.Module.Core.ViewModels;

namespace SecretTarot.Module.Cms.ViewModels
{
    public class CarouselWidgetForm : WidgetFormBase
    {
        public IList<CarouselWidgetItemForm> Items = new List<CarouselWidgetItemForm>();
    }
}
