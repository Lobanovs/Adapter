using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Adapter.Models;

namespace Adapter.Adapter.Interfaces
{
    public interface PCGame
    {
        string getTitle();
        int getPegiAllowedAge();
        bool isTripleAGame();
        Requirements getRequirements();
    }

}
