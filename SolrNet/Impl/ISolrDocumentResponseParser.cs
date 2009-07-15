﻿#region license
// Copyright (c) 2007-2009 Mauricio Scheffer
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System.Collections.Generic;
using System.Xml;

namespace SolrNet.Impl {
    /// <summary>
    /// Parses documents from query response
    /// </summary>
    /// <typeparam name="T">Document type</typeparam>
    public interface ISolrDocumentResponseParser<T> {
        /// <summary>
        /// Parses documents from query response
        /// </summary>
        /// <param name="parentNode"></param>
        /// <returns></returns>
        IList<T> ParseResults(XmlNode parentNode);
    }
}