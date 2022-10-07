// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12DebugDevice2"]/*' />
/// <unmanaged>ID3D12DebugDevice2</unmanaged>
[Guid("60eccbc1-378d-4df1-894c-f8ac5ce4d7dd")]
[NativeTypeName("struct ID3D12DebugDevice2 : ID3D12DebugDevice")]
[NativeInheritance("ID3D12DebugDevice")]
public unsafe partial struct ID3D12DebugDevice2 : INativeGuid
{
	public static ref readonly Guid IID_ID3D12DebugDevice2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xC1, 0xCB, 0xEC, 0x60,
				0x8D, 0x37,
				0xF1, 0x4D,
				0x89,
				0x4C,
				0xF8,
				0xAC,
				0x5C,
				0xE4,
				0xD7,
				0xDD
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugDevice2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugDevice2));
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

	/// <inheritdoc cref="ID3D12DebugDevice.SetFeatureMask" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetFeatureMask(DebugFeature Mask)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, DebugFeature, int>)(lpVtbl[3]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this), Mask);
	}

	/// <inheritdoc cref="ID3D12DebugDevice.GetFeatureMask" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public DebugFeature GetFeatureMask()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, DebugFeature>)(lpVtbl[4]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12DebugDevice.ReportLiveDeviceObjects" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult ReportLiveDeviceObjects(ReportLiveDeviceObjectFlags Flags)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, ReportLiveDeviceObjectFlags, int>)(lpVtbl[5]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this), Flags);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12DebugDevice2::SetDebugParameter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetDebugParameter(DebugDeviceParameterType Type, void* pData, uint DataSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, DebugDeviceParameterType, void*, uint, int>)(lpVtbl[6]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12DebugDevice2::GetDebugParameter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDebugParameter(DebugDeviceParameterType Type, void* pData, uint DataSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice2*, DebugDeviceParameterType, void*, uint, int>)(lpVtbl[7]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
	}
}

