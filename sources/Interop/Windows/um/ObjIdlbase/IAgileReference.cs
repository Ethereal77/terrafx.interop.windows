// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C03F6A43-65A4-9818-987E-E0B810D2A6F2")]
    [NativeTypeName("struct IAgileReference : IUnknown")]
    public unsafe partial struct IAgileReference
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAgileReference*, Guid*, void**, int>)(lpVtbl[0]))((IAgileReference*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAgileReference*, uint>)(lpVtbl[1]))((IAgileReference*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAgileReference*, uint>)(lpVtbl[2]))((IAgileReference*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resolve([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObjectReference)
        {
            return ((delegate* stdcall<IAgileReference*, Guid*, void**, int>)(lpVtbl[3]))((IAgileReference*)Unsafe.AsPointer(ref this), riid, ppvObjectReference);
        }
    }
}
