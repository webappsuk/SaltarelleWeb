﻿using System.Html.Media.Graphics;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'CANVAS'"), ScriptName("Element")]
	public partial class CanvasElement : Element {
		internal CanvasElement() {
		}

		public void AddEventListener(CanvasElementEvents type, Action listener) {
		}

		public void AddEventListener(CanvasElementEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(CanvasElementEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(CanvasElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(CanvasElementEvents type, HtmlEventHandlerWithTarget<CanvasElement> listener) {
		}

		public void AddEventListener(CanvasElementEvents type, HtmlEventHandlerWithTarget<CanvasElement> listener, bool capture) {
		}

		public void AddEventListener(CanvasElementEvents type, IEventListener listener) {
		}

		public void AddEventListener(CanvasElementEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<CanvasElement> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<CanvasElement> listener, bool capture) {
		}

		public CanvasRenderingContext GetContext(string contextId) {
			return default(CanvasRenderingContext);
		}

		public CanvasRenderingContext GetContext(string contextId, object contextOptions) {
			return default(CanvasRenderingContext);
		}

		[IntrinsicProperty]
		public int Height {
			get {
				return 0;
			}
			set {
			}
		}

		public void RemoveEventListener(CanvasElementEvents type, Action listener) {
		}

		public void RemoveEventListener(CanvasElementEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(CanvasElementEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(CanvasElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(CanvasElementEvents type, HtmlEventHandlerWithTarget<CanvasElement> listener) {
		}

		public void RemoveEventListener(CanvasElementEvents type, HtmlEventHandlerWithTarget<CanvasElement> listener, bool capture) {
		}

		public void RemoveEventListener(CanvasElementEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(CanvasElementEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<CanvasElement> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<CanvasElement> listener, bool capture) {
		}

		public void ToBlob(Action<Blob> callback) {
		}

		public void ToBlob(Action<Blob> callback, string type, object encoderOptions) {
		}

		public string ToDataURL() {
			return null;
		}

		public string ToDataURL(string type, object encoderOptions) {
			return null;
		}

		[IntrinsicProperty]
		public int Width {
			get {
				return 0;
			}
			set {
			}
		}
	}
}
