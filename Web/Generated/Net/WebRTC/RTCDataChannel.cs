﻿// RTCDataChannel.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Collections.TypedArrays;
using System.Html;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("DataChannel")]
	public partial class RTCDataChannel : EventTarget {
		internal RTCDataChannel() {
		}

		[IntrinsicProperty]
		public RTCDataChannelType BinaryType {
			get { return default(RTCDataChannelType); }
			set { }
		}

		[IntrinsicProperty]
		public uint BufferedAmount {
			get { return 0; }
		}

		public void Close() {
		}

		[IntrinsicProperty]
		public ushort Id {
			get { return 0; }
		}

		[IntrinsicProperty]
		public string Label {
			get { return null; }
		}

		[IntrinsicProperty, ScriptName("onclose")]
		public HtmlEventHandler OnClose {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onmessage")]
		public HtmlEventHandler OnMessage {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onopen")]
		public HtmlEventHandler OnOpen {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty]
		public bool Ordered {
			get { return false; }
		}

		[IntrinsicProperty]
		public string Protocol {
			get { return null; }
		}

		[IntrinsicProperty]
		public RTCDataChannelState ReadyState {
			get { return default(RTCDataChannelState); }
		}

		[IntrinsicProperty]
		public bool Reliable {
			get { return false; }
		}

		public void Send(ArrayBuffer data) {
		}

		public void Send(ArrayBufferView data) {
		}

		public void Send(Blob data) {
		}

		public void Send(string data) {
		}

		[IntrinsicProperty]
		public ushort Stream {
			get { return 0; }
		}
	}
}