using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;


namespace R5T.V0002
{
    [FunctionalityMarker]
    public partial interface ITestMethods : IFunctionalityMarker
    {
        public void Verify_DayOfWeekNumbers_N001<TTestArticle>(TTestArticle testArticle)
            where TTestArticle : IDayOfWeekOperatorTestArticle
        {
            var expectation = Instances.DayOfWeekExpectations._Raw.N_001;

            Dictionary<DayOfWeek, int> Internal(DayOfWeek[] daysOfWeek)
            {
                var output = daysOfWeek
                    .ToDictionary(
                        x => x,
                        testArticle.Get_DayOfWeekNumber);

                return output;
            }

            Instances.TestOperator.Test_Function(
                Internal,
                expectation);
        }

        public void Verify_DayOfWeekNumbers_N002<TTestArticle>(TTestArticle testArticle)
            where TTestArticle : IDayOfWeekOperatorTestArticle
        {
            var expectation = Instances.DayOfWeekExpectations._Raw.N_002;

            int[] Internal(DayOfWeek[] daysOfWeek)
            {
                var output = daysOfWeek
                    .Select(testArticle.Get_DayOfWeekNumber)
                    .Now();

                return output;
            }

            Instances.TestOperator.Test_Function(
                Internal,
                expectation);
        }
    }
}
