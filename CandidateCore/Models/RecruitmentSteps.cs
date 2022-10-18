using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateCore.Models
{
    public class RecruitmentSteps : BaseEntity<int>
    {
        public string StepsName { get; set; }
        public int StepsQueue { get; set; }    
    }
}
