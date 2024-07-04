using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("InMemoryDb"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

var scope = app.Services.CreateScope();
var sevices = scope.ServiceProvider;
var context = sevices.GetRequiredService<AppDbContext>();
if (!context.Students.Any())
{
    var students = new List<Student>();

    for (int i = 1; i <= 50; i++)
    {
        uint a = (uint)i;
        students.Add(new Student
        {
            Id = i,
            Age = a,
            Height = 160 + (a % 30),
            Gender = i % 2,
            Name = "Name",
            UniversityName = "Unviersity"

        }); 
    }
    context.Students.AddRange(students);
    context.SaveChanges();
}


app.Run();