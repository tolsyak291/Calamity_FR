using CalamityMod.UI;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace CalamityFR.DraedonLogs
{
	public class PlanetoidGUI : DraedonsLogGUI
	{
		public override int TotalPages => 3;

		public override string GetTextByPage()
		{
			switch (Page)
			{
				case 0:
					return "À basse orbite, des masses de terres et de parties variés de ce monde créent un endroit distant et isolé pour les recherches. " +
                        "Indéniablement optimal pour l'astronomie et les sciences assimilées. " +
                        "Je fais grandir beaucoup de choses, ici, dans mes laboratoires, pour tester leurs limites face au froid et au vide de la stratosphère. " +
                        "Bien que peu y survivent, l'existence de certaines créatures ici confirme la possibilité d'y établir une vie avec le temps.";
				case 1:
					return "Je ne porte pas grand intérêt pour les étoiles, ou le cosmos. " +
                        "Bien que je les ai traversés, il reste encore beaucoup à découvrir et à faire dans mon monde. " +
                        "Même si j'ai autrefois habité une autre planète, Le souhait du Seigneur que je lui fournisse des machines fut suffisant pour me motiver à la quitter et à m'installer ailleurs. " +
                        "Un fois que j'aurais découvert et disséqué chaque partie de cet endroit, peut-être que je retournerai vers le macrocosme.";
				default:
					return "Le ver cosmique gonflé, bien que je comprenne pourquoi le Seigneur décide de s'en servir puisqu'il peut le contrôler, est une existence répugnante. " +
                        "Cependant, je n'ai pas pu résister à l'idée de lui créer une armure parfaite en tout point spécialement faite pour lui. " +
                        "Forgée dans un acier cosmique de ma création, il résiste à presque toutes les attaques, tout en lui permettant de conserver sa flexibilité naturelle, en plus d'augmenter ses capacités dimensionnelles. " +
                        "Je suis plutôt satisfait du résultat.";
			}
		}

		public override Texture2D GetTextureByPage()
		{
			switch (Page)
			{
				case 0:
					return ModContent.Request<Texture2D>("CalamityMod/ExtraTextures/UI/DraedonsLogPlanetoid").Value;
				case 1:
					return null;
				default:
					return ModContent.Request<Texture2D>("CalamityMod/ExtraTextures/UI/DraedonsLogDoGArmor").Value;
			}
		}
	}
}
