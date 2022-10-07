// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1GradientMesh"]/*' />
/// <unmanaged>ID2D1GradientMesh</unmanaged>
[Guid("f292e401-c050-4cde-83d7-04962d3b23c2")]
[NativeTypeName("struct ID2D1GradientMesh : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1GradientMesh : INativeGuid
{
	public static ref readonly Guid IID_ID2D1GradientMesh
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x01, 0xE4, 0x92, 0xF2,
				0x50, 0xC0,
				0xDE, 0x4C,
				0x83,
				0xD7,
				0x04,
				0x96,
				0x2D,
				0x3B,
				0x23,
				0xC2
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GradientMesh));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GradientMesh));
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

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GradientMesh*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this), factory);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1GradientMesh::GetPatchCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public uint GetPatchCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GradientMesh*, uint>)(lpVtbl[4]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1GradientMesh::GetPatches"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPatches(uint startIndex, GradientMeshPatch* patches, uint patchesCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GradientMesh*, uint, GradientMeshPatch*, uint, int>)(lpVtbl[5]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this), startIndex, patches, patchesCount);
	}
}

