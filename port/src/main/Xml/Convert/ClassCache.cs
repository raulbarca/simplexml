#region License
//
// ClassMap.cs January 2010
//
// Copyright (C) 2010, Niall Gallagher <niallg@users.sf.net>
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
// implied. See the License for the specific language governing
// permissions and limitations under the License.
//
#endregion
#region Using directives
using SimpleFramework.Xml.Util;
using SimpleFramework.Xml;
using System;
#endregion
namespace SimpleFramework.Xml.Util {
   /// <summary>
   /// The <c>ClassCache</c> is used to cache converter bindings.
   /// It is used so the overhead of instantiating a converters each time
   /// an object of the specified type requires conversion is removed.
   /// Essentially this acts as a typedef for the generic hash map.
   /// </summary>
   class ClassCache : WeakCache<Class, Class> {
      /// <summary>
      /// Constructor for the <c>ClassCache</c> object. This is
      /// a concurrent hash table that maps class types to the converter
      /// classes they represent. To enable reloading of classes by the
      /// system this will drop the mapping if the class in unloaded.
      /// </summary>
      public ClassCache() {
         super();
      }
   }
}
