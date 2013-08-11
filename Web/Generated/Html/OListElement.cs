﻿// OListElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'OL'"), ScriptName("Element")]
	public partial class OListElement : Element {
		internal OListElement() {
		}

		[IntrinsicProperty]
		public bool Compact {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public bool Reversed {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public int Start {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public string Type {
			get { return null; }
			set { }
		}
	}
}