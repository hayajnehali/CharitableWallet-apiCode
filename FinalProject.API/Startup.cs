using FinalProject.Core.Common;
using FinalProject.Core.Repository;
using FinalProject.Core.Service;
using FinalProject.Infra.Common;
using FinalProject.Infra.Repository;
using FinalProject.Infra.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.API
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
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(option =>
                {
                    option.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("CharityTeamCharity"))
                    };
                });
            services.AddCors(corsOptions => {
                corsOptions.AddPolicy("policy",
                builder => {
                    builder.AllowAnyOrigin().AllowAnyMethod().
                          AllowAnyHeader();
                });


            });
            services.AddControllers();
            services.AddScoped<IDbContext, DbContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDocumentRepository, DocumentRepository>();
            services.AddScoped<IDocumentService, DocumentService>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>();
            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<IContactUsRepository, ContactUsRepository>();
            services.AddScoped<IContactUsService, ContactUsService>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IDonationRepository,DonationRepository>();
            services.AddScoped<IDonationService,DonationService>();

            services.AddScoped<IReportRepository, ReportRepository>();
            services.AddScoped<IReportService, ReportService>();

            services.AddScoped<ICategoryService, CategoryService>();

            services.AddScoped<ICharityRepository, CharityRepository>();
            services.AddScoped<ICharityService, CharityService>();
            services.AddScoped<IBankRepository, BankRepository>();
            services.AddScoped<IBankService, BankService>();
            services.AddScoped<IHomeRepository, HomeRepository>();
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<IJWTRepository, JWTRepository>();
            services.AddScoped<IJWTService, JWTService>();
            services.AddScoped<IAboutusRepository, AboutusRepository>();
            services.AddScoped<IAboutuService, AboutuService>();



            services.AddScoped<IWalletRepository, WalletRepository>();
            services.AddScoped<IWalletService, WalletService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("policy");

            app.UseAuthorization();
            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
