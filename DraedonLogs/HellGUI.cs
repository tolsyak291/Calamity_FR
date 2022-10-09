using System;
using CalamityMod.UI;
using Microsoft.Xna.Framework.Graphics;
using CalamityMod.Items.DraedonMisc;
using Terraria.ModLoader;

namespace CalamityFR.DraedonLogs
{
	public class HellGUI : CalamityMod.UI.DraedonLogs.DraedonsLogGUI
	{
		public override int TotalPages => 3;

		public override string GetTextByPage()
		{
			switch (Page)
			{
				case 0:
					return "Cet endroit est une source d'énergie géothermique et de chaleur constante pour une forge. " +
                        "Si ce n'était pas complètement inhabitable à part pour les démons et les esprits, je conduirais beaucoup plus de mes recherches dans les entrailles de la terre. " +
                        "En revanche, j'évite soigneusement les vestiges de soufre. " +
                        "Là-bas, le magma est... non-coopératif et beaucoup plus corrosif que ce qui devrait être possible, vu qu'il est saturé d'âmes maudites et déformées, grace à cette sorcière.";
				case 1:
					return "Quelle terrible abomination, et pourtant c'est un sujet d'étude attrayant. " +
                        "Non sans rappeler la fusion des esprits qui hantent le donjon, cette entité n'est pas formée d'une, mais d'une multitude de pécheurs. " +
                        "Ce qui le rend différent en revanche, c'est que les limitations causées par l'artificialité de l'existence du donjon ne s'y applique pas. " +
                        "Ce sont les lois de l'enfer qui les ont rassemblés en un seul suzerain des enfers. " +
                        "Et quand une vie innocente est sacrifiée... Sa faim, qui semble être en phase avec l'au-delà, déferle.";
				default:
					return "Une lame complètement inondée par mon entourage au moment de sa création. " +
                        "Elle fut trempée par les feux alimentés par les esprits, et formée dans le magma tiré de mes laboratoires. " +
                        "Son tranchant est sans pareil, bien que sa portée rend son utilité discutable. " +
                        "Je la considère comme ma première incursion dans l'art et l'artisanat. " +
                        "J'ai beau être né artificiellement, chacune de mes créations amènant a se reposer la question est une création dont je peux être fier. " +
                        "Cela montre, qu'après tout, je peux être visité par une muse.";
			}
		}

		public override Texture2D GetTextureByPage()
		{
			switch (Page)
			{
				case 0:
					return ModContent.Request<Texture2D>("CalamityMod/UI/DraedonLogs/DraedonsLogCragsBiome").Value;
				case 1:
					return ModContent.Request<Texture2D>("CalamityMod/UI/DraedonLogs/DraedonsLogWallOfFlesh").Value;
				default:
					return ModContent.Request<Texture2D>("CalamityMod/UI/DraedonLogs/DraedonsLogMurasamaPhaseslayer").Value;
			}
		}

	}
}
