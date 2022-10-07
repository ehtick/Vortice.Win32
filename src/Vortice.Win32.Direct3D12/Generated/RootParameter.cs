// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER"]/*' />
/// <unmanaged>D3D12_ROOT_PARAMETER</unmanaged>
public partial struct RootParameter
{
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER::ParameterType"]/*' />
	public RootParameterType ParameterType;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER::Anonymous"]/*' />
	public _Anonymous_e__Union Anonymous;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER::ShaderVisibility"]/*' />
	public ShaderVisibility ShaderVisibility;

	[UnscopedRef]
	public ref RootDescriptorTable DescriptorTable
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.DescriptorTable;
		}
	}

	[UnscopedRef]
	public ref RootConstants Constants
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Constants;
		}
	}

	[UnscopedRef]
	public ref RootDescriptor Descriptor
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Descriptor;
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public partial struct _Anonymous_e__Union
	{
		/// <include file='../Direct3D12.xml' path='doc/member[@name="_Anonymous_e__Union::DescriptorTable"]/*' />
		[FieldOffset(0)]
		public RootDescriptorTable DescriptorTable;

		/// <include file='../Direct3D12.xml' path='doc/member[@name="_Anonymous_e__Union::Constants"]/*' />
		[FieldOffset(0)]
		public RootConstants Constants;

		/// <include file='../Direct3D12.xml' path='doc/member[@name="_Anonymous_e__Union::Descriptor"]/*' />
		[FieldOffset(0)]
		public RootDescriptor Descriptor;
	}
}
