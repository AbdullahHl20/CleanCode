using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCode.DataBase.SqlServer.EFModel;

namespace CleanCode.Code
{
   
    class UsersControler : IdataHelper<UserTable>
    {
        StudentEntities _dbstudentEntities;
        UserTable userTable;

        public UsersControler()
        {
            _dbstudentEntities = new StudentEntities();
        }
        public  void Adddata(object[] param)
        {
            userTable = new UserTable()
            {
                FirstName = param[0].ToString(),
                LastName = param[1].ToString(),
                UserName = param[2].ToString(),
                UserPassword = param[3].ToString(),
                UserRole = param[4].ToString(),
                UserLogo = (byte[])param[5],
                AddedDate = DateTime.Now

            };
            _dbstudentEntities.UserTables.Add(userTable);
            _dbstudentEntities.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public UserTable Detailes(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserTable> GetAllData()
        {
            return _dbstudentEntities.UserTables.ToList();
        }

        public List<UserTable> SearchtData(string item)
        {
            throw new NotImplementedException();
        }
    }
}
