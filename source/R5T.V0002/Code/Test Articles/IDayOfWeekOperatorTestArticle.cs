using System;

using R5T.T0243;


namespace R5T.V0002
{
    [TestArticleMarker]
    public partial interface IDayOfWeekOperatorTestArticle : ITestArticleMarker
    {
        int Get_DayOfWeekNumber(DayOfWeek dayOfWeek);

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive" path="descendant::summary"/>
        /// </summary>
        int Get_DaysToNextDayOfWeek_Inclusive(
            DayOfWeek from,
            DayOfWeek to);

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive" path="descendant::summary"/>
        /// </summary>
        int Get_DaysToNextDayOfWeek_Exclusive(
            DayOfWeek from,
            DayOfWeek to);

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Inclusive" path="descendant::summary"/>
        /// </summary>
        int Get_DaysToPriorDayOfWeek_Inclusive(
            DayOfWeek from,
            DayOfWeek to);

        /// <summary>
        /// <inheritdoc cref="L0066.Documentation.DayOfWeek_Exclusive" path="descendant::summary"/>
        /// </summary>
        int Get_DaysToPriorDayOfWeek_Exclusive(
            DayOfWeek from,
            DayOfWeek to);
    }
}
