// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

public static unsafe partial class Apis
{
	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11CreateDevice"]/*' />
	[DllImport("d3d11.dll", ExactSpelling = true)]
	public static extern HResult D3D11CreateDevice(Graphics.Dxgi.IDXGIAdapter* pAdapter, Graphics.Direct3D.DriverType DriverType, IntPtr Software, CreateDeviceFlags Flags, Graphics.Direct3D.FeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Graphics.Direct3D.FeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11CreateDeviceAndSwapChain"]/*' />
	[DllImport("d3d11.dll", ExactSpelling = true)]
	public static extern HResult D3D11CreateDeviceAndSwapChain(Graphics.Dxgi.IDXGIAdapter* pAdapter, Graphics.Direct3D.DriverType DriverType, IntPtr Software, CreateDeviceFlags Flags, Graphics.Direct3D.FeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Graphics.Dxgi.SwapChainDescription* pSwapChainDesc, Graphics.Dxgi.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Graphics.Direct3D.FeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);
}
