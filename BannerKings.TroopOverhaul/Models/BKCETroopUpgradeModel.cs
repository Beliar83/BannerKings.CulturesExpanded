using BannerKings.CulturesExpanded.Cultures;
using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCETroopUpgradeModel : BKTroopUpgradeModel
    {
        public override int GetXpCostForUpgrade(PartyBase party, CharacterObject characterObject, CharacterObject upgradeTarget)
        {
            float result = base.GetXpCostForUpgrade(party, characterObject, upgradeTarget);
            if (characterObject.Culture.HasFeat(BKCEFeats.Instance.Darshi1))
            {
                result *= 1f + BKCEFeats.Instance.Darshi1.EffectBonus;
            }

            return (int)result;
        }
    }
}
