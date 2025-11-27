using CNET.MVC.Models.Composite;

namespace CNET.MVC.Repositories;

public interface IServiceFormRepository
{
    public IEnumerable<ServiceFormViewModel> GetSomeOrderInfo();
    public ServiceFormViewModel GetRelevantData(int id);

    public ServiceFormViewModel GetOneRowById(int id);

    void Insert(ServiceFormViewModel serviceFormViewModel);
}