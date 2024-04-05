using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doro.GameDefinitions
{
    public static class Duel
    {
        public static GameDefinition GetGame()
        {
            return new GameDefinition(
                "duel",
                Localization.Duel.Dorfromantik_Duel,
                2,
                GetBaseGoals(),
                [ GetModule1(), GetModule2() ]
            );
        }

        private static GoalPack GetBaseGoals()
        {
            var baseGoals = new GoalPack("duelBase", Localization.Doro.BasePack);
            baseGoals.Categories.Add(GetBaseTasks());
            baseGoals.Categories.Add(GetBaseFlags());
            return baseGoals;
        }

        private static GoalCategory GetBaseTasks()
        {
            var baseTasks = new GoalCategory("tasks", Localization.Doro.Tasks);
            baseTasks.Goals.Add(new Goal("forest", Localization.Doro.Forest, 18));
            baseTasks.Goals.Add(new Goal("grain", Localization.Doro.Grain, 18));
            baseTasks.Goals.Add(new Goal("village", Localization.Doro.Village, 18));
            baseTasks.Goals.Add(new Goal("track", Localization.Doro.Track, 18));
            baseTasks.Goals.Add(new Goal("stream", Localization.Doro.Stream, 18));
            baseTasks.Goals.Add(new Goal("wraparound", Localization.Duel.Wraparound, 18));
            baseTasks.Goals.Add(new Goal("double", Localization.Duel.Double, 18, 6));
            return baseTasks;
        }

        private static GoalCategory GetBaseFlags()
        {
            var baseFlags = new GoalCategory("flags", Localization.Doro.Flags);
            baseFlags.Goals.Add(new Goal("forest", Localization.Doro.Forest));
            baseFlags.Goals.Add(new Goal("grain", Localization.Doro.Grain));
            baseFlags.Goals.Add(new Goal("village", Localization.Doro.Village));
            baseFlags.Goals.Add(new Goal("track", Localization.Doro.LongestTrack));
            baseFlags.Goals.Add(new Goal("stream", Localization.Doro.LongestStream));
            return baseFlags;
        }

        private static GoalPack GetModule1()
        {
            var module1 = new GoalPack("duelModule1", Localization.Duel.Module1);
            var category = new GoalCategory("module1", Localization.Duel.Module1);
            category.Goals.Add(new Goal("largeForest", Localization.Duel.LargeForest, 8, 2));
            category.Goals.Add(new Goal("forestMaster", Localization.Duel.ForestMaster, 8, 2));
            category.Goals.Add(new Goal("manyForests", Localization.Duel.ManyForests, 15));
            category.Goals.Add(new Goal("largeField", Localization.Duel.LargeField, 8, 2));
            category.Goals.Add(new Goal("fieldMaster", Localization.Duel.FieldMaster, 8, 2));
            category.Goals.Add(new Goal("manyFields", Localization.Duel.ManyFields, 15));
            category.Goals.Add(new Goal("largeVillage", Localization.Duel.LargeVillage, 8, 2));
            category.Goals.Add(new Goal("villageMaster", Localization.Duel.VillageMaster, 8, 2));
            category.Goals.Add(new Goal("manyVillages", Localization.Duel.ManyVillages, 15));
            module1.Categories.Add(category);
            return module1;
        }

        private static GoalPack GetModule2()
        {
            var module2 = new GoalPack("duelModule2", Localization.Duel.Module2);
            var category = new GoalCategory("module2", Localization.Duel.Module2);
            category.Goals.Add(new Goal("hearts", Localization.Duel.Hearts, Doro.UNLIMITED, 1, Localization.Doro.RedHearts));
            category.Goals.Add(new Goal("photographer", Localization.Duel.Photographer, 18, 1, Localization.Duel.Photographer_Descr));
            category.Goals.Add(new Goal("oak", Localization.Duel.OldOak, 18, 1, Localization.Duel.OldOak_Descr));
            category.Goals.Add(new Goal("granary", Localization.Duel.Granary, 18, 1, Localization.Duel.Granary_Descr));
            category.Goals.Add(new Goal("school", Localization.Duel.School, 18, 1, Localization.Duel.School_Descr));
            module2.Categories.Add(category);
            return module2;
        }
    }
}
