#region Copyright
//
// This framework is based on log4j see http://jakarta.apache.org/log4j
// Copyright (C) The Apache Software Foundation. All rights reserved.
//
// This software is published under the terms of the Apache Software
// License version 1.1, a copy of which has been included with this
// distribution in the LICENSE.txt file.
// 
#endregion

using System;
using System.Text;
using System.IO;

using log4net.Core;

namespace log4net.Layout.Pattern
{
	/// <summary>
	/// Pattern converter for the class name
	/// </summary>
	/// <author>Nicko Cadell</author>
	internal sealed class TypeNamePatternConverter : NamedPatternConverter 
	{
		/// <summary>
		/// Gets the fully qualified name of the class
		/// </summary>
		/// <param name="loggingEvent">the event being logged</param>
		/// <returns>the class name</returns>
		override protected string GetFullyQualifiedName(LoggingEvent loggingEvent) 
		{
			return loggingEvent.LocationInformation.ClassName;
		}
	}
}
