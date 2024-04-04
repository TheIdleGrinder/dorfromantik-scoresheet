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
                Localization.Doro.Dorfromantik_BaseGame,
                1,
                GetBaseGoals(),
                [ GetMillGoals(), GetDuelGoals() ]
            );
        }

        public static GoalPack GetBaseGoals()
        {
            var baseGoals = new GoalPack("base", Localization.Doro.BasePack);
            baseGoals.Categories.Add(GetBaseTasks());
            baseGoals.Categories.Add(GetBaseFlags());
            baseGoals.Categories.Add(GetBaseUnlockables());
            return baseGoals;
        }

        private static GoalCategory GetBaseTasks()
        {
            var baseTasks = new GoalCategory(TASKS, Localization.Doro.Tasks);
            baseTasks.Goals.Add(new Goal("forest", Localization.Doro.Forest, 37));
            baseTasks.Goals.Add(new Goal("grain", Localization.Doro.Grain, 37));
            baseTasks.Goals.Add(new Goal("village", Localization.Doro.Village, 37));
            baseTasks.Goals.Add(new Goal("track", Localization.Doro.Track, 30));
            baseTasks.Goals.Add(new Goal("stream", Localization.Doro.Stream, 30));
            return baseTasks;
        }

        private static GoalCategory GetBaseFlags()
        {
            var baseFlags = new GoalCategory(FLAGS, Localization.Doro.Flags);
            baseFlags.Goals.Add(new Goal("forest", Localization.Doro.Forest));
            baseFlags.Goals.Add(new Goal("grain", Localization.Doro.Grain));
            baseFlags.Goals.Add(new Goal("village", Localization.Doro.Village));
            baseFlags.Goals.Add(new Goal("track", Localization.Doro.Track));
            baseFlags.Goals.Add(new Goal("stream", Localization.Doro.Stream));
            return baseFlags;
        }

        private static GoalCategory GetBaseUnlockables()
        {
            var baseUnlockables = new GoalCategory(UNLOCKABLES, Localization.Doro.Unlockables);
            baseUnlockables.Goals.Add(new Goal("redHearts", Localization.Doro.RedHearts, UNLIMITED, 1, "1/passende Kante"));
            baseUnlockables.Goals.Add(new Goal("circus", Localization.Doro.Circus, 10, 10, "Umschlossen = 10"));
            baseUnlockables.Goals.Add(new Goal("signalman", Localization.Doro.Signalman, UNLIMITED, 2, "2/Bahnübergang"));
            baseUnlockables.Goals.Add(new Goal("shepherdess", Localization.Doro.Shepherdess, UNLIMITED, 1, "1/Schaf"));
            baseUnlockables.Goals.Add(new Goal("hill", Localization.Doro.Hill, UNLIMITED, 2, "im Abstand 2 = 2/Auftrag"));
            baseUnlockables.Goals.Add(new Goal("construction", Localization.Doro.Construction, 21, 7, "pro Gebiet 7+ = 7"));
            baseUnlockables.Goals.Add(new Goal("balloon", Localization.Doro.Balloon, UNLIMITED, 2, "2/Entfernung"));
            baseUnlockables.Goals.Add(new Goal("goldenHeart", Localization.Doro.GoldenHeart, 12, 2, "2/passende Kante"));
            baseUnlockables.Goals.Add(new Goal("forestCabin", Localization.Doro.ForestCabin, UNLIMITED, 1, "Wald-Aufträge"));
            baseUnlockables.Goals.Add(new Goal("harvestFestival", Localization.Doro.HarvestFestival, UNLIMITED, 1, "Getreide-Aufträge"));
            baseUnlockables.Goals.Add(new Goal("watchtower", Localization.Doro.Watchtower, UNLIMITED, 1, "Stadt-Aufträge"));
            baseUnlockables.Goals.Add(new Goal("locomotive", Localization.Doro.Locomotive, UNLIMITED, 1, "Schienen-Aufträge"));
            baseUnlockables.Goals.Add(new Goal("ship", Localization.Doro.Ship, UNLIMITED, 1, "Fluss-Aufträge"));
            baseUnlockables.Goals.Add(new Goal("trainStation", Localization.Doro.Trainstation, UNLIMITED, 2, "beendet = 1/Plättchen"));
            baseUnlockables.Goals.Add(new Goal("harbor", Localization.Doro.Harbor, UNLIMITED, 2, "beendet = 1/Plättchen"));
            return baseUnlockables;
        }

        public static GoalPack GetMillGoals()
        {
            var millGoals = new GoalPack("mill", "Große Mühle");
            var millUnlockables = new GoalCategory(UNLOCKABLES, Localization.Doro.Unlockables);
            millUnlockables.Goals.Add(new Goal("mill", "Große Mühle", UNLIMITED, 2, "abgeschlossen = 2/Auftrag + 2/Fahne"));
            millGoals.Categories.Add(millUnlockables);
            return millGoals;
        }

        public static GoalPack GetDuelGoals()
        {
            var duelGoals = new GoalPack("duel", "Das Duell");
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
