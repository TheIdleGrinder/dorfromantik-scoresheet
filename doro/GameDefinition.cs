using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doro
{
    public class GameDefinition(string id, string name, GoalPack baseGoals, List<GoalPack> expansions)
    {
        public string Id { get; } = id;
        public string Name { get; } = name;
        public GoalPack BaseGoals { get; } = baseGoals;
        public List<GoalPack> ExpansionPacks { get; } = expansions;

        public GameConfiguration GetBaseConfiguration()
        {
            GameConfiguration game = new();
            game.AddPack(BaseGoals, true);
            return game;
        }

        public GameConfiguration GetExpandedConfiguration(List<string> packIds)
        {
            var game = GetBaseConfiguration();
            foreach (string packId in packIds)
            {
                GoalPack pack = ExpansionPacks.FirstOrDefault(p => p.Id == packId) 
                    ?? throw new Exception($"No expansion '{packId}' for '{Id}'");
                game.AddPack(pack, false);
            }
            return game;
        }

        public List<GoalPack> GetAllPacks()
        {
            return [BaseGoals, .. ExpansionPacks];
        }

        public List<string> GetAllCategoryIds()
        {
            var categories = BaseGoals.Categories.Select(c => c.Id).ToList();
            foreach (var pack in ExpansionPacks)
            {
                foreach (var category in pack.Categories)
                {
                    if (!categories.Contains(category.Id)) // Do this instead of set to guarantee order
                    {
                        categories.Add(category.Id);
                    }
                }
            }
            return categories;
        }
    }
}
