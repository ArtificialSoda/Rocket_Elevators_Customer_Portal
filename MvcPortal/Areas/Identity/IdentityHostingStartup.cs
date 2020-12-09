using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcPortal.Areas.Identity.Data;

[assembly: HostingStartup(typeof(MvcPortal.Areas.Identity.IdentityHostingStartup))]
namespace MvcPortal.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MvcPortalIdentityDbContext>(options =>
                    options.UseSqlServer(
                        //context.Configuration.GetConnectionString("MvcPortalIdentityDbContextConnection")));
                        context.Configuration.GetConnectionString("FabienDimitrovDB-Prod")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<MvcPortalIdentityDbContext>();
            });
        }
    }
}