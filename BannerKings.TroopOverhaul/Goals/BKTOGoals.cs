using BannerKings.Managers.Goals;
using BannerKings.Managers.Goals.Decisions;
using System.Collections.Generic;

namespace BannerKings.CulturesExpanded.Goals
{
    internal class BKTOGoals : DefaultTypeInitializer<BKTOGoals, Goal>
    {
        public CrownGuardGoal CrownGuard { get; } = new CrownGuardGoal();
        public Goal VlandiaGoal { get; } = new VlandiaEmpireGoal();
        public Goal BattaniaGoal { get; } = new GreaterBattaniaGoal();
        public Goal AseraiGoal { get; } = new AseraiEmpireGoal();
        public Goal SturgiaGoal { get; } = new SturgiaEmpireGoal();
        public Goal DarshiGoal { get; } = new DarshiEmpireGoal();
        public override IEnumerable<Goal> All
        {
            get
            {
                yield return CrownGuard;
                yield return VlandiaGoal;
                yield return BattaniaGoal;
                yield return AseraiGoal;
                yield return SturgiaGoal;
                yield return DarshiGoal;
            }
        }

        public override void Initialize()
        {
            foreach (Goal goal in All)
            {
                DefaultGoals.Instance.AddObject(goal);
            }
        }
    }
}
