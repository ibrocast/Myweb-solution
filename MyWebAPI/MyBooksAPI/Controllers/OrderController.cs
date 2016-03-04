using System.Linq;
using System.Web.Http;
using MyBooksAPI.Models;

namespace MyBooksAPI.Controllers
{
    public class OrderController : ApiController
    {
        private readonly IRepository _repo;

        public OrderController(IRepository repo)
        {

            _repo = repo;

        }

        protected IRepository TheRepository
        {
            get
            {
                return _repo;
            }
        }

        public IQueryable<Order> Get()
        {

            return _repo.GetAllOrders();

        }

        public IQueryable<Order> Get(bool includeDetails)
        {

            IQueryable<Order> query;

            query = includeDetails ? _repo.GetAllOrdersWithDetails() : _repo.GetAllOrders();

            return query;
        }

        public Order Get(int id)
        {
            return _repo.GetOrder(id);
        }

    }
}
