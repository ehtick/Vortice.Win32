// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D.Dxc;

/// <unmanaged>IDxcCompilerArgs</unmanaged>
[Guid("73effe2a-70dc-45f8-9690-eff64c02429d")]
[NativeTypeName("struct IDxcCompilerArgs : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcCompilerArgs : IDxcCompilerArgs.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDxcCompilerArgs
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x2A, 0xFE, 0xEF, 0x73,
				0xDC, 0x70,
				0xF8, 0x45,
				0x96,
				0x90,
				0xEF,
				0xF6,
				0x4C,
				0x02,
				0x42,
				0x9D
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcCompilerArgs));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcCompilerArgs));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Guid*, void**, int>)(lpVtbl[0]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint>)(lpVtbl[1]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint>)(lpVtbl[2]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public ushort** GetArguments()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, ushort**>)(lpVtbl[3]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public uint GetCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint>)(lpVtbl[4]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult AddArguments(ushort** pArguments, uint argCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, ushort**, uint, int>)(lpVtbl[5]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pArguments, argCount);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult AddArgumentsUTF8(sbyte** pArguments, uint argCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, sbyte**, uint, int>)(lpVtbl[6]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pArguments, argCount);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult AddDefines(DxcDefine* pDefines, uint defineCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, DxcDefine*, uint, int>)(lpVtbl[7]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pDefines, defineCount);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		ushort** GetArguments();

		[VtblIndex(4)]
		uint GetCount();

		[VtblIndex(5)]
		HResult AddArguments(ushort** pArguments, uint argCount);

		[VtblIndex(6)]
		HResult AddArgumentsUTF8(sbyte** pArguments, uint argCount);

		[VtblIndex(7)]
		HResult AddDefines(DxcDefine* pDefines, uint defineCount);
	}
}

