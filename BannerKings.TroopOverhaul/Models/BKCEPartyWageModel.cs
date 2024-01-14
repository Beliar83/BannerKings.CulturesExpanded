using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEPartyWageModel : BKPartyWageModel
    {
        public override ExplainedNumber GetTotalWage(MobileParty mobileParty, bool includeDescriptions = false)
        {
            ExplainedNumber wage = base.GetTotalWage(mobileParty, includeDescriptions);

            if (mobileParty.IsLordParty)
            {
                if (TaleWorlds.CampaignSystem.Campaign.Current.MapSceneWrapper.GetFaceTerrainType(mobileParty.CurrentNavigationFace) == TerrainType.Swamp)
                {
                    wage.AddFactor(0.25f, new TaleWorlds.Localization.TextObject("{=!}Sailing"));
                }
            }

            return wage;
        }
    }
}
