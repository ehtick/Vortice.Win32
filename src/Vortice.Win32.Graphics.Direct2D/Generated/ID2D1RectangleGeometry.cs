// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RectangleGeometry"]/*' />
/// <unmanaged>ID2D1RectangleGeometry</unmanaged>
[Guid("2cd906a2-12e2-11dc-9fed-001143a055f9")]
[NativeTypeName("struct ID2D1RectangleGeometry : ID2D1Geometry")]
[NativeInheritance("ID2D1Geometry")]
public unsafe partial struct ID2D1RectangleGeometry : ID2D1RectangleGeometry.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1RectangleGeometry
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xA2, 0x06, 0xD9, 0x2C,
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

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1RectangleGeometry));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1RectangleGeometry));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1RectangleGeometry*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1RectangleGeometry*, uint>)(lpVtbl[1]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, uint>)(lpVtbl[1]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1RectangleGeometry*, uint>)(lpVtbl[2]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, uint>)(lpVtbl[2]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1RectangleGeometry*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), factory);
#else
		((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), factory);
#endif
	}

	/// <inheritdoc cref="ID2D1Geometry.GetBounds" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetBounds(Matrix3x2* worldTransform, Win32.Numerics.RectF** bounds)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1RectangleGeometry*, Matrix3x2*, Win32.Numerics.RectF**, int>)(lpVtbl[4]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), worldTransform, bounds);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, Matrix3x2*, Win32.Numerics.RectF**, int>)(lpVtbl[4]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), worldTransform, bounds);
#endif
	}

	/// <inheritdoc cref="ID2D1Geometry.GetWidenedBounds" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetWidenedBounds(float strokeWidth, ID2D1StrokeStyle* strokeStyle, Matrix3x2* worldTransform, float flatteningTolerance, Win32.Numerics.RectF** bounds)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1RectangleGeometry*, float, ID2D1StrokeStyle*, Matrix3x2*, float, Win32.Numerics.RectF**, int>)(lpVtbl[5]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), strokeWidth, strokeStyle, worldTransform, flatteningTolerance, bounds);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, float, ID2D1StrokeStyle*, Matrix3x2*, float, Win32.Numerics.RectF**, int>)(lpVtbl[5]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), strokeWidth, strokeStyle, worldTransform, flatteningTolerance, bounds);
#endif
	}

	/// <inheritdoc cref="ID2D1Geometry.StrokeContainsPoint" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult StrokeContainsPoint(Vector2 point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, Matrix3x2* worldTransform, float flatteningTolerance, Bool32* contains)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1RectangleGeometry*, Vector2, float, ID2D1StrokeStyle*, Matrix3x2*, float, Bool32*, int>)(lpVtbl[6]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, contains);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, Vector2, float, ID2D1StrokeStyle*, Matrix3x2*, float, Bool32*, int>)(lpVtbl[6]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, contains);
#endif
	}

	/// <inheritdoc cref="ID2D1Geometry.FillContainsPoint" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult FillContainsPoint(Vector2 point, Matrix3x2* worldTransform, float flatteningTolerance, Bool32* contains)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1RectangleGeometry*, Vector2, Matrix3x2*, float, Bool32*, int>)(lpVtbl[7]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), point, worldTransform, flatteningTolerance, contains);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, Vector2, Matrix3x2*, float, Bool32*, int>)(lpVtbl[7]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), point, worldTransform, flatteningTolerance, contains);
#endif
	}

	/// <inheritdoc cref="ID2D1Geometry.CompareWithGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CompareWithGeometry(ID2D1Geometry* inputGeometry, Matrix3x2* inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1RectangleGeometry*, ID2D1Geometry*, Matrix3x2*, float, GeometryRelation*, int>)(lpVtbl[8]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), inputGeometry, inputGeometryTransform, flatteningTolerance, relation);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, ID2D1Geometry*, Matrix3x2*, float, GeometryRelation*, int>)(lpVtbl[8]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), inputGeometry, inputGeometryTransform, flatteningTolerance, relation);
#endif
	}

	/// <inheritdoc cref="ID2D1Geometry.Simplify" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult Simplify(GeometrySimplificationOption simplificationOption, Matrix3x2* worldTransform, float flatteningTolerance, Common.ID2D1SimplifiedGeometrySink* geometrySink)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1RectangleGeometry*, GeometrySimplificationOption, Matrix3x2*, float, Common.ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[9]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), simplificationOption, worldTransform, flatteningTolerance, geometrySink);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, GeometrySimplificationOption, Matrix3x2*, float, Common.ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[9]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), simplificationOption, worldTransform, flatteningTolerance, geometrySink);
#endif
	}

	/// <inheritdoc cref="ID2D1Geometry.Tessellate" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult Tessellate(Matrix3x2* worldTransform, float flatteningTolerance, ID2D1TessellationSink* tessellationSink)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1RectangleGeometry*, Matrix3x2*, float, ID2D1TessellationSink*, int>)(lpVtbl[10]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, tessellationSink);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, Matrix3x2*, float, ID2D1TessellationSink*, int>)(lpVtbl[10]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, tessellationSink);
#endif
	}

	/// <inheritdoc cref="ID2D1Geometry.CombineWithGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CombineWithGeometry(ID2D1Geometry* inputGeometry, CombineMode combineMode, Matrix3x2* inputGeometryTransform, float flatteningTolerance, Common.ID2D1SimplifiedGeometrySink* geometrySink)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1RectangleGeometry*, ID2D1Geometry*, CombineMode, Matrix3x2*, float, Common.ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[11]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, ID2D1Geometry*, CombineMode, Matrix3x2*, float, Common.ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[11]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
#endif
	}

	/// <inheritdoc cref="ID2D1Geometry.Outline" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult Outline(Matrix3x2* worldTransform, float flatteningTolerance, Common.ID2D1SimplifiedGeometrySink* geometrySink)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1RectangleGeometry*, Matrix3x2*, float, Common.ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[12]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, geometrySink);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, Matrix3x2*, float, Common.ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[12]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, geometrySink);
#endif
	}

	/// <inheritdoc cref="ID2D1Geometry.ComputeArea" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult ComputeArea(Matrix3x2* worldTransform, float flatteningTolerance, float* area)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1RectangleGeometry*, Matrix3x2*, float, float*, int>)(lpVtbl[13]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, area);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, Matrix3x2*, float, float*, int>)(lpVtbl[13]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, area);
#endif
	}

	/// <inheritdoc cref="ID2D1Geometry.ComputeLength" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult ComputeLength(Matrix3x2* worldTransform, float flatteningTolerance, float* length)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1RectangleGeometry*, Matrix3x2*, float, float*, int>)(lpVtbl[14]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, length);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, Matrix3x2*, float, float*, int>)(lpVtbl[14]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, length);
#endif
	}

	/// <inheritdoc cref="ID2D1Geometry.ComputePointAtLength" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult ComputePointAtLength(float length, Matrix3x2* worldTransform, float flatteningTolerance, Vector2* point, Vector2* unitTangentVector)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1RectangleGeometry*, float, Matrix3x2*, float, Vector2*, Vector2*, int>)(lpVtbl[15]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), length, worldTransform, flatteningTolerance, point, unitTangentVector);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, float, Matrix3x2*, float, Vector2*, Vector2*, int>)(lpVtbl[15]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), length, worldTransform, flatteningTolerance, point, unitTangentVector);
#endif
	}

	/// <inheritdoc cref="ID2D1Geometry.Widen" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult Widen(float strokeWidth, ID2D1StrokeStyle* strokeStyle, Matrix3x2* worldTransform, float flatteningTolerance, Common.ID2D1SimplifiedGeometrySink* geometrySink)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1RectangleGeometry*, float, ID2D1StrokeStyle*, Matrix3x2*, float, Common.ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[16]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), strokeWidth, strokeStyle, worldTransform, flatteningTolerance, geometrySink);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, float, ID2D1StrokeStyle*, Matrix3x2*, float, Common.ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[16]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), strokeWidth, strokeStyle, worldTransform, flatteningTolerance, geometrySink);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RectangleGeometry::GetRect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public void GetRect(Win32.Numerics.RectF** rect)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1RectangleGeometry*, Win32.Numerics.RectF**, void>)(lpVtbl[17]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), rect);
#else
		((delegate* unmanaged[Stdcall]<ID2D1RectangleGeometry*, Win32.Numerics.RectF**, void>)(lpVtbl[17]))((ID2D1RectangleGeometry*)Unsafe.AsPointer(ref this), rect);
#endif
	}

	public interface Interface : ID2D1Geometry.Interface
	{
		[VtblIndex(17)]
		void GetRect(Win32.Numerics.RectF** rect);
	}
}

