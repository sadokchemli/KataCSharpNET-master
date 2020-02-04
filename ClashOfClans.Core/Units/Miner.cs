using System;

namespace ClashOfClans.Core.Units
{
	public class Miner : Unit
	{
		private int _defensiveHitpoints;

		private int _offensiveHitpoints;

		public Miner()
		{
		}
		public Miner(int offensiveHitpoints, int defensiveHitpoints)
		{
			_offensiveHitpoints = offensiveHitpoints;
			_defensiveHitpoints = defensiveHitpoints;
		}

		public const string MinerLastMessage = "we return in the ground";

		public int DefensiveHitpoints
		{
			get { return this._defensiveHitpoints; }
		}

		public int OffensiveHitpoints
		{
			get { return this._offensiveHitpoints; }
		}


		public void ReceiveHit(int attackHitpoints)
		{
			_defensiveHitpoints -= attackHitpoints;
			if (DefensiveHitpoints <= 0)
			{
				LastMessageBeforeDying = MinerLastMessage;
			}
		}

		public int Move(int seconds)
		{
			return seconds * 5;
		}
	}
}
