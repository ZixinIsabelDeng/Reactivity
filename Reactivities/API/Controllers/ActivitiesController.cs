

using Persistence;

namespace API.Controllers
{
    public class ActivitiesController:BaseApiController
    {

        private readonly DataContext context;
        public ActivitiesController(DataContext context)
        {
            this.context=context;
        }
    }
}