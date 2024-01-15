using BannerKings.Campaign.Economy.Markets;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;

namespace BannerKings.CulturesExpanded.Cultures
{
    public class BKCEMarketGroups : DefaultTypeInitializer<BKCEMarketGroups, MarketGroup>
    {
        public MarketGroup SiriGroup = new MarketGroup("siri");
        public MarketGroup MassaGroup = new MarketGroup("massa");
        public MarketGroup NordGroup = new MarketGroup("nord");
        public MarketGroup VakkenGroup = new MarketGroup("vakken");
        public MarketGroup BragantiaGroup = new MarketGroup("bragantia");
        public MarketGroup KannicGroup = new MarketGroup("kannic");
        public MarketGroup DarshiGroup = new MarketGroup("darshi");
        public MarketGroup GeroiaGroup = new MarketGroup("geroia");

        public override IEnumerable<MarketGroup> All
        {
            get
            {
                yield return SiriGroup;
                yield return MassaGroup;
                yield return NordGroup; 
                yield return VakkenGroup;
                yield return BragantiaGroup;
                yield return KannicGroup;
                yield return DarshiGroup;
                yield return GeroiaGroup;
            }
        }

        public override void Initialize()
        {
            var cultures = TaleWorlds.CampaignSystem.Campaign.Current.ObjectManager.GetObjectTypeList<CultureObject>();
            var siri = cultures.First(x => x.StringId == "siri");
            var nord = cultures.First(x => x.StringId == "nord");
            var vakken = cultures.First(x => x.StringId == "vakken");
            var massa = cultures.First(x => x.StringId == "massa");
            var aserai = cultures.First(x => x.StringId == "aserai");
            var vlandia = cultures.First(x => x.StringId == "vlandia");
            var empire = cultures.First(x => x.StringId == "empire");
            var sturgia = cultures.First(x => x.StringId == "sturgia");
            var kannic = cultures.First(x => x.StringId == "kannic");
            var darshi = cultures.First(x => x.StringId == "darshi");
            var khuzait = cultures.First(x => x.StringId == "khuzait");
            var geroia = cultures.First(x => x.StringId == "geroia");
            var bragantia = cultures.First(x => x.StringId == "bragantia");

            GeroiaGroup.Initialize(null,
              null,
              geroia,
              new Dictionary<CultureObject, float>
              {
                    { aserai, 0.2f },
                    { empire, 0.8f }
              });

            KannicGroup.Initialize(null,
               null,
               kannic,
               new Dictionary<CultureObject, float>
               {
                    { aserai, 0.5f }
               });

            DarshiGroup.Initialize(null,
               null,
               darshi,
               new Dictionary<CultureObject, float>
               {
                    { aserai, 0.2f },
                    { khuzait, 0.2f }
               });

            SiriGroup.Initialize(null,
                null,
                siri,
                new Dictionary<CultureObject, float> 
                { 
                    { aserai, 0.4f } 
                });

            MassaGroup.Initialize(null,
                null,
                massa,
                new Dictionary<CultureObject, float>
                {
                    { vlandia, 0.8f }
                });

            BragantiaGroup.Initialize(null,
                null,
                bragantia,
                new Dictionary<CultureObject, float>
                {
                    { vlandia, 0.6f },
                    { empire, 0.4f }
                });

            NordGroup.Initialize(null,
               null,
               nord,
               new Dictionary<CultureObject, float>
               {
                    { vlandia, 0.2f },
                    { sturgia, 0.8f }
               });

            VakkenGroup.Initialize(null,
               null,
               vakken,
               new Dictionary<CultureObject, float>
               {
                    { sturgia, 0.8f },
                    { nord, 0.2f }
               });

            foreach (var group in All)
            {
                DefaultMarketGroups.Instance.AddObject(group);
            }
        }
    }
}
