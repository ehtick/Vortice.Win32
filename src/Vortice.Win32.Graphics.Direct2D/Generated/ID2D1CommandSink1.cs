// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1CommandSink1"]/*' />
/// <unmanaged>ID2D1CommandSink1</unmanaged>
[Guid("9eb767fd-4269-4467-b8c2-eb30cb305743")]
[NativeTypeName("struct ID2D1CommandSink1 : ID2D1CommandSink")]
[NativeInheritance("ID2D1CommandSink")]
public unsafe partial struct ID2D1CommandSink1 : ID2D1CommandSink1.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1CommandSink1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xFD, 0x67, 0xB7, 0x9E,
				0x69, 0x42,
				0x67, 0x44,
				0xB8,
				0xC2,
				0xEB,
				0x30,
				0xCB,
				0x30,
				0x57,
				0x43
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1CommandSink1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1CommandSink1));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, uint>)(lpVtbl[1]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, uint>)(lpVtbl[2]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1CommandSink.BeginDraw" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult BeginDraw()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, int>)(lpVtbl[3]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1CommandSink.EndDraw" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult EndDraw()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, int>)(lpVtbl[4]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1CommandSink.SetAntialiasMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetAntialiasMode(AntialiasMode antialiasMode)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, AntialiasMode, int>)(lpVtbl[5]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), antialiasMode);
	}

	/// <inheritdoc cref="ID2D1CommandSink.SetTags" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetTags(ulong tag1, ulong tag2)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ulong, ulong, int>)(lpVtbl[6]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), tag1, tag2);
	}

	/// <inheritdoc cref="ID2D1CommandSink.SetTextAntialiasMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetTextAntialiasMode(TextAntialiasMode textAntialiasMode)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, TextAntialiasMode, int>)(lpVtbl[7]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), textAntialiasMode);
	}

	/// <inheritdoc cref="ID2D1CommandSink.SetTextRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetTextRenderingParams(Graphics.DirectWrite.IDWriteRenderingParams* textRenderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Graphics.DirectWrite.IDWriteRenderingParams*, int>)(lpVtbl[8]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), textRenderingParams);
	}

	/// <inheritdoc cref="ID2D1CommandSink.SetTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetTransform(Matrix3x2* transform)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Matrix3x2*, int>)(lpVtbl[9]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), transform);
	}

	/// <inheritdoc cref="ID2D1CommandSink.SetPrimitiveBlend" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetPrimitiveBlend(PrimitiveBlend primitiveBlend)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, PrimitiveBlend, int>)(lpVtbl[10]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), primitiveBlend);
	}

	/// <inheritdoc cref="ID2D1CommandSink.SetUnitMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult SetUnitMode(UnitMode unitMode)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, UnitMode, int>)(lpVtbl[11]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), unitMode);
	}

	/// <inheritdoc cref="ID2D1CommandSink.Clear" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult Clear(Color4* color)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Color4*, int>)(lpVtbl[12]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), color);
	}

	/// <inheritdoc cref="ID2D1CommandSink.DrawGlyphRun" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult DrawGlyphRun(System.Drawing.PointF baselineOrigin, Graphics.DirectWrite.GlyphRun* glyphRun, Graphics.DirectWrite.GlyphRunDescription* glyphRunDescription, ID2D1Brush* foregroundBrush, Graphics.DirectWrite.MeasuringMode measuringMode)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, System.Drawing.PointF, Graphics.DirectWrite.GlyphRun*, Graphics.DirectWrite.GlyphRunDescription*, ID2D1Brush*, Graphics.DirectWrite.MeasuringMode, int>)(lpVtbl[13]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
	}

	/// <inheritdoc cref="ID2D1CommandSink.DrawLine" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult DrawLine(System.Drawing.PointF point0, System.Drawing.PointF point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, System.Drawing.PointF, System.Drawing.PointF, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)(lpVtbl[14]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), point0, point1, brush, strokeWidth, strokeStyle);
	}

	/// <inheritdoc cref="ID2D1CommandSink.DrawGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)(lpVtbl[15]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), geometry, brush, strokeWidth, strokeStyle);
	}

	/// <inheritdoc cref="ID2D1CommandSink.DrawRectangle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult DrawRectangle(Common.RectF* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Common.RectF*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)(lpVtbl[16]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), rect, brush, strokeWidth, strokeStyle);
	}

	/// <inheritdoc cref="ID2D1CommandSink.DrawBitmap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult DrawBitmap(ID2D1Bitmap* bitmap, Common.RectF* destinationRectangle, float opacity, InterpolationMode interpolationMode, Common.RectF* sourceRectangle, Matrix4x4* perspectiveTransform)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, Common.RectF*, float, InterpolationMode, Common.RectF*, Matrix4x4*, int>)(lpVtbl[17]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
	}

	/// <inheritdoc cref="ID2D1CommandSink.DrawImage" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult DrawImage(ID2D1Image* image, System.Drawing.PointF* targetOffset, Common.RectF* imageRectangle, InterpolationMode interpolationMode, Common.CompositeMode compositeMode)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Image*, System.Drawing.PointF*, Common.RectF*, InterpolationMode, Common.CompositeMode, int>)(lpVtbl[18]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), image, targetOffset, imageRectangle, interpolationMode, compositeMode);
	}

	/// <inheritdoc cref="ID2D1CommandSink.DrawGdiMetafile" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult DrawGdiMetafile(ID2D1GdiMetafile* gdiMetafile, System.Drawing.PointF* targetOffset)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1GdiMetafile*, System.Drawing.PointF*, int>)(lpVtbl[19]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), gdiMetafile, targetOffset);
	}

	/// <inheritdoc cref="ID2D1CommandSink.FillMesh" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult FillMesh(ID2D1Mesh* mesh, ID2D1Brush* brush)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Mesh*, ID2D1Brush*, int>)(lpVtbl[20]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), mesh, brush);
	}

	/// <inheritdoc cref="ID2D1CommandSink.FillOpacityMask" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, Common.RectF* destinationRectangle, Common.RectF* sourceRectangle)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, Common.RectF*, Common.RectF*, int>)(lpVtbl[21]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), opacityMask, brush, destinationRectangle, sourceRectangle);
	}

	/// <inheritdoc cref="ID2D1CommandSink.FillGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)(lpVtbl[22]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), geometry, brush, opacityBrush);
	}

	/// <inheritdoc cref="ID2D1CommandSink.FillRectangle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult FillRectangle(Common.RectF* rect, ID2D1Brush* brush)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Common.RectF*, ID2D1Brush*, int>)(lpVtbl[23]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), rect, brush);
	}

	/// <inheritdoc cref="ID2D1CommandSink.PushAxisAlignedClip" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult PushAxisAlignedClip(Common.RectF* clipRect, AntialiasMode antialiasMode)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, Common.RectF*, AntialiasMode, int>)(lpVtbl[24]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), clipRect, antialiasMode);
	}

	/// <inheritdoc cref="ID2D1CommandSink.PushLayer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult PushLayer(LayerParameters1* layerParameters1, ID2D1Layer* layer)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, LayerParameters1*, ID2D1Layer*, int>)(lpVtbl[25]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), layerParameters1, layer);
	}

	/// <inheritdoc cref="ID2D1CommandSink.PopAxisAlignedClip" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult PopAxisAlignedClip()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, int>)(lpVtbl[26]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1CommandSink.PopLayer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult PopLayer()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, int>)(lpVtbl[27]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1CommandSink1::SetPrimitiveBlend1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult SetPrimitiveBlend1(PrimitiveBlend primitiveBlend)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1CommandSink1*, PrimitiveBlend, int>)(lpVtbl[28]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), primitiveBlend);
	}

	public interface Interface : ID2D1CommandSink.Interface
	{
		[VtblIndex(28)]
		HResult SetPrimitiveBlend1(PrimitiveBlend primitiveBlend);
	}
}

