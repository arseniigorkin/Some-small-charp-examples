using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;
using WebApplicationFromEmpty.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyCustomMW>();
// builder.WebHost.ConfigureKestrel(option =>
// {
// 	option.ConfigureEndpointDefaults(lo => lo.Protocols = HttpProtocols.Http2);
//
// });

var app = builder.Build();


// app.MapGet("/", () => "Hello World 2!");

// Registering MiddleWare class
// app.UseMiddleware<MyCustomMW>();
app.UseMyCustomMW();

app.Use(async (HttpContext context, RequestDelegate next) =>
{
	await context.Response.WriteAsync("Second MW <br />");
	await next(context);
});


app.Run(async (HttpContext context) =>
{
	await context.Response.WriteAsync("Third MW call <br />");
});

// app.Run(async (HttpContext context) =>
// 	{
// 		context.Response.Headers["Content-type"] = "text/html; charset=UTF-8";
// 		if (context.Request.Method != "GET")
// 		{
// 			context.Response.StatusCode = 400;
// 			await context.Response.WriteAsync("Вы использовали неверный метод.");
// 		}
// 		if (!context.Request.Query.ContainsKey("firstNumber"))
// 		{
// 			context.Response.StatusCode = 400;
// 			await context.Response.WriteAsync("Не указан параметр firstNumber.");
// 		}
// 		if (!context.Request.Query.ContainsKey("secondNumber"))
// 		{
// 			context.Response.StatusCode = 400;
// 			await context.Response.WriteAsync("Не указан параметр secondNumber.");
// 		}
// 		if (!context.Request.Query.ContainsKey("operator"))
// 		{
// 			context.Response.StatusCode = 400;
// 			await context.Response.WriteAsync("Не указан параметр operator.");
// 		}
//
// 		int firstNumber = Convert.ToInt32(context.Request.Query["firstNumber"][0]);
// 		int secondNumber = Convert.ToInt32(context.Request.Query["secondNumber"][0]);
//
// 		int result = 0;
// 		switch (context.Request.Query["operator"][0])
// 		{
// 			case "add":
// 				result = firstNumber + secondNumber;
// 				break;
// 			case "deduct":
// 				result = firstNumber - secondNumber;
// 				break;
// 			default:
// 				context.Response.StatusCode = 400;
// 				await context.Response.WriteAsync("Неверный оператор.");
// 				break;
// 		}
// 		
// 		context.Response.StatusCode = 200;
// 		await context.Response.WriteAsync($"Результат вычисления: {result.ToString()}<br />");
//
// 		// await context.Response.WriteAsync($"The method was used is: {context.Request.Method}<br />");
// 		// System.IO.StreamReader reader = new System.IO.StreamReader(context.Request.Body);
// 		// string body = await reader.ReadToEndAsync();
// 		// await context.Response.WriteAsync($"Text body: <b>{body}</b><br />");
//
// 		// Dictionary<string, StringValues> dictQuery = QueryHelpers.ParseQuery(body);
// 		// использование stringValues позволяет получать много значений одного ключа в виде списков.
// 		// Но при такой структуре ВСЕ значения будут списками,что требует индексированный вызов (словарь["ключ"][0])
// 		// await context.Response.WriteAsync($"Получено значение Name = {dictQuery["Name"][0]}<br />");
//
//
// 		// context.Response.Headers["Content-type"] = "text/html";
// 		// // context.Response.StatusCode = 400;
// 		// // context.Response.Headers["Name"] = "SomeName";
// 		// await context.Response.WriteAsync("<h2>Hello!</h2>");
// 		// if (context.Request.Query.ContainsKey("somekey"))
// 		// {
// 		// 	string someval = context.Request.Query["somekey"];
// 		// 	await context.Response.WriteAsync($"seomekey is set to <b>{someval}</b>.<br />");
// 		// }
// 		//
// 		// if (context.Request.Headers.ContainsKey("Name"))
// 		// {
// 		// 	string hVal = context.Request.Headers["Name"];
// 		// 	await context.Response.WriteAsync($"The Name in the headers is set to: {hVal}.<br />");
// 		// }
//
//
// 	}
// );

app.Run();