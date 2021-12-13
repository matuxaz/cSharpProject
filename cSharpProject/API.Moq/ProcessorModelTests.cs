using Autofac.Extras.Moq;
using Moq;
using ScraperLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace API.Moq
{
    public class ProcessorModelTests
    {
        [Fact]
        public async Task GetHtmlAsync_ShouldReturnEmptyList_WhenCannotConnectEver()
        {
            var cpuUrl = "https://www.1a.lt/c/kompiuteriu-komponentai-tinklo-produktai/komponentai/procesoriai/2vf?page=1&page_per=72";
            Mock<Processor> mock = new Mock<Processor>();
            mock.CallBase = true;
            mock.Setup(x => x.getHtml(cpuUrl)).Returns(() => Task.FromResult("Error"));

            var results = await mock.Object.GetHtmlAsync();

            List<Processor> noProcessors = new List<Processor>();
            Assert.Equal(noProcessors, results);
        }
        [Fact]
        public async Task GetHtmlAsync_ShouldReturnListWith3CPUs_WhenReadsFromHTML()
        {
            var CpuHttpClient = new HttpClient();
            Mock<Processor> mock = new Mock<Processor>();
            mock.CallBase = true;
            mock.Setup(x => x.getHtml(It.IsAny<string>())).Returns(await CpuHttpClient.GetStringAsync(new Uri("C:/Users/matol/OneDrive/Desktop/cSharpProject/API.Moq/TestHTML")));

            var results = await mock.Object.GetHtmlAsync();

            List<Processor> noProcessors = new List<Processor>();
            Assert.Equal(noProcessors, results);
        }

    }
}