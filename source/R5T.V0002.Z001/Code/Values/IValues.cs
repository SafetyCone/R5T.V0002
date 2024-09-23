using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.V0002.Z001
{
    [ValuesMarker]
    public partial interface IValues : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0066.IValues _L0066 => L0066.Values.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="L0066.IValues.False"/>
        public bool False => _L0066.False;

        /// <inheritdoc cref="L0066.IValues.True"/>
        public bool True => _L0066.True;
    }
}
