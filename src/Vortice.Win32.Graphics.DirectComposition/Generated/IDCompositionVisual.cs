// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual"]/*' />
/// <unmanaged>IDCompositionVisual</unmanaged>
[Guid("4d93059d-097b-4651-9a60-f0f25116e2f3")]
[NativeTypeName("struct IDCompositionVisual : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDCompositionVisual : IDCompositionVisual.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDCompositionVisual
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x9D, 0x05, 0x93, 0x4D,
				0x7B, 0x09,
				0x51, 0x46,
				0x9A,
				0x60,
				0xF0,
				0xF2,
				0x51,
				0x16,
				0xE2,
				0xF3
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionVisual));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionVisual));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, uint>)(lpVtbl[1]))((IDCompositionVisual*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, uint>)(lpVtbl[2]))((IDCompositionVisual*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::SetOffsetX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetOffsetX(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::SetOffsetX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetOffsetX(float offsetX)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, float, int>)(lpVtbl[4]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), offsetX);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::SetOffsetY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetOffsetY(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::SetOffsetY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetOffsetY(float offsetY)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, float, int>)(lpVtbl[6]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), offsetY);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::SetTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetTransform(IDCompositionTransform* transform)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionTransform*, int>)(lpVtbl[7]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), transform);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::SetTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetTransform(Matrix3x2* matrix)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Matrix3x2*, int>)(lpVtbl[8]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), matrix);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::SetTransformParent"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetTransformParent(IDCompositionVisual* visual)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, int>)(lpVtbl[9]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), visual);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::SetEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetEffect(IDCompositionEffect* effect)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionEffect*, int>)(lpVtbl[10]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), effect);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::SetBitmapInterpolationMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult SetBitmapInterpolationMode(BitmapInterpolationMode interpolationMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, BitmapInterpolationMode, int>)(lpVtbl[11]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), interpolationMode);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::SetBorderMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult SetBorderMode(BorderMode borderMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, BorderMode, int>)(lpVtbl[12]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), borderMode);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::SetClip"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult SetClip(IDCompositionClip* clip)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionClip*, int>)(lpVtbl[13]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), clip);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::SetClip"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult SetClip(Graphics.Direct2D.Common.RectF* rect)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Graphics.Direct2D.Common.RectF*, int>)(lpVtbl[14]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), rect);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::SetContent"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult SetContent(IUnknown* content)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IUnknown*, int>)(lpVtbl[15]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), content);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::AddVisual"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult AddVisual(IDCompositionVisual* visual, Bool32 insertAbove, IDCompositionVisual* referenceVisual)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, Bool32, IDCompositionVisual*, int>)(lpVtbl[16]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), visual, insertAbove, referenceVisual);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::RemoveVisual"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult RemoveVisual(IDCompositionVisual* visual)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, int>)(lpVtbl[17]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), visual);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::RemoveAllVisuals"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult RemoveAllVisuals()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, int>)(lpVtbl[18]))((IDCompositionVisual*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual::SetCompositeMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult SetCompositeMode(CompositeMode compositeMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, CompositeMode, int>)(lpVtbl[19]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), compositeMode);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult SetOffsetX(IDCompositionAnimation* animation);

		[VtblIndex(4)]
		HResult SetOffsetX(float offsetX);

		[VtblIndex(5)]
		HResult SetOffsetY(IDCompositionAnimation* animation);

		[VtblIndex(6)]
		HResult SetOffsetY(float offsetY);

		[VtblIndex(7)]
		HResult SetTransform(IDCompositionTransform* transform);

		[VtblIndex(8)]
		HResult SetTransform(Matrix3x2* matrix);

		[VtblIndex(9)]
		HResult SetTransformParent(IDCompositionVisual* visual);

		[VtblIndex(10)]
		HResult SetEffect(IDCompositionEffect* effect);

		[VtblIndex(11)]
		HResult SetBitmapInterpolationMode(BitmapInterpolationMode interpolationMode);

		[VtblIndex(12)]
		HResult SetBorderMode(BorderMode borderMode);

		[VtblIndex(13)]
		HResult SetClip(IDCompositionClip* clip);

		[VtblIndex(14)]
		HResult SetClip(Graphics.Direct2D.Common.RectF* rect);

		[VtblIndex(15)]
		HResult SetContent(IUnknown* content);

		[VtblIndex(16)]
		HResult AddVisual(IDCompositionVisual* visual, Bool32 insertAbove, IDCompositionVisual* referenceVisual);

		[VtblIndex(17)]
		HResult RemoveVisual(IDCompositionVisual* visual);

		[VtblIndex(18)]
		HResult RemoveAllVisuals();

		[VtblIndex(19)]
		HResult SetCompositeMode(CompositeMode compositeMode);
	}
}

