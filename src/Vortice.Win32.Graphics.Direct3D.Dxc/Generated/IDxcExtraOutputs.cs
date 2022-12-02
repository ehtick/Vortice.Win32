// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D.Dxc;

/// <unmanaged>IDxcExtraOutputs</unmanaged>
[Guid("319b37a2-a5c2-494a-a5de-4801b2faf989")]
[NativeTypeName("struct IDxcExtraOutputs : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcExtraOutputs : IDxcExtraOutputs.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDxcExtraOutputs
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xA2, 0x37, 0x9B, 0x31,
				0xC2, 0xA5,
				0x4A, 0x49,
				0xA5,
				0xDE,
				0x48,
				0x01,
				0xB2,
				0xFA,
				0xF9,
				0x89
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcExtraOutputs));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcExtraOutputs));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, Guid*, void**, int>)(lpVtbl[0]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint>)(lpVtbl[1]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint>)(lpVtbl[2]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetOutputCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint>)(lpVtbl[3]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetOutput(uint uIndex, Guid* iid, void** ppvObject, IDxcBlobUtf16** ppOutputType, IDxcBlobUtf16** ppOutputName)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)(lpVtbl[4]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this), uIndex, iid, ppvObject, ppOutputType, ppOutputName);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		uint GetOutputCount();

		[VtblIndex(4)]
		HResult GetOutput(uint uIndex, Guid* iid, void** ppvObject, IDxcBlobUtf16** ppOutputType, IDxcBlobUtf16** ppOutputName);
	}
}

