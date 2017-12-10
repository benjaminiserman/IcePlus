using Terraria;
using Terraria.ModLoader;

namespace IcePlus.Buffs
{
	public class FlinxMinion : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Friendly Flinx");
			Description.SetDefault("This friendly flinx will fight for you!");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			IcePlusPlayer modPlayer = player.GetModPlayer<IcePlusPlayer>(mod);
			if (player.ownedProjectileCounts[mod.ProjectileType("FlinxMinion")] > 0)
			{
				modPlayer.flinxMinion = true;
			}
			if (!modPlayer.flinxMinion)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 18000;
			}
		}
	}
}