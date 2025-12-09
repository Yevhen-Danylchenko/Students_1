using Students.Services;


namespace Students
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            var builder = WebApplication.CreateBuilder(args);

            // Razor Pages
            builder.Services.AddRazorPages();

            // Репозиторій файлів
            builder.Services.AddSingleton<IStudentRepository, FileStudentRepository>();

            var app = builder.Build();

            // Мінімальна безпека/помилки
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.MapRazorPages();
            app.Run();
        }
    }
}
