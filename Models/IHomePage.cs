using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagementSystem.Models
{
    public interface IHomePage
    {
        List<Entry> getUserDataList();
        void addNewEntry(Entry entry);
        void removeEntry(Entry entry);
        LoggedInUser getLoggedInUser();
        string getFilePath();
    }
}
