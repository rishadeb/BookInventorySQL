using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    public interface IDatabaseMan
    {
        bool ConnectDb(string server, string port);
        void CloseDb();
        void Update(string name, string author, string edition, string date, string price, string id);
        void Delete(string id);
        DataTable SelectAll();
        DataTable SelectDistinct();
        string SelectCount(string name);
        DataTable SelectWhere(string name);
        void Insert(string name, string author, string edition, string date, string price);
    }
}
