﻿// MediaList.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MediaList {
		internal MediaList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public string this[uint index] {
			get { return null; }
		}

		public void AppendMedium(string medium) {
		}

		public void DeleteMedium(string medium) {
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<string> GetEnumerator() {
			return default(IEnumerator<string>);
		}

		public string Item(uint index) {
			return null;
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
		}

		[IntrinsicProperty]
		public string MediaText {
			get { return null; }
			set { }
		}
	}
}