using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcePlus.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class FluffyCap : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Immunity to 'Chilled'");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 6;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("FluffyCoat") && legs.type == mod.ItemType("FluffyPants");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "20% increased minion damage.";
			player.minionDamage *= 1.2f;
		}
		
		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.Chilled] = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SnowyFur", 8);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}