namespace WebApplicationFromEmpty.CustomMiddleware;

public class HelloMW
{
	private readonly RequestDelegate _next;

	public HelloMW(RequestDelegate next)
	{
		_next = next;
	}

	public async Task Invoke(HttpContext httpContext)
	{
		httpContext.Response.WriteAsync("This is a Hello MW<br />");
		await _next(httpContext);
		httpContext.Response.WriteAsync("This is a last Hello MW<br />");
	}
}

public static class HelloMWExtension
{
	public static IApplicationBuilder UseHelloMW(this IApplicationBuilder builder)
	{
		return builder.UseMiddleware<HelloMW>();
	}
}