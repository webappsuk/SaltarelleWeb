﻿// MenuElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'MENU'"), ScriptName("Element")]
	public partial class MenuElement : Element {
		internal MenuElement() {
		}

		[IntrinsicProperty]
		public bool Compact {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public string Label {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Type {
			get { return null; }
			set { }
		}
	}
}