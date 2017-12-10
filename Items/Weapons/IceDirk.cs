using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcePlus.Items.Weapons
{
	public class IceDirk : ModItem
	{

		public override void SetDefaults()
		{
			item.damage = 27;         
			item.melee = true;       
			item.width = 40;         
			item.height = 40;          
			item.useTime = 20;         
			item.useAnimation = 20;        
			item.useStyle = 3;          
			item.knockBack = 3;        
			item.value = 8000;          
			item.rare = 2;          
			item.UseSound = SoundID.Item1;      
			item.autoReuse = true;      
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "IceSpike", 10);
			recipe.AddIngredient(null, "IceTear", 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(5) == 0)
			{
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 15);
			}
		}
	}
}