using System.Linq;

namespace GameLogic
{
    public class StarterOne
    {
        public void CreateRaces()
        {
            Race Fianku = new Race()
            {
                Name = "Fianku",
                Desc = "Ones of the most beautiful creatures you can find and their minds as magnificent as their snake beauty. " +
                "Their pale skin with islands of green and blue scales on it creates a quite tempting view." +
                "Though it can be immensely hard, don't keep'em in your bed for too long: don't forget that they must bring you money in the first place.",
                HungerRate = 2,
                MaxHunger = 10,
                Beauty = 10,
                Strength = 3,
                Intelligence = 5
            };
            Race Gurdir = new Race()
            {
                Name = "Gurdir",
                Desc = "Big, strong and sturdy creatures with hoves and silky white hair. " +
                "Mostly stubborn yet unwavering. " +
                "You can use them well at different hard labors but remember that they become hungry very fast.",
                HungerRate = 4,
                MaxHunger = 8,
                Beauty = 3,
                Strength = 6,
                Intelligence = 2
            };
            Race Lakeya = new Race()
            {
                Name = "Lakeya",
                Desc = "Common and very mediocore creatures living here and there. " +
                "They have tails, little horns, usually two or more and a pair of big glowing eyes. " +
                "Their skin is variety of pink, red and blue.",
                HungerRate = 1,
                MaxHunger = 8,
                Beauty = 4,
                Strength = 2,
                Intelligence = 3
            };

            Fortress.Races.Add(Fianku);
            Fortress.Races.Add(Gurdir);
            Fortress.Races.Add(Lakeya);

        }

        public void CreateJobs()
        {
            Fortress.Jobs.Add(new Occupation("Forager", 1, 2, 100)
            {
                Level = 1,
            });
            Fortress.Jobs.Add(new Occupation("WoodCutter", 3, 1, 150)
            {
                Level = 1
            });
            Fortress.Jobs.Add(new Occupation("Miner", 2, 1, 200)
            {
                Level = 1
            });
            Fortress.Jobs.Add(new Occupation("Houses", 0, 0, 100)
            {
                Level = 1
            });

        }
        public void StartingResources()
        {
            Fortress.Servants.Add(new Servant("Nigoya", Fortress.Races.First(r => r.Name == "Fianku"))
            {
                Occupation = Fortress.Jobs.First(j => j.Name == "Forager")
            });
            Fortress.Servants.Add(new Servant("Latakiya", Fortress.Races.First(r => r.Name == "Lakeya"))
            {
                Occupation = Fortress.Jobs.First(j => j.Name == "Forager")
            });
            Fortress.CompletedProductsStorage.Add((GeneratedProduct)Fortress.ProductTypes.First().Clone());
            Fortress.CompletedProductsStorage.First().Count = 5;



        }
        public void CreateProductTypes()
        {
            //Forager//
            Fortress.ProductTypes.Add(new GeneratedProduct()
            {
                Name = "Mushroom",
                BelongsToOccup = Fortress.Jobs.First(j => j.Name == "Forager"),
                Price = 2,
                AmountOfWorkNeed = 4,
                Saturation = 2,
                ObtainDifficulty = 3
            });

            //WoodCutter//
            Fortress.ProductTypes.Add(new GeneratedProduct()
            {
                Name = "Wood",
                BelongsToOccup = Fortress.Jobs.First(j => j.Name == "WoodCutter"),
                Price = 4,
                AmountOfWorkNeed = 20,
                Saturation = 0,
                ObtainDifficulty = 1
            });

            //Miner//
            Fortress.ProductTypes.Add(new GeneratedProduct()
            {
                Name = "Stone",
                BelongsToOccup = Fortress.Jobs.First(j => j.Name == "Miner"),
                Price = 2,
                AmountOfWorkNeed = 20,
                Saturation = 0,
                ObtainDifficulty = 1
            });
        }

    }
}
