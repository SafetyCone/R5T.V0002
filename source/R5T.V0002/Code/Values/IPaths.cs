using System;

using R5T.T0131;


namespace R5T.V0002
{
    [ValuesMarker]
    public partial interface IPaths : IValuesMarker
    {
        /// <summary>
        /// <para><value>C:\Temp</value></para>
        /// </summary>
        public string N001 => @"C:\Temp";
    }
}
