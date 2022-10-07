// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12Debug3"]/*' />
/// <unmanaged>ID3D12Debug3</unmanaged>
[Guid("5cf4e58f-f671-4ff1-a542-3686e3d153d1")]
[NativeTypeName("struct ID3D12Debug3 : ID3D12Debug")]
[NativeInheritance("ID3D12Debug")]
public unsafe partial struct ID3D12Debug3 : INativeGuid
{
	public static ref readonly Guid IID_ID3D12Debug3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x8F, 0xE5, 0xF4, 0x5C,
				0x71, 0xF6,
				0xF1, 0x4F,
				0xA5,
				0x42,
				0x36,
				0x86,
				0xE3,
				0xD1,
				0x53,
				0xD1
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Debug3));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Debug3));
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

	/// <inheritdoc cref="ID3D12Debug.EnableDebugLayer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void EnableDebugLayer()
	{
		((delegate* unmanaged[Stdcall]<ID3D12Debug3*, void>)(lpVtbl[3]))((ID3D12Debug3*)Unsafe.AsPointer(ref this));
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12Debug3::SetEnableGPUBasedValidation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void SetEnableGPUBasedValidation(Bool32 Enable)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Debug3*, Bool32, void>)(lpVtbl[4]))((ID3D12Debug3*)Unsafe.AsPointer(ref this), Enable);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12Debug3::SetEnableSynchronizedCommandQueueValidation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void SetEnableSynchronizedCommandQueueValidation(Bool32 Enable)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Debug3*, Bool32, void>)(lpVtbl[5]))((ID3D12Debug3*)Unsafe.AsPointer(ref this), Enable);
	}

	/// <include file='Direct3D12.xml' path='doc/member[@name="ID3D12Debug3::SetGPUBasedValidationFlags"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public void SetGPUBasedValidationFlags(GpuBasedValidationFlags Flags)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Debug3*, GpuBasedValidationFlags, void>)(lpVtbl[6]))((ID3D12Debug3*)Unsafe.AsPointer(ref this), Flags);
	}
}

