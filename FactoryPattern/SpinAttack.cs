using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class SpinAttack : ISkillCall
    {
        public string SkillName { get; set; } = "Spin Attack";
        public string StrengthEstimate { get; set; } = "Solid strength";
        public string Description { get; set; } = "\nA simple yet powerful attackwhere the\n\t" +
                                                    "user spins with weapon outstretched.";

        public void Build()
        {
            Console.WriteLine($"Skill being called: {SkillName}");
            Console.WriteLine($"Strength of Skill: {StrengthEstimate}");
            Console.WriteLine($"Description: {Description}");
        }
    }
}
