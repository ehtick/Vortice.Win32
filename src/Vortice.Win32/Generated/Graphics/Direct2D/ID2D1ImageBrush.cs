// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ImageBrush"]/*' />
/// <unmanaged>ID2D1ImageBrush</unmanaged>
[Guid("fe9e984d-3f95-407c-b5db-cb94d4e8f87c")]
[NativeTypeName("struct ID2D1ImageBrush : ID2D1Brush")]
[NativeInheritance("ID2D1Brush")]
public unsafe partial struct ID2D1ImageBrush : INativeGuid
{
	public static ref readonly Guid IID_ID2D1ImageBrush
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x4D, 0x98, 0x9E, 0xFE,
				0x95, 0x3F,
				0x7C, 0x40,
				0xB5,
				0xDB,
				0xCB,
				0x94,
				0xD4,
				0xE8,
				0xF8,
				0x7C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ImageBrush));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ImageBrush));
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

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), factory);
	}

	/// <inheritdoc cref="ID2D1Brush.SetOpacity" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void SetOpacity(float opacity)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, float, void>)(lpVtbl[4]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), opacity);
	}

	/// <inheritdoc cref="ID2D1Brush.SetTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void SetTransform(Matrix3x2* transform)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Matrix3x2*, void>)(lpVtbl[5]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), transform);
	}

	/// <inheritdoc cref="ID2D1Brush.GetOpacity" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public float GetOpacity()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, float>)(lpVtbl[6]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Brush.GetTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetTransform(Matrix3x2* transform)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Matrix3x2*, void>)(lpVtbl[7]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), transform);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ImageBrush::SetImage"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void SetImage(ID2D1Image* image)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ID2D1Image*, void>)(lpVtbl[8]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), image);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ImageBrush::SetExtendModeX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void SetExtendModeX(ExtendMode extendModeX)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ExtendMode, void>)(lpVtbl[9]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), extendModeX);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ImageBrush::SetExtendModeY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public void SetExtendModeY(ExtendMode extendModeY)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ExtendMode, void>)(lpVtbl[10]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), extendModeY);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ImageBrush::SetInterpolationMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public void SetInterpolationMode(InterpolationMode interpolationMode)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, InterpolationMode, void>)(lpVtbl[11]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), interpolationMode);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ImageBrush::SetSourceRectangle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public void SetSourceRectangle(Common.RectF* sourceRectangle)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Common.RectF*, void>)(lpVtbl[12]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), sourceRectangle);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ImageBrush::GetImage"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public void GetImage(ID2D1Image** image)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ID2D1Image**, void>)(lpVtbl[13]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), image);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ImageBrush::GetExtendModeX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public ExtendMode GetExtendModeX()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ExtendMode>)(lpVtbl[14]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ImageBrush::GetExtendModeY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public ExtendMode GetExtendModeY()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ExtendMode>)(lpVtbl[15]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ImageBrush::GetInterpolationMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public InterpolationMode GetInterpolationMode()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, InterpolationMode>)(lpVtbl[16]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ImageBrush::GetSourceRectangle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public void GetSourceRectangle(Common.RectF* sourceRectangle)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Common.RectF*, void>)(lpVtbl[17]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), sourceRectangle);
	}
}

