using System;

namespace ClashOfClans.Core.Units
{
	public class Bomber : Unit
	{
		public Bomber()
		{

		}
		public Bomber(int offensiveHitpoints, int defensiveHitpoints)
		{
			OffensiveHitpoints = offensiveHitpoints;
			DefensiveHitpoints = defensiveHitpoints;
		}

		public const string BomberLastMessage = "WHEN YOU play with Explosives is dangerous bussiness";
		public int DefensiveHitpoints { get; private set; }
		public int OffensiveHitpoints { get; private set; }

		public void ReceiveHit(int attackHitpoints)
		{
			DefensiveHitpoints -= attackHitpoints;
			if (DefensiveHitpoints <= 0)
			{
				LastMessageBeforeDying = BomberLastMessage;
			}
		}

		public int Move(int seconds)
		{
			return seconds * 6;
		}
	}
}
