﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Generator.Tests {
	[TestFixture]
	public class WebIDLRoundtripTests {
		private string GetTestcase() {
			using (var s = Assembly.GetExecutingAssembly().GetManifestResourceStream("Generator.Tests.Testcase.webidl"))
			using (var rdr = new StreamReader(s, Encoding.UTF8)) {
				return rdr.ReadToEnd();
			}
		}

		private readonly Regex _spaceRe = new Regex("\\s");
		private readonly Regex _hexRe = new Regex(@"\b0x[0-9a-f]+\b", RegexOptions.IgnoreCase);
		private string Normalize(string text) {
			return _hexRe.Replace(_spaceRe.Replace(text.Trim(), " ").Replace(", ", ",").Replace(" (", "("), m => {
				return int.Parse(m.Value.Substring(2), NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture);
			}).Replace("stringifier;", "stringifier DOMString();"); // These are equivalent according to the spec, and our AST doesn't differentiate between them
		}

		[Test]
		public void CanRoundtripTestcase() {
			string testcase = GetTestcase();
			var ast = WebIDLParser.Parse(new StringReader(testcase));
			string actual = WebIDLFormatter.Format(ast);

			//File.WriteAllText("Result.webidl", actual);

			var expectedLines  = testcase.Replace("\r\n", "\n").Split('\n');
			var actualLines   = actual.Replace("\r\n", "\n").Split('\n').Select(Normalize).Where(s => s != "").ToArray();
			int actualIndex = 0;
			for (int expectedIndex = 0; expectedIndex < expectedLines.Length; expectedIndex++) {
				string expectedLine = Normalize(expectedLines[expectedIndex].Trim());
				if (expectedLine == "")
					continue;
				if (actualIndex == actualLines.Length) {
					Assert.Fail("Testcase line #{0}:\nWas \"{1}\".\nNo more expected lines.", expectedIndex + 1, expectedLines[expectedIndex]);
				}
				if (expectedLine != actualLines[actualIndex]) {
					Assert.Fail("Testcase line #{0}:\nWas \"{1}\".\nexpected \"{2}\".", expectedIndex + 1, actualLines[actualIndex], expectedLines[expectedIndex]);
				}
				actualIndex++;
			}
		}
	}
}
