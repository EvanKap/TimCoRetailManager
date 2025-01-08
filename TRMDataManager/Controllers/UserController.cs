using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Routing;
using TRMDataManager.Library.DataAccess;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Controllers
{
    [Authorize]
    [Route("api/User")]
    public class UserController : ApiController
    {
        
        public List<UserModel> GetById()
        {
            var id = RequestContext.Principal.Identity.GetUserId();
            UserData userData = new UserData();

            var output  = userData.GetUserById(id);

            return output;
        }
        
    }
}
