using IcePlus.Items.Weapons;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcePlus.Projectiles
{
	public class IceBolt : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.Stake);
			aiType = ProjectileID.Stake;
			projectile.penetrate = 5;
		}
		
		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			Main.PlaySound(0, projectile.position);
			projectile.Kill();
			return true;
			
		}
		public override void Kill(int timeLeft)
		{
			Vector2 usePos = projectile.position;
			Vector2 rotVector = (projectile.rotation - MathHelper.ToRadians(90f)).ToRotationVector2();
			usePos += rotVector * 16f;
			
			for (int i = 0; i<10; i++)
			{
				Dust dust = Dust.NewDustDirect(usePos, projectile.width, projectile.height, 15);
				dust.position = (dust.position + projectile.Center) / 2f;
				dust.velocity += rotVector * 2f;
				dust.velocity *= 0.75f;
				dust.noGravity = false;
				usePos -= rotVector * 8f;
			}
			
		} 

	}
	
}
