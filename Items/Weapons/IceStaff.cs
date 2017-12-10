using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcePlus.Items.Weapons
{
	public class IceStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.DiamondStaff);
			item.damage = 21;
			item.magic = true;
			item.mana = 7;
			item.width = 40;
			item.height = 40;
			item.useTime = 27;
			item.useAnimation = 29;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 8000;
			item.rare = 2;
			item.autoReuse = true;
			item.shoot = 126;
			item.shootSpeed = 9f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "IceSpike", 15);
			recipe.AddIngredient(null, "IceTear", 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}