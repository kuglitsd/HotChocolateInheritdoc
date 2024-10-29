using HotChocolateInheritdoc;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .ModifyOptions(opt => opt.UseXmlDocumentation = true);

var app = builder.Build();

app.MapGraphQL();

app.MapGet("/", context =>
{
    context.Response.Redirect("/graphql");
    return Task.CompletedTask;
});

await app.RunAsync();
