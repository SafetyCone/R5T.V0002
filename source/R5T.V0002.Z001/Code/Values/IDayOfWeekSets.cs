using System;

using R5T.T0131;


namespace R5T.V0002.Z001
{
    [ValuesMarker]
    public partial interface IDayOfWeekSets : IValuesMarker
    {
        public DayOfWeek[] All_InOrder => new[]
        {
            DayOfWeek.Sunday,
            DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
            DayOfWeek.Friday,
            DayOfWeek.Saturday
        };
    }
}
