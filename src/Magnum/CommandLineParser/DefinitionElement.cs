// Copyright 2007-2008 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Magnum.CommandLineParser
{
	public class DefinitionElement :
		IDefinitionElement
	{
		public DefinitionElement(string key, string value)
		{
			Key = key;
			Value = value;
		}

		public string Key { get; private set; }
		public string Value { get; private set; }

		public override string ToString()
		{
			return "DEFINE: " + Key + " = " + Value;
		}

		public static ICommandLineElement New(string key, string value)
		{
			return new DefinitionElement(key, value);
		}
	}
}