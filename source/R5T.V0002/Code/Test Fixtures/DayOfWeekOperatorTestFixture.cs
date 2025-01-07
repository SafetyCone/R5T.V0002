using System;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0242;
using R5T.T0243;


namespace R5T.V0002
{
    [TestFixtureMarker]
    public abstract class DayOfWeekOperatorTestFixture<TTestArticle> : TestFixtureBase<TTestArticle>
        where TTestArticle : IDayOfWeekOperatorTestArticle
    {
        /// <summary>
        /// Verify that the days of the week run from Sunday: 0, to Saturday: 6.
        /// </summary>
        [TestMethod]
        public void Verify_DayOfWeekNumbers()
            => Instances.TestMethods.Verify_DayOfWeekNumbers_N002(this.TestArticle);

        /// <summary>
        /// Verify the method to get days to the next day of the week.
        /// </summary>
        [TestMethod]
        public void Verify_Get_DaysToNextDayOfWeek_Inclusive()
        {
            var expectation = Instances.DayOfWeekExpectations._Raw.N_003;

            int[] Internal((DayOfWeek, DayOfWeek)[] daysOfWeekPairs)
            {
                var output = daysOfWeekPairs
                    .Select(pair => this.TestArticle.Get_DaysToNextDayOfWeek_Inclusive(pair.Item1, pair.Item2))
                    .Now();

                return output;
            }

            Instances.TestOperator.Test_Function(
                Internal,
                expectation);
        }

        /// <summary>
        /// Verify the method to get days to the next day of the week.
        /// </summary>
        [TestMethod]
        public void Verify_Get_DaysToNextDayOfWeek_Exclusive()
        {
            var expectation = Instances.DayOfWeekExpectations._Raw.N_004;

            int[] Internal((DayOfWeek, DayOfWeek)[] daysOfWeekPairs)
            {
                var output = daysOfWeekPairs
                    .Select(pair => this.TestArticle.Get_DaysToNextDayOfWeek_Exclusive(pair.Item1, pair.Item2))
                    .Now();

                return output;
            }

            Instances.TestOperator.Test_Function(
                Internal,
                expectation);
        }

        /// <summary>
        /// Verify the method to get days to the next day of the week.
        /// </summary>
        [TestMethod]
        public void Verify_Get_DaysToPriorDayOfWeek_Inclusive()
        {
            var expectation = Instances.DayOfWeekExpectations._Raw.N_005;

            int[] Internal((DayOfWeek, DayOfWeek)[] daysOfWeekPairs)
            {
                var output = daysOfWeekPairs
                    .Select(pair => this.TestArticle.Get_DaysToPriorDayOfWeek_Inclusive(pair.Item1, pair.Item2))
                    .Now();

                return output;
            }

            Instances.TestOperator.Test_Function(
                Internal,
                expectation);
        }

        /// <summary>
        /// Verify the method to get days to the next day of the week.
        /// </summary>
        [TestMethod]
        public void Verify_Get_DaysToProrDayOfWeek_Exclusive()
        {
            var expectation = Instances.DayOfWeekExpectations._Raw.N_006;

            int[] Internal((DayOfWeek, DayOfWeek)[] daysOfWeekPairs)
            {
                var output = daysOfWeekPairs
                    .Select(pair => this.TestArticle.Get_DaysToPriorDayOfWeek_Exclusive(pair.Item1, pair.Item2))
                    .Now();

                return output;
            }

            Instances.TestOperator.Test_Function(
                Internal,
                expectation);
        }
    }
}
