﻿// MessageEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Html;
using System.Runtime.CompilerServices;

namespace System.Net.WebSockets {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MessageEvent : Event {
		internal MessageEvent() {
		}

		[IntrinsicProperty]
		public object Data {
			get { return null; }
		}

		[IntrinsicProperty]
		public string LastEventId {
			get { return null; }
		}

		[IntrinsicProperty]
		public string Origin {
			get { return null; }
		}

		[IntrinsicProperty]
		public WindowInstance Source {
			get { return default(WindowInstance); }
		}
	}
}