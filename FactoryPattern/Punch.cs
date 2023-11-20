using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Punch : ISkillCall
    {
        public string SkillName { get; set; } = "Punch";
        public string StrengthEstimate { get; set; } = "Mediocre";
        public string Description { get; set; } =
            "\nUhm, do you really need to purchase\n" +
            "this? It's not a special type of punch,\n" +
            "really anybody could do it...";

        public void Build()
        {
            Console.WriteLine($"Skill being called: {SkillName}");
            Console.WriteLine($"Strength of Skill: {StrengthEstimate}");
            Console.WriteLine($"Description: {Description}");
        }
    }
}
