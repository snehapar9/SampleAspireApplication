var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.SampleAspireApplication_ApiService>("apiservice");

builder.AddProject<Projects.SampleAspireApplication_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();
