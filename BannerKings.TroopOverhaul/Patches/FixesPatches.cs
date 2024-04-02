using HarmonyLib;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.CampaignSystem.Extensions;
using TaleWorlds.CampaignSystem.ComponentInterfaces;
using TaleWorlds.CampaignSystem.Map;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.CampaignBehaviors.AiBehaviors;
using System.Reflection;
using TaleWorlds.CampaignSystem.CharacterDevelopment;

namespace BannerKings.CulturesExpanded.Patches
{
    internal class FixesPatches
    {
        [HarmonyPatch(typeof(AgingCampaignBehavior))]
        internal class AgingCampaignBehaviorPatches
        {
            [HarmonyPrefix]
            [HarmonyPatch("OnHeroComesOfAge")]
            private static bool OnHeroComesOfAgePrefix(Hero hero)
            {
                if (hero.HeroState != Hero.CharacterStates.Active)
                {
                    try
                    {
                        bool flag = !hero.IsFemale || hero.Clan == Hero.MainHero.Clan || (hero.Mother != null && !hero.Mother.IsNoncombatant) || (hero.RandomIntWithSeed(17U, 0, 1) == 0 && hero.GetTraitLevel(DefaultTraits.Valor) == 1);
                        if (hero.Clan != Clan.PlayerClan)
                        {
                            foreach (TraitObject trait in DefaultTraits.SkillCategories)
                            {
                                hero.SetTraitLevel(trait, 0);
                            }
                            if (flag)
                            {
                                hero.SetTraitLevel(DefaultTraits.CavalryFightingSkills, 5);
                                int value = MathF.Max(DefaultTraits.Commander.MinValue, 3 + hero.GetTraitLevel(DefaultTraits.Valor) + hero.GetTraitLevel(DefaultTraits.Generosity) + hero.RandomIntWithSeed(18U, -1, 2));
                                hero.SetTraitLevel(DefaultTraits.Commander, value);
                            }
                            int value2 = MathF.Max(DefaultTraits.Manager.MinValue, 3 + hero.GetTraitLevel(DefaultTraits.Honor) + hero.RandomIntWithSeed(19U, -1, 2));
                            hero.SetTraitLevel(DefaultTraits.Manager, value2);
                            int value3 = MathF.Max(DefaultTraits.Politician.MinValue, 3 + hero.GetTraitLevel(DefaultTraits.Calculating) + hero.RandomIntWithSeed(20U, -1, 2));
                            hero.SetTraitLevel(DefaultTraits.Politician, value3);
                            hero.HeroDeveloper.InitializeHeroDeveloper(true, null);
                        }
                        else
                        {
                            hero.HeroDeveloper.SetInitialLevel(hero.Level);
                        }
                        MBList<MBEquipmentRoster> equipmentRostersForHeroComeOfAge = TaleWorlds.CampaignSystem.Campaign.Current.Models.EquipmentSelectionModel.GetEquipmentRostersForHeroComeOfAge(hero, false);
                        MBList<MBEquipmentRoster> equipmentRostersForHeroComeOfAge2 = TaleWorlds.CampaignSystem.Campaign.Current.Models.EquipmentSelectionModel.GetEquipmentRostersForHeroComeOfAge(hero, true);
                        MBEquipmentRoster randomElement = equipmentRostersForHeroComeOfAge.GetRandomElement<MBEquipmentRoster>();
                        MBEquipmentRoster randomElement2 = equipmentRostersForHeroComeOfAge2.GetRandomElement<MBEquipmentRoster>();
                        Equipment randomElement3 = randomElement.AllEquipments.GetRandomElement<Equipment>();
                        Equipment randomElement4 = randomElement2.AllEquipments.GetRandomElement<Equipment>();
                        EquipmentHelper.AssignHeroEquipmentFromEquipment(hero, randomElement3);
                        EquipmentHelper.AssignHeroEquipmentFromEquipment(hero, randomElement4);
                    }
                    catch (NullReferenceException e)
                    {
                        throw new NullReferenceException("Missing template for culture " + hero.Culture.StringId, e);
                    }
                }

                return false;
            }
        }

        [HarmonyPatch(typeof(InitialChildGenerationCampaignBehavior))]
        internal class InitialChildGenerationCampaignBehaviorPatches
        {
            [HarmonyPrefix]
            [HarmonyPatch("OnNewGameCreatedPartialFollowUp")]
            private static bool OnNewGameCreatedPartialFollowUpPrefix(CampaignGameStarter starter, int index)
            {
                if (index == 0)
                {
                    using (List<Clan>.Enumerator enumerator = Clan.All.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            Clan clan = enumerator.Current;
                            if (!clan.IsBanditFaction && !clan.IsMinorFaction && !clan.IsEliminated && clan != Clan.PlayerClan)
                            {
                                List<Hero> list = new List<Hero>();
                                MBList<Hero> mblist = new MBList<Hero>();
                                MBList<Hero> mblist2 = new MBList<Hero>();
                                foreach (Hero hero in clan.Lords)
                                {
                                    if (hero.IsAlive)
                                    {
                                        if (hero.IsChild)
                                        {
                                            list.Add(hero);
                                        }
                                        else if (hero.IsFemale)
                                        {
                                            mblist.Add(hero);
                                        }
                                        else
                                        {
                                            mblist2.Add(hero);
                                        }
                                    }
                                }
                                int num = MathF.Ceiling((float)(mblist2.Count + mblist.Count) / 2f) - list.Count;
                                float num2 = 0.49f;
                                if (mblist2.Count == 0)
                                {
                                    num2 = -1f;
                                }
                                Func<Clan, bool> predicate = (Clan t) => t != clan && t.Culture == clan.Culture;
                                for (int i = 0; i < num; i++)
                                {
                                    bool isFemale = MBRandom.RandomFloat <= num2;
                                    Hero hero2 = isFemale ? mblist.GetRandomElement<Hero>() : mblist2.GetRandomElement<Hero>();
                                    if (hero2 == null)
                                    {
                                        IEnumerable<Clan> nonBanditFactions = Clan.NonBanditFactions;
                                        MBList<Clan> e = nonBanditFactions.Where(predicate).ToMBList<Clan>();
                                        if (e.Count > 0)
                                        {
                                            for (int j = 0; j < 10; j++)
                                            {
                                                IEnumerable<Hero> lords = e.GetRandomElement<Clan>().Lords;
                                                Func<Hero, bool> predicate2 = (Hero t) => t.IsAlive && t.IsFemale == isFemale;
                                                hero2 = lords.Where(predicate2).ToMBList<Hero>().GetRandomElement<Hero>();
                                                if (hero2 != null)
                                                {
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    if (hero2 != null)
                                    {
                                        int age = MBRandom.RandomInt(2, 18);
                                        Hero hero3 = HeroCreator.CreateSpecialHero(hero2.CharacterObject, clan.HomeSettlement, clan, null, age);
                                        hero3.UpdateHomeSettlement();
                                        hero3.HeroDeveloper.InitializeHeroDeveloper(true, null);
                                        MBEquipmentRoster randomElementInefficiently =
                                            TaleWorlds.CampaignSystem.Campaign.Current.Models.EquipmentSelectionModel.GetEquipmentRostersForInitialChildrenGeneration(hero3).GetRandomElementInefficiently<MBEquipmentRoster>();
                                        if (randomElementInefficiently != null)
                                        {
                                            Equipment randomCivilianEquipment = randomElementInefficiently.GetRandomCivilianEquipment();
                                            EquipmentHelper.AssignHeroEquipmentFromEquipment(hero3, randomCivilianEquipment);
                                            Equipment equipment = new Equipment(false);
                                            equipment.FillFrom(randomCivilianEquipment, false);
                                            EquipmentHelper.AssignHeroEquipmentFromEquipment(hero3, equipment);
                                        }
                                    }
                                    if (num2 <= 0f)
                                    {
                                        num2 = 0.49f;
                                    }
                                }
                            }
                        }
                    }
                }

                return false;
            }
        }

        [HarmonyPatch(typeof(AiVisitSettlementBehavior))]
        internal class AiVisitSettlementBehaviorPatches
        {
            private static MethodInfo IsSuitable => TaleWorlds.CampaignSystem.Campaign.Current.GetCampaignBehavior<AiVisitSettlementBehavior>()
                .GetType()
                .GetMethod("IsSettlementSuitableForVisitingCondition", BindingFlags.Instance | BindingFlags.NonPublic);

            private static Settlement last;

            [HarmonyPrefix]
            [HarmonyPatch("FindSettlementsToVisitWithDistances")]
            private static bool FindSettlementsToVisitWithDistancesPrefix(AiVisitSettlementBehavior __instance, MobileParty mobileParty, ref SortedList<ValueTuple<float, int>, Settlement> __result)
            {
                SortedList<ValueTuple<float, int>, Settlement> sortedList = new SortedList<ValueTuple<float, int>, Settlement>();
                MapDistanceModel mapDistanceModel = TaleWorlds.CampaignSystem.Campaign.Current.Models.MapDistanceModel;
                if (mobileParty.LeaderHero != null && mobileParty.LeaderHero.MapFaction.IsKingdomFaction)
                {
                    if (mobileParty.Army == null || mobileParty.Army.LeaderParty == mobileParty)
                    {
                        LocatableSearchData<Settlement> locatableSearchData = Settlement.StartFindingLocatablesAroundPosition(mobileParty.Position2D, 30f);
                        for (Settlement settlement = Settlement.FindNextLocatable(ref locatableSearchData); settlement != null; settlement = Settlement.FindNextLocatable(ref locatableSearchData))
                        {
                            if (!settlement.IsCastle && (bool)IsSuitable.Invoke(__instance, new object[] { mobileParty, settlement }))
                            {
                                float distance = mapDistanceModel.GetDistance(mobileParty, settlement);
                                if (distance < 350f)
                                {
                                    last = settlement;
                                    sortedList.Add(new ValueTuple<float, int>(distance, settlement.GetHashCode()), settlement);
                                }
                            }
                        }
                    }
                    using (List<Settlement>.Enumerator enumerator = mobileParty.MapFaction.Settlements.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            Settlement settlement2 = enumerator.Current;
                            if ((bool)IsSuitable.Invoke(__instance, new object[] { mobileParty, settlement2 }))
                            {
                                float distance2 = mapDistanceModel.GetDistance(mobileParty, settlement2);
                                if (mobileParty.Position2D.Distance(settlement2.Position2D) > 30f && distance2 < 350f)
                                {
                                    last = settlement2;
                                    sortedList.Add(new ValueTuple<float, int>(distance2, settlement2.GetHashCode()), settlement2);
                                }
                            }
                        }
                        __result = sortedList;
                        return false;
                    }
                }
                LocatableSearchData<Settlement> locatableSearchData2 = Settlement.StartFindingLocatablesAroundPosition(mobileParty.Position2D, 50f);
                for (Settlement settlement3 = Settlement.FindNextLocatable(ref locatableSearchData2); settlement3 != null; settlement3 = Settlement.FindNextLocatable(ref locatableSearchData2))
                {
                    if ((bool)IsSuitable.Invoke(__instance, new object[] { mobileParty, settlement3 }))
                    {
                        float distance3 = mapDistanceModel.GetDistance(mobileParty, settlement3);
                        if (distance3 < 350f)
                        {
                            last = settlement3;
                            sortedList.Add(new ValueTuple<float, int>(distance3, settlement3.GetHashCode()), settlement3);
                        }
                    }
                }

                __result = sortedList;
                return false;
            }
        }
    }
}
