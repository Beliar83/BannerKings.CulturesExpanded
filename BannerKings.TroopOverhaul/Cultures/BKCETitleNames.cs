using BannerKings.Managers.Cultures;
using BannerKings.Settings;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Cultures
{
    public class BKCETitleNames : DefaultTypeInitializer<BKCETitleNames, CulturalTitleName>
    {
        #region Empire
        public CulturalTitleName EmpireEmperor { get; private set; }
        public CulturalTitleName EmpireKing { get; private set; }
        public CulturalTitleName EmpireDuke { get; private set; }
        public CulturalTitleName EmpireCount { get; private set; }
        public CulturalTitleName EmpireBaron { get; private set; }
        public CulturalTitleName EmpireLord { get; private set; }
        public CulturalTitleName EmpirePrince { get; private set; }
        public CulturalTitleName EmpireKnight { get; private set; }
        #endregion Empire

        #region Zendar
        public CulturalTitleName ZendarEmperor { get; private set; }
        public CulturalTitleName ZendarKing { get; private set; }
        public CulturalTitleName ZendarDuke { get; private set; }
        public CulturalTitleName ZendarCount { get; private set; }
        public CulturalTitleName ZendarBaron { get; private set; }
        public CulturalTitleName ZendarLord { get; private set; }
        public CulturalTitleName ZendarPrince { get; private set; }
        public CulturalTitleName ZendarKnight { get; private set; }
        #endregion Zendar

        #region Aserai
        public CulturalTitleName AseraiEmperor { get; private set; }
        public CulturalTitleName AseraiKing { get; private set; }
        public CulturalTitleName AseraiDuke { get; private set; }
        public CulturalTitleName AseraiCount { get; private set; }
        public CulturalTitleName AseraiBaron { get; private set; }
        public CulturalTitleName AseraiLord { get; private set; }
        public CulturalTitleName AseraiPrince { get; private set; }
        public CulturalTitleName AseraiKnight { get; private set; }
        #endregion Aserai

        #region Battania
        public CulturalTitleName BattaniaEmperor { get; private set; }
        public CulturalTitleName BattaniaKing { get; private set; }
        public CulturalTitleName BattaniaDuke { get; private set; }
        public CulturalTitleName BattaniaCount { get; private set; }
        public CulturalTitleName BattaniaBaron { get; private set; }
        public CulturalTitleName BattaniaLord { get; private set; }
        public CulturalTitleName BattaniaPrince { get; private set; }
        public CulturalTitleName BattaniaKnight { get; private set; }
        #endregion Battania

        #region Vlandia
        public CulturalTitleName VlandiaEmperor { get; private set; }
        public CulturalTitleName VlandiaKing { get; private set; }
        public CulturalTitleName VlandiaDuke { get; private set; }
        public CulturalTitleName VlandiaCount { get; private set; }
        public CulturalTitleName VlandiaBaron { get; private set; }
        public CulturalTitleName VlandiaLord { get; private set; }
        public CulturalTitleName VlandiaPrince { get; private set; }
        public CulturalTitleName VlandiaKnight { get; private set; }
        #endregion Vlandia

        #region Balion
        public CulturalTitleName BalionEmperor { get; private set; }
        public CulturalTitleName BalionKing { get; private set; }
        public CulturalTitleName BalionDuke { get; private set; }
        public CulturalTitleName BalionCount { get; private set; }
        public CulturalTitleName BalionBaron { get; private set; }
        public CulturalTitleName BalionLord { get; private set; }
        public CulturalTitleName BalionPrince { get; private set; }
        public CulturalTitleName BalionKnight { get; private set; }
        #endregion Balion

        #region Swadia
        public CulturalTitleName SwadiaEmperor { get; private set; }
        public CulturalTitleName SwadiaKing { get; private set; }
        public CulturalTitleName SwadiaDuke { get; private set; }
        public CulturalTitleName SwadiaCount { get; private set; }
        public CulturalTitleName SwadiaBaron { get; private set; }
        public CulturalTitleName SwadiaLord { get; private set; }
        public CulturalTitleName SwadiaPrince { get; private set; }
        public CulturalTitleName SwadiaKnight { get; private set; }
        #endregion Swadia

        #region Rhodok
        public CulturalTitleName RhodokEmperor { get; private set; }
        public CulturalTitleName RhodokKing { get; private set; }
        public CulturalTitleName RhodokDuke { get; private set; }
        public CulturalTitleName RhodokCount { get; private set; }
        public CulturalTitleName RhodokBaron { get; private set; }
        public CulturalTitleName RhodokLord { get; private set; }
        public CulturalTitleName RhodokPrince { get; private set; }
        public CulturalTitleName RhodokKnight { get; private set; }
        #endregion Rhodok

        #region Sturgia
        public CulturalTitleName SturgiaEmperor { get; private set; }
        public CulturalTitleName SturgiaKing { get; private set; }
        public CulturalTitleName SturgiaDuke { get; private set; }
        public CulturalTitleName SturgiaCount { get; private set; }
        public CulturalTitleName SturgiaBaron { get; private set; }
        public CulturalTitleName SturgiaLord { get; private set; }
        public CulturalTitleName SturgiaPrince { get; private set; }
        public CulturalTitleName SturgiaKnight { get; private set; }
        #endregion Sturgia

        #region Khuzait
        public CulturalTitleName KhuzaitEmperor { get; private set; }
        public CulturalTitleName KhuzaitKing { get; private set; }
        public CulturalTitleName KhuzaitDuke { get; private set; }
        public CulturalTitleName KhuzaitCount { get; private set; }
        public CulturalTitleName KhuzaitBaron { get; private set; }
        public CulturalTitleName KhuzaitLord { get; private set; }
        public CulturalTitleName KhuzaitPrince { get; private set; }
        public CulturalTitleName KhuzaitKnight { get; private set; }
        #endregion Khuzait

        #region Iltanlar
        public CulturalTitleName IltanlarEmperor { get; private set; }
        public CulturalTitleName IltanlarKing { get; private set; }
        public CulturalTitleName IltanlarDuke { get; private set; }
        public CulturalTitleName IltanlarCount { get; private set; }
        public CulturalTitleName IltanlarBaron { get; private set; }
        public CulturalTitleName IltanlarLord { get; private set; }
        public CulturalTitleName IltanlarPrince { get; private set; }
        public CulturalTitleName IltanlarKnight { get; private set; }
        #endregion Iltanlar

        #region Darshi
        public CulturalTitleName DarshiEmperor { get; private set; }
        public CulturalTitleName DarshiKing { get; private set; }
        public CulturalTitleName DarshiDuke { get; private set; }
        public CulturalTitleName DarshiCount { get; private set; }
        public CulturalTitleName DarshiBaron { get; private set; }
        public CulturalTitleName DarshiLord { get; private set; }
        public CulturalTitleName DarshiPrince { get; private set; }
        public CulturalTitleName DarshiKnight { get; private set; }
        #endregion Darshi

        #region Nord
        public CulturalTitleName NordEmperor { get; private set; }
        public CulturalTitleName NordKing { get; private set; }
        public CulturalTitleName NordDuke { get; private set; }
        public CulturalTitleName NordCount { get; private set; }
        public CulturalTitleName NordBaron { get; private set; }
        public CulturalTitleName NordLord { get; private set; }
        public CulturalTitleName NordPrince { get; private set; }
        public CulturalTitleName NordKnight { get; private set; }
        #endregion Nord

        #region Vakken
        public CulturalTitleName VakkenEmperor { get; private set; }
        public CulturalTitleName VakkenKing { get; private set; }
        public CulturalTitleName VakkenDuke { get; private set; }
        public CulturalTitleName VakkenCount { get; private set; }
        public CulturalTitleName VakkenBaron { get; private set; }
        public CulturalTitleName VakkenLord { get; private set; }
        public CulturalTitleName VakkenPrince { get; private set; }
        public CulturalTitleName VakkenKnight { get; private set; }
        #endregion Vakken

        #region Geroia
        public CulturalTitleName GeroiaEmperor { get; private set; }
        public CulturalTitleName GeroiaKing { get; private set; }
        public CulturalTitleName GeroiaDuke { get; private set; }
        public CulturalTitleName GeroiaCount { get; private set; }
        public CulturalTitleName GeroiaBaron { get; private set; }
        public CulturalTitleName GeroiaLord { get; private set; }
        public CulturalTitleName GeroiaPrince { get; private set; }
        public CulturalTitleName GeroiaKnight { get; private set; }
        #endregion Geroia

        #region Siri
        public CulturalTitleName SiriEmperor { get; private set; }
        public CulturalTitleName SiriKing { get; private set; }
        public CulturalTitleName SiriDuke { get; private set; }
        public CulturalTitleName SiriCount { get; private set; }
        public CulturalTitleName SiriBaron { get; private set; }
        public CulturalTitleName SiriLord { get; private set; }
        public CulturalTitleName SiriPrince { get; private set; }
        public CulturalTitleName SiriKnight { get; private set; }
        #endregion Siri

        #region Massa
        public CulturalTitleName MassaEmperor { get; private set; }
        public CulturalTitleName MassaKing { get; private set; }
        public CulturalTitleName MassaDuke { get; private set; }
        public CulturalTitleName MassaCount { get; private set; }
        public CulturalTitleName MassaBaron { get; private set; }
        public CulturalTitleName MassaLord { get; private set; }
        public CulturalTitleName MassaPrince { get; private set; }
        public CulturalTitleName MassaKnight { get; private set; }
        #endregion Massa

        #region Bragantia
        public CulturalTitleName BragantiaEmperor { get; private set; }
        public CulturalTitleName BragantiaKing { get; private set; }
        public CulturalTitleName BragantiaDuke { get; private set; }
        public CulturalTitleName BragantiaCount { get; private set; }
        public CulturalTitleName BragantiaBaron { get; private set; }
        public CulturalTitleName BragantiaLord { get; private set; }
        public CulturalTitleName BragantiaPrince { get; private set; }
        public CulturalTitleName BragantiaKnight { get; private set; }
        #endregion Bragantia

        #region Lokti
        public CulturalTitleName LoktiEmperor { get; private set; }
        public CulturalTitleName LoktiKing { get; private set; }
        public CulturalTitleName LoktiDuke { get; private set; }
        public CulturalTitleName LoktiCount { get; private set; }
        public CulturalTitleName LoktiBaron { get; private set; }
        public CulturalTitleName LoktiLord { get; private set; }
        public CulturalTitleName LoktiPrince { get; private set; }
        public CulturalTitleName LoktiKnight { get; private set; }
        #endregion Lokti

        public override IEnumerable<CulturalTitleName> All
        {
            get
            {
                yield return AseraiEmperor;
                yield return AseraiKing;
                yield return AseraiDuke;
                yield return AseraiCount;
                yield return AseraiBaron;
                yield return AseraiLord;
                yield return AseraiPrince;
                yield return AseraiKnight;

                yield return BattaniaEmperor;
                yield return BattaniaKing;
                yield return BattaniaDuke;
                yield return BattaniaCount;
                yield return BattaniaBaron;
                yield return BattaniaLord;
                yield return BattaniaPrince;
                yield return BattaniaKnight;

                yield return KhuzaitEmperor;
                yield return KhuzaitKing;
                yield return KhuzaitDuke;
                yield return KhuzaitCount;
                yield return KhuzaitBaron;
                yield return KhuzaitLord;
                yield return KhuzaitPrince;
                yield return KhuzaitKnight;

                yield return IltanlarEmperor;
                yield return IltanlarKing;
                yield return IltanlarDuke;
                yield return IltanlarCount;
                yield return IltanlarBaron;
                yield return IltanlarLord;
                yield return IltanlarPrince;
                yield return IltanlarKnight;

                yield return SturgiaEmperor;
                yield return SturgiaKing;
                yield return SturgiaDuke;
                yield return SturgiaCount;
                yield return SturgiaBaron;
                yield return SturgiaLord;
                yield return SturgiaPrince;
                yield return SturgiaKnight;

                yield return VlandiaEmperor;
                yield return VlandiaKing;
                yield return VlandiaDuke;
                yield return VlandiaCount;
                yield return VlandiaBaron;
                yield return VlandiaLord;
                yield return VlandiaPrince;
                yield return VlandiaKnight;

                yield return BalionEmperor;
                yield return BalionKing;
                yield return BalionDuke;
                yield return BalionCount;
                yield return BalionBaron;
                yield return BalionLord;
                yield return BalionPrince;
                yield return BalionKnight;

                yield return SwadiaEmperor;
                yield return SwadiaKing;
                yield return SwadiaDuke;
                yield return SwadiaCount;
                yield return SwadiaBaron;
                yield return SwadiaLord;
                yield return SwadiaPrince;
                yield return SwadiaKnight;

                yield return RhodokEmperor;
                yield return RhodokKing;
                yield return RhodokDuke;
                yield return RhodokCount;
                yield return RhodokBaron;
                yield return RhodokLord;
                yield return RhodokPrince;
                yield return RhodokKnight;

                yield return EmpireEmperor;
                yield return EmpireKing;
                yield return EmpireDuke;
                yield return EmpireCount;
                yield return EmpireBaron;
                yield return EmpireLord;
                yield return EmpirePrince;
                yield return EmpireKnight;

                yield return ZendarEmperor;
                yield return ZendarKing;
                yield return ZendarDuke;
                yield return ZendarCount;
                yield return ZendarBaron;
                yield return ZendarLord;
                yield return ZendarPrince;
                yield return ZendarKnight;

                yield return VakkenEmperor;
                yield return VakkenKing;
                yield return VakkenDuke;
                yield return VakkenCount;
                yield return VakkenBaron;
                yield return VakkenLord;
                yield return VakkenPrince;
                yield return VakkenKnight;

                yield return GeroiaEmperor;
                yield return GeroiaKing;
                yield return GeroiaDuke;
                yield return GeroiaCount;
                yield return GeroiaBaron;
                yield return GeroiaLord;
                yield return GeroiaPrince;
                yield return GeroiaKnight;

                yield return SiriEmperor;
                yield return SiriKing;
                yield return SiriDuke;
                yield return SiriCount;
                yield return SiriBaron;
                yield return SiriLord;
                yield return SiriPrince;
                yield return SiriKnight;

                yield return MassaEmperor;
                yield return MassaKing;
                yield return MassaDuke;
                yield return MassaCount;
                yield return MassaBaron;
                yield return MassaLord;
                yield return MassaPrince;
                yield return MassaKnight;

                yield return BragantiaEmperor;
                yield return BragantiaKing;
                yield return BragantiaDuke;
                yield return BragantiaCount;
                yield return BragantiaBaron;
                yield return BragantiaLord;
                yield return BragantiaPrince;
                yield return BragantiaKnight;

                yield return DarshiEmperor;
                yield return DarshiKing;
                yield return DarshiDuke;
                yield return DarshiCount;
                yield return DarshiBaron;
                yield return DarshiLord;
                yield return DarshiPrince;
                yield return DarshiKnight;

                yield return NordEmperor;
                yield return NordKing;
                yield return NordDuke;
                yield return NordCount;
                yield return NordBaron;
                yield return NordLord;
                yield return NordPrince;
                yield return NordKnight;

                yield return LoktiEmperor;
                yield return LoktiKing;
                yield return LoktiDuke;
                yield return LoktiCount;
                yield return LoktiBaron;
                yield return LoktiLord;
                yield return LoktiPrince;
                yield return LoktiKnight;
            }
        }

        public override void Initialize()
        {
            var cultures = TaleWorlds.CampaignSystem.Campaign.Current.ObjectManager.GetObjectTypeList<CultureObject>();
            var empire = cultures.First(x => x.StringId == BannerKingsConfig.EmpireCulture);
            var vlandia = cultures.First(x => x.StringId == BannerKingsConfig.VlandiaCulture);
            var battania = cultures.First(x => x.StringId == BannerKingsConfig.BattaniaCulture);
            var khuzait = cultures.First(x => x.StringId == BannerKingsConfig.KhuzaitCulture);
            var aserai = cultures.First(x => x.StringId == BannerKingsConfig.AseraiCulture);
            var sturgia = cultures.First(x => x.StringId == BannerKingsConfig.SturgiaCulture);
            var darshi = cultures.First(x => x.StringId == "darshi");
            var vakken = cultures.First(x => x.StringId == "vakken");
            var nord = cultures.First(x => x.StringId == "nord");
            var geroia = cultures.First(x => x.StringId == "geroia");
            var massa = cultures.First(x => x.StringId == "massa");
            var siri = cultures.First(x => x.StringId == "siri");
            var balion = cultures.First(x => x.StringId == "balion");
            var bragantia = cultures.First(x => x.StringId == "bragantia");
            var iltanlar = cultures.First(x => x.StringId == "iltanlar");
            var lokti = cultures.First(x => x.StringId == "lokti");
            var rhodok = cultures.First(x => x.StringId == "rhodok");
            var swadia = cultures.First(x => x.StringId == "swadia");
            var zendar = cultures.First(x => x.StringId == "zendar");

            #region Zendar
            ZendarEmperor = CulturalTitleName.CreateEmpire("ZendarEmperor",
                zendar,
                new TextObject("{=emperor_zendar}Aftokrator"),
                new TextObject("{=empress_zendar}Aftokratira"),
                new TextObject("{=zendar_zendar}Aftokratoria"));

            ZendarKing = CulturalTitleName.CreateKingdom("ZendarKing",
                zendar,
                new TextObject("{=king_zendar}Krátor"),
                new TextObject("{=queen_zendar}Kráteira"),
                new TextObject("{=kingdom_zendar}Kratoria"));

            ZendarDuke = CulturalTitleName.CreateDuchy("ZendarDuke",
                zendar,
                new TextObject("{=duke_zendar}Prinkips"),
                new TextObject("{=duchess_zendar}Prinkipissa"),
                new TextObject("{=duchy_zendar}Dukaton"));

            ZendarCount = CulturalTitleName.CreateCounty("ZendarCount",
                zendar,
                new TextObject("{=count_zendar}Komis"),
                new TextObject("{=countess_zendar}Komissa"),
                new TextObject("{=county_zendar}Pólis"));

            ZendarBaron = CulturalTitleName.CreateBarony("ZendarBaron",
                zendar,
                new TextObject("{=baron_zendar}Polémarkhos"),
                new TextObject("{=baroness_zendar}Polémarkhousa"),
                new TextObject("{=barony_zendar}Polemarkhontía"));

            ZendarLord = CulturalTitleName.CreateLordship("ZendarLord",
                zendar,
                new TextObject("{=lord_zendar}Coryárkhos"),
                new TextObject("{=lady_zendar}Coryárkhousa"),
                new TextObject("{=lordship_zendar}Corys"));

            ZendarPrince = CulturalTitleName.CreatePrince("ZendarPrince",
                zendar,
                new TextObject("{=prince_zendar}Prinkips"),
                new TextObject("{=princess_zendar}Prinkipissa"),
                new TextObject("{=princes_zendar}Prinkipes"));

            ZendarKnight = CulturalTitleName.CreateKnight("ZendarKnight",
                zendar,
                new TextObject("{=knight_zendar}Athanatos"),
                new TextObject("{=knightess_zendar}Athanate"),
                new TextObject("{=knights_zendar}Athanatoi"));

            #endregion Zendar

            #region Empire
            if (BKCESettings.Instance.LatinTitles)
            {
                EmpireEmperor = CulturalTitleName.CreateEmpire("EmpireEmperor",
                  empire,
                  new TextObject("{=emperor_empire}Imperator"),
                  new TextObject("{=empress_empire}Imperatrix"),
                  new TextObject("{=empire_empire}Imperium"));

                EmpireKing = CulturalTitleName.CreateKingdom("EmpireKing",
                   empire,
                   new TextObject("{=king_empire}Rex"),
                   new TextObject("{=queen_empire}Regina"),
                   new TextObject("{=kingdom_empire}Regnum"));

                EmpireDuke = CulturalTitleName.CreateDuchy("EmpireDuke",
                    empire,
                    new TextObject("{=duke_empire}Dux"),
                    new TextObject("{=duchess_empire}Ducissa"),
                    new TextObject("{=duchy_empire}Ducatum"));

                EmpireCount = CulturalTitleName.CreateCounty("EmpireCount",
                    empire,
                    new TextObject("{=count_empire}Comes"),
                    new TextObject("{=countess_empire}Cometessa"),
                    new TextObject("{=county_empire}Comitatus"));

                EmpireBaron = CulturalTitleName.CreateBarony("EmpireBaron",
                    empire,
                    new TextObject("{=baron_empire}Baro"),
                    new TextObject("{=baroness_empire}Baronessa"),
                    new TextObject("{=barony_empire}Baronatum"));

                EmpireLord = CulturalTitleName.CreateLordship("EmpireLord",
                    empire,
                    new TextObject("{=lord_empire}Dominus"),
                    new TextObject("{=lady_empire}Domina"),
                    new TextObject("{=lordship_empire}Dominium"));

                EmpirePrince = CulturalTitleName.CreatePrince("EmpirePrince",
                    empire,
                    new TextObject("{=prince_empire}Princeps"),
                    new TextObject("{=princess_empire}Principissa"),
                    new TextObject("{=princes_empire}Principes"));

                EmpireKnight = CulturalTitleName.CreateKnight("EmpireKnight",
                    empire,
                    new TextObject("{=knight_empire}Pronoiarius"),
                    new TextObject("{=knightess_empire}Pronoiarius"),
                    new TextObject("{=knights_empire}Pronoiarii"));
            }
            else
            {
                EmpireEmperor = CulturalTitleName.CreateEmpire("EmpireEmperor",
                   empire,
                   new TextObject("{=emperor_empire_alt}Basileús"),
                   new TextObject("{=empress_empire_alt}Basíleia"),
                   new TextObject("{=empire_empire_alt}Basileía"));

                EmpireKing = CulturalTitleName.CreateKingdom("EmpireKing",
                   empire,
                   new TextObject("{=king_empire_alt}Exarkhos"),
                   new TextObject("{=queen_empire_alt}Exarkhousa"),
                   new TextObject("{=kingdom_empire_alt}Exarkhontía"));

                EmpireDuke = CulturalTitleName.CreateDuchy("EmpireDuke",
                    empire,
                    new TextObject("{=duke_empire_alt}Doux"),
                    new TextObject("{=duchess_empire_alt}Doucissa"),
                    new TextObject("{=duchy_empire_alt}Théma"));

                EmpireCount = CulturalTitleName.CreateCounty("EmpireCount",
                    empire,
                    new TextObject("{=count_empire_alt}Árkhon"),
                    new TextObject("{=countess_empire_alt}Árkhousa"),
                    new TextObject("{=county_empire_alt}Arkhontía"));

                EmpireBaron = CulturalTitleName.CreateBarony("EmpireBaron",
                    empire,
                    new TextObject("{=baron_empire_alt}Kephalé"),
                    new TextObject("{=baroness_empire_alt}Kephalé"),
                    new TextObject("{=barony_empire_alt}Katepaníkion"));

                EmpireLord = CulturalTitleName.CreateLordship("EmpireLord",
                    empire,
                    new TextObject("{=lord_empire_alt}Corysárkhos"),
                    new TextObject("{=lady_empire_alt}Corysárkhousa"),
                    new TextObject("{=lordship_empire_alt}Corys"));

                EmpirePrince = CulturalTitleName.CreatePrince("EmpirePrince",
                    empire,
                    new TextObject("{=prince_empire_alt}Princeps"),
                    new TextObject("{=princess_empire_alt}Principissa"),
                    new TextObject("{=princes_empire_alt}Principes"));

                EmpireKnight = CulturalTitleName.CreateKnight("EmpireKnight",
                    empire,
                    new TextObject("{=knight_empire_alt}Pronoiarius"),
                    new TextObject("{=knightess_empire_alt}Pronoiarius"),
                    new TextObject("{=knights_empire_alt}Pronoiarii"));
            }

            #endregion Empire

            #region Battania
            if (BKCESettings.Instance.GoidelicTitles)
            {
                BattaniaEmperor = CulturalTitleName.CreateEmpire("BattaniaEmperor",
                    battania,
                    new TextObject("{=emperor_battania_alt}Pendràgon"),
                    new TextObject("{=empress_battania_alt}Penbandràgon"),
                    new TextObject("{=empire_battania_alt}Pendràgonachd"));

                BattaniaKing = CulturalTitleName.CreateKingdom("BattaniaKing",
                    battania,
                    new TextObject("{=king_battania_alt}Ard-Righ"),
                    new TextObject("{=queen_battania_alt}Ard-Banrigh"),
                    new TextObject("{=kingdom_battania_alt}Ard-Rioghachd"));

                BattaniaDuke = CulturalTitleName.CreateDuchy("BattaniaDuke",
                    battania,
                    new TextObject("{=duke_battania_alt}Righ"),
                    new TextObject("{=duchess_battania_alt}Banrigh"),
                    new TextObject("{=duchy_battania_alt}Rioghachd"));

                BattaniaCount = CulturalTitleName.CreateCounty("BattaniaCount",
                    battania,
                    new TextObject("{=count_battania_alt}Mormaer"),
                    new TextObject("{=countess_battania_alt}Banmormaer"),
                    new TextObject("{=county_battania_alt}Mormaeracht"));

                BattaniaBaron = CulturalTitleName.CreateBarony("BattaniaBaron",
                    battania,
                    new TextObject("{=baron_battania_alt}Taoiseach"),
                    new TextObject("{=baroness_battania_alt}Bantaoiseach"),
                    new TextObject("{=barony_battania_alt}Toiseachadh"));

                BattaniaLord = CulturalTitleName.CreateLordship("BattaniaLord",
                    battania,
                    new TextObject("{=lord_battania_alt}Tiarna"),
                    new TextObject("{=lady_battania_alt}Bantiarna"),
                    new TextObject("{=lordship_battania_alt}Tigernas"));

                BattaniaPrince = CulturalTitleName.CreatePrince("BattaniaPrince",
                    battania,
                    new TextObject("{=prince_battania_alt}Flath"),
                    new TextObject("{=princess_battania_alt}Banflath"),
                    new TextObject("{=princes_battania_alt}Flathan"));

                BattaniaKnight = CulturalTitleName.CreateKnight("BattaniaKnight",
                    battania,
                    new TextObject("{=knight_battania_alt}Fiann"),
                    new TextObject("{=knightess_battania_alt}Fiannes"),
                    new TextObject("{=knights_battania_alt}Fianna"));
            }
            else
            {
                BattaniaEmperor = CulturalTitleName.CreateEmpire("BattaniaEmperor",
                   battania,
                   new TextObject("{=emperor_battania}Pendreic"),
                   new TextObject("{=empress_battania}Pendreices"),
                   new TextObject("{=empire_battania}Pendreiciaeth"));

                BattaniaKing = CulturalTitleName.CreateKingdom("BattaniaKing",
                    battania,
                    new TextObject("{=king_battania}Uchelbrenhin"),
                    new TextObject("{=queen_battania}Uchelbrenhines"),
                    new TextObject("{=kingdom_battania}Uchelbrenhinaeth"));

                BattaniaDuke = CulturalTitleName.CreateDuchy("BattaniaDuke",
                    battania,
                    new TextObject("{=duke_battania}Brenhin"),
                    new TextObject("{=duchess_battania}Brenhines"),
                    new TextObject("{=duchy_battania}Brenhinaeth"));

                BattaniaCount = CulturalTitleName.CreateCounty("BattaniaCount",
                    battania,
                    new TextObject("{=count_battania}Tywysauc"),
                    new TextObject("{=countess_battania}Tywysauces"),
                    new TextObject("{=county_battania}Tywysauciaeth"));

                BattaniaBaron = CulturalTitleName.CreateBarony("BattaniaBaron",
                    battania,
                    new TextObject("{=baron_battania}Teyrn"),
                    new TextObject("{=baroness_battania}Teyrnes"),
                    new TextObject("{=barony_battania}Teyrnas"));

                BattaniaLord = CulturalTitleName.CreateLordship("BattaniaLord",
                    battania,
                    new TextObject("{=lord_battania}Arglwyt"),
                    new TextObject("{=lady_battania}Arglwytes"),
                    new TextObject("{=lordship_battania}Arglwydiaeth"));

                BattaniaPrince = CulturalTitleName.CreatePrince("BattaniaPrince",
                    battania,
                    new TextObject("{=prince_battania}Pendewic"),
                    new TextObject("{=princess_battania}Pendewices"),
                    new TextObject("{=princes_battania}Pendewiciaidd"));

                BattaniaKnight = CulturalTitleName.CreateKnight("BattaniaKnight",
                    battania,
                    new TextObject("{=knight_battania}Fiann"),
                    new TextObject("{=knightess_battania}Fiannes"),
                    new TextObject("{=knights_battania}Fianna"));
            }

            #endregion Battania

            #region Sturgia
            SturgiaEmperor = CulturalTitleName.CreateEmpire("SturgiaEmperor",
                sturgia,
                new TextObject("{=emperor_sturgia}Koról"),
                new TextObject("{=empress_sturgia}Koroléva"),
                new TextObject("{=empire_sturgia}Korolévstvo"));

            SturgiaKing = CulturalTitleName.CreateKingdom("SturgiaKing",
                sturgia,
                new TextObject("{=king_sturgia}Velykyy Knjaz"),
                new TextObject("{=queen_sturgia}Velykyy Knjahýnja"),
                new TextObject("{=kingdom_sturgia}Velykyy Knjazývstvo"));

            SturgiaDuke = CulturalTitleName.CreateDuchy("SturgiaDuke",
                sturgia,
                new TextObject("{=duke_sturgia}Knjaz"),
                new TextObject("{=duchess_sturgia}Knjahýnja"),
                new TextObject("{=duchy_sturgia}Knjazývstvo"));

            SturgiaCount = CulturalTitleName.CreateCounty("SturgiaCount",
                sturgia,
                new TextObject("{=count_sturgia}Bojárin"),
                new TextObject("{=countess_sturgia}Bojarýnja"), 
                new TextObject("{=county_sturgia}Bojárstvo"));

            SturgiaBaron = CulturalTitleName.CreateBarony("SturgiaBaron",
                sturgia,
                new TextObject("{=baron_sturgia}Vojevóda"),
                new TextObject("{=baroness_sturgia}Vojevodýnja"),
                new TextObject("{=barony_sturgia}Vojevódastvo"));

            SturgiaLord = CulturalTitleName.CreateLordship("SturgiaLord",
                sturgia,
                new TextObject("{=lord_sturgia}Gospodin"),
                new TextObject("{=lady_sturgia}Gospodja"),
                new TextObject("{=lordship_sturgia}Gospoda"));

            SturgiaPrince = CulturalTitleName.CreatePrince("SturgiaPrince",
                sturgia,
                new TextObject("{=prince_sturgia}Knyaz"),
                new TextObject("{=princess_sturgia}Knyaginya"),
                new TextObject("{=princes_sturgia}Knjázi"));

            SturgiaKnight = CulturalTitleName.CreateKnight("SturgiaKnight",
                sturgia,
                new TextObject("{=knight_sturgia}Druzhinnik"),
                new TextObject("{=knightess_sturgia}Druzhinnica"),
                new TextObject("{=knights_sturgia}Druzhina"));

            #endregion Sturgia

            #region Vlandia
            VlandiaEmperor = CulturalTitleName.CreateEmpire("VlandiaEmperor",
                vlandia,
                new TextObject("{=emperor_vlandia}Emperere"),
                new TextObject("{=empress_vlandia}Emperesse"),
                new TextObject("{=empire_vlandia}Empires"));

            VlandiaKing = CulturalTitleName.CreateKingdom("VlandiaKing",
                vlandia,
                new TextObject("{=king_vlandia}Reis"),
                new TextObject("{=queen_vlandia}Reigne"),
                new TextObject("{=kingdom_vlandia}Regnes"));

            VlandiaDuke = CulturalTitleName.CreateDuchy("VlandiaDuke",
                vlandia,
                new TextObject("{=duke_vlandia}Princes"),
                new TextObject("{=duchess_vlandia}Princesse"),
                new TextObject("{=duchy_vlandia}Principaliz"));

            VlandiaCount = CulturalTitleName.CreateCounty("VlandiaCount",
                vlandia,
                new TextObject("{=count_vlandia}Cuens"),
                new TextObject("{=countess_vlandia}Contesse"),
                new TextObject("{=county_vlandia}Cuntez"));

            VlandiaBaron = CulturalTitleName.CreateBarony("VlandiaBaron",
                vlandia,
                new TextObject("{=baron_vlandia}Bers"),
                new TextObject("{=baroness_vlandia}Bersesse"),
                new TextObject("{=barony_vlandia}Baronie"));

            VlandiaLord = CulturalTitleName.CreateLordship("VlandiaLord",
                vlandia,
                new TextObject("{=lord_vlandia}Sire"),
                new TextObject("{=lady_vlandia}Siresse"),
                new TextObject("{=lordship_vlandia}Seignurie"));

            VlandiaPrince = CulturalTitleName.CreatePrince("VlandiaPrince",
                vlandia,
                new TextObject("{=prince_vlandia}Edelings"),
                new TextObject("{=princess_vlandia}Edelesse"),
                new TextObject("{=princes_vlandia}Edeling"));

            VlandiaKnight = CulturalTitleName.CreateKnight("VlandiaKnight",
                vlandia,
                new TextObject("{=knight_vlandia}Chevalers"),
                new TextObject("{=knightess_vlandia}Chevalesse"),
                new TextObject("{=knights_vlandia}Chevaler"));

            #endregion Vlandia

            #region Balion
            BalionEmperor = CulturalTitleName.CreateEmpire("BalionEmperor",
                balion,
                new TextObject("{=emperor_balion}Brytenwealda"),
                new TextObject("{=empress_balion}Brytenwealden"),
                new TextObject("{=empire_balion}Brytenríce"));

            BalionKing = CulturalTitleName.CreateKingdom("BalionKing",
                balion,
                new TextObject("{=king_balion}Cyning"),
                new TextObject("{=queen_balion}Cwén"),
                new TextObject("{=kingdom_balion}Ríce"));

            BalionDuke = CulturalTitleName.CreateDuchy("BalionDuke",
                balion,
                new TextObject("{=duke_balion}Eorl"),
                new TextObject("{=duchess_balion}Eorlen"),
                new TextObject("{=duchy_balion}Eorldóm"));

            BalionCount = CulturalTitleName.CreateCounty("BalionCount",
                balion,
                new TextObject("{=count_balion}Ealdormann"),
                new TextObject("{=countess_balion}Hlaefdíge"),
                new TextObject("{=county_balion}Schyre"));

            BalionBaron = CulturalTitleName.CreateBarony("BalionBaron",
                balion,
                new TextObject("{=baron_balion}Thegen"),
                new TextObject("{=baroness_balion}Hlaefdíge"),
                new TextObject("{=barony_balion}Hundred"));

            BalionLord = CulturalTitleName.CreateLordship("BalionLord",
                balion,
                new TextObject("{=lord_balion}Hláford"),
                new TextObject("{=lady_balion}Hlaefdíge"),
                new TextObject("{=lordship_balion}Hlafordsciepe"));

            BalionPrince = CulturalTitleName.CreatePrince("BalionPrince",
                balion,
                new TextObject("{=prince_balion}Aetheling"),
                new TextObject("{=princess_balion}Hlaefdíge"),
                new TextObject("{=princes_balion}Aethelingas"));

            BalionKnight = CulturalTitleName.CreateKnight("BalionKnight",
                balion,
                new TextObject("{=knight_balion}Gesíth"),
                new TextObject("{=knightess_balion}Gesíthen"),
                new TextObject("{=knights_balion}Gesíthas"));

            #endregion Balion

            #region Swadia
            SwadiaEmperor = CulturalTitleName.CreateEmpire("SwadiaEmperor",
                 swadia,
                 new TextObject("{=emperor_swadia}Fronenant"),
                 new TextObject("{=empress_swadia}Fronenantin"),
                 new TextObject("{=empire_swadia}Fronenantriche"));

            SwadiaKing = CulturalTitleName.CreateKingdom("SwadiaKing",
                swadia,
                new TextObject("{=king_swadia}Kunic"),
                new TextObject("{=queen_swadia}Kunicin"),
                new TextObject("{=kingdom_swadia}Kunicriche"));

            SwadiaDuke = CulturalTitleName.CreateDuchy("SwadiaDuke",
                swadia,
                new TextObject("{=duke_swadia}Herzoge"),
                new TextObject("{=duchess_swadia}Herzogin"),
                new TextObject("{=duchy_swadia}Herzogentuom"));

            SwadiaCount = CulturalTitleName.CreateCounty("SwadiaCount",
                swadia,
                new TextObject("{=count_swadia}Grave"),
                new TextObject("{=countess_swadia}Gravin"),
                new TextObject("{=county_swadia}Graveschaft"));

            SwadiaBaron = CulturalTitleName.CreateBarony("SwadiaBaron",
                swadia,
                new TextObject("{=baron_swadia}Burcgrave"),
                new TextObject("{=baroness_swadia}Burcgravin"),
                new TextObject("{=barony_swadia}Burcgraveschaft"));

            SwadiaLord = CulturalTitleName.CreateLordship("SwadiaLord",
                swadia,
                new TextObject("{=lord_swadia}Gougrave"),
                new TextObject("{=lady_swadia}Gougravin"),
                new TextObject("{=lordship_swadia}Gougraveschaft"));

            SwadiaPrince = CulturalTitleName.CreatePrince("SwadiaPrince",
                swadia,
                new TextObject("{=prince_swadia}Edelinc"),
                new TextObject("{=princess_swadia}Edelvrouwe"),
                new TextObject("{=princes_swadia}Edelincen"));

            SwadiaKnight = CulturalTitleName.CreateKnight("SwadiaKnight",
                swadia,
                new TextObject("{=knight_swadia}Herre"),
                new TextObject("{=knightess_swadia}Vrouwe"),
                new TextObject("{=knights_swadia}Herren"));

            #endregion Swadia

            #region Rhodok
            RhodokEmperor = CulturalTitleName.CreateEmpire("RhodokEmperor",
                rhodok,
                new TextObject("{=emperor_rhodok}Vronenent"),
                new TextObject("{=empress_rhodok}Vronenentin"),
                new TextObject("{=empire_rhodok}Vronenentriich"));

            RhodokKing = CulturalTitleName.CreateKingdom("RhodokKing",
                rhodok,
                new TextObject("{=king_rhodok}Hougekunic"),
                new TextObject("{=queen_rhodok}Hougekunicin"),
                new TextObject("{=kingdom_rhodok}Hougeriich"));

            RhodokDuke = CulturalTitleName.CreateDuchy("RhodokDuke",
                rhodok,
                new TextObject("{=duke_rhodok}Kunic"),
                new TextObject("{=duchess_rhodok}Kunicin"),
                new TextObject("{=duchy_rhodok}Kunicriich"));

            RhodokCount = CulturalTitleName.CreateCounty("RhodokCount",
                rhodok,
                new TextObject("{=count_rhodok}Grave"),
                new TextObject("{=countess_rhodok}Gravin"),
                new TextObject("{=county_rhodok}Graveschaft"));

            RhodokBaron = CulturalTitleName.CreateBarony("RhodokBaron",
                rhodok,
                new TextObject("{=baron_rhodok}Vriherre"),
                new TextObject("{=baroness_rhodok}Vrifrou"),
                new TextObject("{=barony_rhodok}Vriherreschaft"));

            RhodokLord = CulturalTitleName.CreateLordship("RhodokLord",
                rhodok,
                new TextObject("{=lord_rhodok}Lhandsherre"),
                new TextObject("{=lady_rhodok}Lhandsfrou"),
                new TextObject("{=lordship_rhodok}Lhandsherreschaft"));

            RhodokPrince = CulturalTitleName.CreatePrince("RhodokPrince",
                rhodok,
                new TextObject("{=prince_rhodok}Edelinc"),
                new TextObject("{=princess_rhodok}Edelfrou"),
                new TextObject("{=princes_rhodok}Edelincen"));

            RhodokKnight = CulturalTitleName.CreateKnight("RhodokKnight",
                rhodok,
                new TextObject("{=knight_rhodok}Herre"),
                new TextObject("{=knightess_rhodok}Frou"),
                new TextObject("{=knights_rhodok}Herren"));

            #endregion Rhodok

            #region Khuzait
            KhuzaitEmperor = CulturalTitleName.CreateEmpire("KhuzaitEmperor",
                khuzait,
                new TextObject("{=emperor_khuzait}Erxem Khagan"),
                new TextObject("{=empress_khuzait}Erxem Khatun"),
                new TextObject("{=khuzait_khuzait}Ulus"));

            KhuzaitKing = CulturalTitleName.CreateKingdom("KhuzaitKing",
                khuzait,
                new TextObject("{=king_khuzait}Khagan"),
                new TextObject("{=queen_khuzait}Khatun"),
                new TextObject("{=kingdom_khuzait}Khaganlik"));

            KhuzaitDuke = CulturalTitleName.CreateDuchy("KhuzaitDuke",
                khuzait,
                new TextObject("{=duke_khuzait}Khan"),
                new TextObject("{=duchess_khuzait}Khanum"),
                new TextObject("{=duchy_khuzait}Khanlik"));

            KhuzaitCount = CulturalTitleName.CreateCounty("KhuzaitCount",
                khuzait,
                new TextObject("{=count_khuzait}Atabeg"),
                new TextObject("{=countess_khuzait}Atabegum"),
                new TextObject("{=county_khuzait}Atabeglik"));

            KhuzaitBaron = CulturalTitleName.CreateBarony("KhuzaitBaron",
                khuzait,
                new TextObject("{=baron_khuzait}Beg"),
                new TextObject("{=baroness_khuzait}Begum"),
                new TextObject("{=barony_khuzait}Beglik"));

            KhuzaitLord = CulturalTitleName.CreateLordship("KhuzaitLord",
                khuzait,
                new TextObject("{=lord_khuzait}Erxem"),
                new TextObject("{=lady_khuzait}Khatagtai"),
                new TextObject("{=lordship_khuzait}Erxemlik"));

            KhuzaitPrince = CulturalTitleName.CreatePrince("KhuzaitPrince",
                khuzait,
                new TextObject("{=prince_khuzait}Khan Khuu"),
                new TextObject("{=princess_khuzait}Gonji"),
                new TextObject("{=princes_khuzait}Khan Khuunud"));

            KhuzaitKnight = CulturalTitleName.CreateKnight("KhuzaitKnight",
                khuzait,
                new TextObject("{=knight_khuzait}Kheshig"),
                new TextObject("{=knightess_khuzait}Kheshigum"),
                new TextObject("{=knights_khuzait}Kheshignud"));

            #endregion Khuzait

            #region Iltanlar
            IltanlarEmperor = CulturalTitleName.CreateEmpire("IltanlarEmperor",
                iltanlar,
                new TextObject("{=emperor_iltanlar}Erxem Khagan"),
                new TextObject("{=empress_iltanlar}Erxem Khatun"),
                new TextObject("{=iltanlar_iltanlar}Ulus"));

            IltanlarKing = CulturalTitleName.CreateKingdom("IltanlarKing",
                iltanlar,
                new TextObject("{=king_iltanlar}Khagan"),
                new TextObject("{=queen_iltanlar}Khatun"),
                new TextObject("{=kingdom_iltanlar}Khaganlik"));

            IltanlarDuke = CulturalTitleName.CreateDuchy("IltanlarDuke",
                iltanlar,
                new TextObject("{=duke_iltanlar}Khan"),
                new TextObject("{=duchess_iltanlar}Khanum"),
                new TextObject("{=duchy_iltanlar}Khanlik"));

            IltanlarCount = CulturalTitleName.CreateCounty("IltanlarCount",
                iltanlar,
                new TextObject("{=count_iltanlar}Atabeg"),
                new TextObject("{=countess_iltanlar}Atabegum"),
                new TextObject("{=county_iltanlar}Atabeglik"));

            IltanlarBaron = CulturalTitleName.CreateBarony("IltanlarBaron",
                iltanlar,
                new TextObject("{=baron_iltanlar}Beg"),
                new TextObject("{=baroness_iltanlar}Begum"),
                new TextObject("{=barony_iltanlar}Beglik"));

            IltanlarLord = CulturalTitleName.CreateLordship("IltanlarLord",
                iltanlar,
                new TextObject("{=lord_iltanlar}Erxem"),
                new TextObject("{=lady_iltanlar}Khatagtai"),
                new TextObject("{=lordship_iltanlar}Erxemlik"));

            IltanlarPrince = CulturalTitleName.CreatePrince("IltanlarPrince",
                iltanlar,
                new TextObject("{=prince_iltanlar}Khan Khuu"),
                new TextObject("{=princess_iltanlar}Gonji"),
                new TextObject("{=princes_iltanlar}Khan Khuunud"));

            IltanlarKnight = CulturalTitleName.CreateKnight("IltanlarKnight",
                iltanlar,
                new TextObject("{=knight_iltanlar}Kheshig"),
                new TextObject("{=knightess_iltanlar}Kheshigum"),
                new TextObject("{=knights_iltanlar}Kheshignud"));

            #endregion Iltanlar

            #region Aserai
            AseraiEmperor = CulturalTitleName.CreateEmpire("AseraiEmperor",
                aserai,
                new TextObject("{=emperor_aserai}Khalifa"),
                new TextObject("{=empress_aserai}Khalifa"),
                new TextObject("{=empire_aserai}Khilaafa"));

            AseraiKing = CulturalTitleName.CreateKingdom("AseraiKing",
                aserai,
                new TextObject("{=king_aserai}Sultan"),
                new TextObject("{=queen_aserai}Sultana"),
                new TextObject("{=kingdom_aserai}Saltana"));

            AseraiDuke = CulturalTitleName.CreateDuchy("AseraiDuke",
                aserai,
                new TextObject("{=duke_aserai}Amiir"),
                new TextObject("{=duchess_aserai}Amiira"),
                new TextObject("{=duchy_aserai}Imaara"));

            AseraiCount = CulturalTitleName.CreateCounty("AseraiCount",
                aserai,
                new TextObject("{=count_aserai}Shayk"),
                new TextObject("{=countess_aserai}Shaykah"),
                new TextObject("{=county_aserai}Mashyaka"));

            AseraiBaron = CulturalTitleName.CreateBarony("AseraiBaron",
                aserai,
                new TextObject("{=baron_aserai}Wali"),
                new TextObject("{=baroness_aserai}Walia"),
                new TextObject("{=barony_aserai}Walya"));

            AseraiLord = CulturalTitleName.CreateLordship("AseraiLord",
                aserai,
                new TextObject("{=lord_aserai}Mawlaa"),
                new TextObject("{=lady_aserai}Beghum"),
                new TextObject("{=lordship_aserai}Daya"));

            AseraiPrince = CulturalTitleName.CreatePrince("AseraiPrince",
                aserai,
                new TextObject("{=prince_aserai}Amiir"),
                new TextObject("{=princess_aserai}Amiira"),
                new TextObject("{=princes_aserai}Umaraa"));

            AseraiKnight = CulturalTitleName.CreateKnight("AseraiKnight",
                aserai,
                new TextObject("{=knight_aserai}Faaris"),
                new TextObject("{=knightess_aserai}Faaris"),
                new TextObject("{=knights_aserai}Fursaan"));

            #endregion Aserai

            #region Darshi
            DarshiEmperor = CulturalTitleName.CreateEmpire("DarshiEmperor",
                darshi,
                new TextObject("{=!}Shahanshah"),
                new TextObject("{=!}Shahbanu"),
                new TextObject("{=!}Shahanshahr"));

            DarshiKing = CulturalTitleName.CreateKingdom("DarshiKing",
                darshi,
                new TextObject("{=!}Shah"),
                new TextObject("{=!}Shahbanu"),
                new TextObject("{=!}Shahr"));

            DarshiDuke = CulturalTitleName.CreateDuchy("DarshiDuke",
                darshi,
                new TextObject("{=!}Shahrab"),
                new TextObject("{=!}Shahrabanu"),
                new TextObject("{=!}Shahrabr"));

            DarshiCount = CulturalTitleName.CreateCounty("DarshiCount",
                darshi,
                new TextObject("{=!}Marzban"),
                new TextObject("{=!}Marzban"),
                new TextObject("{=!}Marzbananate"));

            DarshiBaron = CulturalTitleName.CreateBarony("DarshiBaron",
                darshi,
                new TextObject("{=!}Argbadh"),
                new TextObject("{=!}Argbadh"),
                new TextObject("{=!}Arg"));

            DarshiLord = CulturalTitleName.CreateLordship("DarshiLord",
                darshi,
                new TextObject("{=!}Dihqan"),
                new TextObject("{=!}Dihqan"),
                new TextObject("{=!}Deh"));

            DarshiPrince = CulturalTitleName.CreatePrince("DarshiPrince",
                darshi,
                new TextObject("{=!}Shahpur"),
                new TextObject("{=!}Shahdokht"),
                new TextObject("{=!}Shahzade"));

            DarshiKnight = CulturalTitleName.CreateKnight("DarshiKnight",
                darshi,
                new TextObject("{=!}Aswar"),
                new TextObject("{=!}Aswar"),
                new TextObject("{=!}Aswaran"));

            #endregion Darshi

            #region Nord
            NordEmperor = CulturalTitleName.CreateEmpire("NordEmperor",
                nord,
                new TextObject("{=!}Storkungen"),
                new TextObject("{=!}Riksdrottning"),
                new TextObject("{=!}Storkungendómr"));

            NordKing = CulturalTitleName.CreateKingdom("NordKing",
                nord,
                new TextObject("{=!}Konung"),
                new TextObject("{=!}Drottning"),
                new TextObject("{=!}Konungdómr"));

            NordDuke = CulturalTitleName.CreateDuchy("NordDuke",
                nord,
                new TextObject("{=!}Jarl"),
                new TextObject("{=!}Haerskarinna"),
                new TextObject("{=!}Jarldómr"));

            NordCount = CulturalTitleName.CreateCounty("NordCount",
                nord,
                new TextObject("{=!}Thegn"),
                new TextObject("{=!}Thegna"),
                new TextObject("{=!}Thegndómr"));

            NordBaron = CulturalTitleName.CreateBarony("NordBaron",
                nord,
                new TextObject("{=!}Aedling"),
                new TextObject("{=!}Drott"),
                new TextObject("{=!}Aedlingdómr"));

            NordLord = CulturalTitleName.CreateLordship("NordLord",
                nord,
                new TextObject("{=!}Hoevding"),
                new TextObject("{=!}Hoevdinga"),
                new TextObject("{=!}Hoevdingdómr"));

            NordPrince = CulturalTitleName.CreatePrince("NordPrince",
                nord,
                new TextObject("{=!}Fursteson"),
                new TextObject("{=!}Furstedatter"),
                new TextObject("{=!}Furstanar"));

            NordKnight = CulturalTitleName.CreateKnight("NordKnight",
                nord,
                new TextObject("{=!}Vaepnare"),
                new TextObject("{=!}Vaepnarinna"),
                new TextObject("{=!}Vaepnarenar"));


            #endregion Nord

            #region Vakken
            VakkenEmperor = CulturalTitleName.CreateEmpire("VakkenEmperor",
                vakken,
                new TextObject("{=!}Maailmas"),
                new TextObject("{=!}Maailmatar"),
                new TextObject("{=!}Maailmanvalta"));

            VakkenKing = CulturalTitleName.CreateKingdom("VakkenKing",
                vakken,
                new TextObject("{=!}Valtias"),
                new TextObject("{=!}Valtiatar"),
                new TextObject("{=!}Valtakunta"));

            VakkenDuke = CulturalTitleName.CreateDuchy("VakkenDuke",
                vakken,
                new TextObject("{=!}Ruhtinas"),
                new TextObject("{=!}Ruhtinatar"),
                new TextObject("{=!}Ruhtinaskunta"));

            VakkenCount = CulturalTitleName.CreateCounty("VakkenCount",
                vakken,
                new TextObject("{=!}Kreivi"),
                new TextObject("{=!}Kreivatar"),
                new TextObject("{=!}Kreivikunta"));

            VakkenBaron = CulturalTitleName.CreateBarony("VakkenBaron",
                vakken,
                new TextObject("{=!}Vapaaherra"),
                new TextObject("{=!}Vapaaherratar"),
                new TextObject("{=!}Vapaaherrakunta"));

            VakkenLord = CulturalTitleName.CreateLordship("VakkenLord",
                vakken,
                new TextObject("{=!}Johtaja"),
                new TextObject("{=!}Johtajatar"),
                new TextObject("{=!}Haimo"));

            VakkenPrince = CulturalTitleName.CreatePrince("VakkenPrince",
                vakken,
                new TextObject("{=!}Ruhtinas"),
                new TextObject("{=!}Ruhtinatar"),
                new TextObject("{=!}Ruhtinaat"));

            VakkenKnight = CulturalTitleName.CreateKnight("VakkenKnight",
                vakken,
                new TextObject("{=!}Seuralainen"),
                new TextObject("{=!}Seuralainen"),
                new TextObject("{=!}Seuralaiset"));

            #endregion Vakken

            #region Siri
            SiriEmperor = CulturalTitleName.CreateEmpire("SiriEmperor",
                siri,
                new TextObject("{=emperor_siri}Uruigun Uru"),
                new TextObject("{=empress_siri}Ngonnenigun Ngonnen"),
                new TextObject("{=empire_siri}Urkane Ur"));

            SiriKing = CulturalTitleName.CreateKingdom("SiriKing",
                siri,
                new TextObject("{=king_siri}Uru"),
                new TextObject("{=queen_siri}Ngonnen"),
                new TextObject("{=kingdom_siri}Urkane"));

            SiriDuke = CulturalTitleName.CreateDuchy("SiriDuke",
                siri,
                new TextObject("{=duke_siri}Mek"),
                new TextObject("{=duchess_siri}Mek-Itt"),
                new TextObject("{=duchy_siri}Mekk"));

            SiriCount = CulturalTitleName.CreateCounty("SiriCount",
                siri,
                new TextObject("{=count_siri}Samet"),
                new TextObject("{=countess_siri}Samet-Itt"),
                new TextObject("{=county_siri}Samett"));

            SiriBaron = CulturalTitleName.CreateBarony("SiriBaron",
                siri,
                new TextObject("{=baron_siri}Dawkatt"),
                new TextObject("{=baroness_siri}Dawkatt-Itt"),
                new TextObject("{=barony_siri}Dipp"));

            SiriLord = CulturalTitleName.CreateLordship("SiriLord",
                siri,
                new TextObject("{=lord_siri}Ngod"),
                new TextObject("{=lady_siri}Ngod-Itt"),
                new TextObject("{=lordship_siri}Erk"));

            SiriPrince = CulturalTitleName.CreatePrince("SiriPrince",
                siri,
                new TextObject("{=prince_siri}Pour"),
                new TextObject("{=princess_siri}Ngonnas"),
                new TextObject("{=princes_siri}Pournigou"));

            SiriKnight = CulturalTitleName.CreateKnight("SiriKnight",
                siri,
                new TextObject("{=knight_siri}Dignarel"),
                new TextObject("{=knightess_siri}Dignarel-Itt"),
                new TextObject("{=knights_siri}Dignareligou"));

            #endregion Siri

            #region Massa
            MassaEmperor = CulturalTitleName.CreateEmpire("MassaEmperor",
                massa,
                new TextObject("{=!}Fraujinonds"),
                new TextObject("{=!}Fraujinondei"),
                new TextObject("{=!}Fraujinondgardi"));

            MassaKing = CulturalTitleName.CreateKingdom("MassaKing",
                massa,
                new TextObject("{=!}Thiudans"),
                new TextObject("{=!}Thiudana"),
                new TextObject("{=!}Thiudangardi"));

            MassaDuke = CulturalTitleName.CreateDuchy("MassaDuke",
                massa,
                new TextObject("{=!}Ufarreiks"),
                new TextObject("{=!}Ufarqino"),
                new TextObject("{=!}Ufarreiki"));

            MassaCount = CulturalTitleName.CreateCounty("MassaCount",
                massa,
                new TextObject("{=!}Reiks"),
                new TextObject("{=!}Qino"),
                new TextObject("{=!}Reiki"));

            MassaBaron = CulturalTitleName.CreateBarony("MassaBaron",
                massa,
                new TextObject("{=!}Harjatuga"),
                new TextObject("{=!}Harjatugo"),
                new TextObject("{=!}Harjatugianassus"));

            MassaLord = CulturalTitleName.CreateLordship("MassaLord",
                massa,
                new TextObject("{=!}Frauja"),
                new TextObject("{=!}Frauja"),
                new TextObject("{=!}Fraujinassus"));

            MassaPrince = CulturalTitleName.CreatePrince("MassaPrince",
                massa,
                new TextObject("{=!}Nithjis"),
                new TextObject("{=!}Nithjo"),
                new TextObject("{=!}Nithjos"));

            MassaKnight = CulturalTitleName.CreateKnight("MassaKnight",
                massa,
                new TextObject("{=!}Rìkis"),
                new TextObject("{=!}Rìkis"),
                new TextObject("{=!}Rìkiai"));

            #endregion Massa

            #region Bragantia
            BragantiaEmperor = CulturalTitleName.CreateEmpire("BragantiaEmperor",
                bragantia,
                new TextObject("{=!}Grão-Rei"),
                new TextObject("{=!}Grã-Reinna"),
                new TextObject("{=!}Grão-Reinato"));

            BragantiaKing = CulturalTitleName.CreateKingdom("BragantiaKing",
                bragantia,
                new TextObject("{=!}Rei"),
                new TextObject("{=!}Reinna"),
                new TextObject("{=!}Reinato"));

            BragantiaDuke = CulturalTitleName.CreateDuchy("BragantiaDuke",
                bragantia,
                new TextObject("{=!}Duc"),
                new TextObject("{=!}Duca"),
                new TextObject("{=!}Ducato"));

            BragantiaCount = CulturalTitleName.CreateCounty("BragantiaCount",
                bragantia,
                new TextObject("{=!}Conde"),
                new TextObject("{=!}Condessa"),
                new TextObject("{=!}Condato"));

            BragantiaBaron = CulturalTitleName.CreateBarony("BragantiaBaron",
                bragantia,
                new TextObject("{=!}Barão"),
                new TextObject("{=!}Baronesa"),
                new TextObject("{=!}Baronato"));

            BragantiaLord = CulturalTitleName.CreateLordship("BragantiaLord",
                bragantia,
                new TextObject("{=!}Sennor"),
                new TextObject("{=!}Sennora"),
                new TextObject("{=!}Sennorio"));

            BragantiaPrince = CulturalTitleName.CreatePrince("BragantiaPrince",
                bragantia,
                new TextObject("{=!}Principe"),
                new TextObject("{=!}Princesa"),
                new TextObject("{=!}Principes"));

            BragantiaKnight = CulturalTitleName.CreateKnight("BragantiaKnight",
                bragantia,
                new TextObject("{=!}Mesnadeiro"),
                new TextObject("{=!}Mesnadeira"),
                new TextObject("{=!}Mesnadeiros"));

            #endregion Bragantia

            #region Lokti
            LoktiEmperor = CulturalTitleName.CreateEmpire("LoktiEmperor",
                lokti,
                new TextObject("{=emperor_lokti}Karalius"),
                new TextObject("{=empress_lokti}Karaliene"),
                new TextObject("{=empire_lokti}Karalyste"));

            LoktiKing = CulturalTitleName.CreateKingdom("LoktiKing",
                lokti,
                new TextObject("{=king_lokti}Kunigu Kunigas"),
                new TextObject("{=queen_lokti}Kunigieniu Kunigiene"),
                new TextObject("{=kingdom_lokti}Didi Kunigyste"));

            LoktiDuke = CulturalTitleName.CreateDuchy("LoktiDuke",
                lokti,
                new TextObject("{=duke_lokti}Kunigas"),
                new TextObject("{=duchess_lokti}Kunigiene"),
                new TextObject("{=duchy_lokti}Kunigystė"));

            LoktiCount = CulturalTitleName.CreateCounty("LoktiCount",
                lokti,
                new TextObject("{=baron_lokti}Kunigaikshtis"),
                new TextObject("{=baroness_lokti}Kunigaikshtiene"),
                new TextObject("{=barony_lokti}Kunigaikshtyste"));

            LoktiBaron = CulturalTitleName.CreateBarony("LoktiBaron",
                lokti,
                new TextObject("{=count_lokti}Vieshpats"),
                new TextObject("{=countess_lokti}Vieshpatiene"),
                new TextObject("{=county_lokti}Valschius"));

            LoktiLord = CulturalTitleName.CreateLordship("LoktiLord",
                lokti,
                new TextObject("{=lord_lokti}Valdovas"),
                new TextObject("{=lady_lokti}Valdove"),
                new TextObject("{=lordship_lokti}Valdovyste"));

            LoktiPrince = CulturalTitleName.CreatePrince("LoktiPrince",
                lokti,
                new TextObject("{=prince_lokti}Ipedinis"),
                new TextObject("{=princess_lokti}Ipedine"),
                new TextObject("{=princes_lokti}Ipediniai"));

            LoktiKnight = CulturalTitleName.CreateKnight("LoktiKnight",
                lokti,
                new TextObject("{=knight_lokti}Leitis"),
                new TextObject("{=knightess_lokti}Leitis"),
                new TextObject("{=knights_lokti}Leiciai"));

            #endregion Lokti

            #region Geroia
            GeroiaEmperor = CulturalTitleName.CreateEmpire("GeroiaEmperor",
                geroia,
                new TextObject("{=!}Arciprincipe"),
                new TextObject("{=!}Arciprincipa"),
                new TextObject("{=!}Arciprincipateri"));

            GeroiaKing = CulturalTitleName.CreateKingdom("GeroiaKing",
                geroia,
                new TextObject("{=!}Arciducxate"),
                new TextObject("{=!}Arciducxata"),
                new TextObject("{=!}Arciducxateri"));

            GeroiaDuke = CulturalTitleName.CreateDuchy("GeroiaDuke",
                geroia,
                new TextObject("{=!}Ducxate"),
                new TextObject("{=!}Ducxata"),
                new TextObject("{=!}Ducxateri"));

            GeroiaCount = CulturalTitleName.CreateCounty("GeroiaCount",
                geroia,
                new TextObject("{=!}Gondh"),
                new TextObject("{=!}Gonda"),
                new TextObject("{=!}Gonderi"));

            GeroiaBaron = CulturalTitleName.CreateBarony("GeroiaBaron",
                geroia,
                new TextObject("{=!}Giudicadh"),
                new TextObject("{=!}Giudicada"),
                new TextObject("{=!}Giudicaderi"));

            GeroiaLord = CulturalTitleName.CreateLordship("GeroiaLord",
                geroia,
                new TextObject("{=!}Capitaine"),
                new TextObject("{=!}Capitaina"),
                new TextObject("{=!}Capitaneri"));

            GeroiaPrince = CulturalTitleName.CreatePrince("GeroiaPrince",
                geroia,
                new TextObject("{=!}Principe"),
                new TextObject("{=!}Principa"),
                new TextObject("{=!}Principi"));

            GeroiaKnight = CulturalTitleName.CreateKnight("GeroiaKnight",
                geroia,
                new TextObject("{=!}Cavaliere"),
                new TextObject("{=!}Cavaliere"),
                new TextObject("{=!}Cavalieri"));

            #endregion Geroia

            foreach (CulturalTitleName name in All)
            {
                DefaultTitleNames.Instance.AddObject(name);
            }
        }
    }
}
