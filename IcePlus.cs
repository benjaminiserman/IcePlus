using Terraria.ModLoader;
using Terraria.ID;

namespace IcePlus
{
	class IcePlus : Mod
	{
        public IcePlus()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
    }
}
