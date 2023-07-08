// Copyright 2003-2009 The AnkhSVN Project
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Resources;
using Ankh;
using System.Runtime.InteropServices;

//
// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: CLSCompliant(true)]
[assembly: AssemblyTitle("AnkhSVN - Subversion support for Visual Studio")]
[assembly: AssemblyDescription("AnkhSVN - Subversion support for Visual Studio")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(AnkhId.AssemblyCompany)]
[assembly: AssemblyProduct(AnkhId.AssemblyProduct)]
[assembly: AssemblyCopyright(AnkhId.AssemblyCopyright)]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en-US")]

// We only want the Connect class to be visible
[assembly: ComVisible(false)]

[assembly: AssemblyVersion(AnkhId.AssemblyVersion)]
//[assembly: AssemblyVersion("2.9.*")]
