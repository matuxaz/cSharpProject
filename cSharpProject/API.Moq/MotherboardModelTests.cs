using Autofac.Extras.Moq;
using Moq;
using ScraperLibrary;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace API.Moq
{
    public class MotherboardModelTests
    {
        [Fact]
        public async Task GetHtmlAsync_ShouldReturnEmptyList_WhenCannotConnectEver()
        {

            Mock<Motherboard> mock = new Mock<Motherboard>();
            mock.CallBase = true;
            mock.Setup(x => x.getHtml(It.IsAny<string>())).Returns("Error");

            var results = mock.Object.GetHtmlAsync();

            Assert.Empty(results);
        }
    }
}