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
					Image = "https://dictionary.cambridge.org/images/thumb/book_noun_001_01679.jpg?version=5.0.286",
					Price = 9.99m,
					OriginalPrice = 19.99m 
				},
				new Product {
					Id  = 2,
                    CategoryId = 1,
					Title = "Ready Player One",
					Description = "Ready Player One is a 2e1i science fiction novel,and the debut novel of American author Ernest Cline.\r\n\t\t\t\t\tThe story,\r\n\t\t\t\t\tset in a ",
                    Image = "https://dictionary.cambridge.org/images/thumb/book_noun_001_01679.jpg?version=5.0.286",
					Price =  7.99m,
					OriginalPrice = 14.99m
				},
                new Product{
                    Id = 3,
                    CategoryId = 1,
                    Title = "MX Master 3",
                    Description = "An eronomic Maus for profissional use",
                    Image = "https://cdn.idealo.com/folder/Product/201968/1/201968116/s2_produktbild_gross_1/logitech-mx-master-3s.jpg",
                    Price = 99.99m,
                    OriginalPrice = 104.99m
                },
                new Product{
                    Id = 4,
                    CategoryId = 1,
                    Title = "MX Keys",
                    Description = "An eronomic Keyboard for profissional use",
                    Image = "https://resource.logitech.com/content/dam/logitech/en/products/keyboards/mx-keys-for-business/gallery/mx-keys-business-keyboard-gallery-rus-graphite-1.png",
                    Price = 109.99m,
                    OriginalPrice = 139.99m
                },
                new Product{
                    Id = 5,
                    CategoryId = 1,
                    Title = "Book",
                    Description = "an amazing book",
                    Image = "https://dictionary.cambridge.org/images/thumb/book_noun_001_01679.jpg?version=5.0.286",
                    Price = 4.99m,
                    OriginalPrice = 9.99m
                },
                new Product{
                    Id = 6,
                    CategoryId = 1,
                    Title = "watch",
                    Description = "a smartwatch for daily use",
                    Image = "https://m.media-amazon.com/images/I/61TzjMeU3mS._AC_SL1500_.jpg",
                    Price = 99.99m,
                }
            };
		}
	}
}
