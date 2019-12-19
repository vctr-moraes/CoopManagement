using System;
using CoopManagement.Areas.Identity.Data;
using CoopManagement.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CoopManagement.Areas.Identity.IdentityHostingStartup))]
namespace CoopManagement.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CoopManagementContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CoopManagementContextConnection")));

                services.AddDefaultIdentity<CoopManagementUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<CoopManagementContext>();
            });
        }
    }
}