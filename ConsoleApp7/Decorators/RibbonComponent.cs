using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp7.Bouguet;

namespace ConsoleApp7.Decorators;
//стрічка з написом
class RibbonComponent : DecoratorBase
{
    private BouquetBase _bouquet;
    public RibbonComponent(BouquetBase bouquet)
    {
        _bouquet = bouquet;

        Description = _bouquet.GetDescription() + "\n  +Ribbon Component";
    }
    public override double GetCost()
    {
        return _bouquet.GetCost() + 10;
    }
}
