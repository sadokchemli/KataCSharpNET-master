using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Units
{
	public class Unit
	{
		public Unit()
		{

		}
		public Unit(int offensiveHitpoints, int defensiveHitpoints)
		{
			OffensiveHitpoints = offensiveHitpoints;
			DefensiveHitpoints = defensiveHitpoints;
		}
		public virtual int OffensiveHitpoints { get; protected set; }
		public virtual int DefensiveHitpoints { get; protected set; }
		public MovementType Mouvement { get; protected set; }
		public string LastMessageBeforeDying { get; protected set; }


		public virtual void ReceiveHit(int attackHitpoints)
		{
		
		}

		public int Move(int seconds)
		{
	
			return seconds * this.Mouvement.Speed;
		}
	}

}
