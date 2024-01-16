using BannerKings.CulturesExpanded.Cultures;
using BannerKings.Managers.Populations;
using BannerKings.Models.BKModels;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEGrowthModel: BKGrowthModel
    {
        public override ExplainedNumber CalculateSettlementCap(Settlement settlement, PopulationData data, bool descriptions = false)
        {
            ExplainedNumber result = base.CalculateSettlementCap(settlement, data, descriptions);

            if (settlement.IsTown)
            {
                Utils.Helpers.ApplyFeat(BKCEFeats.Instance.Megalopolis, settlement.Town.Owner, ref result);
            }  

            return result;
        }
    }
}
