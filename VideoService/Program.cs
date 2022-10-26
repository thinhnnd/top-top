using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

// app.UseAuthorization();

// app.MapControllers();

app.MapGet("/", () => {
    return "Toptop API tét2 3";
});

app.MapGet("/video", () => {
    string fileName = "SampleVideo_1280x720_20mb.mp4";
    string wwwroot = builder.Environment.WebRootPath;
    string filePath = Path.Combine(wwwroot, fileName);
    var fileStream = new FileStream(filePath, FileMode.Open);
    return Results.Stream(fileStream, contentType: "video/mp4");
});

app.Run();
