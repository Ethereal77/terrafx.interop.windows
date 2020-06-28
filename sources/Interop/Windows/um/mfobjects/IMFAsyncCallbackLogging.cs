// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C7A4DCA1-F5F0-47B6-B92B-BF0106D25791")]
    public unsafe partial struct IMFAsyncCallbackLogging
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFAsyncCallbackLogging*, Guid*, void**, int>)(lpVtbl[0]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFAsyncCallbackLogging*, uint>)(lpVtbl[1]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFAsyncCallbackLogging*, uint>)(lpVtbl[2]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParameters([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD *")] uint* pdwQueue)
        {
            return ((delegate* stdcall<IMFAsyncCallbackLogging*, uint*, uint*, int>)(lpVtbl[3]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this), pdwFlags, pdwQueue);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pAsyncResult)
        {
            return ((delegate* stdcall<IMFAsyncCallbackLogging*, IMFAsyncResult*, int>)(lpVtbl[4]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this), pAsyncResult);
        }

        [return: NativeTypeName("void *")]
        public void* GetObjectPointer()
        {
            return ((delegate* stdcall<IMFAsyncCallbackLogging*, void*>)(lpVtbl[5]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("DWORD")]
        public uint GetObjectTag()
        {
            return ((delegate* stdcall<IMFAsyncCallbackLogging*, uint>)(lpVtbl[6]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this));
        }
    }
}