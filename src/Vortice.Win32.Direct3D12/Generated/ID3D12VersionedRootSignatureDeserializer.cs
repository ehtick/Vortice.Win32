// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12VersionedRootSignatureDeserializer"]/*' />
/// <unmanaged>ID3D12VersionedRootSignatureDeserializer</unmanaged>
[Guid("7f91ce67-090c-4bb7-b78e-ed8ff2e31da0")]
[NativeTypeName("struct ID3D12VersionedRootSignatureDeserializer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12VersionedRootSignatureDeserializer : INativeGuid
{
	public static ref readonly Guid IID_ID3D12VersionedRootSignatureDeserializer
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x67, 0xCE, 0x91, 0x7F,
				0x0C, 0x09,
				0xB7, 0x4B,
				0xB7,
				0x8E,
				0xED,
				0x8F,
				0xF2,
				0xE3,
				0x1D,
				0xA0
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12VersionedRootSignatureDeserializer));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12VersionedRootSignatureDeserializer));
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

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12VersionedRootSignatureDeserializer::GetRootSignatureDescAtVersion"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetRootSignatureDescAtVersion(RootSignatureVersion convertToVersion, VersionedRootSignatureDescription** ppDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12VersionedRootSignatureDeserializer*, RootSignatureVersion, VersionedRootSignatureDescription**, int>)(lpVtbl[3]))((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this), convertToVersion, ppDesc);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12VersionedRootSignatureDeserializer::GetUnconvertedRootSignatureDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public VersionedRootSignatureDescription* GetUnconvertedRootSignatureDesc()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12VersionedRootSignatureDeserializer*, VersionedRootSignatureDescription*>)(lpVtbl[4]))((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this));
	}
}

