using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
	public class OrderService
	{
		TestDbContext _ctx;

        public OrderService()
        {
        }

        public OrderService(TestDbContext ctx)
		{
			_ctx = ctx;
		}

		public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
		{
			if (paymentMethod == "pix")
			{
				//Faz pagamento...
			}
			else if (paymentMethod == "creditcard")
			{
				//Faz pagamento...
			}
			else if (paymentMethod == "paypal")
			{
				//Faz pagamento...
			}

			return await Task.FromResult( new Order()
			{
				Value = paymentValue,
				CustomerId = customerId,
				OrderDate = DateTime.Now,
			});
		}
	}
}
