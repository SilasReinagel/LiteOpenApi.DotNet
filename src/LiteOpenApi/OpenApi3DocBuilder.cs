using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace LiteOpenApi
{
    public class OpenApi3DocBuilder
    {
        private readonly OpenApiDoc _doc = new OpenApiDoc { Openapi = "3.0.1" };

        public OpenApi3DocBuilder(string title) 
            : this(new OpenApiInfo {Title = title}) {}
        
        public OpenApi3DocBuilder(OpenApiInfo info)
        {
            _doc.Info = info;
        }
        
        public string ToJson() => JsonSerializer.Serialize(_doc, new JsonSerializerOptions());

        public OpenApiDoc Build() => _doc;

        public OpenApi3DocBuilder WithInfo(OpenApiInfo info) 
            => With(doc => doc.Info = info);

        public OpenApi3DocBuilder WithServer(string serversUrl) 
            => WithServers(new [] {serversUrl});
        public OpenApi3DocBuilder WithServers(IEnumerable<string> serverUrls) 
            => With(doc => doc.Servers = serverUrls.Select(url => new Server {Url = url}).ToList());
        
        private OpenApi3DocBuilder With(Action<OpenApiDoc> mutate)
        {
            mutate(_doc);
            return this;
        }
    }
}
