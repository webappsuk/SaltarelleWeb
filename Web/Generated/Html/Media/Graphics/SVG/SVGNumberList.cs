﻿// SVGNumberList.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGNumberList {
		internal SVGNumberList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public SVGNumber this[uint index] {
			get { return default(SVGNumber); }
		}

		public SVGNumber AppendItem(SVGNumber newItem) {
			return default(SVGNumber);
		}

		public void Clear() {
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SVGNumber> GetEnumerator() {
			return default(IEnumerator<SVGNumber>);
		}

		public SVGNumber GetItem(uint index) {
			return default(SVGNumber);
		}

		public SVGNumber Initialize(SVGNumber newItem) {
			return default(SVGNumber);
		}

		public SVGNumber InsertItemBefore(SVGNumber newItem, uint index) {
			return default(SVGNumber);
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
		}

		[IntrinsicProperty]
		public uint NumberOfItems {
			get { return 0; }
		}

		public SVGNumber RemoveItem(uint index) {
			return default(SVGNumber);
		}

		public SVGNumber ReplaceItem(SVGNumber newItem, uint index) {
			return default(SVGNumber);
		}
	}
}