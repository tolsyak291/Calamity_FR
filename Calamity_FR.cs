using Terraria.ModLoader;
using Terraria.Localization;
using CalamityMod.NPCs.TownNPCs;
using System.Collections.Generic;
using CalamityMod.UI;
using System.Text.Json;
using System.IO;
using CalamityMod;
using CalamityMod.Items;
using CalamityFR.DraedonLogs;
using CalamityFR.JSON;
using Microsoft.Xna.Framework;
using System.Reflection;

namespace Calamity_FR
{
	public class Calamity_FR : Mod
	{
		public Calamity_FR() { }

		public override void Load()
        {
			//Using reflection for adding translatedGUI for Draedons logs
			List<PopupGUI> DraedonGUIList = ((List<PopupGUI>)typeof(PopupGUIManager).GetField("gUIs", BindingFlags.NonPublic | BindingFlags.Static ).GetValue(null));
			DraedonGUIList.Add(new HellGUI() as PopupGUI);
			DraedonGUIList.Add(new JungleGUI() as PopupGUI);
			DraedonGUIList.Add(new SnowGUI() as PopupGUI);
			DraedonGUIList.Add(new PlanetoidGUI() as PopupGUI);
			DraedonGUIList.Add(new SunkenGUI() as PopupGUI);
			//Using reflection for adding translatedGUI for draedon schematics
			//The text is in CalamityMod.TileEntities.TECodebreaker.UnderlyingSchematicText

			//Items To manage in globalItems
			//DraedonsHeart
			//RottenDogtooth
			//SerpentsBite
			//BobbitHook
			//ThePrince
			//HeavenlyGale
			//Seraphim
			//RelicOfResilience
		}

		public override void PostSetupContent()
		{
			if (ModLoader.GetMod("CalamityMod") != null)
			{
				Mod Calamity = ModLoader.GetMod("CalamityMod");
				TranslationConfig cfg = ((TranslationConfig)this.GetConfig("TranslationConfig"));
				if (Calamity != null)
				{
					var list = JsonSerializer.Deserialize<List<TranslationElement>>(TranslationElement.getRaw());
					//this.Logger.Info("Test : taille liste : " + list.Count);
					foreach (TranslationElement element in list)
					{
						if (element.state == "Traduit")
						{
							try
							{
								if (element.type == "BUFF")
								{
									Calamity.Find<ModBuff>(element.id)?.DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), element.name);
									Calamity.Find<ModBuff>(element.id)?.Description.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), element.desc);
								}
								else if (element.type == "ITEM")
								{
									string effectiveName = element.englishName;
									if (cfg.nameInEnglishWithFrench)
									{
										effectiveName = element.name + " (" + effectiveName + ")";
									}
									else if (cfg.nameInFrench) {
										effectiveName = element.name;
									}

									Calamity.Find<ModItem>(element.id)?.DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), effectiveName);
									if (element?.englishTooltip[0] != "DO NOT TRAD")
									{
										Calamity.Find<ModItem>(element.id)?.Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), element.transformTooltip());
									}
								}
								else if (element.type == "NPC")
								{
									Calamity.Find<ModNPC>(element.id)?.DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), element.name);
								}
								else if (element.type == "TRANSLATION")
								{
									ModTranslation text = LocalizationLoader.CreateTranslation("Mods." + ModContent.GetInstance<CalamityMod.CalamityMod>().Name + "." + element.id);
									text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.English), element.englishDesc);
									text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), element.desc);
									text.SetDefault(element.englishDesc);
									LocalizationLoader.AddTranslation(text);
								}
								//ModTranslation name = Calamity.GetTile("PerennialOre").CreateMapEntryName();
								//name.SetDefault("Minerai Vivace");
								//Calamity.GetTile("PerennialOre").AddMapEntry(new Color(200, 250, 100), name);
							}
							catch { }
						}
					}
				}
			}
		}
	}
}