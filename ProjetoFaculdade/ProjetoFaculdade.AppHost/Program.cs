var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.ProjetoFaculdade_ApiService>("apiservice");

builder.AddProject<Projects.ProjetoFaculdade_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
