using Terraria.ID;
using Terraria.ModLoader;

namespace IcePlus.Items.Weapons
{
	public class IceBolt : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Stake);
			item.damage = 9;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("IceBolt");   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 1.5f;                  //The speed of the projectile
			item.ammo = AmmoID.Stake;              //The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "IceSpike", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
