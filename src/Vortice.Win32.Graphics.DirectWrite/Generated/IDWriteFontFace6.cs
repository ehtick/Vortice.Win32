// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace6"]/*' />
/// <unmanaged>IDWriteFontFace6</unmanaged>
[Guid("c4b1fe1b-6e84-47d5-b54c-a597981b06ad")]
[NativeTypeName("struct IDWriteFontFace6 : IDWriteFontFace5")]
[NativeInheritance("IDWriteFontFace5")]
public unsafe partial struct IDWriteFontFace6 : IDWriteFontFace6.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontFace6
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x1B, 0xFE, 0xB1, 0xC4,
				0x84, 0x6E,
				0xD5, 0x47,
				0xB5,
				0x4C,
				0xA5,
				0x97,
				0x98,
				0x1B,
				0x06,
				0xAD
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFace6));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFace6));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, uint>)(lpVtbl[1]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, uint>)(lpVtbl[1]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, uint>)(lpVtbl[2]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, uint>)(lpVtbl[2]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace.GetType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public new FontFaceType GetType()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, FontFaceType>)(lpVtbl[3]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, FontFaceType>)(lpVtbl[3]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace.GetFiles" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetFiles(uint* numberOfFiles, IDWriteFontFile** fontFiles)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, uint*, IDWriteFontFile**, int>)(lpVtbl[4]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), numberOfFiles, fontFiles);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, uint*, IDWriteFontFile**, int>)(lpVtbl[4]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), numberOfFiles, fontFiles);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace.GetIndex" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public uint GetIndex()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, uint>)(lpVtbl[5]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, uint>)(lpVtbl[5]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace.GetSimulations" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public FontSimulations GetSimulations()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, FontSimulations>)(lpVtbl[6]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, FontSimulations>)(lpVtbl[6]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace.IsSymbolFont" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public Bool32 IsSymbolFont()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, Bool32>)(lpVtbl[7]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, Bool32>)(lpVtbl[7]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace.GetMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetMetrics(FontMetrics* fontFaceMetrics)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IDWriteFontFace6*, FontMetrics*, void>)(lpVtbl[8]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFaceMetrics);
#else
		((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, FontMetrics*, void>)(lpVtbl[8]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFaceMetrics);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace.GetGlyphCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public ushort GetGlyphCount()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, ushort>)(lpVtbl[9]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, ushort>)(lpVtbl[9]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace.GetDesignGlyphMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetDesignGlyphMetrics(ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Bool32 isSideways)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, ushort*, uint, GlyphMetrics*, Bool32, int>)(lpVtbl[10]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, glyphMetrics, isSideways);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, ushort*, uint, GlyphMetrics*, Bool32, int>)(lpVtbl[10]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, glyphMetrics, isSideways);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace.GetGlyphIndices" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetGlyphIndices(uint* codePoints, uint codePointCount, ushort* glyphIndices)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, uint*, uint, ushort*, int>)(lpVtbl[11]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), codePoints, codePointCount, glyphIndices);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, uint*, uint, ushort*, int>)(lpVtbl[11]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), codePoints, codePointCount, glyphIndices);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace.TryGetFontTable" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult TryGetFontTable(uint openTypeTableTag, void** tableData, uint* tableSize, void** tableContext, Bool32* exists)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, uint, void**, uint*, void**, Bool32*, int>)(lpVtbl[12]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), openTypeTableTag, tableData, tableSize, tableContext, exists);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, uint, void**, uint*, void**, Bool32*, int>)(lpVtbl[12]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), openTypeTableTag, tableData, tableSize, tableContext, exists);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace.ReleaseFontTable" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public void ReleaseFontTable(void* tableContext)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IDWriteFontFace6*, void*, void>)(lpVtbl[13]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), tableContext);
#else
		((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, void*, void>)(lpVtbl[13]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), tableContext);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace.GetGlyphRunOutline" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetGlyphRunOutline(float emSize, ushort* glyphIndices, float* glyphAdvances, GlyphOffset* glyphOffsets, uint glyphCount, Bool32 isSideways, Bool32 isRightToLeft, Graphics.Direct2D.Common.ID2D1SimplifiedGeometrySink* geometrySink)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, float, ushort*, float*, GlyphOffset*, uint, Bool32, Bool32, Graphics.Direct2D.Common.ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[14]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, float, ushort*, float*, GlyphOffset*, uint, Bool32, Bool32, Graphics.Direct2D.Common.ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[14]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace.GetRecommendedRenderingMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetRecommendedRenderingMode(float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, RenderingMode* renderingMode)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)(lpVtbl[15]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)(lpVtbl[15]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace.GetGdiCompatibleMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, Matrix3x2* transform, FontMetrics* fontFaceMetrics)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, float, float, Matrix3x2*, FontMetrics*, int>)(lpVtbl[16]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontFaceMetrics);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, float, float, Matrix3x2*, FontMetrics*, int>)(lpVtbl[16]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontFaceMetrics);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace.GetGdiCompatibleGlyphMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, Matrix3x2* transform, Bool32 useGdiNatural, ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Bool32 isSideways)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, float, float, Matrix3x2*, Bool32, ushort*, uint, GlyphMetrics*, Bool32, int>)(lpVtbl[17]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, float, float, Matrix3x2*, Bool32, ushort*, uint, GlyphMetrics*, Bool32, int>)(lpVtbl[17]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public void GetMetrics(FontMetrics1* fontMetrics)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IDWriteFontFace6*, FontMetrics1*, void>)(lpVtbl[18]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontMetrics);
#else
		((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, FontMetrics1*, void>)(lpVtbl[18]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontMetrics);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetGdiCompatibleMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, Matrix3x2* transform, FontMetrics1* fontMetrics)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, float, float, Matrix3x2*, FontMetrics1*, int>)(lpVtbl[19]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontMetrics);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, float, float, Matrix3x2*, FontMetrics1*, int>)(lpVtbl[19]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontMetrics);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetCaretMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public void GetCaretMetrics(CaretMetrics* caretMetrics)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IDWriteFontFace6*, CaretMetrics*, void>)(lpVtbl[20]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), caretMetrics);
#else
		((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, CaretMetrics*, void>)(lpVtbl[20]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), caretMetrics);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetUnicodeRanges" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetUnicodeRanges(uint maxRangeCount, UnicodeRange* unicodeRanges, uint* actualRangeCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, uint, UnicodeRange*, uint*, int>)(lpVtbl[21]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, uint, UnicodeRange*, uint*, int>)(lpVtbl[21]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace1.IsMonospacedFont" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public Bool32 IsMonospacedFont()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, Bool32>)(lpVtbl[22]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, Bool32>)(lpVtbl[22]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetDesignGlyphAdvances" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult GetDesignGlyphAdvances(uint glyphCount, ushort* glyphIndices, int* glyphAdvances, Bool32 isSideways)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, uint, ushort*, int*, Bool32, int>)(lpVtbl[23]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvances, isSideways);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, uint, ushort*, int*, Bool32, int>)(lpVtbl[23]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvances, isSideways);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetGdiCompatibleGlyphAdvances" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, Matrix3x2* transform, Bool32 useGdiNatural, Bool32 isSideways, uint glyphCount, ushort* glyphIndices, int* glyphAdvances)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, float, float, Matrix3x2*, Bool32, Bool32, uint, ushort*, int*, int>)(lpVtbl[24]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, float, float, Matrix3x2*, Bool32, Bool32, uint, ushort*, int*, int>)(lpVtbl[24]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetKerningPairAdjustments" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult GetKerningPairAdjustments(uint glyphCount, ushort* glyphIndices, int* glyphAdvanceAdjustments)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, uint, ushort*, int*, int>)(lpVtbl[25]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvanceAdjustments);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, uint, ushort*, int*, int>)(lpVtbl[25]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvanceAdjustments);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace1.HasKerningPairs" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public Bool32 HasKerningPairs()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, Bool32>)(lpVtbl[26]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, Bool32>)(lpVtbl[26]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetRecommendedRenderingMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, Matrix3x2* transform, Bool32 isSideways, OutlineThreshold outlineThreshold, MeasuringMode measuringMode, RenderingMode* renderingMode)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, float, float, float, Matrix3x2*, Bool32, OutlineThreshold, MeasuringMode, RenderingMode*, int>)(lpVtbl[27]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingMode);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, float, float, float, Matrix3x2*, Bool32, OutlineThreshold, MeasuringMode, RenderingMode*, int>)(lpVtbl[27]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingMode);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetVerticalGlyphVariants" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult GetVerticalGlyphVariants(uint glyphCount, ushort* nominalGlyphIndices, ushort* verticalGlyphIndices)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, uint, ushort*, ushort*, int>)(lpVtbl[28]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphCount, nominalGlyphIndices, verticalGlyphIndices);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, uint, ushort*, ushort*, int>)(lpVtbl[28]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphCount, nominalGlyphIndices, verticalGlyphIndices);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace1.HasVerticalGlyphVariants" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public Bool32 HasVerticalGlyphVariants()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, Bool32>)(lpVtbl[29]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, Bool32>)(lpVtbl[29]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace2.IsColorFont" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public Bool32 IsColorFont()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, Bool32>)(lpVtbl[30]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, Bool32>)(lpVtbl[30]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace2.GetColorPaletteCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public uint GetColorPaletteCount()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, uint>)(lpVtbl[31]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, uint>)(lpVtbl[31]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace2.GetPaletteEntryCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public uint GetPaletteEntryCount()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, uint>)(lpVtbl[32]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, uint>)(lpVtbl[32]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace2.GetPaletteEntries" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public HResult GetPaletteEntries(uint colorPaletteIndex, uint firstEntryIndex, uint entryCount, Color4** paletteEntries)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, uint, uint, uint, Color4**, int>)(lpVtbl[33]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), colorPaletteIndex, firstEntryIndex, entryCount, paletteEntries);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, uint, uint, uint, Color4**, int>)(lpVtbl[33]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), colorPaletteIndex, firstEntryIndex, entryCount, paletteEntries);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace2.GetRecommendedRenderingMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, Matrix3x2* transform, Bool32 isSideways, OutlineThreshold outlineThreshold, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, RenderingMode* renderingMode, GridFitMode* gridFitMode)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, float, float, float, Matrix3x2*, Bool32, OutlineThreshold, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, GridFitMode*, int>)(lpVtbl[34]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, float, float, float, Matrix3x2*, Bool32, OutlineThreshold, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, GridFitMode*, int>)(lpVtbl[34]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetFontFaceReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public HResult GetFontFaceReference(IDWriteFontFaceReference** fontFaceReference)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, IDWriteFontFaceReference**, int>)(lpVtbl[35]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFaceReference);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, IDWriteFontFaceReference**, int>)(lpVtbl[35]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFaceReference);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetPanose" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public void GetPanose(Panose* panose)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IDWriteFontFace6*, Panose*, void>)(lpVtbl[36]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), panose);
#else
		((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, Panose*, void>)(lpVtbl[36]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), panose);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetWeight" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public FontWeight GetWeight()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, FontWeight>)(lpVtbl[37]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, FontWeight>)(lpVtbl[37]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetStretch" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public FontStretch GetStretch()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, FontStretch>)(lpVtbl[38]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, FontStretch>)(lpVtbl[38]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetStyle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public FontStyle GetStyle()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, FontStyle>)(lpVtbl[39]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, FontStyle>)(lpVtbl[39]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetFamilyNames" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(40)]
	public HResult GetFamilyNames(IDWriteLocalizedStrings** names)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, IDWriteLocalizedStrings**, int>)(lpVtbl[40]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), names);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, IDWriteLocalizedStrings**, int>)(lpVtbl[40]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), names);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetFaceNames" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(41)]
	public HResult GetFaceNames(IDWriteLocalizedStrings** names)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, IDWriteLocalizedStrings**, int>)(lpVtbl[41]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), names);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, IDWriteLocalizedStrings**, int>)(lpVtbl[41]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), names);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetInformationalStrings" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(42)]
	public HResult GetInformationalStrings(InformationalStringId informationalStringID, IDWriteLocalizedStrings** informationalStrings, Bool32* exists)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, InformationalStringId, IDWriteLocalizedStrings**, Bool32*, int>)(lpVtbl[42]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, InformationalStringId, IDWriteLocalizedStrings**, Bool32*, int>)(lpVtbl[42]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace3.HasCharacter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(43)]
	public Bool32 HasCharacter(uint unicodeValue)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, uint, Bool32>)(lpVtbl[43]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), unicodeValue);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, uint, Bool32>)(lpVtbl[43]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), unicodeValue);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetRecommendedRenderingMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(44)]
	public HResult GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, Matrix3x2* transform, Bool32 isSideways, OutlineThreshold outlineThreshold, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, RenderingMode1* renderingMode, GridFitMode* gridFitMode)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, float, float, float, Matrix3x2*, Bool32, OutlineThreshold, MeasuringMode, IDWriteRenderingParams*, RenderingMode1*, GridFitMode*, int>)(lpVtbl[44]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, float, float, float, Matrix3x2*, Bool32, OutlineThreshold, MeasuringMode, IDWriteRenderingParams*, RenderingMode1*, GridFitMode*, int>)(lpVtbl[44]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace3.IsCharacterLocal" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(45)]
	public Bool32 IsCharacterLocal(uint unicodeValue)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, uint, Bool32>)(lpVtbl[45]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), unicodeValue);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, uint, Bool32>)(lpVtbl[45]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), unicodeValue);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace3.IsGlyphLocal" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(46)]
	public Bool32 IsGlyphLocal(ushort glyphId)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, ushort, Bool32>)(lpVtbl[46]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphId);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, ushort, Bool32>)(lpVtbl[46]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphId);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace3.AreCharactersLocal" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(47)]
	public HResult AreCharactersLocal(ushort* characters, uint characterCount, Bool32 enqueueIfNotLocal, Bool32* isLocal)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, ushort*, uint, Bool32, Bool32*, int>)(lpVtbl[47]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), characters, characterCount, enqueueIfNotLocal, isLocal);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, ushort*, uint, Bool32, Bool32*, int>)(lpVtbl[47]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), characters, characterCount, enqueueIfNotLocal, isLocal);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace3.AreGlyphsLocal" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(48)]
	public HResult AreGlyphsLocal(ushort* glyphIndices, uint glyphCount, Bool32 enqueueIfNotLocal, Bool32* isLocal)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, ushort*, uint, Bool32, Bool32*, int>)(lpVtbl[48]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, enqueueIfNotLocal, isLocal);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, ushort*, uint, Bool32, Bool32*, int>)(lpVtbl[48]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, enqueueIfNotLocal, isLocal);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace4.GetGlyphImageFormats" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(49)]
	public HResult GetGlyphImageFormats(ushort glyphId, uint pixelsPerEmFirst, uint pixelsPerEmLast, GlyphImageFormats* glyphImageFormats)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, ushort, uint, uint, GlyphImageFormats*, int>)(lpVtbl[49]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphId, pixelsPerEmFirst, pixelsPerEmLast, glyphImageFormats);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, ushort, uint, uint, GlyphImageFormats*, int>)(lpVtbl[49]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphId, pixelsPerEmFirst, pixelsPerEmLast, glyphImageFormats);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace4.GetGlyphImageFormats" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(50)]
	public GlyphImageFormats GetGlyphImageFormats()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, GlyphImageFormats>)(lpVtbl[50]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, GlyphImageFormats>)(lpVtbl[50]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace4.GetGlyphImageData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(51)]
	public HResult GetGlyphImageData(ushort glyphId, uint pixelsPerEm, GlyphImageFormats glyphImageFormat, GlyphImageData* glyphData, void** glyphDataContext)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, ushort, uint, GlyphImageFormats, GlyphImageData*, void**, int>)(lpVtbl[51]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphId, pixelsPerEm, glyphImageFormat, glyphData, glyphDataContext);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, ushort, uint, GlyphImageFormats, GlyphImageData*, void**, int>)(lpVtbl[51]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphId, pixelsPerEm, glyphImageFormat, glyphData, glyphDataContext);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace4.ReleaseGlyphImageData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(52)]
	public void ReleaseGlyphImageData(void* glyphDataContext)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IDWriteFontFace6*, void*, void>)(lpVtbl[52]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphDataContext);
#else
		((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, void*, void>)(lpVtbl[52]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphDataContext);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace5.GetFontAxisValueCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(53)]
	public uint GetFontAxisValueCount()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, uint>)(lpVtbl[53]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, uint>)(lpVtbl[53]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace5.GetFontAxisValues" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(54)]
	public HResult GetFontAxisValues(FontAxisValue* fontAxisValues, uint fontAxisValueCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, FontAxisValue*, uint, int>)(lpVtbl[54]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, FontAxisValue*, uint, int>)(lpVtbl[54]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace5.HasVariations" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(55)]
	public Bool32 HasVariations()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, Bool32>)(lpVtbl[55]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, Bool32>)(lpVtbl[55]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace5.GetFontResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(56)]
	public HResult GetFontResource(IDWriteFontResource** fontResource)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, IDWriteFontResource**, int>)(lpVtbl[56]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontResource);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, IDWriteFontResource**, int>)(lpVtbl[56]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontResource);
#endif
	}

	/// <inheritdoc cref="IDWriteFontFace5.Equals" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(57)]
	public Bool32 Equals(IDWriteFontFace* fontFace)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, IDWriteFontFace*, Bool32>)(lpVtbl[57]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFace);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, IDWriteFontFace*, Bool32>)(lpVtbl[57]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFace);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace6::GetFamilyNames"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(58)]
	public HResult GetFamilyNames(FontFamilyModel fontFamilyModel, IDWriteLocalizedStrings** names)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, FontFamilyModel, IDWriteLocalizedStrings**, int>)(lpVtbl[58]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFamilyModel, names);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, FontFamilyModel, IDWriteLocalizedStrings**, int>)(lpVtbl[58]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFamilyModel, names);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace6::GetFaceNames"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(59)]
	public HResult GetFaceNames(FontFamilyModel fontFamilyModel, IDWriteLocalizedStrings** names)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontFace6*, FontFamilyModel, IDWriteLocalizedStrings**, int>)(lpVtbl[59]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFamilyModel, names);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace6*, FontFamilyModel, IDWriteLocalizedStrings**, int>)(lpVtbl[59]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFamilyModel, names);
#endif
	}

	public interface Interface : IDWriteFontFace5.Interface
	{
		[VtblIndex(58)]
		HResult GetFamilyNames(FontFamilyModel fontFamilyModel, IDWriteLocalizedStrings** names);

		[VtblIndex(59)]
		HResult GetFaceNames(FontFamilyModel fontFamilyModel, IDWriteLocalizedStrings** names);
	}
}

