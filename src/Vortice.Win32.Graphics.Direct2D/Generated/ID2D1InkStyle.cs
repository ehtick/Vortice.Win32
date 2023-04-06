// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1InkStyle"]/*' />
/// <unmanaged>ID2D1InkStyle</unmanaged>
[Guid("bae8b344-23fc-4071-8cb5-d05d6f073848")]
[NativeTypeName("struct ID2D1InkStyle : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1InkStyle : ID2D1InkStyle.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1InkStyle
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x44, 0xB3, 0xE8, 0xBA,
				0xFC, 0x23,
				0x71, 0x40,
				0x8C,
				0xB5,
				0xD0,
				0x5D,
				0x6F,
				0x07,
				0x38,
				0x48
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1InkStyle));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1InkStyle));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1InkStyle*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1InkStyle*, uint>)(lpVtbl[1]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, uint>)(lpVtbl[1]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1InkStyle*, uint>)(lpVtbl[2]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, uint>)(lpVtbl[2]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1InkStyle*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), factory);
#else
		((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), factory);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1InkStyle::SetNibTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void SetNibTransform(Matrix3x2* transform)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1InkStyle*, Matrix3x2*, void>)(lpVtbl[4]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), transform);
#else
		((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, Matrix3x2*, void>)(lpVtbl[4]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), transform);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1InkStyle::GetNibTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void GetNibTransform(Matrix3x2* transform)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1InkStyle*, Matrix3x2*, void>)(lpVtbl[5]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), transform);
#else
		((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, Matrix3x2*, void>)(lpVtbl[5]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), transform);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1InkStyle::SetNibShape"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public void SetNibShape(InkNibShape nibShape)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1InkStyle*, InkNibShape, void>)(lpVtbl[6]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), nibShape);
#else
		((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, InkNibShape, void>)(lpVtbl[6]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), nibShape);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1InkStyle::GetNibShape"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public InkNibShape GetNibShape()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1InkStyle*, InkNibShape>)(lpVtbl[7]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1InkStyle*, InkNibShape>)(lpVtbl[7]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
#endif
	}

	public interface Interface : ID2D1Resource.Interface
	{
		[VtblIndex(4)]
		void SetNibTransform(Matrix3x2* transform);

		[VtblIndex(5)]
		void GetNibTransform(Matrix3x2* transform);

		[VtblIndex(6)]
		void SetNibShape(InkNibShape nibShape);

		[VtblIndex(7)]
		InkNibShape GetNibShape();
	}
}

