using Autofac.Extras.Moq;
using Moq;
using ScraperLibrary;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace API.Moq
{
    public class UrlShortTests
    {
        [Fact]
        public void ShortenUrl_ShouldReturn1a_WhenLongUrlIsNull()
        {
            //Arrange
            UrlShort us = new UrlShort();
            string url = null;
            //Act
            var results = us.shortenUrl(url);
            //Assert
            Assert.Equal("1a.lt", results);
        }
        [Fact]
        public void ShortenUrl_ShouldReturnShortUrl_WhenLongUrlIsCorrect()
        {
            string CorrectShortUrl = "correctShort.com";
            string GoodLongUrl = "goodLong.com";

            Mock<UrlShort> name = new Mock<UrlShort>();
            name.CallBase = true;
            name.Setup(x => x.getUrl(It.IsAny<string>())).Returns(CorrectShortUrl);

            var results = name.Object.shortenUrl(GoodLongUrl);

            Assert.Equal(CorrectShortUrl, results);
        }
        [Fact]
        public void ShortenUrl_ShouldReturn1a_WhenRecievedError()
        {
            string ErrorUrl = "Error";
            string BadUrl = "bad.com";

            Mock<UrlShort> name = new Mock<UrlShort>();
            name.CallBase = true;
            name.Setup(x => x.getUrl(It.IsAny<string>())).Returns(ErrorUrl);

            var results = name.Object.shortenUrl(BadUrl);

            Assert.Equal("1a.lt", results);
        }
    }
}