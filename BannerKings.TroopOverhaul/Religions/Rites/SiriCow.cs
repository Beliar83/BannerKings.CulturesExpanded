using BannerKings.Managers.Institutions.Religions.Faiths.Rites;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;

namespace BannerKings.CulturesExpanded.Religions.Rites
{
    public class SiriCow : Offering
    {
        public SiriCow() : base(MBObjectManager.Instance.GetObject<ItemObject>("cow"), 
            5)
        {
        }

        public override TextObject GetName() => new TextObject("{=!}Tuygu Darpne");
    }
}
