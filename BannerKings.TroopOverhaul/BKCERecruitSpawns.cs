using BannerKings.Managers.Innovations.Eras;
using BannerKings.Managers.Recruits;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;

namespace BannerKings.CulturesExpanded
{
    internal class BKCERecruitSpawns : DefaultTypeInitializer<BKCERecruitSpawns, RecruitSpawn>
    {
        #region strugia
        public RecruitSpawn SturgiaMeleeT1 { get; } = new RecruitSpawn();
        public RecruitSpawn SturgiaRangedT1 { get; } = new RecruitSpawn();
        public RecruitSpawn SturgiaMeleeT2 { get; } = new RecruitSpawn();
        public RecruitSpawn SturgiaRangedT2 { get; } = new RecruitSpawn();
        public RecruitSpawn SturgiaMeleeT3 { get; } = new RecruitSpawn();
        public RecruitSpawn SturgiaTyalRecruit { get; } = new RecruitSpawn();
        public RecruitSpawn SturgiaTyal { get; } = new RecruitSpawn();
        public RecruitSpawn SturgiaNoble { get; } = new RecruitSpawn();
        public RecruitSpawn SturgiaSkirmisher { get; } = new RecruitSpawn();
        public RecruitSpawn SturgiaCavalry { get; } = new RecruitSpawn();
        #endregion sturgia

        #region Nord
        public RecruitSpawn NordMeleeT1 { get; } = new RecruitSpawn();
        public RecruitSpawn NordRangedT1 { get; } = new RecruitSpawn();
        public RecruitSpawn NordMeleeT2 { get; } = new RecruitSpawn();
        public RecruitSpawn NordRangedT2 { get; } = new RecruitSpawn();
        public RecruitSpawn NordMeleeT3 { get; } = new RecruitSpawn();
        public RecruitSpawn NordNoble { get; } = new RecruitSpawn();
        #endregion Nord

        #region Bragantia
        public RecruitSpawn BragantiaMeleeT1 { get; } = new RecruitSpawn();
        public RecruitSpawn BragantiaRangedT1 { get; } = new RecruitSpawn();
        public RecruitSpawn BragantiaMeleeT2 { get; } = new RecruitSpawn();
        public RecruitSpawn BragantiaRangedT2 { get; } = new RecruitSpawn();
        public RecruitSpawn BragantiaMeleeT3 { get; } = new RecruitSpawn();
        public RecruitSpawn BragantiaNoble { get; } = new RecruitSpawn();
        #endregion Bragantia

        #region Massa
        public RecruitSpawn MassaMeleeT1 { get; } = new RecruitSpawn();
        public RecruitSpawn MassaRangedT1 { get; } = new RecruitSpawn();
        public RecruitSpawn MassaMeleeT2 { get; } = new RecruitSpawn();
        public RecruitSpawn MassaRangedT2 { get; } = new RecruitSpawn();
        public RecruitSpawn MassaMeleeT3 { get; } = new RecruitSpawn();
        public RecruitSpawn MassaNoble { get; } = new RecruitSpawn();
        #endregion Massa

        #region Kannic
        public RecruitSpawn KannicMeleeT1 { get; } = new RecruitSpawn();
        public RecruitSpawn KannicRangedT1 { get; } = new RecruitSpawn();
        public RecruitSpawn KannicMeleeT2 { get; } = new RecruitSpawn();
        public RecruitSpawn KannicRangedT2 { get; } = new RecruitSpawn();
        public RecruitSpawn KannicMeleeT3 { get; } = new RecruitSpawn();
        public RecruitSpawn KannicNoble { get; } = new RecruitSpawn();
        public RecruitSpawn KannicHoplite { get; } = new RecruitSpawn();
        public RecruitSpawn KannicRiderT3 { get; } = new RecruitSpawn();
        public RecruitSpawn KannicRiderT4 { get; } = new RecruitSpawn();
        

        #endregion Kannic

        #region empire
        public RecruitSpawn EmpireMeleeT1 { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireRangedT1 { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireMeleeT2 { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireRangedT2 { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireMeleeT3 { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireXbowT1 { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireXbowT2 { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireEques { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireHippo { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireNoble { get; } = new RecruitSpawn();
        public RecruitSpawn EmpirePeltast { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireBorderBattania { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireBorderSturgia { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireBorderKhuzait { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireBorderAserai { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireRepublicT2 { get; } = new RecruitSpawn();
        public RecruitSpawn EmpireRepublicT3 { get; } = new RecruitSpawn();
        #endregion empire

        #region Geroia
        public RecruitSpawn GeroiaMeleeT1 { get; } = new RecruitSpawn();
        public RecruitSpawn GeroiaRangedT1 { get; } = new RecruitSpawn();
        public RecruitSpawn GeroiaMeleeT2 { get; } = new RecruitSpawn();
        public RecruitSpawn GeroiaRangedT2 { get; } = new RecruitSpawn();
        public RecruitSpawn GeroiaMeleeT3 { get; } = new RecruitSpawn();
        public RecruitSpawn GeroiaSpearSergeant { get; } = new RecruitSpawn();
        public RecruitSpawn GeroiaRangedT3 { get; } = new RecruitSpawn();
        public RecruitSpawn GeroiaNoble { get; } = new RecruitSpawn();
        public RecruitSpawn GeroiaSlave { get; } = new RecruitSpawn();
        #endregion Geroia

        #region Aserai
        public RecruitSpawn AseraiMeleeT1 { get; } = new RecruitSpawn();
        public RecruitSpawn AseraiRangedT1 { get; } = new RecruitSpawn();
        public RecruitSpawn AseraiMeleeT2 { get; } = new RecruitSpawn();
        public RecruitSpawn AseraiRangedT2 { get; } = new RecruitSpawn();
        public RecruitSpawn AseraiMeleeT3 { get; } = new RecruitSpawn();
        public RecruitSpawn AseraiCamel { get; } = new RecruitSpawn();
        public RecruitSpawn AseraiCamelNoble { get; } = new RecruitSpawn();
        public RecruitSpawn AseraiNoble { get; } = new RecruitSpawn();
        public RecruitSpawn KanicRider { get; } = new RecruitSpawn();
        public RecruitSpawn KanicHorseman { get; } = new RecruitSpawn();
        #endregion Aserai

        public override IEnumerable<RecruitSpawn> All
        {
            get
            {
                yield return SturgiaMeleeT1;
                yield return SturgiaRangedT1;
                yield return SturgiaMeleeT2;
                yield return SturgiaRangedT2;
                yield return SturgiaSkirmisher;
                yield return SturgiaMeleeT3;
                yield return SturgiaCavalry;
                yield return SturgiaTyalRecruit;
                yield return SturgiaTyal;
                yield return SturgiaNoble;
                yield return EmpireMeleeT1;
                yield return EmpireRangedT1;
                yield return EmpireXbowT1;
                yield return EmpireXbowT2;
                yield return EmpireMeleeT2;
                yield return EmpireRangedT2;
                yield return EmpirePeltast;
                yield return EmpireMeleeT3;
                yield return EmpireBorderBattania;
                yield return EmpireBorderAserai;
                yield return EmpireBorderKhuzait;
                yield return EmpireBorderSturgia;
                yield return EmpireRepublicT2;
                yield return EmpireRepublicT3;
                yield return EmpireEques;
                yield return EmpireHippo;
                yield return EmpireNoble;         
                yield return AseraiMeleeT1;
                yield return AseraiRangedT1;
                yield return AseraiMeleeT2;
                yield return AseraiRangedT2;
                yield return AseraiMeleeT3;
                yield return KanicRider;
                yield return KanicHorseman;
                yield return AseraiCamel;
                yield return AseraiCamelNoble;
                yield return AseraiNoble;
                yield return GeroiaMeleeT1;
                yield return GeroiaMeleeT2;
                yield return GeroiaMeleeT3;
                yield return GeroiaSpearSergeant;
                yield return GeroiaRangedT1;
                yield return GeroiaRangedT2;
                yield return GeroiaRangedT3;
                yield return GeroiaNoble;
                yield return GeroiaSlave;
                yield return NordMeleeT1;
                yield return NordMeleeT2;
                yield return NordMeleeT3;
                yield return NordNoble;
                yield return NordRangedT1;
                yield return NordRangedT2;
                yield return KannicMeleeT1;
                yield return KannicMeleeT2;
                yield return KannicMeleeT3;
                yield return KannicNoble;
                yield return KannicRangedT1;
                yield return KannicRangedT2;
                yield return KannicHoplite;
                yield return KannicRiderT3;
                yield return KannicRiderT4;
                yield return MassaMeleeT1;
                yield return MassaMeleeT2;
                yield return MassaMeleeT3;
                yield return MassaNoble;
                yield return MassaRangedT1;
                yield return MassaRangedT2;
                yield return BragantiaMeleeT1;
                yield return BragantiaMeleeT2;
                yield return BragantiaMeleeT3;
                yield return BragantiaNoble;
                yield return BragantiaRangedT1;
                yield return BragantiaRangedT2;
            }
        }

        public override void Initialize()
        {
            #region sturgia
            var sturgia = GetCulture("sturgia");
            SturgiaMeleeT1.Initialize(GetTroop("bk_sturgian_levy"),
                sturgia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    { 
                        Managers.PopulationManager.PopType.Serfs, 0.7f
                    }
                });

            SturgiaRangedT1.Initialize(GetTroop("bk_sturgian_levy_archer"),
                sturgia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.3f
                    }
                });

            SturgiaMeleeT2.Initialize(GetTroop("bk_sturgian_militiaman"),
                sturgia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.5f
                    }
                });

            SturgiaRangedT2.Initialize(GetTroop("bk_sturgian_militiaman_archer"),
                sturgia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.3f
                    },
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.15f
                    }
                });

            SturgiaSkirmisher.Initialize(GetTroop("bk_sturgian_skirmisher"),
                sturgia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.2f
                    },
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.1f
                    }
                });

            SturgiaMeleeT3.Initialize(GetTroop("bk_sturgia_sergeant"),
                sturgia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 0.5f
                    }
                });

            SturgiaCavalry.Initialize(GetTroop("bk_sturgia_cavalry"),
               sturgia,
               new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 1f
                    }
                });

            SturgiaNoble.Initialize(GetTroop("bk_sturgia_squire"),
                sturgia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Nobles, 1f
                    }
                });

            SturgiaTyalRecruit.Initialize(GetTroop("bk_sturgian_tyalese_scout"),
                sturgia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 1f
                    }
                });
            SturgiaTyal.AddFiefString("town_S5");

            SturgiaTyal.Initialize(GetTroop("bk_sturgian_tyalese_archer"),
                sturgia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 1f
                    }
                });
            SturgiaTyal.AddFiefString("town_S5");

            #endregion sturgia

            #region Nord
            var nord = GetCulture("nord");
            NordMeleeT1.Initialize(GetTroop("bk_nord_levy"),
                nord,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.7f
                    }
                });

            NordRangedT1.Initialize(GetTroop("bk_nord_levy_archer"),
                nord,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.3f
                    }
                });

            NordMeleeT2.Initialize(GetTroop("bk_nord_militiaman"),
                nord,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.5f
                    }
                });

            NordRangedT2.Initialize(GetTroop("bk_nord_militiaman_archer"),
                nord,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.3f
                    },
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.15f
                    }
                });

            NordMeleeT3.Initialize(GetTroop("bk_nord_sergeant"),
                nord,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 0.5f
                    }
                });

            NordNoble.Initialize(GetTroop("bk_nord_squire"),
                nord,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Nobles, 1f
                    }
                });

            #endregion Nord

            #region Massa
            var massa = GetCulture("massa");
            MassaMeleeT1.Initialize(GetTroop("bk_massa_levy"),
                massa,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.7f
                    }
                });

            MassaRangedT1.Initialize(GetTroop("bk_massa_levy_sling"),
                massa,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.3f
                    }
                });

            MassaMeleeT2.Initialize(GetTroop("bk_massa_militiaman"),
                massa,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.25f
                    }
                });

            MassaRangedT2.Initialize(GetTroop("bk_massa_militiaman_sling"),
                massa,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.3f
                    },
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.15f
                    }
                });

            MassaMeleeT3.Initialize(GetTroop("bk_massa_sergeant"),
                massa,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 0.5f
                    }
                });

            MassaNoble.Initialize(GetTroop("bk_massa_squire"),
                massa,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Nobles, 1f
                    }
                });

            #endregion Massa

            #region Kannic
            var kannic = GetCulture("kannic");
            KannicMeleeT1.Initialize(GetTroop("bk_kannic_levy"),
                kannic,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.7f
                    }
                });

            KannicRangedT1.Initialize(GetTroop("bk_kannic_levy_archer"),
                kannic,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.3f
                    }
                });

            KannicMeleeT2.Initialize(GetTroop("bk_kannic_militiaman"),
                kannic,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.25f
                    }
                });

            KannicRangedT2.Initialize(GetTroop("bk_kannic_militiaman_archer"),
                kannic,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.3f
                    },
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.15f
                    }
                });

            KannicMeleeT3.Initialize(GetTroop("bk_kannic_sergeant"),
                kannic,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 0.5f
                    }
                });

            KannicRiderT3.Initialize(GetTroop("bk_kanic_rider"),
                kannic,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.15f
                    }
                });

            KannicRiderT4.Initialize(GetTroop("bk_kanic_horseman"),
                kannic,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 0.15f
                    }
                });

            KannicHoplite.Initialize(GetTroop("bk_kanic_citizen"),
                kannic,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Nobles, 0.5f
                    },
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 0.25f
                    }
                }); 

            KannicNoble.Initialize(GetTroop("bk_kanic_highborn"),
                kannic,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Nobles, 1f
                    }
                });

            #endregion Kannic

            #region Bragantia
            var bragantia = GetCulture("bragantia");
            BragantiaMeleeT1.Initialize(GetTroop("bk_bragantia_levy"),
                bragantia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.7f
                    }
                });

            BragantiaRangedT1.Initialize(GetTroop("bk_bragantia_levy_crossbow"),
                bragantia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.3f
                    }
                });

            BragantiaMeleeT2.Initialize(GetTroop("bk_bragantia_militiaman"),
                bragantia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.5f
                    }
                });

            BragantiaRangedT2.Initialize(GetTroop("bk_bragantia_militiaman_crossbow"),
                bragantia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.3f
                    },
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.15f
                    }
                });

            BragantiaMeleeT3.Initialize(GetTroop("bk_bragantia_sergeant"),
                bragantia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 0.5f
                    }
                });

            BragantiaNoble.Initialize(GetTroop("bk_bragantia_squire"),
                bragantia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Nobles, 1f
                    }
                });

            #endregion Bragantia

            #region empire
            var empire = GetCulture("empire");
            EmpireMeleeT1.Initialize(GetTroop("bk_imperial_levy"),
                empire,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.7f
                    }
                });

            EmpireRangedT1.Initialize(GetTroop("bk_imperial_levy_archer"),
                empire,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.15f
                    }
                });

            EmpireXbowT1.Initialize(GetTroop("bk_imperial_levy_crossbow"),
                empire,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.15f
                    }
                });

            EmpireMeleeT2.Initialize(GetTroop("bk_imperial_militiaman"),
                empire,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.5f
                    },
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.15f
                    }
                });

            EmpireBorderSturgia.Initialize(GetTroop("bk_imperial_liminatei_sturgia"),
                empire,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.5f
                    },
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.15f
                    }
                });
            EmpireBorderSturgia.AddFiefString("town_EN1");
            EmpireBorderSturgia.AddFiefString("village_EN1_1");
            EmpireBorderSturgia.AddFiefString("village_EN1_2");
            EmpireBorderSturgia.AddFiefString("village_EN1_3");
            EmpireBorderSturgia.AddFiefString("castle_EN9");
            EmpireBorderSturgia.AddFiefString("castle_village_EN9_2");
            EmpireBorderSturgia.AddFiefString("town_EN6");
            EmpireBorderSturgia.AddFiefString("village_EN6_1");
            EmpireBorderSturgia.AddFiefString("village_EN6_2");
            EmpireBorderSturgia.AddFiefString("castle_EN7");
            EmpireBorderSturgia.AddFiefString("castle_village_EN7_1");
            EmpireBorderSturgia.AddFiefString("castle_village_EN7_2");

            EmpireBorderBattania.Initialize(GetTroop("bk_imperial_liminatei_battania"),
                empire,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.5f
                    },
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.15f
                    }
                });
            EmpireBorderBattania.AddFiefString("town_EW1");
            EmpireBorderBattania.AddFiefString("village_EW1_1");
            EmpireBorderBattania.AddFiefString("village_EW1_2");
            EmpireBorderBattania.AddFiefString("village_EN1_3");
            EmpireBorderBattania.AddFiefString("castle_EW6");
            EmpireBorderBattania.AddFiefString("castle_village_EW6_1");
            EmpireBorderBattania.AddFiefString("castle_village_EW6_2");
            EmpireBorderBattania.AddFiefString("castle_EW5");
            EmpireBorderBattania.AddFiefString("castle_village_EW5_1");
            EmpireBorderBattania.AddFiefString("castle_village_EW5_2");

            EmpireBorderKhuzait.Initialize(GetTroop("bk_imperial_liminatei_khuzait"),
               empire,
               new Dictionary<Managers.PopulationManager.PopType, float>()
               {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.5f
                    },
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.15f
                    }
               });
            EmpireBorderKhuzait.AddFiefString("town_ES5");
            EmpireBorderKhuzait.AddFiefString("village_ES5_1");
            EmpireBorderKhuzait.AddFiefString("village_ES5_2");
            EmpireBorderKhuzait.AddFiefString("village_ES5_3");
            EmpireBorderKhuzait.AddFiefString("castle_ES2");
            EmpireBorderKhuzait.AddFiefString("castle_village_ES2_1");
            EmpireBorderKhuzait.AddFiefString("castle_village_ES2_2");
            EmpireBorderKhuzait.AddFiefString("town_EN3");
            EmpireBorderKhuzait.AddFiefString("village_EN3_1");
            EmpireBorderKhuzait.AddFiefString("village_EN3_3");
            EmpireBorderKhuzait.AddFiefString("castle_EN8");
            EmpireBorderKhuzait.AddFiefString("castle_village_EN8_1");
            EmpireBorderKhuzait.AddFiefString("castle_village_EN8_2");

            EmpireBorderAserai.Initialize(GetTroop("bk_imperial_liminatei_aserai"),
              empire,
              new Dictionary<Managers.PopulationManager.PopType, float>()
              {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.5f
                    },
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.15f
                    }
              });
            EmpireBorderAserai.AddFiefString("town_ES1");
            EmpireBorderAserai.AddFiefString("village_ES1_2");
            EmpireBorderAserai.AddFiefString("village_ES1_3");
            EmpireBorderAserai.AddFiefString("village_ES1_4");
            EmpireBorderAserai.AddFiefString("castle_ES4");
            EmpireBorderAserai.AddFiefString("castle_village_ES4_1");
            EmpireBorderAserai.AddFiefString("castle_village_ES4_2");
            EmpireBorderAserai.AddFiefString("town_ES2");
            EmpireBorderAserai.AddFiefString("village_ES2_2");
            EmpireBorderAserai.AddFiefString("village_ES2_3");
            EmpireBorderAserai.AddFiefString("village_ES2_4");

            Kingdom northEmpire = Kingdom.All.First(x => x.StringId == "empire");
            EmpireRepublicT2.Initialize(GetTroop("bk_imperial_militiaman_republic"),
             empire,
             new Dictionary<Managers.PopulationManager.PopType, float>()
             {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.5f
                    },
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.15f
                    }
             },
             northEmpire);

            EmpireMeleeT3.Initialize(GetTroop("bk_imperial_sergeant_republic"),
               empire,
               new Dictionary<Managers.PopulationManager.PopType, float>()
               {
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 1f
                    }
               },
               northEmpire);

            EmpirePeltast.Initialize(GetTroop("bk_imperial_peltast"),
                empire,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.1f
                    },
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.075f
                    }
                });

            EmpireRangedT2.Initialize(GetTroop("bk_imperial_militiaman_archer"),
                empire,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.2f
                    },
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.075f
                    }
                });

            EmpireRangedT2.Initialize(GetTroop("bk_imperial_militiaman_crossbow"),
                empire,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.2f
                    },
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.075f
                    }
                });

            EmpireMeleeT3.Initialize(GetTroop("bk_imperial_sergeant"),
                empire,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 1f
                    }
                });
            EmpireMeleeT3.SetTroopAdvancement(DefaultEras.Instance.SecondEra, "bk_skoutatos_e2");
            EmpireMeleeT3.SetTroopAdvancement(DefaultEras.Instance.ThirdEra, "bk_skoutatos_e3");

            EmpireNoble.Initialize(GetTroop("bk_imperial_squire"),
               empire,
               new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Nobles, 1f
                    }
                });
            EmpireNoble.SetTroopAdvancement(DefaultEras.Instance.SecondEra, "bk_imperial_squire_e2");
            EmpireNoble.SetTroopAdvancement(DefaultEras.Instance.ThirdEra, "bk_imperial_squire_e3");

            var cataphract = GetTroop("bk_imperial_cataphract");
            DefaultEras.Instance.SecondEra.AddTroopAdvancement(new BKTroopAdvancement(cataphract, 
                "bk_cataphract_e2"));
            DefaultEras.Instance.ThirdEra.AddTroopAdvancement(new BKTroopAdvancement(cataphract,
                "bk_cataphract_e3"));

            EmpireEques.Initialize(GetTroop("bk_imperial_eques"),
                empire,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.1f
                    },
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 1f
                    }
                });
            EmpireEques.SetTroopAdvancement(DefaultEras.Instance.SecondEra, "bk_imperial_eques_e2");
            EmpireEques.SetTroopAdvancement(DefaultEras.Instance.ThirdEra, "bk_imperial_eques_e3");

            EmpireHippo.Initialize(GetTroop("bk_imperial_hippotoxotes"),
                empire,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.1f
                    },
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 1f
                    }
                });
            #endregion empire

            #region Geroia
            var geroia = GetCulture("geroia");
            GeroiaSlave.Initialize(GetTroop("bk_geroia_levy_slave"),
                geroia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Slaves, 1f
                    }
                });

            GeroiaMeleeT1.Initialize(GetTroop("bk_geroia_levy"),
                geroia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.7f
                    }
                });

            GeroiaRangedT1.Initialize(GetTroop("bk_geroia_levy_archer"),
                geroia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.3f
                    }
                });

            GeroiaMeleeT2.Initialize(GetTroop("bk_geroia_militiaman"),
                geroia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.7f
                    }
                });

            GeroiaRangedT2.Initialize(GetTroop("bk_geroia_militiaman_archer"),
                geroia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.3f
                    }
                });

            GeroiaRangedT3.Initialize(GetTroop("bk_geroia_sergeant_xbow"),
                geroia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 0.3f
                    }
                });

            GeroiaMeleeT3.Initialize(GetTroop("bk_geroia_sergeant"),
                geroia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 0.5f
                    }
                });

            GeroiaSpearSergeant.Initialize(GetTroop("bk_geroia_sergeant"),
                geroia,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 0.5f
                    }
                });

            GeroiaNoble.Initialize(GetTroop("bk_geroia_highborn"),
               geroia,
               new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Nobles, 1f
                    }
                });

            #endregion Geroia

            #region Aserai
            var Aserai = GetCulture("aserai");
            AseraiMeleeT1.Initialize(GetTroop("bk_aserai_levy"),
                Aserai,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.7f
                    }
                });

            AseraiRangedT1.Initialize(GetTroop("bk_aserai_levy_archer"),
                Aserai,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Serfs, 0.3f
                    }
                });

            AseraiMeleeT2.Initialize(GetTroop("bk_aserai_militiaman"),
                Aserai,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.7f
                    }
                });

            AseraiRangedT2.Initialize(GetTroop("bk_aserai_militiaman_archer"),
                Aserai,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.3f
                    }
                });

            AseraiCamel.Initialize(GetTroop("bk_aserai_tuareg"),
               Aserai,
               new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.3f
                    }
                });
            AseraiCamel.AddFiefString("town_A7");
            AseraiCamel.AddFiefString("castle_A3");
            AseraiCamel.AddFiefString("castle_A9");
            AseraiCamel.AddFiefString("castle_A4");
            AseraiCamel.AddFiefString("town_A3");
            AseraiCamel.AddFiefString("castle_A5"); 
            AseraiCamel.AddFiefString("town_A5");
            AseraiCamel.AddFiefString("castle_A2");
            AseraiCamel.AddFiefString("castle_A7");
            AseraiCamel.AddFiefString("town_A6"); 
            AseraiCamel.AddFiefString("town_A8");
            AseraiCamel.AddFiefString("castle_A1");

            AseraiCamelNoble.Initialize(GetTroop("bk_aserai_tuareg_noble"),
               Aserai,
               new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Nobles, 0.7f
                    }
                });
            AseraiCamelNoble.AddFiefString("town_A7");
            AseraiCamelNoble.AddFiefString("castle_A3");
            AseraiCamelNoble.AddFiefString("castle_A9");
            AseraiCamelNoble.AddFiefString("castle_A4");
            AseraiCamelNoble.AddFiefString("town_A3");
            AseraiCamelNoble.AddFiefString("castle_A5");
            AseraiCamelNoble.AddFiefString("town_A5");
            AseraiCamelNoble.AddFiefString("castle_A2");
            AseraiCamelNoble.AddFiefString("castle_A7");
            AseraiCamelNoble.AddFiefString("town_A6");
            AseraiCamelNoble.AddFiefString("town_A8");
            AseraiCamelNoble.AddFiefString("castle_A1");
            
            AseraiMeleeT3.Initialize(GetTroop("bk_aserai_sergeant"),
                Aserai,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 1f
                    }
                });
            AseraiMeleeT3.SetTroopAdvancement(DefaultEras.Instance.SecondEra, "bk_aserai_sergeant_e2");
            AseraiMeleeT3.SetTroopAdvancement(DefaultEras.Instance.ThirdEra, "bk_aserai_sergeant_e3");

            KanicRider.Initialize(GetTroop("bk_kanic_rider"),
                Aserai,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Tenants, 0.15f
                    }
                });
            KanicRider.AddFiefString("town_A1");
            KanicRider.AddFiefString("castle_A1");
            KanicRider.AddFiefString("castle_A7");
            KanicRider.AddFiefString("town_A6");
            KanicRider.AddFiefString("town_A8");
            KanicRider.AddFiefString("town_A4");

            KanicHorseman.Initialize(GetTroop("bk_kanic_horseman"),
                Aserai,
                new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Craftsmen, 0.7f
                    }
                });
            KanicHorseman.AddFiefString("town_A1");
            KanicHorseman.AddFiefString("castle_A1");
            KanicHorseman.AddFiefString("castle_A7");
            KanicHorseman.AddFiefString("town_A6");
            KanicHorseman.AddFiefString("town_A8");
            KanicHorseman.AddFiefString("town_A4");

            AseraiNoble.Initialize(GetTroop("bk_aserai_squire"),
               Aserai,
               new Dictionary<Managers.PopulationManager.PopType, float>()
                {
                    {
                        Managers.PopulationManager.PopType.Nobles, 1f
                    }
                });

            var faaris = GetTroop("bk_aserai_faaris");
            DefaultEras.Instance.SecondEra.AddTroopAdvancement(new BKTroopAdvancement(faaris,
                "bk_faaris_e2"));
            DefaultEras.Instance.ThirdEra.AddTroopAdvancement(new BKTroopAdvancement(faaris,
                "bk_faaris_e3"));
            #endregion Aserai

            foreach (var spawn in All)
            {
                DefaultRecruitSpawns.Instance.AddObject(spawn);
            }
        }

        private CultureObject GetCulture(string id) => TaleWorlds.CampaignSystem.Campaign.Current.ObjectManager.GetObject<CultureObject>(x => x.StringId == id);
        private CharacterObject GetTroop(string id) => TaleWorlds.CampaignSystem.Campaign.Current.ObjectManager.GetObject<CharacterObject>(x => x.StringId == id);
    }
}
