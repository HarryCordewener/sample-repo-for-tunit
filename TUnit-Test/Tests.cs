using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace TUnit_Test
{
	public class Tests
	{
		private static IWebHost? webhost;

		[Before(Class)]
		public static async Task OneTimeSetup()
		{
			webhost = CreateWebHostBuilder().Build();
			await webhost.RunAsync();
		}

		[After(Class)]
		public static async Task OneTimeTeardown()
		{
			await Task.Delay(1);
			webhost!.Dispose();
		}

		[Test]
		public async Task TestOne()
		{
			Func<bool> func = () => true;
			await Assert.That(func()).IsTrue();
		}

		[Test]
		public async Task TestTwo()
		{
			Func<bool> func = () => true;
			await Assert.That(func()).IsTrue();
		}

		public static IWebHostBuilder CreateWebHostBuilder() =>
				WebHost
						.CreateDefaultBuilder()
						.UseStartup(x => new Startup());
	}

	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddConnections();
			services.BuildServiceProvider();
		}
		public void Configure(IApplicationBuilder app)
		{
			app.Build();
		}
	}
}
