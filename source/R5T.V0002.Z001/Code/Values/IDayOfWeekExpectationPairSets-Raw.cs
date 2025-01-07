using System;

using R5T.L0087.T000;
using R5T.T0131;


namespace R5T.V0002.Z001.Raw
{
    [ValuesMarker]
    public partial interface IDayOfWeekExpectationPairSets : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IDayOfWeekExpectationPairs _DayOfWeekExpectationPairs => DayOfWeekExpectationPairs.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int>[] N_001 => new[]
        {
            _DayOfWeekExpectationPairs.N_001,
            _DayOfWeekExpectationPairs.N_002,
            _DayOfWeekExpectationPairs.N_003,
            _DayOfWeekExpectationPairs.N_004,
            _DayOfWeekExpectationPairs.N_005,
            _DayOfWeekExpectationPairs.N_006,
            _DayOfWeekExpectationPairs.N_007,
            _DayOfWeekExpectationPairs.N_008,
            _DayOfWeekExpectationPairs.N_009,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int>[] N_002 => new[]
        {
            _DayOfWeekExpectationPairs.N_011,
            _DayOfWeekExpectationPairs.N_012,
            _DayOfWeekExpectationPairs.N_013,
            _DayOfWeekExpectationPairs.N_014,
            _DayOfWeekExpectationPairs.N_015,
            _DayOfWeekExpectationPairs.N_016,
            _DayOfWeekExpectationPairs.N_017,
            _DayOfWeekExpectationPairs.N_018,
            _DayOfWeekExpectationPairs.N_019,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int>[] N_003 => new[]
        {
            _DayOfWeekExpectationPairs.N_021,
            _DayOfWeekExpectationPairs.N_022,
            _DayOfWeekExpectationPairs.N_023,
            _DayOfWeekExpectationPairs.N_024,
            _DayOfWeekExpectationPairs.N_025,
            _DayOfWeekExpectationPairs.N_026,
            _DayOfWeekExpectationPairs.N_027,
            _DayOfWeekExpectationPairs.N_028,
            _DayOfWeekExpectationPairs.N_029,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int>[] N_004 => new[]
        {
            _DayOfWeekExpectationPairs.N_031,
            _DayOfWeekExpectationPairs.N_032,
            _DayOfWeekExpectationPairs.N_033,
            _DayOfWeekExpectationPairs.N_034,
            _DayOfWeekExpectationPairs.N_035,
            _DayOfWeekExpectationPairs.N_036,
            _DayOfWeekExpectationPairs.N_037,
            _DayOfWeekExpectationPairs.N_038,
            _DayOfWeekExpectationPairs.N_039,
        };
    }
}
