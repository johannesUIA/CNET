using CNET.MVC.Models.Composite;

namespace CNET.MVC.Repositories;

    public interface ICheckListRepository
    {


        public CheckListViewModel GetOneRowById(int id);

        public CheckListViewModel GetRelevantData(int id);
        int Insert(CheckListViewModel checkListViewModel);
    }