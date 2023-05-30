using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-GOIG5JI;Database=mydatabaseApi;User Id=web;Password=web987;TrustServerCertificate=True;");


		}
		public DbSet<Employee> Employees { get; set; }
	}
}
