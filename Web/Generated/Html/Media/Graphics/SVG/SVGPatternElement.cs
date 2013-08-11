﻿// SVGPatternElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGPatternElement : SVGElement {
		internal SVGPatternElement() {
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
		public SVGAnimatedEnumeration<SVGUnitType> PatternContentUnits {
			get { return default(SVGAnimatedEnumeration<SVGUnitType>); }
		}

		[IntrinsicProperty]
		public SVGAnimatedTransformList PatternTransform {
			get { return default(SVGAnimatedTransformList); }
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGUnitType> PatternUnits {
			get { return default(SVGAnimatedEnumeration<SVGUnitType>); }
		}

		[IntrinsicProperty]
		public SVGAnimatedPreserveAspectRatio PreserveAspectRatio {
			get { return default(SVGAnimatedPreserveAspectRatio); }
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
		public SVGAnimatedRect ViewBox {
			get { return default(SVGAnimatedRect); }
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