using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Units
{
	public class MovementType
	{
		public virtual int Speed { get; set; }
	}
	public class Walk : MovementType
	{
		public override int Speed
		{
			get
			{
				return 3;
			}
		}

	}
	public class TunnelUnder : MovementType
	{
		public override int Speed
		{
			get
			{
				return 5;
			}
		}
	}
	public class Fly : MovementType
	{
		public override int Speed
		{
			get
			{
				return 8;
			}
		}
	}
	public class Run : MovementType
	{
		public override int Speed
		{
			get
			{
				return 6;
			}
		}
	}
}
