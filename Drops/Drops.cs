using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcePlus.Drops
{
	class MyGlobalNPC : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (NPC.downedBoss2) // if eater of worlds / brain of cthulu is killed
			{
				if (npc.type == NPCID.SpikedIceSlime)
				{
					if (Main.rand.Next(3) < 2)
					{
						Item.NewItem(npc.getRect(), mod.ItemType("IceSpike"), Main.rand.Next(2) + 1);
					}
				}

				if (npc.type == NPCID.SnowFlinx)
				{
					if (Main.rand.Next(4) < 3)
					{
						Item.NewItem(npc.getRect(), mod.ItemType("SnowyFur"), Main.rand.Next(4) + 2);
					}
				}
				
				if (npc.type == NPCID.IceBat)
				{
					if (Main.rand.Next(5) < 1)
					{
						Item.NewItem(npc.getRect(), mod.ItemType("IceTear"), 1);
					}
				}
			}			
		}
	}
}