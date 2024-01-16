using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.MapEvents;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEBattleSimulationModel : BKBattleSimulationModel
    {
        public override int SimulateHit(CharacterObject strikerTroop, CharacterObject struckTroop, PartyBase strikerParty, PartyBase struckParty, float strikerAdvantage, MapEvent battle)
        {
            float result = base.SimulateHit(strikerTroop, struckTroop, strikerParty, struckParty, strikerAdvantage, battle);

            if (strikerParty.IsMobile && TaleWorlds.CampaignSystem.Campaign.Current.MapSceneWrapper
                .GetFaceTerrainType(strikerParty.MobileParty.CurrentNavigationFace) == TerrainType.Swamp)
            {
                if (strikerTroop.IsMounted)
                {
                    result *= 0.6f;
                }

                if (struckTroop.IsMounted)
                {
                    result = 1.2f;
                }
            }

            return (int)result;
        }
    }
}
