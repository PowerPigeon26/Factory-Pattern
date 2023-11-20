using System.ComponentModel.DataAnnotations;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What skill are you looking for?\n" +
                "(Skills available: Dimension Slash, Spin Attack,\n" +
                "Vulcan Blaze, and Punch)");
            string wantedSkill = Console.ReadLine();

            ISkillCall skill = AbilityFactory.GetSkill(wantedSkill); //default is punch
            skill.Build();
        }
    }
}
