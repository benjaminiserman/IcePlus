using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcePlus.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class FluffyCoat : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Fluffy Coat");
			Tooltip.SetDefault("Immunity to 'Frozen'"
				+ "\n and +1 max minions");
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
			player.buffImmune[BuffID.Frozen] = true;
			player.maxMinions++;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SnowyFur", 16);
			recipe.AddIngredient(null, "IceSpike", 10);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}