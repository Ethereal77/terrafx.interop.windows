// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("14885CC9-BAB0-4F90-B6ED-5C366A2CD03D")]
    [NativeTypeName("struct IDWriteNumberSubstitution : IUnknown")]
    public unsafe partial struct IDWriteNumberSubstitution
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteNumberSubstitution*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteNumberSubstitution*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteNumberSubstitution*, uint>)(lpVtbl[1]))((IDWriteNumberSubstitution*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteNumberSubstitution*, uint>)(lpVtbl[2]))((IDWriteNumberSubstitution*)Unsafe.AsPointer(ref this));
        }
    }
}
