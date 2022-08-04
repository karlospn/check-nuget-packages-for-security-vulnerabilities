using System.Threading.Tasks;
using VulnerableApp.Repository.Contracts.Model;

namespace VulnerableApp.Repository.Contracts
{
    public interface IFooRepository
    {
       Task<FooModel> AddFooModelAsync(FooModel dataModel);

    }
}