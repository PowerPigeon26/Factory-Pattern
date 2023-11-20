using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface ISkillCall
    {
        public string SkillName { get; set; }
        public string StrengthEstimate { get; set; }
        public string Description { get; set; }
        void Build();
    }
}
