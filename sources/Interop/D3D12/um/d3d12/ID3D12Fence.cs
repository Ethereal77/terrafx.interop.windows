// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0A753DCF-C4D8-4B91-ADF6-BE5A60D95A76")]
    public unsafe struct ID3D12Fence
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12Fence* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12Fence* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12Fence* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D12Fence* This, [NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint* pDataSize, void* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D12Fence* This, [NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, void* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D12Fence* This, [NativeTypeName("REFGUID")] Guid* guid, IUnknown* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(ID3D12Fence* This, [NativeTypeName("LPCWSTR")] ushort* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(ID3D12Fence* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvDevice = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetCompletedValue(ID3D12Fence* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetEventOnCompletion(ID3D12Fence* This, [NativeTypeName("UINT64")] ulong Value, [NativeTypeName("HANDLE")] IntPtr hEvent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Signal(ID3D12Fence* This, [NativeTypeName("UINT64")] ulong Value);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID3D12Fence* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12Fence* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12Fence* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint* pDataSize, void* pData = null)
        {
            fixed (ID3D12Fence* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(This, guid, pDataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, void* pData = null)
        {
            fixed (ID3D12Fence* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(This, guid, DataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("REFGUID")] Guid* guid, IUnknown* pData = null)
        {
            fixed (ID3D12Fence* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(This, guid, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            fixed (ID3D12Fence* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)(This, Name);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("REFIID")] Guid* riid, void** ppvDevice = null)
        {
            fixed (ID3D12Fence* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)(This, riid, ppvDevice);
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetCompletedValue()
        {
            fixed (ID3D12Fence* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCompletedValue>(lpVtbl->GetCompletedValue)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEventOnCompletion([NativeTypeName("UINT64")] ulong Value, [NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            fixed (ID3D12Fence* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetEventOnCompletion>(lpVtbl->SetEventOnCompletion)(This, Value, hEvent);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Signal([NativeTypeName("UINT64")] ulong Value)
        {
            fixed (ID3D12Fence* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Signal>(lpVtbl->Signal)(This, Value);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetPrivateData;

            public IntPtr SetPrivateData;

            public IntPtr SetPrivateDataInterface;

            public IntPtr SetName;

            public IntPtr GetDevice;

            public IntPtr GetCompletedValue;

            public IntPtr SetEventOnCompletion;

            public IntPtr Signal;
        }
    }
}