using System.Runtime.CompilerServices;

namespace System.Html {
	public partial class EventTarget {
		public void AddEventListener(string type, Action listener) {}
		public void AddEventListener(string type, Action listener, bool capture) {}

		public void RemoveEventListener(string type, Action listener) {}
		public void RemoveEventListener(string type, Action listener, bool capture) {}


		public void AddEventListener(string type, HtmlEventHandler listener) {}
		public void AddEventListener(string type, HtmlEventHandler listener, bool capture) {}

		public void RemoveEventListener(string type, HtmlEventHandler listener) {}
		public void RemoveEventListener(string type, HtmlEventHandler listener, bool capture) {}


		public void AddEventListener(string type, HtmlEventHandlerWithTarget<EventTarget> listener) {}
		public void AddEventListener(string type, HtmlEventHandlerWithTarget<EventTarget> listener, bool capture) {}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<EventTarget> listener) {}
		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<EventTarget> listener, bool capture) {}
	}
}