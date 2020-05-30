// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Numerics;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct X3DAUDIO_EMITTER
    {
        [NativeTypeName("X3DAUDIO_CONE *")]
        public X3DAUDIO_CONE* pCone;

        [NativeTypeName("X3DAUDIO_VECTOR")]
        public Vector3 OrientFront;

        [NativeTypeName("X3DAUDIO_VECTOR")]
        public Vector3 OrientTop;

        [NativeTypeName("X3DAUDIO_VECTOR")]
        public Vector3 Position;

        [NativeTypeName("X3DAUDIO_VECTOR")]
        public Vector3 Velocity;

        [NativeTypeName("FLOAT32")]
        public float InnerRadius;

        [NativeTypeName("FLOAT32")]
        public float InnerRadiusAngle;

        [NativeTypeName("UINT32")]
        public uint ChannelCount;

        [NativeTypeName("FLOAT32")]
        public float ChannelRadius;

        [NativeTypeName("FLOAT32 *")]
        public float* pChannelAzimuths;

        [NativeTypeName("X3DAUDIO_DISTANCE_CURVE *")]
        public X3DAUDIO_DISTANCE_CURVE* pVolumeCurve;

        [NativeTypeName("X3DAUDIO_DISTANCE_CURVE *")]
        public X3DAUDIO_DISTANCE_CURVE* pLFECurve;

        [NativeTypeName("X3DAUDIO_DISTANCE_CURVE *")]
        public X3DAUDIO_DISTANCE_CURVE* pLPFDirectCurve;

        [NativeTypeName("X3DAUDIO_DISTANCE_CURVE *")]
        public X3DAUDIO_DISTANCE_CURVE* pLPFReverbCurve;

        [NativeTypeName("X3DAUDIO_DISTANCE_CURVE *")]
        public X3DAUDIO_DISTANCE_CURVE* pReverbCurve;

        [NativeTypeName("FLOAT32")]
        public float CurveDistanceScaler;

        [NativeTypeName("FLOAT32")]
        public float DopplerScaler;
    }
}
