using System;
using ClashOfClans.Core.Units;

namespace ClashOfClans.Core.Buildings
{
	public class BlueTrainingCamp
	{
		public static Bomber ProduceBomber()
		{
			return new Bomber(800, 350);
		}

		public static Giant ProduceGiant()
		{
			return new Giant(3000, 4500);
		}

		public static Miner ProduceMiner()
		{
			return new Miner(1200, 800);
		}
	}
}
