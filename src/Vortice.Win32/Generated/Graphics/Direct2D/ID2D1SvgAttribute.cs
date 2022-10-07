// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgAttribute"]/*' />
/// <unmanaged>ID2D1SvgAttribute</unmanaged>
[Guid("c9cdb0dd-f8c9-4e70-b7c2-301c80292c5e")]
[NativeTypeName("struct ID2D1SvgAttribute : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1SvgAttribute : INativeGuid
{
	public static ref readonly Guid IID_ID2D1SvgAttribute
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xDD, 0xB0, 0xCD, 0xC9,
				0xC9, 0xF8,
				0x70, 0x4E,
				0xB7,
				0xC2,
				0x30,
				0x1C,
				0x80,
				0x29,
				0x2C,
				0x5E
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgAttribute));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgAttribute));
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
		((delegate* unmanaged[Stdcall]<ID2D1SvgAttribute*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgAttribute*)Unsafe.AsPointer(ref this), factory);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgAttribute::GetElement"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void GetElement(ID2D1SvgElement** element)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SvgAttribute*, ID2D1SvgElement**, void>)(lpVtbl[4]))((ID2D1SvgAttribute*)Unsafe.AsPointer(ref this), element);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgAttribute::Clone"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult Clone(ID2D1SvgAttribute** attribute)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgAttribute*, ID2D1SvgAttribute**, int>)(lpVtbl[5]))((ID2D1SvgAttribute*)Unsafe.AsPointer(ref this), attribute);
	}
}

