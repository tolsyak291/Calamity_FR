using CalamityMod.UI;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace CalamityFR.DraedonLogs
{
	public class SnowGUI : CalamityMod.UI.DraedonLogs.DraedonsLogGUI
    {
		public override int TotalPages => 3;

		public override string GetTextByPage()
		{
			switch (Page)
			{
				case 0:
					return "Une toundra glaçante, ou seules les créatures complètement adaptées a ces températures en-dessous de zéro peuvent survivre et prospérer. " +
                        "C'est une transition violente quand on vient des forêts pures ou du désert au soleil cuisant. " +
                        "Un climat comme celui-ci ne devrait pas exister si facilement dans cette partie du monde. " +
                        "Il semble changer anormalement aux alentours de ces plaines gelées. " +
                        "Il y a probablement une raison à cela, ce qui necessite plus de recherches.";
				case 1:
					return "Intriguant. " +
                        "Bien que profondément encrés dans les cavernes de glace et usés par les siècles de givre et d'eau de fonte, j'ai découvert plusieurs mécanismes dont les tunnels étaient probablement remplis . " +
                        "Leur ingénuité est remarquable, et j'ai trouvé des similarités avec mon travail, ainsi que des mécaniques dont j'ai quelque chose à apprendre. " +
                        "D'ou est-ce qu'ils viennent? Pourquoi des machines si complexes sont dans cet habitat lacunaire et morne? " +
                        "Peut-être qu'il ne sont pas étrangers au climat inhabituel.";
				default:
					return "Je ne suis pas le seul être unique à habiter ce biome. " +
                        "Autrefois, l'archimage qui s'opposa au Seigneur habitait ici, camouflé par de constants blizzards artificiels de sa création, qui ne soufflent désormais plus. " +
                        "Il a probablement choisi cet endroit comme un catalyseur pour sa recherche des sorts de glace et pour la longue période durant laquelle cet zone est restée gelée. " +
                        "Mes recherches et mes matériaux sont bien protégés, profondément sous terre, mais à la surface, dans les tempêtes naturelles, il y a des traces de la prison de glace dans laquelle il réside, qui hante encore le lieu de sa création.";
			}
		}

		public override Texture2D GetTextureByPage()
		{
			switch (Page)
			{
				case 0:
					return ModContent.Request<Texture2D>("CalamityMod/ExtraTextures/UI/DraedonsLogIceBiome").Value;
				case 1:
					return null;
				default:
					return ModContent.Request<Texture2D>("CalamityMod/ExtraTextures/UI/DraedonsLogPermafrost").Value;
			}
		}
	}
}
