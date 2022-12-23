using System.Diagnostics;
using Website.Shared;

namespace Website.Client.Services.ProductService
{
	public class ProductService : IProductService
	{
		public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
		{
			Products = new List<Product>
			{
                new Product{
					Id= 1,
					CategoryId = 1,
					Title = "The Hitchhiker' S Guide to the Galaxy",
					Description = "The Hitchhiker's Guide to the Galaxy (sometimes referred to as HG2G,",
					Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_fromt_cover.jpg",
					Price = 9.99m,
					OriginalPrice = 19.99m 
				},
				new Product {
					Id  = 2,
                    CategoryId = 1,
					Title = "Ready Player One",
					Description = "Ready Player One is a 2e1i science fiction novel,and the debut novel of American author Ernest Cline.\r\n\t\t\t\t\tThe story,\r\n\t\t\t\t\tset in a ",
                    Image = "https://upload.wikimedia.org/wikipedia/en/a/a4/Read_Player_One_cover.jpg",
					Price =  7.99m,
					OriginalPrice = 14.99m,
				}
            };
		}
	}
}
