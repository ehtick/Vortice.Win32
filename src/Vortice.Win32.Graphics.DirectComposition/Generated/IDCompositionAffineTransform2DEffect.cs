// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionAffineTransform2DEffect"]/*' />
/// <unmanaged>IDCompositionAffineTransform2DEffect</unmanaged>
[Guid("0b74b9e8-cdd6-492f-bbbc-5ed32157026d")]
[NativeTypeName("struct IDCompositionAffineTransform2DEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionAffineTransform2DEffect : IDCompositionAffineTransform2DEffect.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDCompositionAffineTransform2DEffect
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xE8, 0xB9, 0x74, 0x0B,
				0xD6, 0xCD,
				0x2F, 0x49,
				0xBB,
				0xBC,
				0x5E,
				0xD3,
				0x21,
				0x57,
				0x02,
				0x6D
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionAffineTransform2DEffect));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionAffineTransform2DEffect));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, uint>)(lpVtbl[1]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, uint>)(lpVtbl[2]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionFilterEffect.SetInput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetInput(uint index, IUnknown* input, uint flags)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), index, input, flags);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionAffineTransform2DEffect::SetInterpolationMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetInterpolationMode(Graphics.Direct2D.Common.AffineTransform2DInterpolationMode interpolationMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, Graphics.Direct2D.Common.AffineTransform2DInterpolationMode, int>)(lpVtbl[4]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), interpolationMode);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionAffineTransform2DEffect::SetBorderMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetBorderMode(Graphics.Direct2D.Common.BorderMode borderMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, Graphics.Direct2D.Common.BorderMode, int>)(lpVtbl[5]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), borderMode);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionAffineTransform2DEffect::SetTransformMatrix"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetTransformMatrix(Matrix3x2* transformMatrix)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, Matrix3x2*, int>)(lpVtbl[6]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), transformMatrix);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionAffineTransform2DEffect::SetTransformMatrixElement"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetTransformMatrixElement(int row, int column, IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, int, int, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), row, column, animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionAffineTransform2DEffect::SetTransformMatrixElement"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetTransformMatrixElement(int row, int column, float value)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, int, int, float, int>)(lpVtbl[8]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), row, column, value);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionAffineTransform2DEffect::SetSharpness"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetSharpness(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionAffineTransform2DEffect::SetSharpness"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetSharpness(float sharpness)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, float, int>)(lpVtbl[10]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), sharpness);
	}

	public interface Interface : IDCompositionFilterEffect.Interface
	{
		[VtblIndex(4)]
		HResult SetInterpolationMode(Graphics.Direct2D.Common.AffineTransform2DInterpolationMode interpolationMode);

		[VtblIndex(5)]
		HResult SetBorderMode(Graphics.Direct2D.Common.BorderMode borderMode);

		[VtblIndex(6)]
		HResult SetTransformMatrix(Matrix3x2* transformMatrix);

		[VtblIndex(7)]
		HResult SetTransformMatrixElement(int row, int column, IDCompositionAnimation* animation);

		[VtblIndex(8)]
		HResult SetTransformMatrixElement(int row, int column, float value);

		[VtblIndex(9)]
		HResult SetSharpness(IDCompositionAnimation* animation);

		[VtblIndex(10)]
		HResult SetSharpness(float sharpness);
	}
}

