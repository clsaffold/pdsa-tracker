using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using pdsa_tracker.Areas.Identity.Data;
using pdsa_tracker.Data;

[assembly: HostingStartup(typeof(pdsa_tracker.Areas.Identity.IdentityHostingStartup))]
namespace pdsa_tracker.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<pdsa_trackerContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("pdsa_trackerContextConnection")));

                services.AddDefaultIdentity<pdsa_trackerUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<pdsa_trackerContext>();
            });
        }
    }
}