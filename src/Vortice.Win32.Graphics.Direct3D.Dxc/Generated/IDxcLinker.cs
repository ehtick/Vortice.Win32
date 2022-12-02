// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D.Dxc;

/// <unmanaged>IDxcLinker</unmanaged>
[Guid("f1b5be2a-62dd-4327-a1c2-42ac1e1e78e6")]
[NativeTypeName("struct IDxcLinker : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcLinker : IDxcLinker.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDxcLinker
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x2A, 0xBE, 0xB5, 0xF1,
				0xDD, 0x62,
				0x27, 0x43,
				0xA1,
				0xC2,
				0x42,
				0xAC,
				0x1E,
				0x1E,
				0x78,
				0xE6
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcLinker));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcLinker));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcLinker*, Guid*, void**, int>)(lpVtbl[0]))((IDxcLinker*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcLinker*, uint>)(lpVtbl[1]))((IDxcLinker*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcLinker*, uint>)(lpVtbl[2]))((IDxcLinker*)Unsafe.AsPointer(ref this));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult RegisterLibrary(ushort* pLibName, IDxcBlob* pLib)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcLinker*, ushort*, IDxcBlob*, int>)(lpVtbl[3]))((IDxcLinker*)Unsafe.AsPointer(ref this), pLibName, pLib);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult Link(ushort* pEntryName, ushort* pTargetProfile, ushort** pLibNames, uint libCount, ushort** pArguments, uint argCount, IDxcOperationResult** ppResult)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcLinker*, ushort*, ushort*, ushort**, uint, ushort**, uint, IDxcOperationResult**, int>)(lpVtbl[4]))((IDxcLinker*)Unsafe.AsPointer(ref this), pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult RegisterLibrary(ushort* pLibName, IDxcBlob* pLib);

		[VtblIndex(4)]
		HResult Link(ushort* pEntryName, ushort* pTargetProfile, ushort** pLibNames, uint libCount, ushort** pArguments, uint argCount, IDxcOperationResult** ppResult);
	}
}

