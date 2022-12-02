// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionMatrixTransform3D"]/*' />
/// <unmanaged>IDCompositionMatrixTransform3D</unmanaged>
[Guid("4b3363f0-643b-41b7-b6e0-ccf22d34467c")]
[NativeTypeName("struct IDCompositionMatrixTransform3D : IDCompositionTransform3D")]
[NativeInheritance("IDCompositionTransform3D")]
public unsafe partial struct IDCompositionMatrixTransform3D : IDCompositionMatrixTransform3D.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDCompositionMatrixTransform3D
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xF0, 0x63, 0x33, 0x4B,
				0x3B, 0x64,
				0xB7, 0x41,
				0xB6,
				0xE0,
				0xCC,
				0xF2,
				0x2D,
				0x34,
				0x46,
				0x7C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionMatrixTransform3D));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionMatrixTransform3D));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform3D*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform3D*, uint>)(lpVtbl[1]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform3D*, uint>)(lpVtbl[2]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionMatrixTransform3D::SetMatrix"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetMatrix(Matrix4x4* matrix)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform3D*, Matrix4x4*, int>)(lpVtbl[3]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this), matrix);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionMatrixTransform3D::SetMatrixElement"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetMatrixElement(int row, int column, IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform3D*, int, int, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this), row, column, animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionMatrixTransform3D::SetMatrixElement"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetMatrixElement(int row, int column, float value)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform3D*, int, int, float, int>)(lpVtbl[5]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this), row, column, value);
	}

	public interface Interface : IDCompositionTransform3D.Interface
	{
		[VtblIndex(3)]
		HResult SetMatrix(Matrix4x4* matrix);

		[VtblIndex(4)]
		HResult SetMatrixElement(int row, int column, IDCompositionAnimation* animation);

		[VtblIndex(5)]
		HResult SetMatrixElement(int row, int column, float value);
	}
}

