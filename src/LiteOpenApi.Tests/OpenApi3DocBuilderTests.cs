using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiteOpenApi.Tests
{
    [TestClass]
    public class OpenApi3DocBuilderTests
    {
        [TestMethod]
        public void SpecVersion_IsCorrect()
        {
            var doc = new OpenApi3DocBuilder("MyWebApi").Build();
            
            Assert.AreEqual("3.0.1", doc.Openapi);
        }

        [TestMethod]
        public void Info_IsCorrect()
        {
            var doc = new OpenApi3DocBuilder(
                new OpenApiInfo
                {
                    Title = "MyWebApi",
                    Version = "1"
                }).Build();
            
            Assert.AreEqual("MyWebApi", doc.Info.Title);
            Assert.AreEqual("1", doc.Info.Version);
        }
    }
}