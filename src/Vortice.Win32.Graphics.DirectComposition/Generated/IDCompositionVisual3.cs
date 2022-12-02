// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual3"]/*' />
/// <unmanaged>IDCompositionVisual3</unmanaged>
[Guid("2775f462-b6c1-4015-b0be-b3e7d6a4976d")]
[NativeTypeName("struct IDCompositionVisual3 : IDCompositionVisualDebug")]
[NativeInheritance("IDCompositionVisualDebug")]
public unsafe partial struct IDCompositionVisual3 : IDCompositionVisual3.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDCompositionVisual3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x62, 0xF4, 0x75, 0x27,
				0xC1, 0xB6,
				0x15, 0x40,
				0xB0,
				0xBE,
				0xB3,
				0xE7,
				0xD6,
				0xA4,
				0x97,
				0x6D
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionVisual3));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionVisual3));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, uint>)(lpVtbl[1]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, uint>)(lpVtbl[2]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionVisual.SetOffsetX" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetOffsetX(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetOffsetX" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetOffsetX(float offsetX)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, float, int>)(lpVtbl[4]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetX);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetOffsetY" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetOffsetY(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetOffsetY" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetOffsetY(float offsetY)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, float, int>)(lpVtbl[6]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetY);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetTransform(IDCompositionTransform* transform)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, IDCompositionTransform*, int>)(lpVtbl[7]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), transform);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetTransform(Matrix3x2* matrix)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, Matrix3x2*, int>)(lpVtbl[8]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), matrix);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetTransformParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetTransformParent(IDCompositionVisual* visual)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, IDCompositionVisual*, int>)(lpVtbl[9]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetEffect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetEffect(IDCompositionEffect* effect)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, IDCompositionEffect*, int>)(lpVtbl[10]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), effect);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetBitmapInterpolationMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult SetBitmapInterpolationMode(BitmapInterpolationMode interpolationMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, BitmapInterpolationMode, int>)(lpVtbl[11]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), interpolationMode);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetBorderMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult SetBorderMode(BorderMode borderMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, BorderMode, int>)(lpVtbl[12]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), borderMode);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetClip" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult SetClip(IDCompositionClip* clip)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, IDCompositionClip*, int>)(lpVtbl[13]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), clip);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetClip" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult SetClip(Graphics.Direct2D.Common.RectF* rect)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, Graphics.Direct2D.Common.RectF*, int>)(lpVtbl[14]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), rect);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetContent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult SetContent(IUnknown* content)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, IUnknown*, int>)(lpVtbl[15]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), content);
	}

	/// <inheritdoc cref="IDCompositionVisual.AddVisual" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult AddVisual(IDCompositionVisual* visual, Bool32 insertAbove, IDCompositionVisual* referenceVisual)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, IDCompositionVisual*, Bool32, IDCompositionVisual*, int>)(lpVtbl[16]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual, insertAbove, referenceVisual);
	}

	/// <inheritdoc cref="IDCompositionVisual.RemoveVisual" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult RemoveVisual(IDCompositionVisual* visual)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, IDCompositionVisual*, int>)(lpVtbl[17]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visual);
	}

	/// <inheritdoc cref="IDCompositionVisual.RemoveAllVisuals" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult RemoveAllVisuals()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, int>)(lpVtbl[18]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionVisual.SetCompositeMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult SetCompositeMode(CompositeMode compositeMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, CompositeMode, int>)(lpVtbl[19]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), compositeMode);
	}

	/// <inheritdoc cref="IDCompositionVisual2.SetOpacityMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult SetOpacityMode(OpacityMode mode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, OpacityMode, int>)(lpVtbl[20]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), mode);
	}

	/// <inheritdoc cref="IDCompositionVisual2.SetBackFaceVisibility" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult SetBackFaceVisibility(BackfaceVisibility visibility)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, BackfaceVisibility, int>)(lpVtbl[21]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visibility);
	}

	/// <inheritdoc cref="IDCompositionVisualDebug.EnableHeatMap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult EnableHeatMap(Color4* color)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, Color4*, int>)(lpVtbl[22]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), color);
	}

	/// <inheritdoc cref="IDCompositionVisualDebug.DisableHeatMap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult DisableHeatMap()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, int>)(lpVtbl[23]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionVisualDebug.EnableRedrawRegions" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult EnableRedrawRegions()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, int>)(lpVtbl[24]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionVisualDebug.DisableRedrawRegions" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult DisableRedrawRegions()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, int>)(lpVtbl[25]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual3::SetDepthMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult SetDepthMode(DepthMode mode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, DepthMode, int>)(lpVtbl[26]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), mode);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual3::SetOffsetZ"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult SetOffsetZ(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, IDCompositionAnimation*, int>)(lpVtbl[27]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual3::SetOffsetZ"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult SetOffsetZ(float offsetZ)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, float, int>)(lpVtbl[28]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), offsetZ);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual3::SetOpacity"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult SetOpacity(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, IDCompositionAnimation*, int>)(lpVtbl[29]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual3::SetOpacity"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult SetOpacity(float opacity)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, float, int>)(lpVtbl[30]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), opacity);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual3::SetTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult SetTransform(IDCompositionTransform3D* transform)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, IDCompositionTransform3D*, int>)(lpVtbl[31]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), transform);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual3::SetTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult SetTransform(Matrix4x4* matrix)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, Matrix4x4*, int>)(lpVtbl[32]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), matrix);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual3::SetVisible"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public HResult SetVisible(Bool32 visible)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, Bool32, int>)(lpVtbl[33]))((IDCompositionVisual3*)Unsafe.AsPointer(ref this), visible);
	}

	public interface Interface : IDCompositionVisualDebug.Interface
	{
		[VtblIndex(26)]
		HResult SetDepthMode(DepthMode mode);

		[VtblIndex(27)]
		HResult SetOffsetZ(IDCompositionAnimation* animation);

		[VtblIndex(28)]
		HResult SetOffsetZ(float offsetZ);

		[VtblIndex(29)]
		HResult SetOpacity(IDCompositionAnimation* animation);

		[VtblIndex(30)]
		HResult SetOpacity(float opacity);

		[VtblIndex(31)]
		HResult SetTransform(IDCompositionTransform3D* transform);

		[VtblIndex(32)]
		HResult SetTransform(Matrix4x4* matrix);

		[VtblIndex(33)]
		HResult SetVisible(Bool32 visible);
	}
}

