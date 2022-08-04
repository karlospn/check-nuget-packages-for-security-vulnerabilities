using System.Threading.Tasks;
using VulnerableApp.Core.Extensions;
using VulnerableApp.Library.Contracts.Dto;

namespace VulnerableApp.Library.Contracts
{
    /// <summary>
    /// Your Service
    /// </summary>
    public interface IFooService
    {
        /// <summary>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<OperationResult<FooRsDto>> DoSomethingAsync(FooRqDto data);
    }
}