// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D;

/// <include file='../Direct3D.xml' path='doc/member[@name="ID3DDestructionNotifier"]/*' />
/// <unmanaged>ID3DDestructionNotifier</unmanaged>
[Guid("a06eb39a-50da-425b-8c31-4eecd6c270f3")]
[NativeTypeName("struct ID3DDestructionNotifier : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3DDestructionNotifier : ID3DDestructionNotifier.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3DDestructionNotifier
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x9A, 0xB3, 0x6E, 0xA0,
				0xDA, 0x50,
				0x5B, 0x42,
				0x8C,
				0x31,
				0x4E,
				0xEC,
				0xD6,
				0xC2,
				0x70,
				0xF3
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3DDestructionNotifier));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3DDestructionNotifier));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3DDestructionNotifier*, Guid*, void**, int>)(lpVtbl[0]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, int>)(lpVtbl[0]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3DDestructionNotifier*, uint>)(lpVtbl[1]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint>)(lpVtbl[1]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3DDestructionNotifier*, uint>)(lpVtbl[2]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint>)(lpVtbl[2]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct3D.xml' path='doc/member[@name="ID3DDestructionNotifier::RegisterDestructionCallback"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult RegisterDestructionCallback(delegate* unmanaged[Stdcall]<void*, void> callbackFn, void* pData, uint* pCallbackID)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3DDestructionNotifier*, delegate* unmanaged[Stdcall]<void*, void>, void*, uint*, int>)(lpVtbl[3]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackFn, pData, pCallbackID);
#else
		return ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, delegate* unmanaged[Stdcall]<void*, void>, void*, uint*, int>)(lpVtbl[3]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackFn, pData, pCallbackID);
#endif
	}

	/// <include file='../Direct3D.xml' path='doc/member[@name="ID3DDestructionNotifier::UnregisterDestructionCallback"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult UnregisterDestructionCallback(uint callbackID)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3DDestructionNotifier*, uint, int>)(lpVtbl[4]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackID);
#else
		return ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint, int>)(lpVtbl[4]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackID);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult RegisterDestructionCallback(delegate* unmanaged[Stdcall]<void*, void> callbackFn, void* pData, uint* pCallbackID);

		[VtblIndex(4)]
		HResult UnregisterDestructionCallback(uint callbackID);
	}
}

