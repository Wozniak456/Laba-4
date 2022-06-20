using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Bouguet;

class PinkBouquet : BouquetBase
{
    public PinkBouquet()
    {
        Description = $"\tPink buequet: \nHortensie\nPink Rose\nPfingstrose";
    }
    public override double GetCost()
    {
        return 450;
    }
}
