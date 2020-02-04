using System;

namespace ClashOfClans.Core.Units
{
    public class Dragon : Unit
    {
        public Dragon()
        {
			OffensiveHitpoints = 7500;
			DefensiveHitpoints = 5000;
		}

		public const string DragonLastMessage = "I WILL RISE AGAIN FROM THE ASHES";

		public int DefensiveHitpoints { get; private set; }

        public int OffensiveHitpoints { get; private set; }

		public void ReceiveHit(int attackHitpoints)
        {
			DefensiveHitpoints -= attackHitpoints;
			if (DefensiveHitpoints <= 0)
			{
				LastMessageBeforeDying = DragonLastMessage;
			}
		}
		public int Move(int seconds)
		{
			return seconds * 8;
		}
	}
}
