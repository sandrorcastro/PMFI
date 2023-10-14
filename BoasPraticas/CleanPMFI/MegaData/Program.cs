using Infrastructure.Context;
using IOC;
using MegaData.Schedule;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddInfrastructureAutoMapper(builder.Configuration);




//builder.Services.AddSingleton<MegaDataSchedule>().Configure(builder,builder.Environment, MegaDataSchedule m){ m.Start() } ;


/*
Configure(IApplicationBuilder app, IWebHostEnvironment env, MegaDataSchedule myScheduledTask)
{
    // Configure o pipeline de solicitação aqui

    // Inicie o MyScheduledTask no início do aplicativo.
}
//builder.Services.AddSingleton<MegaDataSchedule>(MegaDataSchedule m){ };
*/




//MegaDataSchedule rotinaMegaData = new MegaDataSchedule();
//rotinaMegaData.Start();




// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    //pattern: "{controller=Home}/{action=Index}/{id?}");
    pattern: "{controller=MegaData}/{action=Index}/{id?}");

app.Run();
