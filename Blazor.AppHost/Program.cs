var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Blazor_ApiService>("apiservice");

builder.AddProject<Projects.Blazor_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
