using Terraria.ModLoader;

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
