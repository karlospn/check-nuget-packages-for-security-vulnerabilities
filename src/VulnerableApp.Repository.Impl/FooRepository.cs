using System;
using System.Threading.Tasks;
using VulnerableApp.Repository.Contracts;
using VulnerableApp.Repository.Contracts.Model;

namespace VulnerableApp.Repository.Impl
{
    public class FooRepository : IFooRepository
    {
        public async Task<FooModel> AddFooModelAsync(FooModel dataModel)
        {
            //Just for demo purposes
            return await Task.FromResult(new FooModel
            {
                FooData = $"Your data at: {DateTime.Now:D}"
            });
        }
    }
}