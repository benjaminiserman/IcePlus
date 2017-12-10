using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcePlus.Items.Weapons
{
	public class IcicleLauncher : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Fires ice bolts.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.CobaltRepeater);
			item.damage = 11;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 8000;
			item.rare = 2;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 2.5f;
			item.useAmmo = AmmoID.Stake;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "IceSpike", 15);
			recipe.AddIngredient(null, "IceTear", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
