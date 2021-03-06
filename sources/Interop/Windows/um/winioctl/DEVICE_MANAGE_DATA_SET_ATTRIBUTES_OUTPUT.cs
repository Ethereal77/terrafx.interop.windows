// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT
    {
        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DEVICE_DSM_ACTION")]
        public uint Action;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint OperationStatus;

        [NativeTypeName("DWORD")]
        public uint ExtendedError;

        [NativeTypeName("DWORD")]
        public uint TargetDetailedError;

        [NativeTypeName("DWORD")]
        public uint ReservedStatus;

        [NativeTypeName("DWORD")]
        public uint OutputBlockOffset;

        [NativeTypeName("DWORD")]
        public uint OutputBlockLength;
    }
}
