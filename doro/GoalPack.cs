using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doro
{
    public class GoalPack(string id, string name)
    {
        public string Id { get; set; } = id;
        public string Name { get; set; } = name;
        public List<GoalCategory> Categories { get; set; } = [];

        public bool HasCategory(string categoryId)
        {
            return Categories.Any(c => c.Id == categoryId);
        }

        public GoalCategory GetCategory(string categoryId)
        {
            return Categories.FirstOrDefault(c => c.Id == categoryId) ?? throw new Exception($"Pack '{Id}' does not contain category '{categoryId}'");
        }
    }
}
