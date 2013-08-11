﻿// StyleRuleChangeEventInit.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class StyleRuleChangeEventInit : EventInit {
		public CSSRule Rule {
			get { return default(CSSRule); }
			set { }
		}

		public CSSStyleSheet Stylesheet {
			get { return default(CSSStyleSheet); }
			set { }
		}
	}
}