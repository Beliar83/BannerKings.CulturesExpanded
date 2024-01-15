using BannerKings.CulturesExpanded.Cultures;
using BannerKings.Managers.Policies;
using BannerKings.Managers.Populations;
using BannerKings.Managers.Titles;
using BannerKings.Models.Vanilla;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCETaxModel : BKTaxModel
    {
        public override float GetSlaveTaxRate(FeudalTitle title, PopulationData data, BKTaxPolicy policy)
        {
            float result = base.GetSlaveTaxRate(title, data, policy);
            if (data.Settlement.Culture.HasFeat(BKCEFeats.Instance.Geroia2))
            {
                result *= 1f - BKCEFeats.Instance.Geroia2.EffectBonus;
            }

            return result;
        }

        public override float GetNobleTaxRate(FeudalTitle title, PopulationData data, BKTaxPolicy policy)
        {
            float result = base.GetSlaveTaxRate(title, data, policy);
            if (data.Settlement.Culture.HasFeat(BKCEFeats.Instance.Geroia2))
            {
                result *= 1f + BKCEFeats.Instance.Geroia2.EffectBonus;
            }

            return result;
        }

        public override float GetSerfTaxRate(FeudalTitle title, PopulationData data, BKTaxPolicy policy)
        {
            float result = base.GetSlaveTaxRate(title, data, policy);
            if (data.Settlement.Culture.HasFeat(BKCEFeats.Instance.Geroia2))
            {
                result *= 1f + BKCEFeats.Instance.Geroia2.EffectBonus;
            }

            return result;
        }

        public override float GetTenantTaxRate(FeudalTitle title, PopulationData data, BKTaxPolicy policy)
        {
            float result = base.GetSlaveTaxRate(title, data, policy);
            if (data.Settlement.Culture.HasFeat(BKCEFeats.Instance.Geroia2))
            {
                result *= 1f + BKCEFeats.Instance.Geroia2.EffectBonus;
            }

            return result;
        }

        public override float GetCraftsmenTaxRate(FeudalTitle title, PopulationData data, BKTaxPolicy policy)
        {
            float result = base.GetSlaveTaxRate(title, data, policy);
            if (data.Settlement.Culture.HasFeat(BKCEFeats.Instance.Geroia2))
            {
                result *= 1f + BKCEFeats.Instance.Geroia2.EffectBonus;
            }

            return result;
        }
    }
}
