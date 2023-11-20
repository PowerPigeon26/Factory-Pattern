using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class VulcanBlaze : ISkillCall
    {
        public string SkillName { get; set; } = "Vulcan Blaze";
        public string StrengthEstimate { get; set; } = "Strong, and viciously fast!";
        public string Description { get; set; } = "\nAttack foe with blazing fists, and\n\t" +
                                                    "finishing with 2 uppercut kicks and\n\t" +
                                                    "engulfing the enemy in fire!";

        public void Build()
        {
            Console.WriteLine($"Skill being called: {SkillName}");
            Console.WriteLine($"Strength of Skill: {StrengthEstimate}");
            Console.WriteLine($"Description: {Description}");
        }
    }
}
