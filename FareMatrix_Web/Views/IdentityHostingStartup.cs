using System;
using FareMatrix_Repo.AccountData;
using FareMatrix_Web.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FareMatrix_Web.Areas.Identity.IdentityHostingStartup))]
namespace FareMatrix_Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AccountDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AccountDbContextConnection")));

                services.AddDefaultIdentity<FareMatrixAccountUsers>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AccountDbContext>();
            });
        }
    }
}