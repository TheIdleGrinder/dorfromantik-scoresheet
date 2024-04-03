using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doro
{
    public class GameConfiguration
    {
        public List<GoalPack> GoalPacks { get; set; } = [];

        private readonly HashSet<string> _Required = [];

        public List<string> GetPackIds()
        {
            return GoalPacks.Select(p => p.Id).ToList();
        }

        public GoalPack GetPack(string packId)
        {
            return GoalPacks.FirstOrDefault(p => p.Id == packId) ?? throw new Exception($"Game does not contain pack '{packId}'");
        }

        public bool HasPack(string packId)
        {
            return GoalPacks.Any(p => p.Id == packId);
        }

        public List<string> GetCategories()
        {
            return GoalPacks.SelectMany(p => p.Categories).Select(c => c.Id).ToHashSet().ToList();
        }

        public string GetCategoryName(string categoryId)
        {
            return GoalPacks.SelectMany(p => p.Categories).
                FirstOrDefault(c => c.Id == categoryId)?.Name 
                ?? throw new Exception($"Category '{categoryId}' does not exist in game");
        }

        public bool HasCategory(string categoryId)
        {
            return GoalPacks.SelectMany(p => p.Categories).Any(c => c.Id == categoryId);
        }

        public void SetRequiredPack(string packId, bool required)
        {
            _ = GetPack(packId); // Ensure pack exists
            if (required)
            {
                _Required.Add(packId);
            }
            else
            {
                _Required.Remove(packId);
            }
        }

        public bool IsRequired(string packId)
        {
            return _Required.Contains(packId);
        }

        public void AddPack(GoalPack pack, bool required = false)
        {
            if (GoalPacks.Any(p => p.Id == pack.Id))
            {
                throw new Exception($"Pack '{pack.Id}' already exists in game");
            }
            GoalPacks.Add(pack);
            SetRequiredPack(pack.Id, required);
        }

        public void RemovePack(string packId)
        {
            if (!GoalPacks.Any(p => p.Id == packId))
            {
                throw new Exception($"Pack '{packId}' does not exist in game");
            }
            if (_Required.Contains(packId))
            {
                throw new Exception($"Cannot remove required pack '{packId}'");
            }
            GoalPacks.RemoveAll(p => p.Id == packId);
        }
    }
}
