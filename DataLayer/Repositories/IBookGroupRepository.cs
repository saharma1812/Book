using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public interface IBookGroupRepository:IDisposable
    {
        IEnumerable<BookGroup> GetAllGroups();
        BookGroup GetGroupById(int groupId);
        bool InsertGroup(BookGroup bookGroup);
        bool UpdateGroup(BookGroup bookGroup);
        bool DeleteGroup(BookGroup bookGroup);
        bool DeleteGroup(int groupId);
        void save();

    }
}
