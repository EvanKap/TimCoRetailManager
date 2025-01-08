using System.Collections.Generic;
using System.Linq;
using TRMDataManager.Library.Internal.DataAccess;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string id)
        {
            SQLDataAccess sQLDataAccess = new SQLDataAccess();
            var p = new { Id = id };
            return sQLDataAccess.LoadData<UserModel,dynamic>("dbo.spUserLookup",p , "TRMData").ToList();
        }
    }
}
