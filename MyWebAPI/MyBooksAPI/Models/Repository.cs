using System.Linq;

namespace MyBooksAPI.Models
{
    public class Repository : IRepository
    {
        private MyBooksApiContext db;

        public Repository(MyBooksApiContext db)
        {
            this.db = db;
        }

        public IQueryable<Order> GetAllOrders()
        {
            return db.Orders;

        }

        public IQueryable<Order> GetAllOrdersWithDetails()
        {
            return db.Orders.Include("OrderDetail");

        }

        public Order GetOrder(int id)
        {

            return db.Orders.Include("OrderDetails.Book")
            .FirstOrDefault(o => o.Id == id);

        }
    }
}