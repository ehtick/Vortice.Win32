// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory"]/*' />
/// <unmanaged>ID2D1Factory</unmanaged>
[Guid("06152247-6f50-465a-9245-118bfd3b6007")]
[NativeTypeName("struct ID2D1Factory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1Factory : ID2D1Factory.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1Factory
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x47, 0x22, 0x15, 0x06,
				0x50, 0x6F,
				0x5A, 0x46,
				0x92,
				0x45,
				0x11,
				0x8B,
				0xFD,
				0x3B,
				0x60,
				0x07
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Factory));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Factory));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Factory*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Factory*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Factory*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Factory*, uint>)(lpVtbl[1]))((ID2D1Factory*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, uint>)(lpVtbl[1]))((ID2D1Factory*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Factory*, uint>)(lpVtbl[2]))((ID2D1Factory*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, uint>)(lpVtbl[2]))((ID2D1Factory*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory::ReloadSystemMetrics"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult ReloadSystemMetrics()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Factory*, int>)(lpVtbl[3]))((ID2D1Factory*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, int>)(lpVtbl[3]))((ID2D1Factory*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory::GetDesktopDpi"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void GetDesktopDpi(float* dpiX, float* dpiY)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1Factory*, float*, float*, void>)(lpVtbl[4]))((ID2D1Factory*)Unsafe.AsPointer(ref this), dpiX, dpiY);
#else
		((delegate* unmanaged[Stdcall]<ID2D1Factory*, float*, float*, void>)(lpVtbl[4]))((ID2D1Factory*)Unsafe.AsPointer(ref this), dpiX, dpiY);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateRectangleGeometry"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateRectangleGeometry(Win32.Numerics.RectF* rectangle, ID2D1RectangleGeometry** rectangleGeometry)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Factory*, Win32.Numerics.RectF*, ID2D1RectangleGeometry**, int>)(lpVtbl[5]))((ID2D1Factory*)Unsafe.AsPointer(ref this), rectangle, rectangleGeometry);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Win32.Numerics.RectF*, ID2D1RectangleGeometry**, int>)(lpVtbl[5]))((ID2D1Factory*)Unsafe.AsPointer(ref this), rectangle, rectangleGeometry);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateRoundedRectangleGeometry"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateRoundedRectangleGeometry(RoundedRect* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Factory*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)(lpVtbl[6]))((ID2D1Factory*)Unsafe.AsPointer(ref this), roundedRectangle, roundedRectangleGeometry);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)(lpVtbl[6]))((ID2D1Factory*)Unsafe.AsPointer(ref this), roundedRectangle, roundedRectangleGeometry);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateEllipseGeometry"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateEllipseGeometry(Ellipse* ellipse, ID2D1EllipseGeometry** ellipseGeometry)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Factory*, Ellipse*, ID2D1EllipseGeometry**, int>)(lpVtbl[7]))((ID2D1Factory*)Unsafe.AsPointer(ref this), ellipse, ellipseGeometry);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Ellipse*, ID2D1EllipseGeometry**, int>)(lpVtbl[7]))((ID2D1Factory*)Unsafe.AsPointer(ref this), ellipse, ellipseGeometry);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateGeometryGroup"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateGeometryGroup(Common.FillMode fillMode, ID2D1Geometry** geometries, uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Factory*, Common.FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)(lpVtbl[8]))((ID2D1Factory*)Unsafe.AsPointer(ref this), fillMode, geometries, geometriesCount, geometryGroup);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Common.FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)(lpVtbl[8]))((ID2D1Factory*)Unsafe.AsPointer(ref this), fillMode, geometries, geometriesCount, geometryGroup);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateTransformedGeometry"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, Matrix3x2* transform, ID2D1TransformedGeometry** transformedGeometry)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Factory*, ID2D1Geometry*, Matrix3x2*, ID2D1TransformedGeometry**, int>)(lpVtbl[9]))((ID2D1Factory*)Unsafe.AsPointer(ref this), sourceGeometry, transform, transformedGeometry);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, ID2D1Geometry*, Matrix3x2*, ID2D1TransformedGeometry**, int>)(lpVtbl[9]))((ID2D1Factory*)Unsafe.AsPointer(ref this), sourceGeometry, transform, transformedGeometry);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreatePathGeometry"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreatePathGeometry(ID2D1PathGeometry** pathGeometry)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Factory*, ID2D1PathGeometry**, int>)(lpVtbl[10]))((ID2D1Factory*)Unsafe.AsPointer(ref this), pathGeometry);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, ID2D1PathGeometry**, int>)(lpVtbl[10]))((ID2D1Factory*)Unsafe.AsPointer(ref this), pathGeometry);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateStrokeStyle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateStrokeStyle(StrokeStyleProperties* strokeStyleProperties, float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Factory*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)(lpVtbl[11]))((ID2D1Factory*)Unsafe.AsPointer(ref this), strokeStyleProperties, dashes, dashesCount, strokeStyle);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)(lpVtbl[11]))((ID2D1Factory*)Unsafe.AsPointer(ref this), strokeStyleProperties, dashes, dashesCount, strokeStyle);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateDrawingStateBlock"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateDrawingStateBlock(DrawingStateDescription* drawingStateDescription, Graphics.DirectWrite.IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Factory*, DrawingStateDescription*, Graphics.DirectWrite.IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)(lpVtbl[12]))((ID2D1Factory*)Unsafe.AsPointer(ref this), drawingStateDescription, textRenderingParams, drawingStateBlock);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, DrawingStateDescription*, Graphics.DirectWrite.IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)(lpVtbl[12]))((ID2D1Factory*)Unsafe.AsPointer(ref this), drawingStateDescription, textRenderingParams, drawingStateBlock);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateWicBitmapRenderTarget"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateWicBitmapRenderTarget(Graphics.Imaging.IWICBitmap* target, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Factory*, Graphics.Imaging.IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)(lpVtbl[13]))((ID2D1Factory*)Unsafe.AsPointer(ref this), target, renderTargetProperties, renderTarget);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Graphics.Imaging.IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)(lpVtbl[13]))((ID2D1Factory*)Unsafe.AsPointer(ref this), target, renderTargetProperties, renderTarget);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateHwndRenderTarget"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateHwndRenderTarget(RenderTargetProperties* renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Factory*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)(lpVtbl[14]))((ID2D1Factory*)Unsafe.AsPointer(ref this), renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)(lpVtbl[14]))((ID2D1Factory*)Unsafe.AsPointer(ref this), renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateDxgiSurfaceRenderTarget"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateDxgiSurfaceRenderTarget(Graphics.Dxgi.IDXGISurface* dxgiSurface, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Factory*, Graphics.Dxgi.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)(lpVtbl[15]))((ID2D1Factory*)Unsafe.AsPointer(ref this), dxgiSurface, renderTargetProperties, renderTarget);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Graphics.Dxgi.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)(lpVtbl[15]))((ID2D1Factory*)Unsafe.AsPointer(ref this), dxgiSurface, renderTargetProperties, renderTarget);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateDCRenderTarget"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateDCRenderTarget(RenderTargetProperties* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Factory*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)(lpVtbl[16]))((ID2D1Factory*)Unsafe.AsPointer(ref this), renderTargetProperties, dcRenderTarget);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)(lpVtbl[16]))((ID2D1Factory*)Unsafe.AsPointer(ref this), renderTargetProperties, dcRenderTarget);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult ReloadSystemMetrics();

		[VtblIndex(4)]
		void GetDesktopDpi(float* dpiX, float* dpiY);

		[VtblIndex(5)]
		HResult CreateRectangleGeometry(Win32.Numerics.RectF* rectangle, ID2D1RectangleGeometry** rectangleGeometry);

		[VtblIndex(6)]
		HResult CreateRoundedRectangleGeometry(RoundedRect* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry);

		[VtblIndex(7)]
		HResult CreateEllipseGeometry(Ellipse* ellipse, ID2D1EllipseGeometry** ellipseGeometry);

		[VtblIndex(8)]
		HResult CreateGeometryGroup(Common.FillMode fillMode, ID2D1Geometry** geometries, uint geometriesCount, ID2D1GeometryGroup** geometryGroup);

		[VtblIndex(9)]
		HResult CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, Matrix3x2* transform, ID2D1TransformedGeometry** transformedGeometry);

		[VtblIndex(10)]
		HResult CreatePathGeometry(ID2D1PathGeometry** pathGeometry);

		[VtblIndex(11)]
		HResult CreateStrokeStyle(StrokeStyleProperties* strokeStyleProperties, float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle);

		[VtblIndex(12)]
		HResult CreateDrawingStateBlock(DrawingStateDescription* drawingStateDescription, Graphics.DirectWrite.IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock);

		[VtblIndex(13)]
		HResult CreateWicBitmapRenderTarget(Graphics.Imaging.IWICBitmap* target, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget);

		[VtblIndex(14)]
		HResult CreateHwndRenderTarget(RenderTargetProperties* renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget);

		[VtblIndex(15)]
		HResult CreateDxgiSurfaceRenderTarget(Graphics.Dxgi.IDXGISurface* dxgiSurface, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget);

		[VtblIndex(16)]
		HResult CreateDCRenderTarget(RenderTargetProperties* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget);
	}
}

