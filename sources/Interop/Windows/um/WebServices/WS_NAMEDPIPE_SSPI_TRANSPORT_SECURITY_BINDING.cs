// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WS_NAMEDPIPE_SSPI_TRANSPORT_SECURITY_BINDING
    {
        public WS_SECURITY_BINDING binding;

        [NativeTypeName("WS_WINDOWS_INTEGRATED_AUTH_CREDENTIAL *")]
        public WS_WINDOWS_INTEGRATED_AUTH_CREDENTIAL* clientCredential;
    }
}
