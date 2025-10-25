var builder = DistributedApplication.CreateBuilder(args);

var webapp = builder.AddProject<Projects.Ims_WebApp>("ims-webapp");

builder.Build().Run();
