using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
     
namespace IcePlus.Items.Weapons
{
	//imported from my tAPI mod because I'm lazy
	public class FlinxStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Summons a friendly flinx to fight for you.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.SlimeStaff);
			item.damage = 10;
			item.summon = true;
			item.width = 26;
			item.height = 28;
			item.noMelee = true;
			item.knockBack = 9.5f;
			item.value = 8000;
			item.rare = 2;
			item.UseSound = SoundID.Item44;
			item.shoot = mod.ProjectileType("FlinxMinion");
			item.shootSpeed = 1f;
			item.buffType = mod.BuffType("FlinxMinion");	
			item.buffTime = 3600;
		}
		
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			return player.altFunctionUse != 2;
		}
		
		public override bool UseItem(Player player)
		{
			if(player.altFunctionUse == 2)
			{
				player.MinionNPCTargetAim();
			}
			return base.UseItem(player);
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "IceSpike", 5);
			recipe.AddIngredient(null, "IceTear", 2);
			recipe.AddIngredient(null, "SnowyFur", 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
