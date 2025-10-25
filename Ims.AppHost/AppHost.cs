var builder = DistributedApplication.CreateBuilder(args);

var backgroundRunner = builder.AddProject<Projects.Ims_BackgroundRunner>("ims-background-runner");
var webapp = builder.AddProject<Projects.Ims_WebApp>("ims-webapp");

builder.Build().Run();
