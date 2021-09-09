using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BookGroupRepository : IBookGroupRepository
{
        private MyCmsContext db;
        public BookGroupRepository(MyCmsContext context)
        {
            this.db = context;
        }

    public IEnumerable<BookGroup> GetAllGroups()
    {
            return db.BookGroups;
    }


    public BookGroup GetGroupById(int groupId)
    {
            return db.BookGroups.Find(groupId);
    }

    public bool InsertGroup(BookGroup bookGroup)
    {
            try
            {

                db.BookGroups.Add(bookGroup);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
    }


    public bool UpdateGroup(BookGroup bookGroup)
    {
            try
            {

                db.Entry(bookGroup).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    public bool DeleteGroup(BookGroup bookGroup)
    {
            try
            {

                db.Entry(bookGroup).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteGroup(int groupId)
        {
            try
            {

                var group = GetGroupById(groupId);
                DeleteGroup(group);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }


}


