using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEPartyFoodModel : BKPartyConsumptionModel
    {
        public override ExplainedNumber CalculateDailyFoodConsumptionf(MobileParty party, ExplainedNumber baseConsumption)
        {
            ExplainedNumber result = base.CalculateDailyFoodConsumptionf(party, baseConsumption);
            if (TaleWorlds.CampaignSystem.Campaign.Current.MapSceneWrapper.GetFaceTerrainType(party.CurrentNavigationFace) == TerrainType.Swamp)
            {
                float mounts = CalculateAnimalFoodNeed(party, false);
                result.Add(mounts / 2f, new TaleWorlds.Localization.TextObject("{=!}Carrying {COUNT} animals while sailing (inventory, party and prisoners)")
                    .SetTextVariable("COUNT", mounts.ToString("0")));
            }
            
            return result;
        }
    }
}
