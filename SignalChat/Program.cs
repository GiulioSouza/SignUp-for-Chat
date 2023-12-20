using Microsoft.AspNetCore.SignalR;
using SignalChat.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("brodcast", async (string message, IHubContext<ChatHub, IChatClient> context) => {
    await context.Clients.All.JoinRoom();
    await context.Clients.All.ReceiveMessage(message);
    return Results.NoContent();
});

app.MapHub<ChatHub>("chat-hub");

app.Run();
