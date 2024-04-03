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
                "Das Duell",
                2,
                GetBaseGoals(),
                [ GetModule1(), GetModule2() ]
            );
        }

        private static GoalPack GetBaseGoals()
        {
            var baseGoals = new GoalPack("duelBase", "Basis");
            baseGoals.Categories.Add(GetBaseTasks());
            baseGoals.Categories.Add(GetBaseFlags());
            return baseGoals;
        }

        private static GoalCategory GetBaseTasks()
        {
            var baseTasks = new GoalCategory("tasks", "Aufträge");
            baseTasks.Goals.Add(new Goal("forest", "Wald", 18));
            baseTasks.Goals.Add(new Goal("wheat", "Getreide", 18));
            baseTasks.Goals.Add(new Goal("village", "Dorf", 18));
            baseTasks.Goals.Add(new Goal("rails", "Schiene", 18));
            baseTasks.Goals.Add(new Goal("river", "Fluss", 18));
            baseTasks.Goals.Add(new Goal("surround", "Rundum", 18));
            baseTasks.Goals.Add(new Goal("double", "Doppel", 18, 6));
            return baseTasks;
        }

        private static GoalCategory GetBaseFlags()
        {
            var baseFlags = new GoalCategory("flags", "Flaggen");
            baseFlags.Goals.Add(new Goal("forest", "Wald"));
            baseFlags.Goals.Add(new Goal("wheat", "Getreide"));
            baseFlags.Goals.Add(new Goal("village", "Dorf"));
            baseFlags.Goals.Add(new Goal("rails", "Längste Schiene"));
            baseFlags.Goals.Add(new Goal("river", "Längster Fluss"));
            return baseFlags;
        }

        private static GoalPack GetModule1()
        {
            var module1 = new GoalPack("duelModule1", "Modul 1");
            var category = new GoalCategory("module1", "Modul 1");
            category.Goals.Add(new Goal("largeForest", "Großer Wald", 8, 2));
            category.Goals.Add(new Goal("forestMaster", "Wälderflut", 8, 2));
            category.Goals.Add(new Goal("manyForests", "Viele Wälder", 15));
            category.Goals.Add(new Goal("largeField", "Großes Feld", 8, 2));
            category.Goals.Add(new Goal("fieldMaster", "Felderflut", 8, 2));
            category.Goals.Add(new Goal("manyFields", "Viele Felder", 15));
            category.Goals.Add(new Goal("largeVillage", "Großes Dorf", 8, 2));
            category.Goals.Add(new Goal("villageMaster", "Dörferflut", 8, 2));
            category.Goals.Add(new Goal("manyVillages", "Viele Dörfer", 15));
            module1.Categories.Add(category);
            return module1;
        }

        private static GoalPack GetModule2()
        {
            var module2 = new GoalPack("duelModule2", "Modul 2");
            var category = new GoalCategory("module2", "Modul 2");
            category.Goals.Add(new Goal("hearts", "Herzen"));
            category.Goals.Add(new Goal("photographer", "Der Fotograf", 18));
            category.Goals.Add(new Goal("oak", "Alte Eiche", 18));
            category.Goals.Add(new Goal("granary", "Kornspeicher", 18));
            category.Goals.Add(new Goal("school", "Schule", 18));
            module2.Categories.Add(category);
            return module2;
        }
    }
}
