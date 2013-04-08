﻿// Int8Array.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	[IgnoreNamespace, Imported]
	public class Int8Array : TypedArray
	{
		[ScriptName("")]
		public Int8Array(long length) { }

		[ScriptName("")]
		public Int8Array(sbyte[] values) { }

		[ScriptName("")]
		public Int8Array(TypedArray buffer) { }

		[ScriptName("")]
		public Int8Array(ArrayBuffer buffer) { }

		[ScriptName("")]
		public Int8Array(ArrayBuffer buffer, int offset) { }

		[ScriptName("")]
		public Int8Array(ArrayBuffer buffer, int offset, int length) { }
	}
}
