var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<LifetimesSingleton>();
builder.Services.AddScoped<LifetimesScoped>();
builder.Services.AddTransient<LifetimesTransient>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/ping", () => "pong");

app.MapGet("/lifetimes", (
    HttpContext context,
    LifetimesSingleton singleton1, 
    LifetimesScoped scoped1, 
    LifetimesTransient transient1) => 
{
    var singleton2 = context.RequestServices.GetRequiredService<LifetimesSingleton>();
    var scoped2 = context.RequestServices.GetRequiredService<LifetimesScoped>();
    var transient2 = context.RequestServices.GetRequiredService<LifetimesTransient>();

    return new {
        singleton = new { first = singleton1.Id, second = singleton2.Id },
        scoped = new { first = scoped1.Id, second = scoped2.Id },
        transient = new { first = transient1.Id, second = transient2.Id }
    };
});

app.Run();

public interface ILifetimes {
    string Id { get; }
}

public class LifetimesSingleton : ILifetimes {
    public string Id { get; }
    public LifetimesSingleton() {
        Id = Guid.NewGuid().ToString().Substring(0, 8); 
    }
}

public class LifetimesScoped : ILifetimes {
    public string Id { get; }
    public LifetimesScoped() {
        Id = Guid.NewGuid().ToString().Substring(0, 8); 
    }
}

public class LifetimesTransient : ILifetimes {
    public string Id { get; }
    public LifetimesTransient() {
        Id = Guid.NewGuid().ToString().Substring(0, 8); 
    }
}
