using System;
using ChatWithSignalR.Areas.Identity.Data;
using ChatWithSignalR.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ChatWithSignalR.Areas.Identity.IdentityHostingStartup))]
namespace ChatWithSignalR.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ChatWithSignalRDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ChatWithSignalRDBContextConnection")));

                services.AddDefaultIdentity<ChatWithSignalRUser>(options => {
                    options.SignIn.RequireConfirmedAccount = true;
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                    })
                    .AddEntityFrameworkStores<ChatWithSignalRDBContext>();
            });
        }
    }
}