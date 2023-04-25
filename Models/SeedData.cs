using HelloWorld.Data;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Models
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new HelloWorldContext(
				serviceProvider.GetRequiredService<DbContextOptions<HelloWorldContext>>()
				))
			{
				// Look for any movies
				if (context.Movie.Any()) return; // DB has been seeded

				context.Movie.AddRange(
					new Movie
					{
						Title = "The Batman",
						ReleaseDate = DateTime.Parse("2022-03-04"),
						Genre = "Action movie",
						Price = 10.99M,
						Rating = "Excellent"
					},
					new Movie 
					{
						Title = "Avatar: The Way of Water",
						ReleaseDate = DateTime.Parse("2022-12-16"),
						Genre = "Sci-fi",
						Price = 53.12M,
						Rating = "Ok"
					},
					new Movie
					{
						Title = "Ghostbusters",
						ReleaseDate = DateTime.Parse("1984-3-13"),
						Genre = "Comedy",
						Price = 8.99M,
						Rating = "Good"
					}
					);

				context.SaveChanges();
			}
		}
	}
}
