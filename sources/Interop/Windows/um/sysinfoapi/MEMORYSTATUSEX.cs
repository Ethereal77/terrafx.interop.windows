// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sysinfoapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MEMORYSTATUSEX
    {
        [NativeTypeName("DWORD")]
        public uint dwLength;

        [NativeTypeName("DWORD")]
        public uint dwMemoryLoad;

        [NativeTypeName("DWORDLONG")]
        public ulong ullTotalPhys;

        [NativeTypeName("DWORDLONG")]
        public ulong ullAvailPhys;

        [NativeTypeName("DWORDLONG")]
        public ulong ullTotalPageFile;

        [NativeTypeName("DWORDLONG")]
        public ulong ullAvailPageFile;

        [NativeTypeName("DWORDLONG")]
        public ulong ullTotalVirtual;

        [NativeTypeName("DWORDLONG")]
        public ulong ullAvailVirtual;

        [NativeTypeName("DWORDLONG")]
        public ulong ullAvailExtendedVirtual;
    }
}
