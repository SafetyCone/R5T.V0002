using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.V0002.Z001
{
    [ValuesMarker]
    public partial interface IDayOfWeekExpectationSets : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IDayOfWeekExpectationSets _Raw => Raw.DayOfWeekExpectationSets.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
