using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doro.GameDefinitions
{
    public static class Doro
    {
        const string TASKS = "tasks";
        const string FLAGS = "flags";
        const string UNLOCKABLES = "unlockables";
        const int UNLIMITED = Int32.MaxValue;

        public static GameDefinition GetGame()
        {
            return new GameDefinition(
                "doro",
                "Das Brettspiel",
                1,
                GetBaseGoals(),
                [ GetMillGoals(), GetDuelGoals() ]
            );
        }

        public static GoalPack GetBaseGoals()
        {
            var baseGoals = new GoalPack("base", "Basis");
            baseGoals.Categories.Add(GetBaseTasks());
            baseGoals.Categories.Add(GetBaseFlags());
            baseGoals.Categories.Add(GetBaseUnlockables());
            return baseGoals;
        }

        private static GoalCategory GetBaseTasks()
        {
            var baseTasks = new GoalCategory(TASKS, "Aufträge");
            baseTasks.Goals.Add(new Goal("forest", "Wald", 37));
            baseTasks.Goals.Add(new Goal("wheat", "Getreide", 37));
            baseTasks.Goals.Add(new Goal("village", "Dorf", 37));
            baseTasks.Goals.Add(new Goal("rails", "Schiene", 30));
            baseTasks.Goals.Add(new Goal("river", "Fluss", 30));
            return baseTasks;
        }

        private static GoalCategory GetBaseFlags()
        {
            var baseFlags = new GoalCategory(FLAGS, "Flaggen");
            baseFlags.Goals.Add(new Goal("forest", "Wald"));
            baseFlags.Goals.Add(new Goal("wheat", "Getreide"));
            baseFlags.Goals.Add(new Goal("village", "Dorf"));
            baseFlags.Goals.Add(new Goal("rails", "Schiene"));
            baseFlags.Goals.Add(new Goal("river", "Fluss"));
            return baseFlags;
        }

        private static GoalCategory GetBaseUnlockables()
        {
            var baseUnlockables = new GoalCategory(UNLOCKABLES, "Freigespielt");
            baseUnlockables.Goals.Add(new Goal("redHearts", "Rote Herzen", UNLIMITED, 1, "1/passende Kante"));
            baseUnlockables.Goals.Add(new Goal("circus", "Zirkus", 10, 10, "Umschlossen = 10"));
            baseUnlockables.Goals.Add(new Goal("signalman", "Bahnwärter", UNLIMITED, 2, "2/Bahnübergang"));
            baseUnlockables.Goals.Add(new Goal("shepherdess", "Schäferin", UNLIMITED, 1, "1/Schaf"));
            baseUnlockables.Goals.Add(new Goal("hill", "Hügel", UNLIMITED, 2, "im Abstand 2 = 2/Auftrag"));
            baseUnlockables.Goals.Add(new Goal("construction", "Baustelle", 21, 7, "pro Gebiet 7+ = 7"));
            baseUnlockables.Goals.Add(new Goal("balloon", "Ballon-Startplatz", UNLIMITED, 2, "2/Entfernung"));
            baseUnlockables.Goals.Add(new Goal("goldenHeart", "Goldenes Herz", 12, 2, "2/passende Kante"));
            baseUnlockables.Goals.Add(new Goal("forestHut", "Waldhütte", UNLIMITED, 1, "Wald-Aufträge"));
            baseUnlockables.Goals.Add(new Goal("harvestFestival", "Erntefest", UNLIMITED, 1, "Getreide-Aufträge"));
            baseUnlockables.Goals.Add(new Goal("guardTower", "Wachturm", UNLIMITED, 1, "Stadt-Aufträge"));
            baseUnlockables.Goals.Add(new Goal("locomotive", "Lokomotive", UNLIMITED, 1, "Schienen-Aufträge"));
            baseUnlockables.Goals.Add(new Goal("riverboat", "Schiff", UNLIMITED, 1, "Fluss-Aufträge"));
            baseUnlockables.Goals.Add(new Goal("trainstation", "Bahnhof", UNLIMITED, 2, "beendet = 1/Plättchen"));
            baseUnlockables.Goals.Add(new Goal("harbor", "Hafen", UNLIMITED, 2, "beendet = 1/Plättchen"));
            return baseUnlockables;
        }

        public static GoalPack GetMillGoals()
        {
            var millGoals = new GoalPack("mill", "Mühle");
            var millUnlockables = new GoalCategory(UNLOCKABLES, "Freigespielt");
            millUnlockables.Goals.Add(new Goal("mill", "Große Mühle", UNLIMITED, 2, "abgeschlossen = 2/Auftrag + 2/Fahne"));
            millGoals.Categories.Add(millUnlockables);
            return millGoals;
        }

        public static GoalPack GetDuelGoals()
        {
            var duelGoals = new GoalPack("duel", "Duell");
            var duelTasks = new GoalCategory(TASKS, "Aufträge");
            duelTasks.Goals.Add(new Goal("double", "Doppel", 18));
            duelTasks.Goals.Add(new Goal("surround", "Rundum", 18));
            duelGoals.Categories.Add(duelTasks);
            var duelUnlockables = new GoalCategory(UNLOCKABLES, "Freigespielt");
            duelUnlockables.Goals.Add(new Goal("photo", "Fotograf", UNLIMITED, 1, "1/Kameramarker"));
            duelUnlockables.Goals.Add(new Goal("school", "Schule", UNLIMITED, 1, "im Abstand 2 = 1/Stadtplättchen"));
            duelUnlockables.Goals.Add(new Goal("granary", "Kornspeicher", UNLIMITED, 1, "im Abstand 2 = 1/Getreideplättchen"));
            duelUnlockables.Goals.Add(new Goal("oak", "Alte Eiche", UNLIMITED, 1, "im Abstand 2 = 1/Waldplättchen"));
            duelGoals.Categories.Add(duelUnlockables);
            return duelGoals;
        }
    }
}
