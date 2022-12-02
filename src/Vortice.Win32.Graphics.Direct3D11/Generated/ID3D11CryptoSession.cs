// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11CryptoSession"]/*' />
/// <unmanaged>ID3D11CryptoSession</unmanaged>
[Guid("9b32f9ad-bdcc-40a6-a39d-d5c865845720")]
[NativeTypeName("struct ID3D11CryptoSession : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
public unsafe partial struct ID3D11CryptoSession : ID3D11CryptoSession.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11CryptoSession
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xAD, 0xF9, 0x32, 0x9B,
				0xCC, 0xBD,
				0xA6, 0x40,
				0xA3,
				0x9D,
				0xD5,
				0xC8,
				0x65,
				0x84,
				0x57,
				0x20
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11CryptoSession));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11CryptoSession));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint>)(lpVtbl[1]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint>)(lpVtbl[2]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
		((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11CryptoSession::GetCryptoType"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetCryptoType(Guid* pCryptoType)
	{
		((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void>)(lpVtbl[7]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCryptoType);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11CryptoSession::GetDecoderProfile"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetDecoderProfile(Guid* pDecoderProfile)
	{
		((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void>)(lpVtbl[8]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pDecoderProfile);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11CryptoSession::GetCertificateSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetCertificateSize(uint* pCertificateSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint*, int>)(lpVtbl[9]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCertificateSize);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11CryptoSession::GetCertificate"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetCertificate(uint CertificateSize, byte* pCertificate)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint, byte*, int>)(lpVtbl[10]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), CertificateSize, pCertificate);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11CryptoSession::GetCryptoSessionHandle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public void GetCryptoSessionHandle(Handle* pCryptoSessionHandle)
	{
		((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Handle*, void>)(lpVtbl[11]))((ID3D11CryptoSession*)Unsafe.AsPointer(ref this), pCryptoSessionHandle);
	}

	public interface Interface : ID3D11DeviceChild.Interface
	{
		[VtblIndex(7)]
		void GetCryptoType(Guid* pCryptoType);

		[VtblIndex(8)]
		void GetDecoderProfile(Guid* pDecoderProfile);

		[VtblIndex(9)]
		HResult GetCertificateSize(uint* pCertificateSize);

		[VtblIndex(10)]
		HResult GetCertificate(uint CertificateSize, byte* pCertificate);

		[VtblIndex(11)]
		void GetCryptoSessionHandle(Handle* pCryptoSessionHandle);
	}
}

