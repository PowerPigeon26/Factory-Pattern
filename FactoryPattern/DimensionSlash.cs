using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class DimensionSlash : ISkillCall
    {
        public string SkillName { get; set; } = "Dimension Slash";
        public string StrengthEstimate { get; set; } = "Immensely strong!";
        public string Description { get; set; } = "\nA slash that release a wave of destructive.";

        public void Build()
        {
            Console.WriteLine($"Skill being called: {SkillName}");
            Console.WriteLine($"Strength of Skill: {StrengthEstimate}");
            Console.WriteLine($"Description: {Description}");
        }
    }
}
