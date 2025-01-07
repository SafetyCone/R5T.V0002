using System;
using System.Collections.Generic;

using R5T.L0087.T000;
using R5T.L0090.T000;
using R5T.T0131;


namespace R5T.V0002.Z001.Raw
{
    [ValuesMarker]
    public partial interface IDayOfWeekExpectations : IValuesMarker
    {
        Expectation<DayOfWeek[], Dictionary<DayOfWeek, int>> N_001 => new Expectation<DayOfWeek[], Dictionary<DayOfWeek, int>>
        {
            Input = Instances.DayOfWeekOperator.Get_DaysOfWeek(),
            Output = new Dictionary<DayOfWeek, int>
            {
                { DayOfWeek.Sunday, 0 },
                { DayOfWeek.Monday, 1 },
                { DayOfWeek.Tuesday, 2 },
                { DayOfWeek.Wednesday, 3 },
                { DayOfWeek.Thursday, 4 },
                { DayOfWeek.Friday, 5 },
                { DayOfWeek.Saturday, 6 }
            },
            OutputEqualityComparer = new FunctionBasedEqualityComparer<Dictionary<DayOfWeek, int>>((a, b) =>
            {
                var sameNumberOfElements = Instances.DictionaryOperator.Equal_Counts(a, b);
                if(!sameNumberOfElements)
                {
                    return false;
                }

                var sameKeySets = Instances.DictionaryOperator.Equal_KeySets(a, b);
                if(!sameKeySets)
                {
                    return false;
                }

                var sameValuesForKeys = Instances.DictionaryOperator.Equal_ValuesForKeyIntersection(a, b);
                if(!sameValuesForKeys)
                {
                    return false;
                }

                return true;
            })
        };

        Expectation<DayOfWeek[], int[]> N_002 => new Expectation<DayOfWeek[], int[]>
        {
            Input = Instances.DayOfWeekSets.All_InOrder,
            Output = Instances.ArrayOperator.Get_Range_Inclusive(0, 6),
            OutputEqualityComparer = new FunctionBasedEqualityComparer<int[]>(
                Instances.ArrayOperator.Are_Equal)
        };

        /// <inheritdoc cref="IDayOfWeekExpectationPairSets.N_001"/>
        Expectation<(DayOfWeek, DayOfWeek)[], int[]> N_003 => Instances.ExpectationOperator.From_ToArray(
            Instances.DayOfWeekExpectationPairSets._Raw.N_001);

        /// <inheritdoc cref="IDayOfWeekExpectationPairSets.N_002"/>
        Expectation<(DayOfWeek, DayOfWeek)[], int[]> N_004 => Instances.ExpectationOperator.From_ToArray(
            Instances.DayOfWeekExpectationPairSets._Raw.N_002);

        /// <inheritdoc cref="IDayOfWeekExpectationPairSets.N_003"/>
        Expectation<(DayOfWeek, DayOfWeek)[], int[]> N_005 => Instances.ExpectationOperator.From_ToArray(
            Instances.DayOfWeekExpectationPairSets._Raw.N_003);

        /// <inheritdoc cref="IDayOfWeekExpectationPairSets.N_004"/>
        Expectation<(DayOfWeek, DayOfWeek)[], int[]> N_006 => Instances.ExpectationOperator.From_ToArray(
            Instances.DayOfWeekExpectationPairSets._Raw.N_004);
    }
}
