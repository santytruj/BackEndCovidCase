using Application.Wrappers;
using System.Net;
using System.Text.Json;

namespace WebApi.Middlewares
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {

            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                var respondeModel = new Response<string>() { Succeeded= false, Message = error?.Message};

                switch (error)
                {
                    case Application.Exceptions.ApiException e:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        break;

                    case Application.Exceptions.ValidationExceptions e:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        respondeModel.Errors = e.Errors;
                        break;

                    case KeyNotFoundException e:
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        break;
                        
                    default:
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }

                var result = JsonSerializer.Serialize(respondeModel);

                await response.WriteAsync(result);
            }
        }
    }
}
