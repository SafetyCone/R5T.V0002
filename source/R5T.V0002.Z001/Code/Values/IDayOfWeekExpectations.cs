using System;
using System.Collections.Generic;

using R5T.L0087.T000;
using R5T.L0090.T000;
using R5T.T0131;
using R5T.T0143;


namespace R5T.V0002.Z001
{
    [ValuesMarker]
    public partial interface IDayOfWeekExpectations : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IDayOfWeekExpectations _Raw => Raw.DayOfWeekExpectations.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IDayOfWeekExpectations.N_001"/>
        IExpectation<DayOfWeek[], Dictionary<DayOfWeek, int>> Get_DayOfWeekNumber => _Raw.N_001;
    }
}
