// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Numerics;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

#if !NET6_0_OR_GREATER
using MemoryMarshal = Win32.MemoryMarshal;
#endif

namespace Win32.Graphics.DirectWrite;

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFactory2"]/*' />
/// <unmanaged>IDWriteFactory2</unmanaged>
[Guid("0439fc60-ca44-4994-8dee-3a9af7b732ec")]
[NativeTypeName("struct IDWriteFactory2 : IDWriteFactory1")]
[NativeInheritance("IDWriteFactory1")]
public unsafe partial struct IDWriteFactory2
{
	public static ref readonly Guid IID_IDWriteFactory2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x60, 0xFC, 0x39, 0x04,
				0x44, 0xCA,
				0x94, 0x49,
				0x8D,
				0xEE,
				0x3A,
				0x9A,
				0xF7,
				0xB7,
				0x32,
				0xEC
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFactory2));

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
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollection**, Bool32, int>)(lpVtbl[3]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateCustomFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, void* collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)(lpVtbl[4]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), collectionLoader, collectionKey, collectionKeySize, fontCollection);
	}

	/// <inheritdoc cref="IDWriteFactory.RegisterFontCollectionLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult RegisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollectionLoader*, int>)(lpVtbl[5]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), fontCollectionLoader);
	}

	/// <inheritdoc cref="IDWriteFactory.UnregisterFontCollectionLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult UnregisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollectionLoader*, int>)(lpVtbl[6]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), fontCollectionLoader);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateFontFileReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateFontFileReference(ushort* filePath, ulong* lastWriteTime, IDWriteFontFile** fontFile)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, ushort*, ulong*, IDWriteFontFile**, int>)(lpVtbl[7]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, fontFile);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateCustomFontFileReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateCustomFontFileReference(void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)(lpVtbl[8]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateFontFace" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateFontFace(FontFaceType fontFaceType, uint numberOfFiles, IDWriteFontFile** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, IDWriteFontFace** fontFace)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)(lpVtbl[9]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateRenderingParams(IDWriteRenderingParams** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteRenderingParams**, int>)(lpVtbl[10]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateMonitorRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateMonitorRenderingParams(IntPtr monitor, IDWriteRenderingParams** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IntPtr, IDWriteRenderingParams**, int>)(lpVtbl[11]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), monitor, renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateCustomRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, IDWriteRenderingParams** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams**, int>)(lpVtbl[12]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory.RegisterFontFileLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult RegisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontFileLoader*, int>)(lpVtbl[13]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), fontFileLoader);
	}

	/// <inheritdoc cref="IDWriteFactory.UnregisterFontFileLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult UnregisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontFileLoader*, int>)(lpVtbl[14]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), fontFileLoader);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateTextFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateTextFormat(ushort* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, ushort* localeName, IDWriteTextFormat** textFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, ushort*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, ushort*, IDWriteTextFormat**, int>)(lpVtbl[15]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateTypography" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateTypography(IDWriteTypography** typography)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteTypography**, int>)(lpVtbl[16]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), typography);
	}

	/// <inheritdoc cref="IDWriteFactory.GetGdiInterop" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetGdiInterop(IDWriteGdiInterop** gdiInterop)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteGdiInterop**, int>)(lpVtbl[17]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), gdiInterop);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateTextLayout" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult CreateTextLayout(ushort* @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, ushort*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)(lpVtbl[18]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateGdiCompatibleTextLayout" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreateGdiCompatibleTextLayout(ushort* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, Matrix* transform, Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, ushort*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Bool32, IDWriteTextLayout**, int>)(lpVtbl[19]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateEllipsisTrimmingSign" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteTextFormat*, IDWriteInlineObject**, int>)(lpVtbl[20]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), textFormat, trimmingSign);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateTextAnalyzer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateTextAnalyzer(IDWriteTextAnalyzer** textAnalyzer)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteTextAnalyzer**, int>)(lpVtbl[21]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), textAnalyzer);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateNumberSubstitution" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, ushort* localeName, Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, NumberSubstitutionMethod, ushort*, Bool32, IDWriteNumberSubstitution**, int>)(lpVtbl[22]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateGlyphRunAnalysis" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult CreateGlyphRunAnalysis(GlyphRun* glyphRun, float pixelsPerDip, Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[23]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
	}

	/// <inheritdoc cref="IDWriteFactory1.GetEudcFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult GetEudcFontCollection(IDWriteFontCollection** fontCollection, Bool32 checkForUpdates)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollection**, Bool32, int>)(lpVtbl[24]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
	}

	/// <inheritdoc cref="IDWriteFactory1.CreateCustomRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float enhancedContrastGrayscale, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, IDWriteRenderingParams1** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams1**, int>)(lpVtbl[25]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, enhancedContrastGrayscale, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFactory2::GetSystemFontFallback"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult GetSystemFontFallback(IDWriteFontFallback** fontFallback)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontFallback**, int>)(lpVtbl[26]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), fontFallback);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFactory2::CreateFontFallbackBuilder"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult CreateFontFallbackBuilder(IDWriteFontFallbackBuilder** fontFallbackBuilder)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontFallbackBuilder**, int>)(lpVtbl[27]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), fontFallbackBuilder);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFactory2::TranslateColorGlyphRun"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, GlyphRun* glyphRun, GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, Matrix* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)(lpVtbl[28]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFactory2::CreateCustomRenderingParams"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, GridFitMode gridFitMode, IDWriteRenderingParams2** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, float, float, PixelGeometry, RenderingMode, GridFitMode, IDWriteRenderingParams2**, int>)(lpVtbl[29]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, renderingParams);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFactory2::CreateGlyphRunAnalysis"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult CreateGlyphRunAnalysis(GlyphRun* glyphRun, Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, GridFitMode gridFitMode, TextAntialiasMode antialiasMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, GlyphRun*, Matrix*, RenderingMode, MeasuringMode, GridFitMode, TextAntialiasMode, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[30]))((IDWriteFactory2*)Unsafe.AsPointer(ref this), glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
	}
}

