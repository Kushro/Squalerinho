﻿namespace Squalr.Engine.Common
{
    using System.Runtime.Serialization;

    /// <summary>
    /// A class representing an emulator target.
    /// </summary>
    [DataContract]
    public enum EmulatorType
    {
        Auto,
        None,
        Dolphin,
    }
    //// End class
}
//// End namespace