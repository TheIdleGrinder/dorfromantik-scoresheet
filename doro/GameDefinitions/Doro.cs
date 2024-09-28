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
        public const int UNLIMITED = Int32.MaxValue;

        public static GameDefinition GetGame()
        {
            return new GameDefinition(
                "doro",
                Localization.Doro.Dorfromantik_BaseGame,
                1,
                GetBaseGoals(),
                [ GetMillGoals(), GetDuelGoals(), GetWetterauGoals() ]
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
            baseUnlockables.Goals.Add(new Goal("redHearts", Localization.Doro.RedHearts, UNLIMITED, 1, Localization.Doro.RedHearts_Descr));
            baseUnlockables.Goals.Add(new Goal("circus", Localization.Doro.Circus, 10, 10, Localization.Doro.Circus_Descr));
            baseUnlockables.Goals.Add(new Goal("signalman", Localization.Doro.Signalman, UNLIMITED, 2, Localization.Doro.Signalman_Descr));
            baseUnlockables.Goals.Add(new Goal("shepherdess", Localization.Doro.Shepherdess, UNLIMITED, 1, Localization.Doro.Shepherdess_Descr));
            baseUnlockables.Goals.Add(new Goal("hill", Localization.Doro.Hill, UNLIMITED, 2, Localization.Doro.Hill_Descr));
            baseUnlockables.Goals.Add(new Goal("construction", Localization.Doro.Construction, 21, 7, Localization.Doro.Construction_Descr));
            baseUnlockables.Goals.Add(new Goal("balloon", Localization.Doro.Balloon, UNLIMITED, 2, Localization.Doro.Balloon_Descr));
            baseUnlockables.Goals.Add(new Goal("goldenHeart", Localization.Doro.GoldenHeart, 12, 2, Localization.Doro.GoldenHeart_Descr));
            baseUnlockables.Goals.Add(new Goal("forestCabin", Localization.Doro.ForestCabin, UNLIMITED, 1, Localization.Doro.ForestCabin_Descr));
            baseUnlockables.Goals.Add(new Goal("harvestFestival", Localization.Doro.HarvestFestival, UNLIMITED, 1, Localization.Doro.HarvestFestival_Descr));
            baseUnlockables.Goals.Add(new Goal("watchtower", Localization.Doro.Watchtower, UNLIMITED, 1, Localization.Doro.Watchtower_Descr));
            baseUnlockables.Goals.Add(new Goal("locomotive", Localization.Doro.Locomotive, UNLIMITED, 1, Localization.Doro.Locomotive_Descr));
            baseUnlockables.Goals.Add(new Goal("ship", Localization.Doro.Ship, UNLIMITED, 1, Localization.Doro.Ship_Descr));
            baseUnlockables.Goals.Add(new Goal("trainStation", Localization.Doro.Trainstation, UNLIMITED, 2, Localization.Doro.Trainstation_Descr));
            baseUnlockables.Goals.Add(new Goal("harbor", Localization.Doro.Harbor, UNLIMITED, 2, Localization.Doro.Harbor_Descr));
            return baseUnlockables;
        }

        public static GoalPack GetMillGoals()
        {
            var millGoals = new GoalPack("mill", Localization.Doro.Mill);
            var millUnlockables = new GoalCategory(UNLOCKABLES, Localization.Doro.Unlockables);
            millUnlockables.Goals.Add(new Goal("mill", Localization.Doro.Mill, UNLIMITED, 2, Localization.Doro.Mill_Descr));
            millGoals.Categories.Add(millUnlockables);
            return millGoals;
        }

        public static GoalPack GetDuelGoals()
        {
            var duelGoals = new GoalPack("duel", Localization.Duel.Dorfromantik_Duel);
            var duelTasks = new GoalCategory(TASKS, Localization.Doro.Tasks);
            duelTasks.Goals.Add(new Goal("double", Localization.Duel.Double, 18));
            duelTasks.Goals.Add(new Goal("surround", Localization.Duel.Wraparound, 18));
            duelGoals.Categories.Add(duelTasks);
            var duelUnlockables = new GoalCategory(UNLOCKABLES, Localization.Doro.Unlockables);
            duelUnlockables.Goals.Add(new Goal("photo", Localization.Duel.Photographer, UNLIMITED, 1, Localization.Duel.Photographer_Descr));
            duelUnlockables.Goals.Add(new Goal("oak", Localization.Duel.OldOak, UNLIMITED, 1, Localization.Duel.OldOak_Descr));
            duelUnlockables.Goals.Add(new Goal("granary", Localization.Duel.Granary, UNLIMITED, 1, Localization.Duel.Granary_Descr));
            duelUnlockables.Goals.Add(new Goal("school", Localization.Duel.School, UNLIMITED, 1, Localization.Duel.School_Descr));
            duelGoals.Categories.Add(duelUnlockables);
            return duelGoals;
        }

        public static GoalPack GetWetterauGoals()
        {
            var wetterauGoals = new GoalPack("wetterau", Localization.Doro.Wetterau);
            var wetterauUnlockables = new GoalCategory(UNLOCKABLES, Localization.Doro.Unlockables);
            wetterauUnlockables.Goals.Add(new Goal("adolfTower", Localization.Doro.AdolfTower, 4, 1, Localization.Doro.AdolfTower_Descr));
            wetterauUnlockables.Goals.Add(new Goal("tvTower", Localization.Doro.TvTower, 4, 1, Localization.Doro.TvTower_Descr));
            wetterauUnlockables.Goals.Add(new Goal("pegasus", Localization.Doro.Pegasus, 4, 1, Localization.Doro.Pegasus_Descr));
            wetterauGoals.Categories.Add(wetterauUnlockables);
            return wetterauGoals;
        }
    }
}
