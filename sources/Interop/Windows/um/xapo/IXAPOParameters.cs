// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("26D95C66-80F2-499A-AD54-5AE7F01C6D98")]
    public unsafe partial struct IXAPOParameters
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IXAPOParameters* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IXAPOParameters* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IXAPOParameters* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetParameters(IXAPOParameters* pThis, [NativeTypeName("const void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParameterByteSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetParameters(IXAPOParameters* pThis, [NativeTypeName("void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParameterByteSize);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IXAPOParameters*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IXAPOParameters*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IXAPOParameters*)Unsafe.AsPointer(ref this));
        }

        public void SetParameters([NativeTypeName("const void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParameterByteSize)
        {
            Marshal.GetDelegateForFunctionPointer<_SetParameters>(lpVtbl->SetParameters)((IXAPOParameters*)Unsafe.AsPointer(ref this), pParameters, ParameterByteSize);
        }

        public void GetParameters([NativeTypeName("void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParameterByteSize)
        {
            Marshal.GetDelegateForFunctionPointer<_GetParameters>(lpVtbl->GetParameters)((IXAPOParameters*)Unsafe.AsPointer(ref this), pParameters, ParameterByteSize);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (const void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetParameters;

            [NativeTypeName("void (void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetParameters;
        }
    }
}