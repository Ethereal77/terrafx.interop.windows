// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WS_ASYNC_STATE
    {
        [NativeTypeName("void *")]
        public void* internal0;

        [NativeTypeName("void *")]
        public void* internal1;

        [NativeTypeName("void *")]
        public void* internal2;

        [NativeTypeName("void *")]
        public void* internal3;

        [NativeTypeName("void *")]
        public void* internal4;
    }
}
