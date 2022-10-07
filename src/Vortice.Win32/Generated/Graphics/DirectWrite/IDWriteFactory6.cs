// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteFactory6"]/*' />
/// <unmanaged>IDWriteFactory6</unmanaged>
[Guid("f3744d80-21f7-42eb-b35d-995bc72fc223")]
[NativeTypeName("struct IDWriteFactory6 : IDWriteFactory5")]
[NativeInheritance("IDWriteFactory5")]
public unsafe partial struct IDWriteFactory6 : INativeGuid
{
	public static ref readonly Guid IID_IDWriteFactory6
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x80, 0x4D, 0x74, 0xF3,
				0xF7, 0x21,
				0xEB, 0x42,
				0xB3,
				0x5D,
				0x99,
				0x5B,
				0xC7,
				0x2F,
				0xC2,
				0x23
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFactory6));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFactory6));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFactory.GetSystemFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetSystemFontCollection(IDWriteFontCollection** fontCollection, Bool32 checkForUpdates)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollection**, Bool32, int>)(lpVtbl[3]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateCustomFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, void* collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)(lpVtbl[4]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), collectionLoader, collectionKey, collectionKeySize, fontCollection);
	}

	/// <inheritdoc cref="IDWriteFactory.RegisterFontCollectionLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult RegisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, int>)(lpVtbl[5]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontCollectionLoader);
	}

	/// <inheritdoc cref="IDWriteFactory.UnregisterFontCollectionLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult UnregisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, int>)(lpVtbl[6]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontCollectionLoader);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateFontFileReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateFontFileReference(ushort* filePath, ulong* lastWriteTime, IDWriteFontFile** fontFile)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ushort*, ulong*, IDWriteFontFile**, int>)(lpVtbl[7]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, fontFile);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateCustomFontFileReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateCustomFontFileReference(void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)(lpVtbl[8]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateFontFace" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateFontFace(FontFaceType fontFaceType, uint numberOfFiles, IDWriteFontFile** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, IDWriteFontFace** fontFace)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)(lpVtbl[9]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateRenderingParams(IDWriteRenderingParams** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteRenderingParams**, int>)(lpVtbl[10]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateMonitorRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateMonitorRenderingParams(IntPtr monitor, IDWriteRenderingParams** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IntPtr, IDWriteRenderingParams**, int>)(lpVtbl[11]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), monitor, renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateCustomRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, IDWriteRenderingParams** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams**, int>)(lpVtbl[12]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory.RegisterFontFileLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult RegisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFileLoader*, int>)(lpVtbl[13]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFileLoader);
	}

	/// <inheritdoc cref="IDWriteFactory.UnregisterFontFileLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult UnregisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFileLoader*, int>)(lpVtbl[14]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFileLoader);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateTextFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateTextFormat(ushort* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, ushort* localeName, IDWriteTextFormat** textFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ushort*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, ushort*, IDWriteTextFormat**, int>)(lpVtbl[15]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateTypography" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateTypography(IDWriteTypography** typography)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTypography**, int>)(lpVtbl[16]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), typography);
	}

	/// <inheritdoc cref="IDWriteFactory.GetGdiInterop" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetGdiInterop(IDWriteGdiInterop** gdiInterop)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteGdiInterop**, int>)(lpVtbl[17]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), gdiInterop);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateTextLayout" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult CreateTextLayout(ushort* @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ushort*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)(lpVtbl[18]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateGdiCompatibleTextLayout" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreateGdiCompatibleTextLayout(ushort* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, Matrix3x2* transform, Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ushort*, uint, IDWriteTextFormat*, float, float, float, Matrix3x2*, Bool32, IDWriteTextLayout**, int>)(lpVtbl[19]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateEllipsisTrimmingSign" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTextFormat*, IDWriteInlineObject**, int>)(lpVtbl[20]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), textFormat, trimmingSign);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateTextAnalyzer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateTextAnalyzer(IDWriteTextAnalyzer** textAnalyzer)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTextAnalyzer**, int>)(lpVtbl[21]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), textAnalyzer);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateNumberSubstitution" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, ushort* localeName, Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, NumberSubstitutionMethod, ushort*, Bool32, IDWriteNumberSubstitution**, int>)(lpVtbl[22]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateGlyphRunAnalysis" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult CreateGlyphRunAnalysis(GlyphRun* glyphRun, float pixelsPerDip, Matrix3x2* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, float, Matrix3x2*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[23]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
	}

	/// <inheritdoc cref="IDWriteFactory1.GetEudcFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult GetEudcFontCollection(IDWriteFontCollection** fontCollection, Bool32 checkForUpdates)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollection**, Bool32, int>)(lpVtbl[24]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
	}

	/// <inheritdoc cref="IDWriteFactory1.CreateCustomRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float enhancedContrastGrayscale, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, IDWriteRenderingParams1** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams1**, int>)(lpVtbl[25]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, enhancedContrastGrayscale, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory2.GetSystemFontFallback" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult GetSystemFontFallback(IDWriteFontFallback** fontFallback)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFallback**, int>)(lpVtbl[26]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFallback);
	}

	/// <inheritdoc cref="IDWriteFactory2.CreateFontFallbackBuilder" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult CreateFontFallbackBuilder(IDWriteFontFallbackBuilder** fontFallbackBuilder)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFallbackBuilder**, int>)(lpVtbl[27]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFallbackBuilder);
	}

	/// <inheritdoc cref="IDWriteFactory2.TranslateColorGlyphRun" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, GlyphRun* glyphRun, GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, Matrix3x2* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix3x2*, uint, IDWriteColorGlyphRunEnumerator**, int>)(lpVtbl[28]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
	}

	/// <inheritdoc cref="IDWriteFactory2.CreateCustomRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, GridFitMode gridFitMode, IDWriteRenderingParams2** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, float, float, PixelGeometry, RenderingMode, GridFitMode, IDWriteRenderingParams2**, int>)(lpVtbl[29]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory2.CreateGlyphRunAnalysis" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult CreateGlyphRunAnalysis(GlyphRun* glyphRun, Matrix3x2* transform, RenderingMode renderingMode, MeasuringMode measuringMode, GridFitMode gridFitMode, TextAntialiasMode antialiasMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, Matrix3x2*, RenderingMode, MeasuringMode, GridFitMode, TextAntialiasMode, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[30]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
	}

	/// <inheritdoc cref="IDWriteFactory3.CreateGlyphRunAnalysis" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult CreateGlyphRunAnalysis(GlyphRun* glyphRun, Matrix3x2* transform, RenderingMode1 renderingMode, MeasuringMode measuringMode, GridFitMode gridFitMode, TextAntialiasMode antialiasMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, Matrix3x2*, RenderingMode1, MeasuringMode, GridFitMode, TextAntialiasMode, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[31]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
	}

	/// <inheritdoc cref="IDWriteFactory3.CreateCustomRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode1 renderingMode, GridFitMode gridFitMode, IDWriteRenderingParams3** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, float, float, PixelGeometry, RenderingMode1, GridFitMode, IDWriteRenderingParams3**, int>)(lpVtbl[32]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory3.CreateFontFaceReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public HResult CreateFontFaceReference(IDWriteFontFile* fontFile, uint faceIndex, FontSimulations fontSimulations, IDWriteFontFaceReference** fontFaceReference)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFile*, uint, FontSimulations, IDWriteFontFaceReference**, int>)(lpVtbl[33]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFile, faceIndex, fontSimulations, fontFaceReference);
	}

	/// <inheritdoc cref="IDWriteFactory3.CreateFontFaceReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult CreateFontFaceReference(ushort* filePath, ulong* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, IDWriteFontFaceReference** fontFaceReference)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ushort*, ulong*, uint, FontSimulations, IDWriteFontFaceReference**, int>)(lpVtbl[34]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, faceIndex, fontSimulations, fontFaceReference);
	}

	/// <inheritdoc cref="IDWriteFactory3.GetSystemFontSet" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public HResult GetSystemFontSet(IDWriteFontSet** fontSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSet**, int>)(lpVtbl[35]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontSet);
	}

	/// <inheritdoc cref="IDWriteFactory3.CreateFontSetBuilder" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public HResult CreateFontSetBuilder(IDWriteFontSetBuilder** fontSetBuilder)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSetBuilder**, int>)(lpVtbl[36]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontSetBuilder);
	}

	/// <inheritdoc cref="IDWriteFactory3.CreateFontCollectionFromFontSet" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public HResult CreateFontCollectionFromFontSet(IDWriteFontSet* fontSet, IDWriteFontCollection1** fontCollection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSet*, IDWriteFontCollection1**, int>)(lpVtbl[37]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontSet, fontCollection);
	}

	/// <inheritdoc cref="IDWriteFactory3.GetSystemFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public HResult GetSystemFontCollection(Bool32 includeDownloadableFonts, IDWriteFontCollection1** fontCollection, Bool32 checkForUpdates)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, Bool32, IDWriteFontCollection1**, Bool32, int>)(lpVtbl[38]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), includeDownloadableFonts, fontCollection, checkForUpdates);
	}

	/// <inheritdoc cref="IDWriteFactory3.GetFontDownloadQueue" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public HResult GetFontDownloadQueue(IDWriteFontDownloadQueue** fontDownloadQueue)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontDownloadQueue**, int>)(lpVtbl[39]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontDownloadQueue);
	}

	/// <inheritdoc cref="IDWriteFactory4.TranslateColorGlyphRun" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(40)]
	public HResult TranslateColorGlyphRun(System.Drawing.PointF baselineOrigin, GlyphRun* glyphRun, GlyphRunDescription* glyphRunDescription, GlyphImageFormats desiredGlyphImageFormats, MeasuringMode measuringMode, Matrix3x2* worldAndDpiTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator1** colorLayers)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, System.Drawing.PointF, GlyphRun*, GlyphRunDescription*, GlyphImageFormats, MeasuringMode, Matrix3x2*, uint, IDWriteColorGlyphRunEnumerator1**, int>)(lpVtbl[40]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, glyphRunDescription, desiredGlyphImageFormats, measuringMode, worldAndDpiTransform, colorPaletteIndex, colorLayers);
	}

	/// <inheritdoc cref="IDWriteFactory4.ComputeGlyphOrigins" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(41)]
	public HResult ComputeGlyphOrigins(GlyphRun* glyphRun, System.Drawing.PointF baselineOrigin, System.Drawing.PointF* glyphOrigins)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, System.Drawing.PointF, System.Drawing.PointF*, int>)(lpVtbl[41]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), glyphRun, baselineOrigin, glyphOrigins);
	}

	/// <inheritdoc cref="IDWriteFactory4.ComputeGlyphOrigins" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(42)]
	public HResult ComputeGlyphOrigins(GlyphRun* glyphRun, MeasuringMode measuringMode, System.Drawing.PointF baselineOrigin, Matrix3x2* worldAndDpiTransform, System.Drawing.PointF* glyphOrigins)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, MeasuringMode, System.Drawing.PointF, Matrix3x2*, System.Drawing.PointF*, int>)(lpVtbl[42]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), glyphRun, measuringMode, baselineOrigin, worldAndDpiTransform, glyphOrigins);
	}

	/// <inheritdoc cref="IDWriteFactory5.CreateFontSetBuilder" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(43)]
	public HResult CreateFontSetBuilder(IDWriteFontSetBuilder1** fontSetBuilder)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSetBuilder1**, int>)(lpVtbl[43]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontSetBuilder);
	}

	/// <inheritdoc cref="IDWriteFactory5.CreateInMemoryFontFileLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(44)]
	public HResult CreateInMemoryFontFileLoader(IDWriteInMemoryFontFileLoader** newLoader)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteInMemoryFontFileLoader**, int>)(lpVtbl[44]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), newLoader);
	}

	/// <inheritdoc cref="IDWriteFactory5.CreateHttpFontFileLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(45)]
	public HResult CreateHttpFontFileLoader(ushort* referrerUrl, ushort* extraHeaders, IDWriteRemoteFontFileLoader** newLoader)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ushort*, ushort*, IDWriteRemoteFontFileLoader**, int>)(lpVtbl[45]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), referrerUrl, extraHeaders, newLoader);
	}

	/// <inheritdoc cref="IDWriteFactory5.AnalyzeContainerType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(46)]
	public ContainerType AnalyzeContainerType(void* fileData, uint fileDataSize)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, void*, uint, ContainerType>)(lpVtbl[46]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fileData, fileDataSize);
	}

	/// <inheritdoc cref="IDWriteFactory5.UnpackFontFile" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(47)]
	public HResult UnpackFontFile(ContainerType containerType, void* fileData, uint fileDataSize, IDWriteFontFileStream** unpackedFontStream)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ContainerType, void*, uint, IDWriteFontFileStream**, int>)(lpVtbl[47]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), containerType, fileData, fileDataSize, unpackedFontStream);
	}

	/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteFactory6::CreateFontFaceReference"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(48)]
	public HResult CreateFontFaceReference(IDWriteFontFile* fontFile, uint faceIndex, FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontFaceReference1** fontFaceReference)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, IDWriteFontFaceReference1**, int>)(lpVtbl[48]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFile, faceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontFaceReference);
	}

	/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteFactory6::CreateFontResource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(49)]
	public HResult CreateFontResource(IDWriteFontFile* fontFile, uint faceIndex, IDWriteFontResource** fontResource)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFile*, uint, IDWriteFontResource**, int>)(lpVtbl[49]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFile, faceIndex, fontResource);
	}

	/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteFactory6::GetSystemFontSet"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(50)]
	public HResult GetSystemFontSet(Bool32 includeDownloadableFonts, IDWriteFontSet1** fontSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, Bool32, IDWriteFontSet1**, int>)(lpVtbl[50]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), includeDownloadableFonts, fontSet);
	}

	/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteFactory6::GetSystemFontCollection"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(51)]
	public HResult GetSystemFontCollection(Bool32 includeDownloadableFonts, FontFamilyModel fontFamilyModel, IDWriteFontCollection2** fontCollection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, Bool32, FontFamilyModel, IDWriteFontCollection2**, int>)(lpVtbl[51]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), includeDownloadableFonts, fontFamilyModel, fontCollection);
	}

	/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteFactory6::CreateFontCollectionFromFontSet"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(52)]
	public HResult CreateFontCollectionFromFontSet(IDWriteFontSet* fontSet, FontFamilyModel fontFamilyModel, IDWriteFontCollection2** fontCollection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSet*, FontFamilyModel, IDWriteFontCollection2**, int>)(lpVtbl[52]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontSet, fontFamilyModel, fontCollection);
	}

	/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteFactory6::CreateFontSetBuilder"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(53)]
	public HResult CreateFontSetBuilder(IDWriteFontSetBuilder2** fontSetBuilder)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSetBuilder2**, int>)(lpVtbl[53]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontSetBuilder);
	}

	/// <include file='DirectWrite.xml' path='doc/member[@name="IDWriteFactory6::CreateTextFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(54)]
	public HResult CreateTextFormat(ushort* fontFamilyName, IDWriteFontCollection* fontCollection, FontAxisValue* fontAxisValues, uint fontAxisValueCount, float fontSize, ushort* localeName, IDWriteTextFormat3** textFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ushort*, IDWriteFontCollection*, FontAxisValue*, uint, float, ushort*, IDWriteTextFormat3**, int>)(lpVtbl[54]))((IDWriteFactory6*)Unsafe.AsPointer(ref this), fontFamilyName, fontCollection, fontAxisValues, fontAxisValueCount, fontSize, localeName, textFormat);
	}
}

