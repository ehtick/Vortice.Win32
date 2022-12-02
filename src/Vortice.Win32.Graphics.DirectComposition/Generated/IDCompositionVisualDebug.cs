// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisualDebug"]/*' />
/// <unmanaged>IDCompositionVisualDebug</unmanaged>
[Guid("fed2b808-5eb4-43a0-aea3-35f65280f91b")]
[NativeTypeName("struct IDCompositionVisualDebug : IDCompositionVisual2")]
[NativeInheritance("IDCompositionVisual2")]
public unsafe partial struct IDCompositionVisualDebug : IDCompositionVisualDebug.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDCompositionVisualDebug
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x08, 0xB8, 0xD2, 0xFE,
				0xB4, 0x5E,
				0xA0, 0x43,
				0xAE,
				0xA3,
				0x35,
				0xF6,
				0x52,
				0x80,
				0xF9,
				0x1B
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionVisualDebug));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionVisualDebug));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, uint>)(lpVtbl[1]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, uint>)(lpVtbl[2]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionVisual.SetOffsetX" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetOffsetX(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), animation);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetOffsetX" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetOffsetX(float offsetX)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, float, int>)(lpVtbl[4]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), offsetX);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetOffsetY" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetOffsetY(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), animation);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetOffsetY" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetOffsetY(float offsetY)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, float, int>)(lpVtbl[6]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), offsetY);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetTransform(IDCompositionTransform* transform)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionTransform*, int>)(lpVtbl[7]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), transform);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetTransform(Matrix3x2* matrix)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Matrix3x2*, int>)(lpVtbl[8]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), matrix);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetTransformParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetTransformParent(IDCompositionVisual* visual)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, int>)(lpVtbl[9]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), visual);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetEffect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetEffect(IDCompositionEffect* effect)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionEffect*, int>)(lpVtbl[10]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), effect);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetBitmapInterpolationMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult SetBitmapInterpolationMode(BitmapInterpolationMode interpolationMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, BitmapInterpolationMode, int>)(lpVtbl[11]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), interpolationMode);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetBorderMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult SetBorderMode(BorderMode borderMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, BorderMode, int>)(lpVtbl[12]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), borderMode);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetClip" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult SetClip(IDCompositionClip* clip)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionClip*, int>)(lpVtbl[13]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), clip);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetClip" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult SetClip(Graphics.Direct2D.Common.RectF* rect)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Graphics.Direct2D.Common.RectF*, int>)(lpVtbl[14]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), rect);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetContent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult SetContent(IUnknown* content)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IUnknown*, int>)(lpVtbl[15]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), content);
	}

	/// <inheritdoc cref="IDCompositionVisual.AddVisual" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult AddVisual(IDCompositionVisual* visual, Bool32 insertAbove, IDCompositionVisual* referenceVisual)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, Bool32, IDCompositionVisual*, int>)(lpVtbl[16]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), visual, insertAbove, referenceVisual);
	}

	/// <inheritdoc cref="IDCompositionVisual.RemoveVisual" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult RemoveVisual(IDCompositionVisual* visual)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, int>)(lpVtbl[17]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), visual);
	}

	/// <inheritdoc cref="IDCompositionVisual.RemoveAllVisuals" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult RemoveAllVisuals()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, int>)(lpVtbl[18]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionVisual.SetCompositeMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult SetCompositeMode(CompositeMode compositeMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, CompositeMode, int>)(lpVtbl[19]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), compositeMode);
	}

	/// <inheritdoc cref="IDCompositionVisual2.SetOpacityMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult SetOpacityMode(OpacityMode mode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, OpacityMode, int>)(lpVtbl[20]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), mode);
	}

	/// <inheritdoc cref="IDCompositionVisual2.SetBackFaceVisibility" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult SetBackFaceVisibility(BackfaceVisibility visibility)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, BackfaceVisibility, int>)(lpVtbl[21]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), visibility);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisualDebug::EnableHeatMap"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult EnableHeatMap(Color4* color)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Color4*, int>)(lpVtbl[22]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), color);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisualDebug::DisableHeatMap"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult DisableHeatMap()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, int>)(lpVtbl[23]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisualDebug::EnableRedrawRegions"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult EnableRedrawRegions()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, int>)(lpVtbl[24]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisualDebug::DisableRedrawRegions"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult DisableRedrawRegions()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, int>)(lpVtbl[25]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
	}

	public interface Interface : IDCompositionVisual2.Interface
	{
		[VtblIndex(22)]
		HResult EnableHeatMap(Color4* color);

		[VtblIndex(23)]
		HResult DisableHeatMap();

		[VtblIndex(24)]
		HResult EnableRedrawRegions();

		[VtblIndex(25)]
		HResult DisableRedrawRegions();
	}
}

