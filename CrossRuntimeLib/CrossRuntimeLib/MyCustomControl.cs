using System;
using Windows.UI.Xaml.Controls;

namespace CrossRuntimeLib
{
	public partial class MyCustomControl : UserControl
	{
		public MyCustomControl()
		{
		}
#if __WASM__
		public void WasmOnlyMethod()
		{

		}
#endif
	}
}
