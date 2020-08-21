using Microsoft.EntityFrameworkCore;

namespace NationalPark.Models
{
  public class NationalParkContext : DbContext
  {
    public NationalParkContext(DbContextOptions<NationalParkContext> options)
      : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Acadia", Location = "Main", Description = "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats.", DateEstablished = "1919/02/26", Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/Bass_Harbor_Head_Light_Station_2016.jpg/1920px-Bass_Harbor_Head_Light_Station_2016.jpg"},
          new Park { ParkId = 2, Name = "American Samoa", Location = "American Samoa", Description = "The southernmost national park is on three Samoan islands and protects coral reefs, rainforests, volcanic mountains, and white beaches. The area is also home to flying foxes, brown boobies, sea turtles, and 900 species of fish.", DateEstablished = "1988/10/31", Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Ofu_Beach_NPS.jpg/1280px-Ofu_Beach_NPS.jpg"},
          new Park { ParkId = 3, Name = "Arches", Location = "Utah", Description = "This site features more than 2,000 natural sandstone arches, with some of the most popular arches in the park being Delicate Arch, Landscape Arch and Double Arch.[15] Millions of years of erosion have created these structures located in a desert climate where the arid ground has life-sustaining biological soil crusts and potholes that serve as natural water-collecting basins. Other geologic formations include stone pinnacles, fins, and balancing rocks.[16]", DateEstablished = "1971/11/12", Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/Delicatearch1.jpg/1280px-Delicatearch1.jpg"},
          new Park { ParkId = 4, Name = "Bad Lands", Location = "South Dakota", Description = "The Badlands are a collection of buttes, pinnacles, spires, and mixed-grass prairies. The White River Badlands contain the largest assemblage of known late Eocene and Oligocene mammal fossils.[17] The wildlife includes bison, bighorn sheep, black-footed ferrets, and prairie dogs.", DateEstablished = "1978/10/10", Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/BadlandsView3.jpg/1280px-BadlandsView3.jpg"},
          new Park { ParkId = 5, Name = "Big Bend", Location = "Texas", Description = "Named for the prominent bend in the Rio Grande along the U.S.–Mexico border, this park encompasses a large and remote part of the Chihuahuan Desert. Its main attraction is backcountry recreation in the arid Chisos Mountains and in canyons along the river. A wide variety of Cretaceous and Tertiary fossils as well as cultural artifacts of Native Americans also exist within its borders.", DateEstablished = "1944/06/12", Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e7/Big_Bend_National_Park_PB112573.jpg/1280px-Big_Bend_National_Park_PB112573.jpg"}
        );
    }
  }
}