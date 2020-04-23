using System;

namespace HolyWasher
{
	public class WorkGiver_HolyWash : WorkGiver_DoBill
	{
		public WorkGiver_HolyWash () : base(LocalJobDefOf.HolyWash, false) {}
	}
}