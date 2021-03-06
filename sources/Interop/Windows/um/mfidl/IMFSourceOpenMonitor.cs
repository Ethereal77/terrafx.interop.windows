// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("059054B3-027C-494C-A27D-9113291CF87F")]
    [NativeTypeName("struct IMFSourceOpenMonitor : IUnknown")]
    public unsafe partial struct IMFSourceOpenMonitor
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSourceOpenMonitor*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceOpenMonitor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSourceOpenMonitor*, uint>)(lpVtbl[1]))((IMFSourceOpenMonitor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSourceOpenMonitor*, uint>)(lpVtbl[2]))((IMFSourceOpenMonitor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnSourceEvent([NativeTypeName("IMFMediaEvent *")] IMFMediaEvent* pEvent)
        {
            return ((delegate* stdcall<IMFSourceOpenMonitor*, IMFMediaEvent*, int>)(lpVtbl[3]))((IMFSourceOpenMonitor*)Unsafe.AsPointer(ref this), pEvent);
        }
    }
}
