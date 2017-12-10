using System;
using Terraria;
using Terraria.ModLoader;

namespace IcePlus
{
	public class IcePlusPlayer : ModPlayer
	{
		
		private const int saveVersion = 0;
		
		public bool flinxMinion = false;
		public int heroLives = 0;
		
		public override void ResetEffects()
		{
			flinxMinion = false;
		}
	}
}
