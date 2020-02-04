using System;
using ClashOfClans.Core.Units;

namespace ClashOfClans.Core.Buildings
{
    public class BlackTrainingCamp
    {
        public static Dragon ProduceUnit(UnitType unitType)
        {
            if (unitType == UnitType.Dragon)
                return new Dragon();

            throw new NotImplementedException();
        }
    }
}
