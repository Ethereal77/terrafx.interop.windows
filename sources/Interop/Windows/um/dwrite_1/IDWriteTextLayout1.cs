// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9064D822-80A7-465C-A986-DF65F78B8FEB")]
    public unsafe partial struct IDWriteTextLayout1
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteTextLayout1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteTextLayout1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteTextLayout1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTextAlignment(IDWriteTextLayout1* pThis, DWRITE_TEXT_ALIGNMENT textAlignment);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetParagraphAlignment(IDWriteTextLayout1* pThis, DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetWordWrapping(IDWriteTextLayout1* pThis, DWRITE_WORD_WRAPPING wordWrapping);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetReadingDirection(IDWriteTextLayout1* pThis, DWRITE_READING_DIRECTION readingDirection);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFlowDirection(IDWriteTextLayout1* pThis, DWRITE_FLOW_DIRECTION flowDirection);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetIncrementalTabStop(IDWriteTextLayout1* pThis, [NativeTypeName("FLOAT")] float incrementalTabStop);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTrimming(IDWriteTextLayout1* pThis, [NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* trimmingSign);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLineSpacing(IDWriteTextLayout1* pThis, DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate DWRITE_TEXT_ALIGNMENT _GetTextAlignment(IDWriteTextLayout1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate DWRITE_PARAGRAPH_ALIGNMENT _GetParagraphAlignment(IDWriteTextLayout1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate DWRITE_WORD_WRAPPING _GetWordWrapping(IDWriteTextLayout1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate DWRITE_READING_DIRECTION _GetReadingDirection(IDWriteTextLayout1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate DWRITE_FLOW_DIRECTION _GetFlowDirection(IDWriteTextLayout1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetIncrementalTabStop(IDWriteTextLayout1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTrimming(IDWriteTextLayout1* pThis, [NativeTypeName("DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** trimmingSign);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLineSpacing(IDWriteTextLayout1* pThis, [NativeTypeName("DWRITE_LINE_SPACING_METHOD *")] DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT *")] float* lineSpacing, [NativeTypeName("FLOAT *")] float* baseline);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontCollection(IDWriteTextLayout1* pThis, [NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetFontFamilyNameLength(IDWriteTextLayout1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFamilyName(IDWriteTextLayout1* pThis, [NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate DWRITE_FONT_WEIGHT _GetFontWeight(IDWriteTextLayout1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate DWRITE_FONT_STYLE _GetFontStyle(IDWriteTextLayout1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate DWRITE_FONT_STRETCH _GetFontStretch(IDWriteTextLayout1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetFontSize(IDWriteTextLayout1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetLocaleNameLength(IDWriteTextLayout1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleName(IDWriteTextLayout1* pThis, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMaxWidth(IDWriteTextLayout1* pThis, [NativeTypeName("FLOAT")] float maxWidth);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMaxHeight(IDWriteTextLayout1* pThis, [NativeTypeName("FLOAT")] float maxHeight);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFontCollection(IDWriteTextLayout1* pThis, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* fontCollection, DWRITE_TEXT_RANGE textRange);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFontFamilyName(IDWriteTextLayout1* pThis, [NativeTypeName("const WCHAR *")] ushort* fontFamilyName, DWRITE_TEXT_RANGE textRange);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFontWeight(IDWriteTextLayout1* pThis, DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFontStyle(IDWriteTextLayout1* pThis, DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFontStretch(IDWriteTextLayout1* pThis, DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFontSize(IDWriteTextLayout1* pThis, [NativeTypeName("FLOAT")] float fontSize, DWRITE_TEXT_RANGE textRange);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetUnderline(IDWriteTextLayout1* pThis, [NativeTypeName("BOOL")] int hasUnderline, DWRITE_TEXT_RANGE textRange);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetStrikethrough(IDWriteTextLayout1* pThis, [NativeTypeName("BOOL")] int hasStrikethrough, DWRITE_TEXT_RANGE textRange);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDrawingEffect(IDWriteTextLayout1* pThis, [NativeTypeName("IUnknown *")] IUnknown* drawingEffect, DWRITE_TEXT_RANGE textRange);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInlineObject(IDWriteTextLayout1* pThis, [NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* inlineObject, DWRITE_TEXT_RANGE textRange);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTypography(IDWriteTextLayout1* pThis, [NativeTypeName("IDWriteTypography *")] IDWriteTypography* typography, DWRITE_TEXT_RANGE textRange);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLocaleName(IDWriteTextLayout1* pThis, [NativeTypeName("const WCHAR *")] ushort* localeName, DWRITE_TEXT_RANGE textRange);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetMaxWidth(IDWriteTextLayout1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetMaxHeight(IDWriteTextLayout1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontCollection1(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFamilyNameLength1(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFamilyName1(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontWeight1(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("DWRITE_FONT_WEIGHT *")] DWRITE_FONT_WEIGHT* fontWeight, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontStyle1(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("DWRITE_FONT_STYLE *")] DWRITE_FONT_STYLE* fontStyle, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontStretch1(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("DWRITE_FONT_STRETCH *")] DWRITE_FONT_STRETCH* fontStretch, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontSize1(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("FLOAT *")] float* fontSize, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetUnderline(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL *")] int* hasUnderline, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetStrikethrough(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL *")] int* hasStrikethrough, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDrawingEffect(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("IUnknown **")] IUnknown** drawingEffect, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetInlineObject(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** inlineObject, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypography(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("IDWriteTypography **")] IDWriteTypography** typography, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleNameLength1(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleName1(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Draw(IDWriteTextLayout1* pThis, [NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("IDWriteTextRenderer *")] IDWriteTextRenderer* renderer, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLineMetrics(IDWriteTextLayout1* pThis, [NativeTypeName("DWRITE_LINE_METRICS *")] DWRITE_LINE_METRICS* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32 *")] uint* actualLineCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetrics(IDWriteTextLayout1* pThis, [NativeTypeName("DWRITE_TEXT_METRICS *")] DWRITE_TEXT_METRICS* textMetrics);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetOverhangMetrics(IDWriteTextLayout1* pThis, [NativeTypeName("DWRITE_OVERHANG_METRICS *")] DWRITE_OVERHANG_METRICS* overhangs);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClusterMetrics(IDWriteTextLayout1* pThis, [NativeTypeName("DWRITE_CLUSTER_METRICS *")] DWRITE_CLUSTER_METRICS* clusterMetrics, [NativeTypeName("UINT32")] uint maxClusterCount, [NativeTypeName("UINT32 *")] uint* actualClusterCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DetermineMinWidth(IDWriteTextLayout1* pThis, [NativeTypeName("FLOAT *")] float* minWidth);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _HitTestPoint(IDWriteTextLayout1* pThis, [NativeTypeName("FLOAT")] float pointX, [NativeTypeName("FLOAT")] float pointY, [NativeTypeName("BOOL *")] int* isTrailingHit, [NativeTypeName("BOOL *")] int* isInside, [NativeTypeName("DWRITE_HIT_TEST_METRICS *")] DWRITE_HIT_TEST_METRICS* hitTestMetrics);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _HitTestTextPosition(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("BOOL")] int isTrailingHit, [NativeTypeName("FLOAT *")] float* pointX, [NativeTypeName("FLOAT *")] float* pointY, [NativeTypeName("DWRITE_HIT_TEST_METRICS *")] DWRITE_HIT_TEST_METRICS* hitTestMetrics);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _HitTestTextRange(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, [NativeTypeName("DWRITE_HIT_TEST_METRICS *")] DWRITE_HIT_TEST_METRICS* hitTestMetrics, [NativeTypeName("UINT32")] uint maxHitTestMetricsCount, [NativeTypeName("UINT32 *")] uint* actualHitTestMetricsCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPairKerning(IDWriteTextLayout1* pThis, [NativeTypeName("BOOL")] int isPairKerningEnabled, DWRITE_TEXT_RANGE textRange);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPairKerning(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL *")] int* isPairKerningEnabled, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCharacterSpacing(IDWriteTextLayout1* pThis, [NativeTypeName("FLOAT")] float leadingSpacing, [NativeTypeName("FLOAT")] float trailingSpacing, [NativeTypeName("FLOAT")] float minimumAdvanceWidth, DWRITE_TEXT_RANGE textRange);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCharacterSpacing(IDWriteTextLayout1* pThis, [NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("FLOAT *")] float* leadingSpacing, [NativeTypeName("FLOAT *")] float* trailingSpacing, [NativeTypeName("FLOAT *")] float* minimumAdvanceWidth, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTextAlignment>(lpVtbl->SetTextAlignment)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), textAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetParagraphAlignment>(lpVtbl->SetParagraphAlignment)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), paragraphAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetWordWrapping>(lpVtbl->SetWordWrapping)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), wordWrapping);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetReadingDirection>(lpVtbl->SetReadingDirection)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), readingDirection);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFlowDirection>(lpVtbl->SetFlowDirection)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), flowDirection);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetIncrementalTabStop([NativeTypeName("FLOAT")] float incrementalTabStop)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetIncrementalTabStop>(lpVtbl->SetIncrementalTabStop)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), incrementalTabStop);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* trimmingSign)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTrimming>(lpVtbl->SetTrimming)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetLineSpacing>(lpVtbl->SetLineSpacing)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTextAlignment>(lpVtbl->GetTextAlignment)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetParagraphAlignment>(lpVtbl->GetParagraphAlignment)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWordWrapping>(lpVtbl->GetWordWrapping)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetReadingDirection>(lpVtbl->GetReadingDirection)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFlowDirection>(lpVtbl->GetFlowDirection)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetIncrementalTabStop()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetIncrementalTabStop>(lpVtbl->GetIncrementalTabStop)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrimming([NativeTypeName("DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** trimmingSign)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTrimming>(lpVtbl->GetTrimming)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing([NativeTypeName("DWRITE_LINE_SPACING_METHOD *")] DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT *")] float* lineSpacing, [NativeTypeName("FLOAT *")] float* baseline)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLineSpacing>(lpVtbl->GetLineSpacing)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection([NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontCollection>(lpVtbl->GetFontCollection)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), fontCollection);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyNameLength>(lpVtbl->GetFontFamilyNameLength)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyName>(lpVtbl->GetFontFamilyName)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
        }

        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontWeight>(lpVtbl->GetFontWeight)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STYLE GetFontStyle()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontStyle>(lpVtbl->GetFontStyle)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontStretch>(lpVtbl->GetFontStretch)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetFontSize()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontSize>(lpVtbl->GetFontSize)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocaleNameLength>(lpVtbl->GetLocaleNameLength)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocaleName>(lpVtbl->GetLocaleName)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), localeName, nameSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMaxWidth([NativeTypeName("FLOAT")] float maxWidth)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMaxWidth>(lpVtbl->SetMaxWidth)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), maxWidth);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMaxHeight([NativeTypeName("FLOAT")] float maxHeight)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMaxHeight>(lpVtbl->SetMaxHeight)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), maxHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontCollection([NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* fontCollection, DWRITE_TEXT_RANGE textRange)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFontCollection>(lpVtbl->SetFontCollection)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), fontCollection, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontFamilyName([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, DWRITE_TEXT_RANGE textRange)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFontFamilyName>(lpVtbl->SetFontFamilyName)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), fontFamilyName, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontWeight(DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFontWeight>(lpVtbl->SetFontWeight)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), fontWeight, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontStyle(DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFontStyle>(lpVtbl->SetFontStyle)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), fontStyle, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontStretch(DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFontStretch>(lpVtbl->SetFontStretch)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), fontStretch, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontSize([NativeTypeName("FLOAT")] float fontSize, DWRITE_TEXT_RANGE textRange)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFontSize>(lpVtbl->SetFontSize)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), fontSize, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUnderline([NativeTypeName("BOOL")] int hasUnderline, DWRITE_TEXT_RANGE textRange)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetUnderline>(lpVtbl->SetUnderline)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), hasUnderline, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStrikethrough([NativeTypeName("BOOL")] int hasStrikethrough, DWRITE_TEXT_RANGE textRange)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetStrikethrough>(lpVtbl->SetStrikethrough)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), hasStrikethrough, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDrawingEffect([NativeTypeName("IUnknown *")] IUnknown* drawingEffect, DWRITE_TEXT_RANGE textRange)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetDrawingEffect>(lpVtbl->SetDrawingEffect)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), drawingEffect, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInlineObject([NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* inlineObject, DWRITE_TEXT_RANGE textRange)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetInlineObject>(lpVtbl->SetInlineObject)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), inlineObject, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTypography([NativeTypeName("IDWriteTypography *")] IDWriteTypography* typography, DWRITE_TEXT_RANGE textRange)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTypography>(lpVtbl->SetTypography)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), typography, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLocaleName([NativeTypeName("const WCHAR *")] ushort* localeName, DWRITE_TEXT_RANGE textRange)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetLocaleName>(lpVtbl->SetLocaleName)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), localeName, textRange);
        }

        [return: NativeTypeName("FLOAT")]
        public float GetMaxWidth()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMaxWidth>(lpVtbl->GetMaxWidth)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetMaxHeight()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMaxHeight>(lpVtbl->GetMaxHeight)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontCollection1>(lpVtbl->GetFontCollection1)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), currentPosition, fontCollection, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyNameLength1>(lpVtbl->GetFontFamilyNameLength1)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyName1>(lpVtbl->GetFontFamilyName1)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), currentPosition, fontFamilyName, nameSize, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontWeight([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("DWRITE_FONT_WEIGHT *")] DWRITE_FONT_WEIGHT* fontWeight, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontWeight1>(lpVtbl->GetFontWeight1)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), currentPosition, fontWeight, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontStyle([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("DWRITE_FONT_STYLE *")] DWRITE_FONT_STYLE* fontStyle, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontStyle1>(lpVtbl->GetFontStyle1)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), currentPosition, fontStyle, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontStretch([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("DWRITE_FONT_STRETCH *")] DWRITE_FONT_STRETCH* fontStretch, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontStretch1>(lpVtbl->GetFontStretch1)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), currentPosition, fontStretch, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSize([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("FLOAT *")] float* fontSize, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontSize1>(lpVtbl->GetFontSize1)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), currentPosition, fontSize, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnderline([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL *")] int* hasUnderline, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetUnderline>(lpVtbl->GetUnderline)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), currentPosition, hasUnderline, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStrikethrough([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL *")] int* hasStrikethrough, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStrikethrough>(lpVtbl->GetStrikethrough)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), currentPosition, hasStrikethrough, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDrawingEffect([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("IUnknown **")] IUnknown** drawingEffect, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDrawingEffect>(lpVtbl->GetDrawingEffect)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), currentPosition, drawingEffect, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInlineObject([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** inlineObject, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetInlineObject>(lpVtbl->GetInlineObject)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), currentPosition, inlineObject, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypography([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("IDWriteTypography **")] IDWriteTypography** typography, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypography>(lpVtbl->GetTypography)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), currentPosition, typography, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocaleNameLength1>(lpVtbl->GetLocaleNameLength1)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocaleName1>(lpVtbl->GetLocaleName1)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), currentPosition, localeName, nameSize, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int Draw([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("IDWriteTextRenderer *")] IDWriteTextRenderer* renderer, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY)
        {
            return Marshal.GetDelegateForFunctionPointer<_Draw>(lpVtbl->Draw)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), clientDrawingContext, renderer, originX, originY);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineMetrics([NativeTypeName("DWRITE_LINE_METRICS *")] DWRITE_LINE_METRICS* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32 *")] uint* actualLineCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLineMetrics>(lpVtbl->GetLineMetrics)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), lineMetrics, maxLineCount, actualLineCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetrics([NativeTypeName("DWRITE_TEXT_METRICS *")] DWRITE_TEXT_METRICS* textMetrics)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMetrics>(lpVtbl->GetMetrics)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), textMetrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOverhangMetrics([NativeTypeName("DWRITE_OVERHANG_METRICS *")] DWRITE_OVERHANG_METRICS* overhangs)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOverhangMetrics>(lpVtbl->GetOverhangMetrics)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), overhangs);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClusterMetrics([NativeTypeName("DWRITE_CLUSTER_METRICS *")] DWRITE_CLUSTER_METRICS* clusterMetrics, [NativeTypeName("UINT32")] uint maxClusterCount, [NativeTypeName("UINT32 *")] uint* actualClusterCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetClusterMetrics>(lpVtbl->GetClusterMetrics)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), clusterMetrics, maxClusterCount, actualClusterCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int DetermineMinWidth([NativeTypeName("FLOAT *")] float* minWidth)
        {
            return Marshal.GetDelegateForFunctionPointer<_DetermineMinWidth>(lpVtbl->DetermineMinWidth)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), minWidth);
        }

        [return: NativeTypeName("HRESULT")]
        public int HitTestPoint([NativeTypeName("FLOAT")] float pointX, [NativeTypeName("FLOAT")] float pointY, [NativeTypeName("BOOL *")] int* isTrailingHit, [NativeTypeName("BOOL *")] int* isInside, [NativeTypeName("DWRITE_HIT_TEST_METRICS *")] DWRITE_HIT_TEST_METRICS* hitTestMetrics)
        {
            return Marshal.GetDelegateForFunctionPointer<_HitTestPoint>(lpVtbl->HitTestPoint)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int HitTestTextPosition([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("BOOL")] int isTrailingHit, [NativeTypeName("FLOAT *")] float* pointX, [NativeTypeName("FLOAT *")] float* pointY, [NativeTypeName("DWRITE_HIT_TEST_METRICS *")] DWRITE_HIT_TEST_METRICS* hitTestMetrics)
        {
            return Marshal.GetDelegateForFunctionPointer<_HitTestTextPosition>(lpVtbl->HitTestTextPosition)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int HitTestTextRange([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, [NativeTypeName("DWRITE_HIT_TEST_METRICS *")] DWRITE_HIT_TEST_METRICS* hitTestMetrics, [NativeTypeName("UINT32")] uint maxHitTestMetricsCount, [NativeTypeName("UINT32 *")] uint* actualHitTestMetricsCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_HitTestTextRange>(lpVtbl->HitTestTextRange)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPairKerning([NativeTypeName("BOOL")] int isPairKerningEnabled, DWRITE_TEXT_RANGE textRange)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPairKerning>(lpVtbl->SetPairKerning)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), isPairKerningEnabled, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPairKerning([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL *")] int* isPairKerningEnabled, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPairKerning>(lpVtbl->GetPairKerning)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), currentPosition, isPairKerningEnabled, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCharacterSpacing([NativeTypeName("FLOAT")] float leadingSpacing, [NativeTypeName("FLOAT")] float trailingSpacing, [NativeTypeName("FLOAT")] float minimumAdvanceWidth, DWRITE_TEXT_RANGE textRange)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCharacterSpacing>(lpVtbl->SetCharacterSpacing)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCharacterSpacing([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("FLOAT *")] float* leadingSpacing, [NativeTypeName("FLOAT *")] float* trailingSpacing, [NativeTypeName("FLOAT *")] float* minimumAdvanceWidth, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCharacterSpacing>(lpVtbl->GetCharacterSpacing)((IDWriteTextLayout1*)Unsafe.AsPointer(ref this), currentPosition, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWRITE_TEXT_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTextAlignment;

            [NativeTypeName("HRESULT (DWRITE_PARAGRAPH_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetParagraphAlignment;

            [NativeTypeName("HRESULT (DWRITE_WORD_WRAPPING) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetWordWrapping;

            [NativeTypeName("HRESULT (DWRITE_READING_DIRECTION) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetReadingDirection;

            [NativeTypeName("HRESULT (DWRITE_FLOW_DIRECTION) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetFlowDirection;

            [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetIncrementalTabStop;

            [NativeTypeName("HRESULT (const DWRITE_TRIMMING *, IDWriteInlineObject *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTrimming;

            [NativeTypeName("HRESULT (DWRITE_LINE_SPACING_METHOD, FLOAT, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetLineSpacing;

            [NativeTypeName("DWRITE_TEXT_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTextAlignment;

            [NativeTypeName("DWRITE_PARAGRAPH_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetParagraphAlignment;

            [NativeTypeName("DWRITE_WORD_WRAPPING () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetWordWrapping;

            [NativeTypeName("DWRITE_READING_DIRECTION () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetReadingDirection;

            [NativeTypeName("DWRITE_FLOW_DIRECTION () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFlowDirection;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetIncrementalTabStop;

            [NativeTypeName("HRESULT (DWRITE_TRIMMING *, IDWriteInlineObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTrimming;

            [NativeTypeName("HRESULT (DWRITE_LINE_SPACING_METHOD *, FLOAT *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLineSpacing;

            [NativeTypeName("HRESULT (IDWriteFontCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontCollection;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFamilyNameLength;

            [NativeTypeName("HRESULT (WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFamilyName;

            [NativeTypeName("DWRITE_FONT_WEIGHT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontWeight;

            [NativeTypeName("DWRITE_FONT_STYLE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontStyle;

            [NativeTypeName("DWRITE_FONT_STRETCH () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontStretch;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontSize;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLocaleNameLength;

            [NativeTypeName("HRESULT (WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLocaleName;

            [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetMaxWidth;

            [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetMaxHeight;

            [NativeTypeName("HRESULT (IDWriteFontCollection *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetFontCollection;

            [NativeTypeName("HRESULT (const WCHAR *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetFontFamilyName;

            [NativeTypeName("HRESULT (DWRITE_FONT_WEIGHT, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetFontWeight;

            [NativeTypeName("HRESULT (DWRITE_FONT_STYLE, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetFontStyle;

            [NativeTypeName("HRESULT (DWRITE_FONT_STRETCH, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetFontStretch;

            [NativeTypeName("HRESULT (FLOAT, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetFontSize;

            [NativeTypeName("HRESULT (BOOL, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetUnderline;

            [NativeTypeName("HRESULT (BOOL, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetStrikethrough;

            [NativeTypeName("HRESULT (IUnknown *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetDrawingEffect;

            [NativeTypeName("HRESULT (IDWriteInlineObject *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetInlineObject;

            [NativeTypeName("HRESULT (IDWriteTypography *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTypography;

            [NativeTypeName("HRESULT (const WCHAR *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetLocaleName;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMaxWidth;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMaxHeight;

            [NativeTypeName("HRESULT (UINT32, IDWriteFontCollection **, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontCollection1;

            [NativeTypeName("HRESULT (UINT32, UINT32 *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFamilyNameLength1;

            [NativeTypeName("HRESULT (UINT32, WCHAR *, UINT32, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFamilyName1;

            [NativeTypeName("HRESULT (UINT32, DWRITE_FONT_WEIGHT *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontWeight1;

            [NativeTypeName("HRESULT (UINT32, DWRITE_FONT_STYLE *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontStyle1;

            [NativeTypeName("HRESULT (UINT32, DWRITE_FONT_STRETCH *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontStretch1;

            [NativeTypeName("HRESULT (UINT32, FLOAT *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontSize1;

            [NativeTypeName("HRESULT (UINT32, BOOL *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetUnderline;

            [NativeTypeName("HRESULT (UINT32, BOOL *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetStrikethrough;

            [NativeTypeName("HRESULT (UINT32, IUnknown **, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDrawingEffect;

            [NativeTypeName("HRESULT (UINT32, IDWriteInlineObject **, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetInlineObject;

            [NativeTypeName("HRESULT (UINT32, IDWriteTypography **, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTypography;

            [NativeTypeName("HRESULT (UINT32, UINT32 *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLocaleNameLength1;

            [NativeTypeName("HRESULT (UINT32, WCHAR *, UINT32, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLocaleName1;

            [NativeTypeName("HRESULT (void *, IDWriteTextRenderer *, FLOAT, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Draw;

            [NativeTypeName("HRESULT (DWRITE_LINE_METRICS *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLineMetrics;

            [NativeTypeName("HRESULT (DWRITE_TEXT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMetrics;

            [NativeTypeName("HRESULT (DWRITE_OVERHANG_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetOverhangMetrics;

            [NativeTypeName("HRESULT (DWRITE_CLUSTER_METRICS *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetClusterMetrics;

            [NativeTypeName("HRESULT (FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DetermineMinWidth;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, BOOL *, BOOL *, DWRITE_HIT_TEST_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr HitTestPoint;

            [NativeTypeName("HRESULT (UINT32, BOOL, FLOAT *, FLOAT *, DWRITE_HIT_TEST_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr HitTestTextPosition;

            [NativeTypeName("HRESULT (UINT32, UINT32, FLOAT, FLOAT, DWRITE_HIT_TEST_METRICS *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr HitTestTextRange;

            [NativeTypeName("HRESULT (BOOL, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetPairKerning;

            [NativeTypeName("HRESULT (UINT32, BOOL *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPairKerning;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCharacterSpacing;

            [NativeTypeName("HRESULT (UINT32, FLOAT *, FLOAT *, FLOAT *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetCharacterSpacing;
        }
    }
}