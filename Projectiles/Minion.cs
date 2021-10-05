using Terraria.ModLoader;

namespace IcePlus.Projectiles
{
	public abstract class Minion : ModProjectile
	{
		public override void AI()
		{
			CheckActive();
		}

		public abstract void CheckActive();
	}
}