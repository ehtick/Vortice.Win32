// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D.Dxc;

/// <include file='../Direct3D.xml' path='doc/member[@name="IDxcBlobEncoding"]/*' />
/// <unmanaged>IDxcBlobEncoding</unmanaged>
[Guid("7241d424-2646-4191-97c0-98e96e42fc68")]
[NativeTypeName("struct IDxcBlobEncoding : IDxcBlob")]
[NativeInheritance("IDxcBlob")]
public unsafe partial struct IDxcBlobEncoding : INativeGuid
{
	public static ref readonly Guid IID_IDxcBlobEncoding
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x24, 0xD4, 0x41, 0x72,
				0x46, 0x26,
				0x91, 0x41,
				0x97,
				0xC0,
				0x98,
				0xE9,
				0x6E,
				0x42,
				0xFC,
				0x68
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcBlobEncoding));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcBlobEncoding));
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

	/// <inheritdoc cref="IDxcBlob.GetBufferPointer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void* GetBufferPointer()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcBlobEncoding*, void*>)(lpVtbl[3]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDxcBlob.GetBufferSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public nuint GetBufferSize()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcBlobEncoding*, nuint>)(lpVtbl[4]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D.xml' path='doc/member[@name="IDxcBlobEncoding::GetEncoding"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetEncoding(Bool32* pKnown, DxcCp* pCodePage)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcBlobEncoding*, Bool32*, DxcCp*, int>)(lpVtbl[5]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this), pKnown, pCodePage);
	}
}

