namespace LDtk;

using System;

/// <summary>
/// Generic LDtk Exception
/// </summary>
public class LDtkException : Exception
{
    /// <summary>
    /// Generic LDtk Exception
    /// </summary>
    private LDtkException() { }
    /// <summary>
    /// Generic LDtk Exception
    /// </summary>
    public LDtkException(string message) : base(message) { }
}
