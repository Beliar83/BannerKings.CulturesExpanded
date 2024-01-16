using BannerKings.CulturesExpanded.Cultures;
using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem.MapEvents;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCERaidModel : BKRaidModel
    {
        public override float CalculateHitDamage(MapEventSide attackerSide, float settlementHitPoints)
        {
            float result = base.CalculateHitDamage(attackerSide, settlementHitPoints);
            var attacker = attackerSide.LeaderParty;
            if (attacker is { LeaderHero: { } })
            {
                if (attacker.Culture.HasFeat(BKCEFeats.Instance.Massa1))
                {
                    result *= 1f + BKCEFeats.Instance.Massa1.EffectBonus;
                }
            }

            return result;
        }
    }
}
