using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcePlus.Projectiles
{
    public class GlacierBall : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.penetrate = -1; // Penetrates NPCs infinitely.
            projectile.melee = true; // Deals melee dmg.

            projectile.aiStyle = 15; // Set the aiStyle to that of a flail.
        }

        // Now this is where the chain magic happens. You don't have to try to figure this whole thing out.
        // Just make sure that you edit the first line (which starts with 'Texture2D texture') correctly.
        public override bool PreDraw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch, Color lightColor)
        {
            // So set the correct path here to load the chain texture. 'YourModName' is of course the name of your mod.
            // Then into the Projectiles folder and take the texture that is called 'CustomFlailBall_Chain'.
            Texture2D texture = ModLoader.GetTexture("IcePlus/Projectiles/GlacierBall_Chain");

            Vector2 position = projectile.Center;
            Vector2 mountedCenter = Main.player[projectile.owner].MountedCenter;
            Microsoft.Xna.Framework.Rectangle? sourceRectangle = new Microsoft.Xna.Framework.Rectangle?();
            Vector2 origin = new Vector2((float)texture.Width * 0.5f, (float)texture.Height * 0.5f);
            float num1 = (float)texture.Height;
            Vector2 vector2_4 = mountedCenter - position;
            float rotation = (float)Math.Atan2((double)vector2_4.Y, (double)vector2_4.X) - 1.57f;

            bool flag = true;
            if (float.IsNaN(position.X) && float.IsNaN(position.Y))
                flag = false;
            if (float.IsNaN(vector2_4.X) && float.IsNaN(vector2_4.Y))
                flag = false;

            while (flag)
            {
                if ((double)vector2_4.Length() < (double)num1 + 1.0)
                {
                    flag = false;
                }
                else
                {
                    Vector2 vector2_1 = vector2_4;
                    vector2_1.Normalize();
                    position += vector2_1 * num1;
                    vector2_4 = mountedCenter - position;
                    Microsoft.Xna.Framework.Color color2 = Lighting.GetColor((int)position.X / 16, (int)((double)position.Y / 16.0));
                    color2 = projectile.GetAlpha(color2);
                    Main.spriteBatch.Draw(texture, position - Main.screenPosition, sourceRectangle, color2, rotation, origin, 1f, SpriteEffects.None, 0.0f);
                }
            }
			
			Vector2 usePos = projectile.position;
			Vector2 rotVector = (projectile.rotation - MathHelper.ToRadians(90f)).ToRotationVector2();
			usePos += rotVector * 16f;		
            
			if (Main.rand.Next(5) == 0)
			{	
				Dust dust = Dust.NewDustDirect(usePos, projectile.width, projectile.height, 15);
				dust.position = (dust.position + projectile.Center) / 2f;
				dust.velocity += rotVector * 2f;
				dust.velocity *= 0.75f;
				dust.noGravity = false;
				usePos -= rotVector * 8f;
			}

            return true;
        }
    }
}