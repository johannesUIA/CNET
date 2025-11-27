using CNET.MVC.Entities;
using System.Data;

namespace CNET.MVC.DataAccess
{
    public interface ISqlConnector
    {
        IDbConnection GetDbConnection();
    }
}