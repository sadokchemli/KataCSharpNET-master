using System;

namespace ClashOfClans.Core.Units
{
	public class Miner : Unit
	{
		private int _defensiveHitpoints;

		private int _offensiveHitpoints;

		public Miner() : base()
		{
			Mouvement = new TunnelUnder();
		}
		public Miner(int offensiveHitpoints, int defensiveHitpoints) : base(offensiveHitpoints, defensiveHitpoints)
		{
			_offensiveHitpoints = offensiveHitpoints;
			_defensiveHitpoints = defensiveHitpoints;
		}

		public const string LastMessage = "we return in the ground";

		public override int DefensiveHitpoints
		{
			get { return this._defensiveHitpoints; }
		}

		public new int OffensiveHitpoints
		{
			get { return this._offensiveHitpoints; }
		}

		public override void ReceiveHit(int attackHitpoints)
		{
			_defensiveHitpoints -= attackHitpoints;
			if (DefensiveHitpoints <= 0)
			{
				LastMessageBeforeDying = LastMessage;
			}
		}

	}

}
