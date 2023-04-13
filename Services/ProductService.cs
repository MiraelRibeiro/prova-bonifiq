using prova_bonifiq.Models;
using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
	public class ProductService 
	{
		TestDbContext _ctx;

		public ProductService(TestDbContext ctx)
		{
			_ctx = ctx;
		}

		public ProductList ListProducts(int page)
		{
			int skip = 0;

			if(page != 0) skip = (int) Math.BigMul(10, page);

			int count = _ctx.Products.ToList().Count;

			var hasNext = !((skip + 10) >= count);

			Complementation comp = new(){ HasNext = hasNext, TotalCount = 10};

			return new ProductList() {  Complementation = comp, Products = _ctx.Products.Skip(skip).Take(10).ToList() };
		}

	}
}
