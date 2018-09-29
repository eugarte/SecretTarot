using System.Threading.Tasks;
using SecretTarot.Module.SampleData.ViewModels;

namespace SecretTarot.Module.SampleData.Services
{
    public interface ISampleDataService
    {
        Task ResetToSampleData(SampleDataOption model);
    }
}
