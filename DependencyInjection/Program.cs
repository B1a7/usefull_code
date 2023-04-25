var builder  = WebApplication.CreateBuilder(args);

// Add Services 

builder.Services.AddControllers();
builder.Services.AddEndPointApiExplorer();

//typical here the last one will be registered 
builder.Services.AddSingleton<IService, ServiceOne>();
builder.Services.AddSingleton<IService, ServiceTwo>();

//different way
var descriptorOne = new ServiceDescriptor(typeof(Iservice), typeof(ServiceOne), ServiceLifetime.Singleton);
var descriptorTwo = new ServiceDescriptor(typeof(Iservice), typeof(ServiceTwo), ServiceLifetime.Singleton);

builder.Services.Add(descriptor);

//other way here only the first will be registered check typeof(Iservice)
builder.Services.TryAddSingleton<IService, ServiceOne>();
builder.Services.TryAddSingleton<IService, ServiceTwo>();

//other way
builder.Services.TryAddEnumerable(new [] {descriptorOne, descriptorTwo});


//other way here we will have 1 service registered because TryAddEnumerable check typeof(Iservice), typeof(ServiceOne)
builder.Services.TryAddEnumerable(descriptorOne);
builder.Services.TryAddEnumerable(descriptorOne);

var app = builder.Build();

//Configure HTTP remote pipeline.
if(app.Environment.IsDevelopment())
{

}

app.UseHttpsRedirection();
// other things
