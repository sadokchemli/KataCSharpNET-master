using System;

namespace ClashOfClans.Core.Units
{
    public class Dragon : Unit
    {
        public Dragon() : base(7500, 5000)
        {
			Mouvement = new Fly();
		}

		public const string LastMessage = "I WILL RISE AGAIN FROM THE ASHES";

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
