// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D.Dxc;

/// <unmanaged>IDxcVersionInfo3</unmanaged>
[Guid("5e13e843-9d25-473c-9ad2-03b2d0b44b1e")]
[NativeTypeName("struct IDxcVersionInfo3 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcVersionInfo3 : IDxcVersionInfo3.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDxcVersionInfo3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x43, 0xE8, 0x13, 0x5E,
				0x25, 0x9D,
				0x3C, 0x47,
				0x9A,
				0xD2,
				0x03,
				0xB2,
				0xD0,
				0xB4,
				0x4B,
				0x1E
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcVersionInfo3));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcVersionInfo3));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDxcVersionInfo3*, Guid*, void**, int>)(lpVtbl[0]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo3*, Guid*, void**, int>)(lpVtbl[0]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDxcVersionInfo3*, uint>)(lpVtbl[1]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo3*, uint>)(lpVtbl[1]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDxcVersionInfo3*, uint>)(lpVtbl[2]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo3*, uint>)(lpVtbl[2]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this));
#endif
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetCustomVersionString(sbyte** pVersionString)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDxcVersionInfo3*, sbyte**, int>)(lpVtbl[3]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this), pVersionString);
#else
		return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo3*, sbyte**, int>)(lpVtbl[3]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this), pVersionString);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult GetCustomVersionString(sbyte** pVersionString);
	}
}

