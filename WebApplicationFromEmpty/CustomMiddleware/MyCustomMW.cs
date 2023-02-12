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

// создаём расширение для короткой вставки MW в программу.
// достаточно лишь вписать app.UseMyCustomMW(); и запустится MyCustomMW.Task
// (как при такой записи: app.UseMiddleware<MyCustomMW>();)
public static class MyCustomMiddleWareExtension
{
	public static IApplicationBuilder UseMyCustomMW(this IApplicationBuilder app)
	{
		return app.UseMiddleware<MyCustomMW>();
	}
}