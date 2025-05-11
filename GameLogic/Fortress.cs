using System.Collections.Generic;

namespace GameLogic
{
    public static class Fortress
    {
        public static string FortressName { get; set; }
        public static decimal Treasury { get; set; } = 0;
        public static int CurrentDay { get; set; } = 1;
        public static int Mana { get; set; } = 0;
        public static int Houses { get; set; } = 5;
        public static bool PortalUsed { get; set; } = false;
        public static bool Rested { get; set; } = false;

        public static BuildingStructure CurrentBuilding { get; set; } = new BuildingStructure();
        public static List<GeneratedProduct> CompletedProductsStorage = new List<GeneratedProduct>();
        public static List<GeneratedProduct> ProductTypes = new List<GeneratedProduct>();
        public static List<GeneratedProduct> SoldItems = new List<GeneratedProduct>();
        public static List<Servant> Servants = new List<Servant>();
        public static List<Race> Races = new List<Race>();
        public static List<Occupation> Jobs = new List<Occupation>();
        public static List<Notification> Notifications = new List<Notification>();
    }
}
