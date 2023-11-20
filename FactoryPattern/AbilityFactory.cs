using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class AbilityFactory
    {
        public static ISkillCall GetSkill(string skillName)
        {
            switch (skillName.ToLower())
            {
                case "dimension slash":
                    return new DimensionSlash();
                case "spin attack":
                    return new SpinAttack();
                case "vulcan blaze":
                    return new VulcanBlaze();
                default:
                    return new Punch();
            }
        }
    }
}
