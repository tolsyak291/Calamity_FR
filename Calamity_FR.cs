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
using System.Reflection;
using Terraria;
using Terraria.GameContent.Bestiary;
using System.Collections;
using System.Runtime.CompilerServices;
using System;


namespace Calamity_FR
{
	
	public class Calamity_FR : Mod
	{
		public static Dictionary<int, string> NPCBestiarys;
		public Calamity_FR() { }

		public override void Load()
        {
			//Using reflection for adding translatedGUI for Draedons logs
			NPCBestiarys = new Dictionary<int, string>();

			List<PopupGUI> DraedonGUIList = ((List<PopupGUI>)typeof(PopupGUIManager).GetField("gUIs", BindingFlags.NonPublic | BindingFlags.Static ).GetValue(null));
			DraedonGUIList.Add(new HellGUI() as PopupGUI);
			DraedonGUIList.Add(new JungleGUI() as PopupGUI);
			DraedonGUIList.Add(new SnowGUI() as PopupGUI);
			DraedonGUIList.Add(new PlanetoidGUI() as PopupGUI);
			DraedonGUIList.Add(new SunkenGUI() as PopupGUI);

            //Using reflection for adding translatedGUI for draedon schematics
            //The text is in CalamityMod.TileEntities.TECodebreaker.UnderlyingSchematicText

            //Items To manage in globalItems
            //Amalgamated Brain
            //RottenDogtooth
            //SerpentsBite
            //BobbitHook
            //ThePrince
            //HeavenlyGale
            //Seraphim
            //RelicOfResilience
            //Biome Blade & Galaxia Line (Check)

            //CoralSymbiosis
            //AmalgamatedBrain
            //DraedonsHeart
            //Nanotech
            //RaidersTalisman
            //RottenDogtooth
            //RoverDrive
            //TheAmalgam
            //SerpentsBite
            //WulfrumLureItem
            //BobbitHook
            //ThePrince
            //Seraphim
            //AresExoskeleton
            //Cosmilamp
            //InfectedRemote
            //WarloksMoonFist
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
						if (element.state == "Traduit" || element.state == "Traduit (Bestiaire Manquant)")
						{
							Translation activeTranslation = null;
							foreach (Translation tr in element.translations) {
								if (tr.id == element.activeTranslation) {
									activeTranslation = tr;
									break;
								}
							}
							if(activeTranslation != null) { 
								try
								{
									if (element.type == "BUFF")
									{
										Calamity.Find<ModBuff>(element.id)?.DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), activeTranslation.translatedName);
										Calamity.Find<ModBuff>(element.id)?.Description.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), activeTranslation.translatedDesc);
									}
									else if (element.type == "ITEM")
									{
										string effectiveName = element.englishName;
										if (cfg.nameInEnglishWithFrench)
										{
											effectiveName = activeTranslation.translatedName + " (" + effectiveName + ")";
										}
										else if (cfg.nameInFrench) {
											effectiveName = activeTranslation.translatedName;
										}

										Calamity.Find<ModItem>(element.id)?.DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), effectiveName);
										if (element?.englishTooltip[0] != "DO NOT TRAD")
										{
											Calamity.Find<ModItem>(element.id)?.Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), activeTranslation.transformTooltip());
										}
									}
									else if (element.type == "NPC")
									{
										Calamity.Find<ModNPC>(element.id)?.DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), activeTranslation.translatedName);
										if (element.state == "Traduit")
										{
											NPCBestiarys.Add(Calamity.Find<ModNPC>(element.id).Type, activeTranslation.translatedBestiary);
										}
									}
									else if (element.type == "TRANSLATION")
									{
										ModTranslation text = LocalizationLoader.CreateTranslation("Mods." + ModContent.GetInstance<CalamityMod.CalamityMod>().Name + "." + element.id);
										text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.English), element.englishDesc);
										text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), activeTranslation.translatedDesc);
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
}