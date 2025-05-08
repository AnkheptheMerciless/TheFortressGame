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
                HungerRate = 2,
                MaxHunger = 10,
                Strength = 3,
                Intelligence = 5
            };
            Race Gurdir = new Race()
            {
                Name = "Gurdir",
                HungerRate = 4,
                MaxHunger = 8,
                Strength = 6,
                Intelligence = 2
            };
            Race Lakeya = new Race()
            {
                Name = "Lakeya",
                HungerRate = 1,
                MaxHunger = 8,
                Strength = 2,
                Intelligence = 3
            };
            Fortress.Races.Add(Fianku);
            Fortress.Races.Add(Gurdir);
            Fortress.Races.Add(Lakeya);

        }

        public void CreateJobs()
        {
            Fortress.Jobs.Add(new Occupation("Forager")
            {
                StrengthAmplifier = 1,
                IntelligenceAmplifier = 2,
            });
            Fortress.Jobs.Add(new Occupation("WoodCutter")
            {
                StrengthAmplifier = 3,
                IntelligenceAmplifier = 1
            });
            Fortress.Jobs.Add(new Occupation("Miner")
            {
                StrengthAmplifier = 2,
                IntelligenceAmplifier = 1
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
                Saturation = 4,
                ObtainDifficulty = 3
            });

            //WoodCutter//
            Fortress.ProductTypes.Add(new GeneratedProduct()
            {
                Name = "Wood",
                BelongsToOccup = Fortress.Jobs.First(j => j.Name == "WoodCutter"),
                Price = 1,
                AmountOfWorkNeed = 20,
                Saturation = 0,
                ObtainDifficulty = 1
            });

            //Miner//
            Fortress.ProductTypes.Add(new GeneratedProduct()
            {
                Name = "Copper",
                BelongsToOccup = Fortress.Jobs.First(j => j.Name == "Miner"),
                Price = 25,
                AmountOfWorkNeed = 30,
                Saturation = 0,
                ObtainDifficulty = 3
            });
        }

    }
}
