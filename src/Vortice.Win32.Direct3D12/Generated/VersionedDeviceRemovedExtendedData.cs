// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA"]/*' />
/// <unmanaged>D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA</unmanaged>
public partial struct VersionedDeviceRemovedExtendedData
{
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA::Version"]/*' />
	public DredVersion Version;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA::Anonymous"]/*' />
	public _Anonymous_e__Union Anonymous;

	[UnscopedRef]
	public ref DeviceRemovedExtendedData Dred_1_0
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Dred_1_0;
		}
	}

	[UnscopedRef]
	public ref DeviceRemovedExtendedData1 Dred_1_1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Dred_1_1;
		}
	}

	[UnscopedRef]
	public ref DeviceRemovedExtendedData2 Dred_1_2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Dred_1_2;
		}
	}

	[UnscopedRef]
	public ref DeviceRemovedExtendedData3 Dred_1_3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Dred_1_3;
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public partial struct _Anonymous_e__Union
	{
		/// <include file='../Direct3D12.xml' path='doc/member[@name="_Anonymous_e__Union::Dred_1_0"]/*' />
		[FieldOffset(0)]
		public DeviceRemovedExtendedData Dred_1_0;

		/// <include file='../Direct3D12.xml' path='doc/member[@name="_Anonymous_e__Union::Dred_1_1"]/*' />
		[FieldOffset(0)]
		public DeviceRemovedExtendedData1 Dred_1_1;

		/// <include file='../Direct3D12.xml' path='doc/member[@name="_Anonymous_e__Union::Dred_1_2"]/*' />
		[FieldOffset(0)]
		public DeviceRemovedExtendedData2 Dred_1_2;

		/// <include file='../Direct3D12.xml' path='doc/member[@name="_Anonymous_e__Union::Dred_1_3"]/*' />
		[FieldOffset(0)]
		public DeviceRemovedExtendedData3 Dred_1_3;
	}
}
