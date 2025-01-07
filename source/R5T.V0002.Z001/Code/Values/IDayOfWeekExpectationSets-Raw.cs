using System;

using R5T.L0087.T000;
using R5T.T0131;


namespace R5T.V0002.Z001.Raw
{
    [ValuesMarker]
    public partial interface IDayOfWeekExpectationSets : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private static IDayOfWeekExpectations _DayOfWeekExpectations => DayOfWeekExpectations.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
