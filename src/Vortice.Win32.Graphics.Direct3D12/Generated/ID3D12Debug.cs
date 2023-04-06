// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Debug"]/*' />
/// <unmanaged>ID3D12Debug</unmanaged>
[Guid("344488b7-6846-474b-b989-f027448245e0")]
[NativeTypeName("struct ID3D12Debug : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12Debug : ID3D12Debug.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12Debug
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xB7, 0x88, 0x44, 0x34,
				0x46, 0x68,
				0x4B, 0x47,
				0xB9,
				0x89,
				0xF0,
				0x27,
				0x44,
				0x82,
				0x45,
				0xE0
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Debug));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Debug));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Debug*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Debug*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Debug*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Debug*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Debug*, uint>)(lpVtbl[1]))((ID3D12Debug*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Debug*, uint>)(lpVtbl[1]))((ID3D12Debug*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Debug*, uint>)(lpVtbl[2]))((ID3D12Debug*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Debug*, uint>)(lpVtbl[2]))((ID3D12Debug*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Debug::EnableDebugLayer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void EnableDebugLayer()
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D12Debug*, void>)(lpVtbl[3]))((ID3D12Debug*)Unsafe.AsPointer(ref this));
#else
		((delegate* unmanaged[Stdcall]<ID3D12Debug*, void>)(lpVtbl[3]))((ID3D12Debug*)Unsafe.AsPointer(ref this));
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		void EnableDebugLayer();
	}
}

