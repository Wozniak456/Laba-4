using ConsoleApp7.Bouguet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Decorators;
//флористична сітка
class FloralMesh : DecoratorBase
{
    private BouquetBase _bouquet;
    public FloralMesh(BouquetBase bouquet)
    {
        _bouquet = bouquet;
        Description = _bouquet.GetDescription()+ "\n  +Floral Mesh";
    }

    public override double GetCost()
    {
        return _bouquet.GetCost() + 30;
    }
}
