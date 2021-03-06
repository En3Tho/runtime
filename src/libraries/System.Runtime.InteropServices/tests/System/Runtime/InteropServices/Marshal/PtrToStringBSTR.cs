// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace System.Runtime.InteropServices.Tests
{
    public class PtrToStringBSTRTests
    {
        [Fact]
        public void PtrToStringBSTR_ZeroPointer_ThrowsArgumentNullException()
        {
            AssertExtensions.Throws<ArgumentNullException>("ptr", () => Marshal.PtrToStringBSTR(IntPtr.Zero));
        }
    }
}
