// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DebugCommandList2"]/*' />
/// <unmanaged>ID3D12DebugCommandList2</unmanaged>
[Guid("aeb575cf-4e06-48be-ba3b-c450fc96652e")]
[NativeTypeName("struct ID3D12DebugCommandList2 : ID3D12DebugCommandList")]
[NativeInheritance("ID3D12DebugCommandList")]
public unsafe partial struct ID3D12DebugCommandList2 : ID3D12DebugCommandList2.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12DebugCommandList2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xCF, 0x75, 0xB5, 0xAE,
				0x06, 0x4E,
				0xBE, 0x48,
				0xBA,
				0x3B,
				0xC4,
				0x50,
				0xFC,
				0x96,
				0x65,
				0x2E
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugCommandList2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugCommandList2));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandList2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandList2*, uint>)(lpVtbl[1]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList2*, uint>)(lpVtbl[1]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandList2*, uint>)(lpVtbl[2]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList2*, uint>)(lpVtbl[2]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D12DebugCommandList.AssertResourceState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public Bool32 AssertResourceState(ID3D12Resource* pResource, uint Subresource, uint State)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandList2*, ID3D12Resource*, uint, uint, Bool32>)(lpVtbl[3]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), pResource, Subresource, State);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList2*, ID3D12Resource*, uint, uint, Bool32>)(lpVtbl[3]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), pResource, Subresource, State);
#endif
	}

	/// <inheritdoc cref="ID3D12DebugCommandList.SetFeatureMask" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetFeatureMask(DebugFeature Mask)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandList2*, DebugFeature, int>)(lpVtbl[4]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), Mask);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList2*, DebugFeature, int>)(lpVtbl[4]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), Mask);
#endif
	}

	/// <inheritdoc cref="ID3D12DebugCommandList.GetFeatureMask" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public DebugFeature GetFeatureMask()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandList2*, DebugFeature>)(lpVtbl[5]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList2*, DebugFeature>)(lpVtbl[5]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DebugCommandList2::SetDebugParameter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetDebugParameter(DebugCommandListParameterType Type, void* pData, uint DataSize)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandList2*, DebugCommandListParameterType, void*, uint, int>)(lpVtbl[6]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList2*, DebugCommandListParameterType, void*, uint, int>)(lpVtbl[6]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DebugCommandList2::GetDebugParameter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDebugParameter(DebugCommandListParameterType Type, void* pData, uint DataSize)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandList2*, DebugCommandListParameterType, void*, uint, int>)(lpVtbl[7]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList2*, DebugCommandListParameterType, void*, uint, int>)(lpVtbl[7]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
#endif
	}

	public interface Interface : ID3D12DebugCommandList.Interface
	{
		[VtblIndex(6)]
		HResult SetDebugParameter(DebugCommandListParameterType Type, void* pData, uint DataSize);

		[VtblIndex(7)]
		HResult GetDebugParameter(DebugCommandListParameterType Type, void* pData, uint DataSize);
	}
}

