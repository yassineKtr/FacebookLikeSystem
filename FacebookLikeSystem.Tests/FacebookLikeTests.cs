using Xunit;

namespace FacebookLikeSystem.Tests
{
    public class FacebookLikeTests
    {
        [Fact]
        public void ShouldHandleNoLike()
        {
            Assert.Equal("no one likes this", FacebookLike.CreateLikeText(new string[] { }));
        }
        [Fact]
        public void ShouldHandleOneLike()
        {
            Assert.Equal("Peter likes this", FacebookLike.CreateLikeText(new string[] { "Peter" }));
        }
        [Fact]
        public void ShouldHandleTwoLikes()
        {
            Assert.Equal("Jacob and Alex like this", FacebookLike.CreateLikeText(new string[] { "Jacob", "Alex" }));
        }
        [Fact]
        public void ShouldHandleThreeLikes()
        {
            Assert.Equal("Max, John and Mark like this", FacebookLike.CreateLikeText(new string[] { "Max", "John", "Mark" }));
        }
        [Fact]
        public void ShouldHandleFourLikes()
        {
            Assert.Equal("Alex, Jacob and 2 others like this", FacebookLike.CreateLikeText(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
    }
}
