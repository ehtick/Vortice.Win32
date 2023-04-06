// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice3"]/*' />
/// <unmanaged>IDCompositionDevice3</unmanaged>
[Guid("0987cb06-f916-48bf-8d35-ce7641781bd9")]
[NativeTypeName("struct IDCompositionDevice3 : IDCompositionDevice2")]
[NativeInheritance("IDCompositionDevice2")]
public unsafe partial struct IDCompositionDevice3 : IDCompositionDevice3.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDCompositionDevice3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x06, 0xCB, 0x87, 0x09,
				0x16, 0xF9,
				0xBF, 0x48,
				0x8D,
				0x35,
				0xCE,
				0x76,
				0x41,
				0x78,
				0x1B,
				0xD9
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionDevice3));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionDevice3));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, uint>)(lpVtbl[1]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, uint>)(lpVtbl[1]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, uint>)(lpVtbl[2]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, uint>)(lpVtbl[2]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.Commit" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult Commit()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, int>)(lpVtbl[3]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, int>)(lpVtbl[3]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.WaitForCommitCompletion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult WaitForCommitCompletion()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, int>)(lpVtbl[4]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, int>)(lpVtbl[4]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.GetFrameStatistics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetFrameStatistics(FrameStatistics* statistics)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, FrameStatistics*, int>)(lpVtbl[5]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), statistics);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, FrameStatistics*, int>)(lpVtbl[5]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), statistics);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateVisual" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateVisual(IDCompositionVisual2** visual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionVisual2**, int>)(lpVtbl[6]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), visual);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionVisual2**, int>)(lpVtbl[6]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), visual);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateSurfaceFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateSurfaceFactory(IUnknown* renderingDevice, IDCompositionSurfaceFactory** surfaceFactory)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IUnknown*, IDCompositionSurfaceFactory**, int>)(lpVtbl[7]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), renderingDevice, surfaceFactory);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IUnknown*, IDCompositionSurfaceFactory**, int>)(lpVtbl[7]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), renderingDevice, surfaceFactory);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateSurface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateSurface(uint width, uint height, Graphics.Dxgi.Common.Format pixelFormat, Graphics.Dxgi.Common.AlphaMode alphaMode, IDCompositionSurface** surface)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, uint, uint, Graphics.Dxgi.Common.Format, Graphics.Dxgi.Common.AlphaMode, IDCompositionSurface**, int>)(lpVtbl[8]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, uint, uint, Graphics.Dxgi.Common.Format, Graphics.Dxgi.Common.AlphaMode, IDCompositionSurface**, int>)(lpVtbl[8]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateVirtualSurface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateVirtualSurface(uint initialWidth, uint initialHeight, Graphics.Dxgi.Common.Format pixelFormat, Graphics.Dxgi.Common.AlphaMode alphaMode, IDCompositionVirtualSurface** virtualSurface)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, uint, uint, Graphics.Dxgi.Common.Format, Graphics.Dxgi.Common.AlphaMode, IDCompositionVirtualSurface**, int>)(lpVtbl[9]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, uint, uint, Graphics.Dxgi.Common.Format, Graphics.Dxgi.Common.AlphaMode, IDCompositionVirtualSurface**, int>)(lpVtbl[9]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateTranslateTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateTranslateTransform(IDCompositionTranslateTransform** translateTransform)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTranslateTransform**, int>)(lpVtbl[10]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), translateTransform);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionTranslateTransform**, int>)(lpVtbl[10]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), translateTransform);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateScaleTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateScaleTransform(IDCompositionScaleTransform** scaleTransform)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionScaleTransform**, int>)(lpVtbl[11]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), scaleTransform);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionScaleTransform**, int>)(lpVtbl[11]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), scaleTransform);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateRotateTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateRotateTransform(IDCompositionRotateTransform** rotateTransform)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionRotateTransform**, int>)(lpVtbl[12]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), rotateTransform);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionRotateTransform**, int>)(lpVtbl[12]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), rotateTransform);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateSkewTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateSkewTransform(IDCompositionSkewTransform** skewTransform)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionSkewTransform**, int>)(lpVtbl[13]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), skewTransform);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionSkewTransform**, int>)(lpVtbl[13]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), skewTransform);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateMatrixTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateMatrixTransform(IDCompositionMatrixTransform** matrixTransform)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionMatrixTransform**, int>)(lpVtbl[14]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), matrixTransform);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionMatrixTransform**, int>)(lpVtbl[14]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), matrixTransform);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateTransformGroup" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateTransformGroup(IDCompositionTransform** transforms, uint elements, IDCompositionTransform** transformGroup)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)(lpVtbl[15]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)(lpVtbl[15]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateTranslateTransform3D" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateTranslateTransform3D(IDCompositionTranslateTransform3D** translateTransform3D)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTranslateTransform3D**, int>)(lpVtbl[16]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), translateTransform3D);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionTranslateTransform3D**, int>)(lpVtbl[16]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), translateTransform3D);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateScaleTransform3D" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult CreateScaleTransform3D(IDCompositionScaleTransform3D** scaleTransform3D)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionScaleTransform3D**, int>)(lpVtbl[17]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), scaleTransform3D);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionScaleTransform3D**, int>)(lpVtbl[17]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), scaleTransform3D);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateRotateTransform3D" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult CreateRotateTransform3D(IDCompositionRotateTransform3D** rotateTransform3D)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionRotateTransform3D**, int>)(lpVtbl[18]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), rotateTransform3D);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionRotateTransform3D**, int>)(lpVtbl[18]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), rotateTransform3D);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateMatrixTransform3D" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreateMatrixTransform3D(IDCompositionMatrixTransform3D** matrixTransform3D)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionMatrixTransform3D**, int>)(lpVtbl[19]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), matrixTransform3D);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionMatrixTransform3D**, int>)(lpVtbl[19]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), matrixTransform3D);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateTransform3DGroup" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)(lpVtbl[20]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)(lpVtbl[20]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateEffectGroup" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateEffectGroup(IDCompositionEffectGroup** effectGroup)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionEffectGroup**, int>)(lpVtbl[21]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), effectGroup);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionEffectGroup**, int>)(lpVtbl[21]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), effectGroup);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateRectangleClip" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult CreateRectangleClip(IDCompositionRectangleClip** clip)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionRectangleClip**, int>)(lpVtbl[22]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), clip);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionRectangleClip**, int>)(lpVtbl[22]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), clip);
#endif
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateAnimation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult CreateAnimation(IDCompositionAnimation** animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionAnimation**, int>)(lpVtbl[23]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionAnimation**, int>)(lpVtbl[23]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice3::CreateGaussianBlurEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult CreateGaussianBlurEffect(IDCompositionGaussianBlurEffect** gaussianBlurEffect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionGaussianBlurEffect**, int>)(lpVtbl[24]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), gaussianBlurEffect);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionGaussianBlurEffect**, int>)(lpVtbl[24]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), gaussianBlurEffect);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice3::CreateBrightnessEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult CreateBrightnessEffect(IDCompositionBrightnessEffect** brightnessEffect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionBrightnessEffect**, int>)(lpVtbl[25]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), brightnessEffect);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionBrightnessEffect**, int>)(lpVtbl[25]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), brightnessEffect);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice3::CreateColorMatrixEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult CreateColorMatrixEffect(IDCompositionColorMatrixEffect** colorMatrixEffect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionColorMatrixEffect**, int>)(lpVtbl[26]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), colorMatrixEffect);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionColorMatrixEffect**, int>)(lpVtbl[26]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), colorMatrixEffect);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice3::CreateShadowEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult CreateShadowEffect(IDCompositionShadowEffect** shadowEffect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionShadowEffect**, int>)(lpVtbl[27]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), shadowEffect);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionShadowEffect**, int>)(lpVtbl[27]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), shadowEffect);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice3::CreateHueRotationEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult CreateHueRotationEffect(IDCompositionHueRotationEffect** hueRotationEffect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionHueRotationEffect**, int>)(lpVtbl[28]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), hueRotationEffect);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionHueRotationEffect**, int>)(lpVtbl[28]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), hueRotationEffect);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice3::CreateSaturationEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult CreateSaturationEffect(IDCompositionSaturationEffect** saturationEffect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionSaturationEffect**, int>)(lpVtbl[29]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), saturationEffect);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionSaturationEffect**, int>)(lpVtbl[29]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), saturationEffect);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice3::CreateTurbulenceEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult CreateTurbulenceEffect(IDCompositionTurbulenceEffect** turbulenceEffect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTurbulenceEffect**, int>)(lpVtbl[30]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), turbulenceEffect);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionTurbulenceEffect**, int>)(lpVtbl[30]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), turbulenceEffect);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice3::CreateLinearTransferEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult CreateLinearTransferEffect(IDCompositionLinearTransferEffect** linearTransferEffect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionLinearTransferEffect**, int>)(lpVtbl[31]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), linearTransferEffect);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionLinearTransferEffect**, int>)(lpVtbl[31]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), linearTransferEffect);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice3::CreateTableTransferEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult CreateTableTransferEffect(IDCompositionTableTransferEffect** tableTransferEffect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTableTransferEffect**, int>)(lpVtbl[32]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), tableTransferEffect);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionTableTransferEffect**, int>)(lpVtbl[32]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), tableTransferEffect);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice3::CreateCompositeEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public HResult CreateCompositeEffect(IDCompositionCompositeEffect** compositeEffect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionCompositeEffect**, int>)(lpVtbl[33]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), compositeEffect);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionCompositeEffect**, int>)(lpVtbl[33]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), compositeEffect);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice3::CreateBlendEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult CreateBlendEffect(IDCompositionBlendEffect** blendEffect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionBlendEffect**, int>)(lpVtbl[34]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), blendEffect);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionBlendEffect**, int>)(lpVtbl[34]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), blendEffect);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice3::CreateArithmeticCompositeEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public HResult CreateArithmeticCompositeEffect(IDCompositionArithmeticCompositeEffect** arithmeticCompositeEffect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionArithmeticCompositeEffect**, int>)(lpVtbl[35]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), arithmeticCompositeEffect);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionArithmeticCompositeEffect**, int>)(lpVtbl[35]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), arithmeticCompositeEffect);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice3::CreateAffineTransform2DEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public HResult CreateAffineTransform2DEffect(IDCompositionAffineTransform2DEffect** affineTransform2dEffect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionAffineTransform2DEffect**, int>)(lpVtbl[36]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), affineTransform2dEffect);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionAffineTransform2DEffect**, int>)(lpVtbl[36]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), affineTransform2dEffect);
#endif
	}

	public interface Interface : IDCompositionDevice2.Interface
	{
		[VtblIndex(24)]
		HResult CreateGaussianBlurEffect(IDCompositionGaussianBlurEffect** gaussianBlurEffect);

		[VtblIndex(25)]
		HResult CreateBrightnessEffect(IDCompositionBrightnessEffect** brightnessEffect);

		[VtblIndex(26)]
		HResult CreateColorMatrixEffect(IDCompositionColorMatrixEffect** colorMatrixEffect);

		[VtblIndex(27)]
		HResult CreateShadowEffect(IDCompositionShadowEffect** shadowEffect);

		[VtblIndex(28)]
		HResult CreateHueRotationEffect(IDCompositionHueRotationEffect** hueRotationEffect);

		[VtblIndex(29)]
		HResult CreateSaturationEffect(IDCompositionSaturationEffect** saturationEffect);

		[VtblIndex(30)]
		HResult CreateTurbulenceEffect(IDCompositionTurbulenceEffect** turbulenceEffect);

		[VtblIndex(31)]
		HResult CreateLinearTransferEffect(IDCompositionLinearTransferEffect** linearTransferEffect);

		[VtblIndex(32)]
		HResult CreateTableTransferEffect(IDCompositionTableTransferEffect** tableTransferEffect);

		[VtblIndex(33)]
		HResult CreateCompositeEffect(IDCompositionCompositeEffect** compositeEffect);

		[VtblIndex(34)]
		HResult CreateBlendEffect(IDCompositionBlendEffect** blendEffect);

		[VtblIndex(35)]
		HResult CreateArithmeticCompositeEffect(IDCompositionArithmeticCompositeEffect** arithmeticCompositeEffect);

		[VtblIndex(36)]
		HResult CreateAffineTransform2DEffect(IDCompositionAffineTransform2DEffect** affineTransform2dEffect);
	}
}

