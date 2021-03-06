// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_RECIPIENT_ENCODE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwRecipientChoice;

        [NativeTypeName("_CMSG_RECIPIENT_ENCODE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:7013:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref CMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO* pKeyTrans
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pKeyTrans;
                }
            }
        }

        public ref CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO* pKeyAgree
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pKeyAgree;
                }
            }
        }

        public ref CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO* pMailList
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pMailList;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("PCMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO")]
            public CMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO* pKeyTrans;

            [FieldOffset(0)]
            [NativeTypeName("PCMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO")]
            public CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO* pKeyAgree;

            [FieldOffset(0)]
            [NativeTypeName("PCMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO")]
            public CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO* pMailList;
        }
    }
}
