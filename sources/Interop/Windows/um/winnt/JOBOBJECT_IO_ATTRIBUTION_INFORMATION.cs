// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct JOBOBJECT_IO_ATTRIBUTION_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint ControlFlags;

        public JOBOBJECT_IO_ATTRIBUTION_STATS ReadStats;

        public JOBOBJECT_IO_ATTRIBUTION_STATS WriteStats;
    }
}
