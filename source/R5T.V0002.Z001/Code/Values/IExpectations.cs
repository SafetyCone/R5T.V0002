using System;

using R5T.L0087.T000;
using R5T.T0131;


namespace R5T.V0002.Z001
{
    /// <summary>
    /// Path operation expectation values.
    /// </summary>
    [ValuesMarker]
    public partial interface IExpectations : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Raw.IExpectations _Raw => Raw.Expectations.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IExpectations.N003"/>
        public IExpectation<string[], string> Combine_ToFilePath => _Raw.N003;

        /// <inheritdoc cref="Raw.IExpectations.N001"/>
        public IExpectation<string, bool> Is_WindowsPath_True => _Raw.N001;

        /// <inheritdoc cref="Raw.IExpectations.N002"/>
        public IExpectation<string, bool> Is_WindowsPath_ShouldFail => _Raw.N002;
    }
}
