namespace doro
{
    public class ScoreTable
    {
        public TerrainGroup Tasks { get; set; } = new();
        public TerrainGroup Flags { get; set; } = new();
        public Unlockables Unlockables { get; set; } = new();

        public int Total => Tasks.Total + Flags.Total + Unlockables.Total;
    }

    public class TerrainGroup
    {
        public int Forest { get; set; } = 0;
        public int Wheat { get; set; } = 0;
        public int Town { get; set; } = 0;
        public int Rails { get; set; } = 0;
        public int River { get; set; } = 0;
        public int Double { get; set; } = 0;
        public int Surround { get; set; } = 0;

        public int Total => Forest + Wheat + Town + Rails + River + Double + Surround;
    }

    public class Unlockables
    {
        public int RedHearts { get; set; } = 0;
        public int Circus { get; set; } = 0;
        public int Signalman { get; set; } = 0;
        public int Shepherd { get; set; } = 0;
        public int Hill { get; set; } = 0;
        public int Construction { get; set; } = 0;
        public int Balloon { get; set; } = 0;
        public int GoldenHeart { get; set; } = 0;
        public int ForestHut { get; set; } = 0;
        public int HarvestFestival { get; set; } = 0;
        public int GuardTower { get; set; } = 0;
        public int Locomotive { get; set; } = 0;
        public int Riverboat { get; set; } = 0;
        public int Trainstation { get; set; } = 0;
        public int Harbor { get; set; } = 0;
        public int Mill { get; set; } = 0;
        public int Photographer { get; set; } = 0;
        public int School { get; set; } = 0;
        public int Granary { get; set; } = 0;
        public int Oak { get; set; } = 0;

        public int Total => RedHearts + Circus + Signalman + Shepherd + Hill 
                            + Construction + Balloon + GoldenHeart + ForestHut + HarvestFestival 
                            + GuardTower + Locomotive + Riverboat + Trainstation + Harbor
                            + Mill
                            + Photographer + School + Granary + Oak;
    }

}
