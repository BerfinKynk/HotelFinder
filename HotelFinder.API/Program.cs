var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddSwaggerDocument(config=>
{
    config.PostProcess = (doc =>
    {
        doc.Info.Title = "All Hotels Api";
        doc.Info.Version = "1.0.13";
        doc.Info.Contact = new NSwag.OpenApiContact()
        {
            Name = "Berfin KAYNAK",
            Url = "https://tr.linkedin.com/in/berfin-kaynak-63558b237?trk=people-guest_people_search-card",
            Email="berfins1296@gmail.com"
        };
    });

});


//yeni versiyonda servis ekleme þekli

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();
app.UseOpenApi();
app.UseSwaggerUi3();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});


app.MapRazorPages();

app.Run();
