
using BLL;
using DAL;
using Microsoft.Extensions.DependencyInjection;
using BE;
using Infrastructure.Interfaces.BLL;
using Infrastructure.Interfaces.DAL;
using UI.Language;
using UI.Profiles;
using UI.Mantainers;
using UI.Points;
namespace UI
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            FrmPrincipal form = ServiceProvider.GetRequiredService<FrmPrincipal>();
            Application.Run(form);
        }

        static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IUserDAL, UserDAL>();
            services.AddTransient<IUserBLL, UserBLL>();
            services.AddTransient<ILanguageBLL, LanguageBLL>();
            services.AddTransient<ILanguageDAL, LanguageDAL>();
            services.AddTransient<ILogDAL, LogDAL>();
            services.AddTransient<ILogBLL, LogBLL>();
            services.AddTransient<IRoleBLL, RoleBLL>();
            services.AddTransient<IRoleDAL, RoleDAL>();
            services.AddTransient<IProductBLL, ProductBLL>();
            services.AddTransient<IProductDAL, ProductDAL>();
            services.AddTransient<IPointBLL, PointBLL>();
            services.AddTransient<IPointDAL, PointDAL>();

            services.AddTransient<FrmLogin>();
            services.AddTransient<FrmPrincipal>();
            services.AddTransient<FrmManageLanguage>();
            services.AddTransient<FrmManageProfile>();
            services.AddTransient<FrmAddProducts>();
            services.AddTransient<FrmPoints>();
            services.AddTransient<FrmExchangePoints>();
            services.AddTransient<FrmViewProducts>();
        }
    }
}