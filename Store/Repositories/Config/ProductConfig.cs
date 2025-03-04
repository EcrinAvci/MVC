using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasKey(p=> p.ProductId);
            builder.Property(p=>p.ProductName).IsRequired();
            builder.Property(p=>p.Price).IsRequired();


            builder.HasData(
                new Product(){ProductId=1,CategoryId=2,ImageUrl="/images/1.jpg", ProductName="computer",Price=17_000,ShowCase=false},
                new Product(){ProductId=2,CategoryId=2,ImageUrl="/images/2.jpg", ProductName="mouse",Price=7_000,ShowCase=false},
                new Product(){ProductId=3,CategoryId=2,ImageUrl="/images/3.jpg", ProductName="keyboard",Price=11_000,ShowCase=false},
                new Product(){ProductId=4,CategoryId=2,ImageUrl="/images/4.jpg", ProductName="monitör",Price=12_000,ShowCase=false},
                new Product(){ProductId=5,CategoryId=2,ImageUrl="/images/5.jpg", ProductName="deck",Price=3_000,ShowCase=false},
                new Product(){ProductId=6,CategoryId=1,ImageUrl="/images/6.jpg", ProductName="History",Price=1_000,ShowCase=false},
                new Product(){ProductId=7,CategoryId=1,ImageUrl="/images/7.jpg", ProductName="Hamlet",Price=27_000,ShowCase=false},
                new Product(){ProductId=8,CategoryId=2,ImageUrl="/images/8.jpg", ProductName="X-box",Price=37_000,ShowCase=true},
                new Product(){ProductId=9,CategoryId=2,ImageUrl="/images9.jpg", ProductName="PlayStation",Price=17_000,ShowCase=true},
                new Product(){ProductId=10,CategoryId=1,ImageUrl="/images/10.jpg", ProductName="AirPods",Price=6_000,ShowCase=true}
            );
        }
    }
}