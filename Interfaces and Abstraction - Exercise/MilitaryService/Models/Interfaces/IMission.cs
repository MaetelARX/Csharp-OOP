using MilitaryService.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryService.Models.Interfaces
{
    public interface IMission
    {
        public string CodeName { get; }

        State State { get; }
        void CompleteMission();
    }
}
