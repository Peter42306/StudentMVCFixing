using Microsoft.EntityFrameworkCore;
using StudentMVCFixing.Models;

var builder = WebApplication.CreateBuilder(args);

// �������� ������ ����������� �� ����� ������������
string? connection = builder.Configuration.GetConnectionString("DefaultConnection");

// ��������� �������� ApplicationContext � �������� ������� � ����������
builder.Services.AddDbContext<StudentContext>(options => options.UseSqlServer(connection));

// ��������� ������� MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(); // ������������ ������� � ������ � ����� wwwroot

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Student}/{action=Index}/{id?}");

app.Run();
