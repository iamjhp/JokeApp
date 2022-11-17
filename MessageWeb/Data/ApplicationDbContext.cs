using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MessageWeb.Models;

namespace MessageWeb.Data {
	public class ApplicationDbContext : IdentityDbContext {
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options) {
		}
		public DbSet<MessageWeb.Models.Joke> Joke { get; set; }
	}
}