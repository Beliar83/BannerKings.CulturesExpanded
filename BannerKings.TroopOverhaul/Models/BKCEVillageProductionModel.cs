using BannerKings.Campaign;
using BannerKings.CulturesExpanded.Cultures;
using BannerKings.Extensions;
using BannerKings.Managers.Items;
using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEVillageProductionModel : BKVillageProductionModel
    {
        public override float CalculateDailyProductionAmount(Village village, ItemObject item)
        {
            float result = base.CalculateDailyProductionAmount(village, item);
            Hero owner = village.Settlement.OwnerClan.Leader;
            ItemCategory category = item.ItemCategory;

            if (owner.Culture.HasFeat(BKCEFeats.Instance.SouthernAgriculture))
            {
                if (category == DefaultItemCategories.Grain || category == BKItemCategories.Instance.Papyrus ||
                    category == DefaultItemCategories.DateFruit)
                {
                    result *= 1f + BKCEFeats.Instance.SouthernAgriculture.EffectBonus;
                }
            }

            if (owner.Culture.HasFeat(BKCEFeats.Instance.Bragantia1))
            {
                if (category == DefaultItemCategories.Cow || category == DefaultItemCategories.Grape ||
                    category == DefaultItemCategories.Olives)
                {
                    result *= 1f + BKCEFeats.Instance.Bragantia1.EffectBonus;
                }
            }

            if (owner.Culture.HasFeat(BKCEFeats.Instance.Vakken1))
            {
                if (category == DefaultItemCategories.Fur || category == DefaultItemCategories.Wood ||
                    category == BKItemCategories.Instance.Honey)
                {
                    result *= 1f + BKCEFeats.Instance.Vakken1.EffectBonus;
                }
            }

            if (owner.Culture.HasFeat(BKCEFeats.Instance.Vakken3))
            {
                if (village.IsFarmingVillage() || village.IsAnimalVillage())
                {
                    result *= 1f + BKCEFeats.Instance.Vakken3.EffectBonus;
                }
            }

            return result;
        }
    }
}
