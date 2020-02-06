using System;

namespace ClashOfClans.Core.Units
{
	public class Bomber : Unit
	{
		public Bomber() : base()
		{
			Mouvement = new Walk();
		}
		public Bomber(int offensiveHitpoints, int defensiveHitpoints) : base(offensiveHitpoints, defensiveHitpoints)
		{
		}

		public const string LastMessage = "WHEN YOU play with Explosives is dangerous bussiness";

		public override void ReceiveHit(int attackHitpoints)
		{
			DefensiveHitpoints -= attackHitpoints;
			if (DefensiveHitpoints <= 0)
			{
				LastMessageBeforeDying = LastMessage;
			}
		}
	}
}
