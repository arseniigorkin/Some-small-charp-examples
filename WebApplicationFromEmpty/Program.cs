using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;

var builder = WebApplication.CreateBuilder(args);
// builder.WebHost.ConfigureKestrel(option =>
// {
// 	option.ConfigureEndpointDefaults(lo => lo.Protocols = HttpProtocols.Http2);
//
// });

var app = builder.Build();


// app.MapGet("/", () => "Hello World 2!");
app.Run(async (HttpContext context) =>
	{	
		context.Response.Headers["Content-type"] = "text/html";
		// context.Response.StatusCode = 400;
		// context.Response.Headers["Name"] = "SomeName";
		await context.Response.WriteAsync("<h2>Hello!</h2>");
		if (context.Request.Query.ContainsKey("somekey"))
		{
			string someval = context.Request.Query["somekey"];
			await context.Response.WriteAsync($"seomekey is set to <b>{someval}</b>.<br />");
		}

		if (context.Request.Headers.ContainsKey("Name"))
		{
			string hVal = context.Request.Headers["Name"];
			await context.Response.WriteAsync($"The Name in the headers is set to: {hVal}.<br />");
		}
	}
);
app.Run();