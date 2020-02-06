using System;

namespace ClashOfClans.Core.Units
{
	public class Giant : Unit
	{
		public Giant() : base()
		{
			Mouvement = new Walk();
		}

		private int _defensiveHitpoints;

		public Giant(int offensiveHitpoints, int defensiveHitpoints) : base(offensiveHitpoints, defensiveHitpoints)
		{
			OffensiveHitpoints = offensiveHitpoints;
			_defensiveHitpoints = defensiveHitpoints;
		}

		public const string LastMessage = "OUR IRON FISTS WILL BE REMEMBERED FOREVER";
		
		public override int DefensiveHitpoints => this._defensiveHitpoints;

		public new int OffensiveHitpoints { get; }

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
