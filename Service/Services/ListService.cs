using Domain.Interface;
using Domain.ViewModel;

namespace Service.Services
{
    public class ListService : IService
    {
        private readonly IRepository _resitory;
        public ListService(IRepository resitory)
        {
            _resitory = resitory;
        }

        public async Task<List<Top10>> Get()
        {
            var dados = await _resitory.GetAsync();
            dados.Countries = dados.Countries.OrderByDescending(c => c.TotalConfirmed - (c.TotalRecoverd + c.TotalDeaths)).Take(10).ToList();
            var result = new List<Top10>();
            for(int i =0; i< dados.Countries.Count(); i++)
            {
                var implant = new Top10();
                implant.Cases = dados.Countries[i].TotalConfirmed - (dados.Countries[i].TotalRecoverd + dados.Countries[i].TotalDeaths);
                implant.Name = dados.Countries[i].Country;
                implant.Position = i + 1;
                result.Add(implant);
            }
            result = result.OrderByDescending(a => a.Cases).ToList();
            return result;
        }
    }
}
