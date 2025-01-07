using System;

using R5T.L0087.T000;
using R5T.T0131;


namespace R5T.V0002.Z001.Raw
{
    [ValuesMarker]
    public partial interface IDayOfWeekExpectationPairs : IValuesMarker
    {
        #region Next-Inclusive

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_001 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Sunday, DayOfWeek.Sunday),
            Output = 0,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_002 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Sunday, DayOfWeek.Monday),
            Output = 1,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_003 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Sunday, DayOfWeek.Saturday),
            Output = 6,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_004 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Saturday, DayOfWeek.Saturday),
            Output = 0,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_005 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Saturday, DayOfWeek.Sunday),
            Output = 1,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_006 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Saturday, DayOfWeek.Friday),
            Output = 6,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_007 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Tuesday, DayOfWeek.Tuesday),
            Output = 0,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_008 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Tuesday, DayOfWeek.Sunday),
            Output = 5,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_009 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Tuesday, DayOfWeek.Saturday),
            Output = 4,
        };

        #endregion

        #region Next-Exclusive

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_011 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Sunday, DayOfWeek.Sunday),
            Output = 7,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_012 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Sunday, DayOfWeek.Monday),
            Output = 1,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_013 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Sunday, DayOfWeek.Saturday),
            Output = 6,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_014 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Saturday, DayOfWeek.Saturday),
            Output = 7,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_015 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Saturday, DayOfWeek.Sunday),
            Output = 1,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_016 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Saturday, DayOfWeek.Friday),
            Output = 6,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_017 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Tuesday, DayOfWeek.Tuesday),
            Output = 7,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_018 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Tuesday, DayOfWeek.Sunday),
            Output = 5,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_019 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Tuesday, DayOfWeek.Saturday),
            Output = 4,
        };

        #endregion


        #region Prior-Inclusive

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_021 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Sunday, DayOfWeek.Sunday),
            Output = 0,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_022 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Sunday, DayOfWeek.Monday),
            Output = 6,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_023 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Sunday, DayOfWeek.Saturday),
            Output = 1,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_024 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Saturday, DayOfWeek.Saturday),
            Output = 0,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_025 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Saturday, DayOfWeek.Sunday),
            Output = 6,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_026 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Saturday, DayOfWeek.Friday),
            Output = 1,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_027 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Tuesday, DayOfWeek.Tuesday),
            Output = 0,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_028 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Tuesday, DayOfWeek.Sunday),
            Output = 2,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_029 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Tuesday, DayOfWeek.Saturday),
            Output = 3,
        };

        #endregion

        #region Prior-Exclusive

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_031 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Sunday, DayOfWeek.Sunday),
            Output = 7,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_032 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Sunday, DayOfWeek.Monday),
            Output = 6,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_033 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Sunday, DayOfWeek.Saturday),
            Output = 1,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_034 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Saturday, DayOfWeek.Saturday),
            Output = 7,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_035 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Saturday, DayOfWeek.Sunday),
            Output = 6,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_036 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Saturday, DayOfWeek.Friday),
            Output = 1,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_037 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Tuesday, DayOfWeek.Tuesday),
            Output = 7,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_038 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Tuesday, DayOfWeek.Sunday),
            Output = 2,
        };

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive"/>
        /// </summary>
        public ExpectationPair<(DayOfWeek, DayOfWeek), int> N_039 => new ExpectationPair<(DayOfWeek, DayOfWeek), int>
        {
            Input = (DayOfWeek.Tuesday, DayOfWeek.Saturday),
            Output = 3,
        };

        #endregion
    }
}
