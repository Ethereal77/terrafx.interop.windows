// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/synchapi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public unsafe delegate void PTIMERAPCROUTINE([NativeTypeName("LPVOID")] void* lpArgToCompletionRoutine, [NativeTypeName("DWORD")] uint dwTimerLowValue, [NativeTypeName("DWORD")] uint dwTimerHighValue);
}