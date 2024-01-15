using BannerKings.CulturesExpanded.Cultures;
using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEMilitiaModel : BKMilitiaModel
    {
        public override ExplainedNumber CalculateMilitiaChange(Settlement settlement, bool includeDescriptions = false)
        {
            ExplainedNumber result = base.CalculateMilitiaChange(settlement, includeDescriptions);

            Utils.Helpers.ApplyFeat(BKCEFeats.Instance.VillageMilitia, settlement.Party, ref result);
            return result;
        }
    }
}
