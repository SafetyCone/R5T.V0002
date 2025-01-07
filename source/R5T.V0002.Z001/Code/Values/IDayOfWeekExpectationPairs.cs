using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.V0002.Z001
{
    [ValuesMarker]
    public partial interface IDayOfWeekExpectationPairs : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IDayOfWeekExpectationPairs _Raw => Raw.DayOfWeekExpectationPairs.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
