using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcePlus.Projectiles
{
	
	public class FlinxMinion : Minion
	{
		public override void SetStaticDefaults()
		{
			Main.projFrames[projectile.type] = 12;
			ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
			ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true; //This is necessary for right-click targeting
		}

		public override void SetDefaults()
		{
			projectile.netImportant = true;
			projectile.width = 34;
			projectile.height = 34;
			projectile.friendly = true;
			projectile.minion = true;
			projectile.minionSlots = 1;
			projectile.penetrate = -1;
			projectile.timeLeft = 18000;
			projectile.tileCollide = false;
			projectile.ignoreWater = false;
			projectile.aiStyle = 26;
			aiType = 266;
		}

		public override void CheckActive()
		{
			Player player = Main.player[projectile.owner];
			IcePlusPlayer modPlayer = player.GetModPlayer<IcePlusPlayer>(mod);
			if (player.dead)
			{
				modPlayer.flinxMinion = false;
			}
			if (modPlayer.flinxMinion)
			{
				projectile.timeLeft = 2;
			}
		}

		
		public override bool TileCollideStyle(ref int width, ref int height, ref bool fallThrough)
		{
			fallThrough = false;
			return true;
		}
		
		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			if (projectile.penetrate == 0)
			{
				projectile.Kill();
			}
			return false;
		}



	}
}