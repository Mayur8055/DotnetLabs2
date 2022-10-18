using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public interface IProjectRequirement
    {
        string GetUserStories();
        bool GetStoryStatus();
    }

    public class TaxTeam : IProjectRequirement
    {
        public bool GetStoryStatus()
        {
            return false;
        }

        public string GetUserStories()
        {
            return "Developer need some time to complete the project";
        }
    }
}
