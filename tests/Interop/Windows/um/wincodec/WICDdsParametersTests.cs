// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="WICDdsParameters" /> struct.</summary>
    public static unsafe class WICDdsParametersTests
    {
        /// <summary>Validates that the <see cref="WICDdsParameters" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<WICDdsParameters>(), Is.EqualTo(sizeof(WICDdsParameters)));
        }

        /// <summary>Validates that the <see cref="WICDdsParameters" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(WICDdsParameters).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="WICDdsParameters" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(WICDdsParameters), Is.EqualTo(32));
        }
    }
}
