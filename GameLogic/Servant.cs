using System.Linq;

namespace GameLogic
{
    public class Servant
    {
        public string Name { get; set; }
        public Occupation Occupation { get; set; }
        public Race Race { get; set; }
        public int Hunger { get; set; }
        public GeneratedProduct ProccesingProduct { get; set; }
        public Servant(string name, Race race)
        {
            Name = name;
            Race = race;
            Hunger = Race.MaxHunger;
        }
        public void ServantDoJob()
        {
            if (Occupation != null)
            {

                if (ProccesingProduct == null)
                {
                    AddProduct();
                    ServantIsWorking();
                }
                else
                {
                    ServantIsWorking();
                }
                Hunger -= Race.HungerRate * 2;

            }
            else
            {
                Hunger -= Race.HungerRate;
            }
            if (Hunger < 0)
            {
                AddNotify($"{Name} died of hunger!");
                Fortress.Servants.Remove(this);
            }
        }
        public void ServantIsEating()
        {
            bool notyCreated = false;
            while (Hunger <= Race.MaxHunger / 2)
            {
                if (Fortress.CompletedProductsStorage.Any(p => p.Saturation > 0))
                {
                    var foodtaken = Fortress.CompletedProductsStorage.First(f => f.Saturation > 0);
                    foreach (var product in Fortress.CompletedProductsStorage)
                    {
                        if (product.Saturation > foodtaken.Saturation)
                        {
                            foodtaken = product;
                        }
                    }
                    Hunger += foodtaken.Saturation;
                    if (Hunger > Race.MaxHunger)
                    {
                        Hunger = Race.MaxHunger;
                    }
                    if (foodtaken.Count > 1)
                        foodtaken.Count -= 1;
                    else
                        Fortress.CompletedProductsStorage.Remove(foodtaken);
                }
                else if (notyCreated == false)
                {
                    AddNotify("Lack of Food!");
                    notyCreated = true;
                }
            }
        }

        public void ServantIsWorking()
        {
            if (Race.Intelligence * Occupation.IntelligenceAmplifier > Race.Strength * Occupation.StrengthAmplifier)
                ProccesingProduct.CurrentWorkProgress += Race.Intelligence * Occupation.IntelligenceAmplifier;
            else if (Race.Intelligence * Occupation.IntelligenceAmplifier < Race.Strength * Occupation.StrengthAmplifier)
                ProccesingProduct.CurrentWorkProgress += Race.Strength * Occupation.StrengthAmplifier;
            if (ProccesingProduct.CurrentWorkProgress > ProccesingProduct.AmountOfWorkNeed)
            {
                var additionalCount = ProccesingProduct.CurrentWorkProgress / ProccesingProduct.AmountOfWorkNeed;
                if (Fortress.CompletedProductsStorage.Any(p => p.Name == ProccesingProduct.Name))
                    Fortress.CompletedProductsStorage.First(p => p.Name == ProccesingProduct.Name).Count += additionalCount;
                else
                {
                    ProccesingProduct.Count = additionalCount;
                    Fortress.CompletedProductsStorage.Add(ProccesingProduct);
                }
                var remained = ProccesingProduct.CurrentWorkProgress - additionalCount * ProccesingProduct.AmountOfWorkNeed;
                AddNotify($"{ProccesingProduct.Name} added", additionalCount);
                AddProduct();
                ProccesingProduct.CurrentWorkProgress += remained;
            }
        }

        public void AddProduct()
        {
            ProccesingProduct = (GeneratedProduct)Fortress.ProductTypes.First(p => p.BelongsToOccup == Occupation).Clone();
        }

        public void AddNotify(string name)
        {
            Notification notify = new Notification()
            {
                Name = name
            };
            if (Fortress.Notifications.Any(n => n.Name == notify.Name) == false)
                Fortress.Notifications.Add(notify);
            else
                Fortress.Notifications.First(n => n.Name == notify.Name).Count += 1;

        }
        public void AddNotify(string name, int count)
        {
            Notification notify = new Notification()
            {
                Name = name,
                Count = count
            };
            if (Fortress.Notifications.Any(n => n.Name == notify.Name) == false)
                Fortress.Notifications.Add(notify);
            else
                Fortress.Notifications.First(n => n.Name == notify.Name).Count += count;
        }

    }


}
