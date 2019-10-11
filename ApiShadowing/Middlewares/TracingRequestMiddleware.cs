//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Http.Internal;
//using Microsoft.Extensions.Logging;
//using System;
//using System.IO;
//using System.Text;
//using System.Threading.Tasks;

//namespace APE.Exposition.Vente.Api.Middlewares
//{
//    public class TracingRequestMiddleware
//    {
//        private readonly RequestDelegate next;
//        protected readonly ILogger<TracingRequestMiddleware> _logger;


//        public TracingRequestMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
//        {
//            this.next = next;
//            _logger = loggerFactory
//                .CreateLogger<TracingRequestMiddleware>();
//        }

//        public async Task Invoke(HttpContext context)
//        {
//            context.Request.EnableRewind();
//            _logger.LogInformation(await FormatRequest(context));

//            var originalBodyStream = context.Response.Body;

//            using (var responseBody = new MemoryStream())
//            {
//                context.Response.Body = responseBody;

//                await next(context);

//                _logger.LogInformation(await FormatResponse(context));
//                await responseBody.CopyToAsync(originalBodyStream);
//            }
//        }

//        private async Task<string> FormatRequest(HttpContext context)
//        {
//            var buffer = new byte[Convert.ToInt32(context.Request.ContentLength)];
//            await context.Request.Body.ReadAsync(buffer, 0, buffer.Length);
//            var bodyAsText = Encoding.UTF8.GetString(buffer);
//            context.Request.Body.Seek(0, SeekOrigin.Begin);

//            return $"{context.TraceIdentifier} - {context.Request.Scheme} {context.Request.Host}{context.Request.Path} {context.Request.QueryString} {bodyAsText}";
//        }

//        private async Task<string> FormatResponse(HttpContext context)
//        {
//            context.Response.Body.Seek(0, SeekOrigin.Begin);
//            var text = await new StreamReader(context.Response.Body).ReadToEndAsync();
//            context.Response.Body.Seek(0, SeekOrigin.Begin);

//            return $"{context.TraceIdentifier} - Response {text}";
//        }
//    }
//}
