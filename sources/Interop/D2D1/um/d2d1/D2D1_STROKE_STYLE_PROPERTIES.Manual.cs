// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_STROKE_STYLE_PROPERTIES
    {
        public static readonly D2D1_STROKE_STYLE_PROPERTIES DEFAULT = new D2D1_STROKE_STYLE_PROPERTIES(D2D1_CAP_STYLE.D2D1_CAP_STYLE_FLAT, D2D1_CAP_STYLE.D2D1_CAP_STYLE_FLAT, D2D1_CAP_STYLE.D2D1_CAP_STYLE_FLAT, D2D1_LINE_JOIN.D2D1_LINE_JOIN_MITER, 10.0f, D2D1_DASH_STYLE.D2D1_DASH_STYLE_SOLID, 0.0f);

        public D2D1_STROKE_STYLE_PROPERTIES(D2D1_CAP_STYLE startCap, D2D1_CAP_STYLE endCap, D2D1_CAP_STYLE dashCap, D2D1_LINE_JOIN lineJoin, float miterLimit, D2D1_DASH_STYLE dashStyle, float dashOffset)
        {
            this.startCap = startCap;
            this.endCap = endCap;
            this.dashCap = dashCap;
            this.lineJoin = lineJoin;
            this.miterLimit = miterLimit;
            this.dashStyle = dashStyle;
            this.dashOffset = dashOffset;
        }
    }
}
