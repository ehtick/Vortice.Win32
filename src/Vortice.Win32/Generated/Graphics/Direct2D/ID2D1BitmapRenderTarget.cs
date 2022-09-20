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

namespace Win32.Graphics.Direct2D;

/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1BitmapRenderTarget"]/*' />
/// <unmanaged>ID2D1BitmapRenderTarget</unmanaged>
[Guid("2cd90695-12e2-11dc-9fed-001143a055f9")]
[NativeTypeName("struct ID2D1BitmapRenderTarget : ID2D1RenderTarget")]
[NativeInheritance("ID2D1RenderTarget")]
public unsafe partial struct ID2D1BitmapRenderTarget
{
	public static ref readonly Guid IID_ID2D1BitmapRenderTarget
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x95, 0x06, 0xD9, 0x2C,
				0xE2, 0x12,
				0xDC, 0x11,
				0x9F,
				0xED,
				0x00,
				0x11,
				0x43,
				0xA0,
				0x55,
				0xF9
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1BitmapRenderTarget));

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

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), factory);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.CreateBitmap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateBitmap(System.Drawing.Size size, void* srcData, uint pitch, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, System.Drawing.Size, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)(lpVtbl[4]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), size, srcData, pitch, bitmapProperties, bitmap);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.CreateBitmapFromWicBitmap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateBitmapFromWicBitmap(Graphics.Imaging.IWICBitmapSource* wicBitmapSource, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Graphics.Imaging.IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)(lpVtbl[5]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), wicBitmapSource, bitmapProperties, bitmap);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.CreateSharedBitmap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateSharedBitmap(Guid* riid, void* data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)(lpVtbl[6]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), riid, data, bitmapProperties, bitmap);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.CreateBitmapBrush" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateBitmapBrush(ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)(lpVtbl[7]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.CreateSolidColorBrush" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateSolidColorBrush(Common.ColorF* color, BrushProperties* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Common.ColorF*, BrushProperties*, ID2D1SolidColorBrush**, int>)(lpVtbl[8]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), color, brushProperties, solidColorBrush);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.CreateGradientStopCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateGradientStopCollection(GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ID2D1GradientStopCollection** gradientStopCollection)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)(lpVtbl[9]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.CreateLinearGradientBrush" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)(lpVtbl[10]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.CreateRadialGradientBrush" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)(lpVtbl[11]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.CreateCompatibleRenderTarget" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateCompatibleRenderTarget(System.Drawing.SizeF* desiredSize, System.Drawing.Size* desiredPixelSize, Common.PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, System.Drawing.SizeF*, System.Drawing.Size*, Common.PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)(lpVtbl[12]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.CreateLayer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateLayer(System.Drawing.SizeF* size, ID2D1Layer** layer)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, System.Drawing.SizeF*, ID2D1Layer**, int>)(lpVtbl[13]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), size, layer);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.CreateMesh" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateMesh(ID2D1Mesh** mesh)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Mesh**, int>)(lpVtbl[14]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), mesh);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.DrawLine" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public void DrawLine(System.Drawing.PointF* point0, System.Drawing.PointF* point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, System.Drawing.PointF*, System.Drawing.PointF*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[15]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), point0, point1, brush, strokeWidth, strokeStyle);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.DrawRectangle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public void DrawRectangle(Common.RectF* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Common.RectF*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[16]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), rect, brush, strokeWidth, strokeStyle);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.FillRectangle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public void FillRectangle(Common.RectF* rect, ID2D1Brush* brush)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Common.RectF*, ID2D1Brush*, void>)(lpVtbl[17]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), rect, brush);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.DrawRoundedRectangle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public void DrawRoundedRectangle(RoundedRect* roundedRect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[18]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), roundedRect, brush, strokeWidth, strokeStyle);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.FillRoundedRectangle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public void FillRoundedRectangle(RoundedRect* roundedRect, ID2D1Brush* brush)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RoundedRect*, ID2D1Brush*, void>)(lpVtbl[19]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), roundedRect, brush);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.DrawEllipse" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public void DrawEllipse(Ellipse* ellipse, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[20]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), ellipse, brush, strokeWidth, strokeStyle);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.FillEllipse" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public void FillEllipse(Ellipse* ellipse, ID2D1Brush* brush)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Ellipse*, ID2D1Brush*, void>)(lpVtbl[21]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), ellipse, brush);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.DrawGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public void DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[22]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), geometry, brush, strokeWidth, strokeStyle);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.FillGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public void FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)(lpVtbl[23]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), geometry, brush, opacityBrush);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.FillMesh" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public void FillMesh(ID2D1Mesh* mesh, ID2D1Brush* brush)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Mesh*, ID2D1Brush*, void>)(lpVtbl[24]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), mesh, brush);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.FillOpacityMask" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public void FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Common.RectF* destinationRectangle, Common.RectF* sourceRectangle)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Common.RectF*, Common.RectF*, void>)(lpVtbl[25]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), opacityMask, brush, content, destinationRectangle, sourceRectangle);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.DrawBitmap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public void DrawBitmap(ID2D1Bitmap* bitmap, Common.RectF* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Common.RectF* sourceRectangle)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, Common.RectF*, float, BitmapInterpolationMode, Common.RectF*, void>)(lpVtbl[26]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.DrawText" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public void DrawText(ushort* @string, uint stringLength, Graphics.DirectWrite.IDWriteTextFormat* textFormat, Common.RectF* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, Graphics.DirectWrite.MeasuringMode measuringMode)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ushort*, uint, Graphics.DirectWrite.IDWriteTextFormat*, Common.RectF*, ID2D1Brush*, DrawTextOptions, Graphics.DirectWrite.MeasuringMode, void>)(lpVtbl[27]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.DrawTextLayout" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public void DrawTextLayout(System.Drawing.PointF* origin, Graphics.DirectWrite.IDWriteTextLayout* textLayout, ID2D1Brush* defaultFillBrush, DrawTextOptions options)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, System.Drawing.PointF*, Graphics.DirectWrite.IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)(lpVtbl[28]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), origin, textLayout, defaultFillBrush, options);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.DrawGlyphRun" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public void DrawGlyphRun(System.Drawing.PointF* baselineOrigin, Graphics.DirectWrite.GlyphRun* glyphRun, ID2D1Brush* foregroundBrush, Graphics.DirectWrite.MeasuringMode measuringMode)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, System.Drawing.PointF*, Graphics.DirectWrite.GlyphRun*, ID2D1Brush*, Graphics.DirectWrite.MeasuringMode, void>)(lpVtbl[29]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, foregroundBrush, measuringMode);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.SetTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public void SetTransform(Matrix3x2* transform)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Matrix3x2*, void>)(lpVtbl[30]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), transform);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.GetTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public void GetTransform(Matrix3x2** transform)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Matrix3x2**, void>)(lpVtbl[31]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), transform);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.SetAntialiasMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public void SetAntialiasMode(AntialiasMode antialiasMode)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, AntialiasMode, void>)(lpVtbl[32]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), antialiasMode);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.GetAntialiasMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public AntialiasMode GetAntialiasMode()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, AntialiasMode>)(lpVtbl[33]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1RenderTarget.SetTextAntialiasMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public void SetTextAntialiasMode(TextAntialiasMode textAntialiasMode)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, TextAntialiasMode, void>)(lpVtbl[34]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), textAntialiasMode);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.GetTextAntialiasMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public TextAntialiasMode GetTextAntialiasMode()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, TextAntialiasMode>)(lpVtbl[35]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1RenderTarget.SetTextRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public void SetTextRenderingParams(Graphics.DirectWrite.IDWriteRenderingParams* textRenderingParams)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Graphics.DirectWrite.IDWriteRenderingParams*, void>)(lpVtbl[36]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), textRenderingParams);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.GetTextRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public void GetTextRenderingParams(Graphics.DirectWrite.IDWriteRenderingParams** textRenderingParams)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Graphics.DirectWrite.IDWriteRenderingParams**, void>)(lpVtbl[37]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), textRenderingParams);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.SetTags" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public void SetTags(ulong tag1, ulong tag2)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong, ulong, void>)(lpVtbl[38]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), tag1, tag2);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.GetTags" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public void GetTags(ulong* tag1, ulong* tag2)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong*, ulong*, void>)(lpVtbl[39]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), tag1, tag2);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.PushLayer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(40)]
	public void PushLayer(LayerParameters* layerParameters, ID2D1Layer* layer)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LayerParameters*, ID2D1Layer*, void>)(lpVtbl[40]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), layerParameters, layer);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.PopLayer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(41)]
	public void PopLayer()
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, void>)(lpVtbl[41]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1RenderTarget.Flush" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(42)]
	public HResult Flush(ulong* tag1, ulong* tag2)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong*, ulong*, int>)(lpVtbl[42]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), tag1, tag2);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.SaveDrawingState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(43)]
	public void SaveDrawingState(ID2D1DrawingStateBlock* drawingStateBlock)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1DrawingStateBlock*, void>)(lpVtbl[43]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), drawingStateBlock);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.RestoreDrawingState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(44)]
	public void RestoreDrawingState(ID2D1DrawingStateBlock* drawingStateBlock)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1DrawingStateBlock*, void>)(lpVtbl[44]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), drawingStateBlock);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.PushAxisAlignedClip" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(45)]
	public void PushAxisAlignedClip(Common.RectF* clipRect, AntialiasMode antialiasMode)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Common.RectF*, AntialiasMode, void>)(lpVtbl[45]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), clipRect, antialiasMode);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.PopAxisAlignedClip" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(46)]
	public void PopAxisAlignedClip()
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, void>)(lpVtbl[46]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1RenderTarget.Clear" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(47)]
	public void Clear(Common.ColorF* clearColor)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Common.ColorF*, void>)(lpVtbl[47]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), clearColor);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.BeginDraw" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(48)]
	public void BeginDraw()
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, void>)(lpVtbl[48]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1RenderTarget.EndDraw" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(49)]
	public HResult EndDraw(ulong* tag1 = null, ulong* tag2 = null)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong*, ulong*, int>)(lpVtbl[49]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), tag1, tag2);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.GetPixelFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(50)]
	public Common.PixelFormat GetPixelFormat()
	{
		Common.PixelFormat result;
		return *((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Common.PixelFormat*, Common.PixelFormat*>)(lpVtbl[50]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), &result);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.SetDpi" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(51)]
	public void SetDpi(float dpiX, float dpiY)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, float, float, void>)(lpVtbl[51]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), dpiX, dpiY);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.GetDpi" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(52)]
	public void GetDpi(float* dpiX, float* dpiY)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, float*, float*, void>)(lpVtbl[52]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), dpiX, dpiY);
	}

	/// <inheritdoc cref="ID2D1RenderTarget.GetSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(53)]
	public System.Drawing.SizeF GetSize()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, System.Drawing.SizeF>)(lpVtbl[53]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1RenderTarget.GetPixelSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(54)]
	public System.Drawing.Size GetPixelSize()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, System.Drawing.Size>)(lpVtbl[54]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1RenderTarget.GetMaximumBitmapSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(55)]
	public uint GetMaximumBitmapSize()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, uint>)(lpVtbl[55]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1RenderTarget.IsSupported" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(56)]
	public Bool32 IsSupported(RenderTargetProperties* renderTargetProperties)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RenderTargetProperties*, Bool32>)(lpVtbl[56]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), renderTargetProperties);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1BitmapRenderTarget::GetBitmap"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(57)]
	public HResult GetBitmap(ID2D1Bitmap** bitmap)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap**, int>)(lpVtbl[57]))((ID2D1BitmapRenderTarget*)Unsafe.AsPointer(ref this), bitmap);
	}
}

