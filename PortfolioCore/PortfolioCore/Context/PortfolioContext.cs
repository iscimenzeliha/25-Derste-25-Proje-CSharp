using Microsoft.EntityFrameworkCore;
using PortfolioCore.Entities;

namespace PortfolioCore.Context
{
	public class PortfolioContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-Q6KQKGH;Initial Catalog=DbPortfolionight;Integrated Security=True; Trusted_Connection=True;TrustServerCertificate=True;");
		}
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Education> Educations { get; set; }
		public DbSet<Experience> Experiences { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<TestiMonial> TestiMonials { get; set; }
		public DbSet<Skill> Skills { get; set; }
	}
}
