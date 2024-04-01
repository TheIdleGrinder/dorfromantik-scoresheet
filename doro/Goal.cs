using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doro
{
    public class Goal
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Minimum { get; set; } = 0; // Currently no goals with different minimums
        public int Maximum { get; set; } = Int32.MaxValue;
        public int Step { get; set; } = 1;
        public string Description { get; set; } = "";

        public Goal(string id, string name, int max = Int32.MaxValue, int step = 1, string description = "")
        {
            Id = id;
            Name = name;
            Maximum = max;
            Step = step;
            Description = description;
        }
    }
}
