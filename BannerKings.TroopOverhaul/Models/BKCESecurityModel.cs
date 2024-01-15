using BannerKings.CulturesExpanded.Cultures;
using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCESecurityModel : BKSecurityModel
    {
        public override ExplainedNumber CalculateSecurityChange(Town town, bool includeDescriptions = false)
        {
            ExplainedNumber result = base.CalculateSecurityChange(town, includeDescriptions);

            Utils.Helpers.ApplyFeat(BKCEFeats.Instance.Massa2, town.Owner, ref result);
            return result;
        }
    }
}
