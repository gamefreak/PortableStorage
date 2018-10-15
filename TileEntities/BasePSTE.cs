﻿using System;
using System.Linq;
using BaseLibrary.Tiles.TileEntites;
using Microsoft.Xna.Framework;
using PortableStorage.UI.TileEntities;
using Terraria.Audio;
using Terraria.ID;

namespace PortableStorage.TileEntities
{
	public abstract class BasePSTE : BaseTE
	{
		public BaseTEPanel UI => PortableStorage.Instance.PanelUI.UI.Elements.OfType<BaseTEPanel>().FirstOrDefault(x => x.te.ID == ID);
		public Vector2? UIPosition;

		public virtual Type UIType => null;
		public virtual LegacySoundStyle OpenSound => SoundID.Item1;
		public virtual LegacySoundStyle CloseSound => SoundID.Item1;
	}
}