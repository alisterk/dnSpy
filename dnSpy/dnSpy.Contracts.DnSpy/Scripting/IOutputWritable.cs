/*
    Copyright (C) 2014-2019 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using dnSpy.Contracts.Text;

namespace dnSpy.Contracts.Scripting {
	/// <summary>
	/// Implemented by classes that can write itself using a <see cref="IOutputWriter"/>
	/// </summary>
	public interface IOutputWritable {
		/// <summary>
		/// Writes itself to <paramref name="output"/>
		/// </summary>
		/// <param name="output">Output</param>
		void WriteTo(IOutputWriter output);
	}

	/// <summary>
	/// Extension methods
	/// </summary>
	public static class OutputWritableExtensions {
		/// <summary>
		/// Writes text followed by a newline
		/// </summary>
		/// <param name="obj">Object</param>
		/// <param name="output">Output</param>
		public static void WriteLineTo(this IOutputWritable obj, IOutputWriter output) {
			obj.WriteTo(output);
			output.Write(Environment.NewLine, BoxedTextColor.ReplScriptOutputText);
		}
	}
}
