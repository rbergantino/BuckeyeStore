using System;
using Xunit;

namespace BuckeyeStore.Core.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var product = new Product
            {
                Id = 1,
                Name = "T-shirt",
                Brand = "Nike"
            };

            var review = new Review
            {
                Id = 1,
                Body = "A durable Buckeye T-shirt."
            };

            //act
            product.AddReview(review);

            //assert
            Assert.NotNull(product.Review);
            Assert.Equal(review.Id, product.Review.Id);
            Assert.Equal(review.Body, product.Review.Body);
        }
    }
}
