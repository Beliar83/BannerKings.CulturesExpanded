using BannerKings.CulturesExpanded.Cultures;
using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEEconomyModel : BKEconomyModel
    {
        public override ExplainedNumber CalculateTradePower(Settlement settlement, bool descriptions = false)
        {
            ExplainedNumber result = base.CalculateTradePower(settlement, descriptions);
            Utils.Helpers.ApplyFeat(BKCEFeats.Instance.Geroia1, settlement.Party, ref result);
            
            return result;
        }
    }
}
