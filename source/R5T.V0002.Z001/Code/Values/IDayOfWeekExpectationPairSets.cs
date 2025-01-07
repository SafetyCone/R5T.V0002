using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.V0002.Z001
{
    [ValuesMarker]
    public partial interface IDayOfWeekExpectationPairSets : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IDayOfWeekExpectationPairSets _Raw => Raw.DayOfWeekExpectationPairSets.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
