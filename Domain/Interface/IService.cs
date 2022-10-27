using Domain.ViewModel;

namespace Domain.Interface
{
    public interface IService
    {
        Task<List<Top10>> Get();
    }
}
