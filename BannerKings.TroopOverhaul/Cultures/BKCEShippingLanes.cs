using BannerKings.Managers.Shipping;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Cultures
{
    public class BKCEShippingLanes : DefaultTypeInitializer<BKCEShippingLanes, ShippingLane>
    {
        public ShippingLane Balion { get; } = new ShippingLane("Balion");
        public ShippingLane Darshi { get; } = new ShippingLane("Darshi");
        public override IEnumerable<ShippingLane> All
        {
            get
            {
                yield return Balion;
                yield return Darshi;
            }
        }

        public override void Initialize()
        {
            Balion.Initialize(new TextObject("{=!}Balion Trade Connection"),
                new TextObject(),
                new List<Settlement>()
                {
                    Settlement.All.First(x => x.StringId == "town_Isles"),
                    Settlement.All.First(x => x.StringId == "castle_Isles"),
                    Settlement.All.First(x => x.StringId == "town_V4")
                },
                false,
                Utils.Helpers.GetCulture("balion"));

            Darshi.Initialize(new TextObject("{=!}Darshi Sea Network"),
                new TextObject(),
                new List<Settlement>()
                {
                    Settlement.All.First(x => x.StringId == "town_Darshi_4"),
                    Settlement.All.First(x => x.StringId == "town_Darshi_1"),
                    Settlement.All.First(x => x.StringId == "castle_Darshi_5")
                });

            DefaultShippingLanes.Instance.Western.Initialize(new TextObject("{=tySxydya}Western Sea Network"),
                new TextObject(),
                new List<Settlement>()
                {
                    Settlement.All.First(x => x.StringId == "town_Isles"),
                    Settlement.All.First(x => x.StringId == "castle_Isles"),
                    Settlement.All.First(x => x.StringId == "town_Massa_1"),
                    Settlement.All.First(x => x.StringId == "town_Massa_2"),
                    Settlement.All.First(x => x.StringId == "town_Kanic_1"),
                    Settlement.All.First(x => x.StringId == "town_V4"),
                    Settlement.All.First(x => x.StringId == "town_V7"),
                    Settlement.All.First(x => x.StringId == "town_V8")
                });

            DefaultShippingLanes.Instance.Junme.Initialize(new TextObject("{=FGXR8tdb}Junme Trade Network"),
                new TextObject(),
                new List<Settlement>()
                {
                    Settlement.All.First(x => x.StringId == "town_Tihr"),
                    Settlement.All.First(x => x.StringId == "town_V11"),
                    Settlement.All.First(x => x.StringId == "castle_village_Jumne_1_1"),
                    Settlement.All.First(x => x.StringId == "castle_S7"),
                    Settlement.All.First(x => x.StringId == "town_S2"),
                    Settlement.All.First(x => x.StringId == "town_V8")
                },
                false,
                Utils.Helpers.GetCulture("nord"));

            DefaultShippingLanes.Instance.Perassic.Initialize(new TextObject("{=TFoGRBnG}Perassic Trade Network"),
                new TextObject(),
                new List<Settlement>()
                {
                    Settlement.All.First(x => x.StringId == "town_ES2"),
                    Settlement.All.First(x => x.StringId == "town_A4"),
                    Settlement.All.First(x => x.StringId == "town_A8"),
                    Settlement.All.First(x => x.StringId == "town_EW2"),
                    Settlement.All.First(x => x.StringId == "town_EW4"),
                    Settlement.All.First(x => x.StringId == "town_A1"),
                    Settlement.All.First(x => x.StringId == "town_Geroia_1"),
                    Settlement.All.First(x => x.StringId == "town_Geroia_2"),
                    Settlement.All.First(x => x.StringId == "town_Geroia_3"),
                    Settlement.All.First(x => x.StringId == "town_A6")
                });

            foreach (var l in All)
            {
                DefaultShippingLanes.Instance.AddObject(l);
            }
        }
    }
}
