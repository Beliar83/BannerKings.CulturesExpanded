using BannerKings.Managers.Institutions.Religions.Faiths.Rites;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;

namespace BannerKings.CulturesExpanded.Religions.Rites
{
    public class SiriHoney : Offering
    {
        public SiriHoney() : base(MBObjectManager.Instance.GetObject<ItemObject>("honey"), 
            20)
        {
        }

        public override TextObject GetName() => new TextObject("{=!}Honey Darpne");
    }
}
