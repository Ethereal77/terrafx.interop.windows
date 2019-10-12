// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d11.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct D3D11_AUTHENTICATED_PROTECTION_FLAGS
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at um/d3d11.h:10816:5)")]
        public _Flags_e__Struct Flags;

        [FieldOffset(0)]
        [NativeTypeName("UINT")]
        public uint Value;

        public partial struct _Flags_e__Struct
        {
            internal uint _bitfield;

            [NativeTypeName("UINT")]
            public uint ProtectionEnabled
            {
                get
                {
                    return _bitfield & 0x1;
                }

                set
                {
                    _bitfield = (_bitfield & ~0x1u) | (value & 0x1);
                }
            }

            [NativeTypeName("UINT")]
            public uint OverlayOrFullscreenRequired
            {
                get
                {
                    return (_bitfield >> 1) & 0x1;
                }

                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1) << 1);
                }
            }

            [NativeTypeName("UINT")]
            public uint Reserved
            {
                get
                {
                    return (_bitfield >> 2) & 0x3FFFFFFF;
                }

                set
                {
                    _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFF) << 2);
                }
            }
        }
    }
}
