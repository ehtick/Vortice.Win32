// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DebugCommandList"]/*' />
/// <unmanaged>ID3D12DebugCommandList</unmanaged>
[Guid("09e0bf36-54ac-484f-8847-4baeeab6053f")]
[NativeTypeName("struct ID3D12DebugCommandList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DebugCommandList : INativeGuid
{
	public static ref readonly Guid IID_ID3D12DebugCommandList
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x36, 0xBF, 0xE0, 0x09,
				0xAC, 0x54,
				0x4F, 0x48,
				0x88,
				0x47,
				0x4B,
				0xAE,
				0xEA,
				0xB6,
				0x05,
				0x3F
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugCommandList));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugCommandList));
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

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DebugCommandList::AssertResourceState"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public Bool32 AssertResourceState(ID3D12Resource* pResource, uint Subresource, uint State)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList*, ID3D12Resource*, uint, uint, Bool32>)(lpVtbl[3]))((ID3D12DebugCommandList*)Unsafe.AsPointer(ref this), pResource, Subresource, State);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DebugCommandList::SetFeatureMask"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetFeatureMask(DebugFeature Mask)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList*, DebugFeature, int>)(lpVtbl[4]))((ID3D12DebugCommandList*)Unsafe.AsPointer(ref this), Mask);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DebugCommandList::GetFeatureMask"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public DebugFeature GetFeatureMask()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList*, DebugFeature>)(lpVtbl[5]))((ID3D12DebugCommandList*)Unsafe.AsPointer(ref this));
	}
}

