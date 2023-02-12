namespace WebApplicationFromEmpty.CustomMiddleware;

public class MyCustomMW : IMiddleware
{
	public async Task InvokeAsync(HttpContext context, RequestDelegate next)
	{
		// throw new NotImplementedException();
		context.Response.Headers["Content-type"] = "text/html; charset=UTF-8";
		await context.Response.WriteAsync("Custom MW<br />");
		await next(context);
		await context.Response.WriteAsync("End of the Custom MW<br />");
	}
}