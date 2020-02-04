using System;

namespace ClashOfClans.Core.Units
{
	public class Giant : Unit
	{
		public Giant()
		{

		}

		private int _defensiveHitpoints;

		public Giant(int offensiveHitpoints, int defensiveHitpoints)
		{
			OffensiveHitpoints = offensiveHitpoints;
			_defensiveHitpoints = defensiveHitpoints;
		}

		public const string GiantLastMessage = "OUR IRON FISTS WILL BE REMEMBERED FOREVER";

		public int DefensiveHitpoints => this._defensiveHitpoints;

		public int OffensiveHitpoints { get; }


		public void ReceiveHit(int attackHitpoints)
		{
			_defensiveHitpoints -= attackHitpoints;
			if (DefensiveHitpoints <= 0)
			{
				LastMessageBeforeDying = Giant.GiantLastMessage;
			}
		}
		public int Move(int seconds)
		{
			return seconds * 3;
		}	
	}
}
