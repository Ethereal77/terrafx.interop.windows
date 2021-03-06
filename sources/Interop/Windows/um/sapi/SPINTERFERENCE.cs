// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SPINTERFERENCE
    {
        SPINTERFERENCE_NONE = 0,
        SPINTERFERENCE_NOISE = (SPINTERFERENCE_NONE + 1),
        SPINTERFERENCE_NOSIGNAL = (SPINTERFERENCE_NOISE + 1),
        SPINTERFERENCE_TOOLOUD = (SPINTERFERENCE_NOSIGNAL + 1),
        SPINTERFERENCE_TOOQUIET = (SPINTERFERENCE_TOOLOUD + 1),
        SPINTERFERENCE_TOOFAST = (SPINTERFERENCE_TOOQUIET + 1),
        SPINTERFERENCE_TOOSLOW = (SPINTERFERENCE_TOOFAST + 1),
        SPINTERFERENCE_LATENCY_WARNING = (SPINTERFERENCE_TOOSLOW + 1),
        SPINTERFERENCE_LATENCY_TRUNCATE_BEGIN = (SPINTERFERENCE_LATENCY_WARNING + 1),
        SPINTERFERENCE_LATENCY_TRUNCATE_END = (SPINTERFERENCE_LATENCY_TRUNCATE_BEGIN + 1),
    }
}
