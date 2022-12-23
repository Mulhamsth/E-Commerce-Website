using Website.Shared;

namespace Website.Client.Services.ProductService
{
	public interface IProductService
	{
		List<Product> Products { get; set; }
		void LoadProducts();
	}
}
