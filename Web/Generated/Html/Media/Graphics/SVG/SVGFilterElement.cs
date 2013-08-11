﻿// SVGFilterElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGFilterElement : SVGElement {
		internal SVGFilterElement() {
		}

		[IntrinsicProperty]
		public SVGAnimatedInteger FilterResX {
			get { return default(SVGAnimatedInteger); }
		}

		[IntrinsicProperty]
		public SVGAnimatedInteger FilterResY {
			get { return default(SVGAnimatedInteger); }
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGUnitType> FilterUnits {
			get { return default(SVGAnimatedEnumeration<SVGUnitType>); }
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Height {
			get { return default(SVGAnimatedLength); }
		}

		[IntrinsicProperty]
		public SVGAnimatedString Href {
			get { return default(SVGAnimatedString); }
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGUnitType> PrimitiveUnits {
			get { return default(SVGAnimatedEnumeration<SVGUnitType>); }
		}

		public void SetFilterRes(uint filterResX, uint filterResY) {
		}

		[ScriptName("SVG_UNIT_TYPE_OBJECTBOUNDINGBOX")]
		public const ushort SVG_UNIT_TYPE_OBJECTBOUNDINGBOX = 2;

		[ScriptName("SVG_UNIT_TYPE_UNKNOWN")]
		public const ushort SVG_UNIT_TYPE_UNKNOWN = 0;

		[ScriptName("SVG_UNIT_TYPE_USERSPACEONUSE")]
		public const ushort SVG_UNIT_TYPE_USERSPACEONUSE = 1;

		[IntrinsicProperty]
		public SVGAnimatedLength Width {
			get { return default(SVGAnimatedLength); }
		}

		[IntrinsicProperty]
		public SVGAnimatedLength X {
			get { return default(SVGAnimatedLength); }
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Y {
			get { return default(SVGAnimatedLength); }
		}
	}
}