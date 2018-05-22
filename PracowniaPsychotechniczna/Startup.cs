
using System.Globalization;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PracowniaPsychotechniczna.Dal;
using PracowniaPsychotechniczna.Model;
using PracowniaPsychotechniczna.Pages.Badanie;
using PracowniaPsychotechniczna.Validator;
using Rotativa.AspNetCore;

namespace PracowniaPsychotechniczna
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddMvc().AddFluentValidation();
            
            services.AddTransient<IValidator<Badany>, BadanyValidatior>();
            services.AddTransient<IValidator<Firma>, FrimaValidatior>();
            services.AddTransient<IValidator<Psycholog>, PsychologValidatior>();
            services.AddTransient<IValidator<TypBadania>, TypBadaniaValidator>();
            services.AddTransient<IValidator<CreateBadanie>, CreateBadanieValidator>();
            
            ValidatorOptions.LanguageManager.Culture = new CultureInfo("pl");

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            RotativaConfiguration.Setup(env);

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
