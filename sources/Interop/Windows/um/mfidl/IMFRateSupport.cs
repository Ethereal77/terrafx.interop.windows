// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0A9CCDBC-D797-4563-9667-94EC5D79292D")]
    [NativeTypeName("struct IMFRateSupport : IUnknown")]
    public unsafe partial struct IMFRateSupport
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFRateSupport*, Guid*, void**, int>)(lpVtbl[0]))((IMFRateSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFRateSupport*, uint>)(lpVtbl[1]))((IMFRateSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFRateSupport*, uint>)(lpVtbl[2]))((IMFRateSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSlowestRate(MFRATE_DIRECTION eDirection, [NativeTypeName("BOOL")] int fThin, [NativeTypeName("float *")] float* pflRate)
        {
            return ((delegate* stdcall<IMFRateSupport*, MFRATE_DIRECTION, int, float*, int>)(lpVtbl[3]))((IMFRateSupport*)Unsafe.AsPointer(ref this), eDirection, fThin, pflRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFastestRate(MFRATE_DIRECTION eDirection, [NativeTypeName("BOOL")] int fThin, [NativeTypeName("float *")] float* pflRate)
        {
            return ((delegate* stdcall<IMFRateSupport*, MFRATE_DIRECTION, int, float*, int>)(lpVtbl[4]))((IMFRateSupport*)Unsafe.AsPointer(ref this), eDirection, fThin, pflRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsRateSupported([NativeTypeName("BOOL")] int fThin, float flRate, [NativeTypeName("float *")] float* pflNearestSupportedRate)
        {
            return ((delegate* stdcall<IMFRateSupport*, int, float, float*, int>)(lpVtbl[5]))((IMFRateSupport*)Unsafe.AsPointer(ref this), fThin, flRate, pflNearestSupportedRate);
        }
    }
}
