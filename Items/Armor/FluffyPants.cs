using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcePlus.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class FluffyPants : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("15% increased minion damage.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 12000;
			item.rare = 2;
			item.defense = 6;
		}

		public override void UpdateEquip(Player player)
		{
			player.minionDamage *= 1.15f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SnowyFur", 8);
			recipe.AddIngredient(null, "IceTear", 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}