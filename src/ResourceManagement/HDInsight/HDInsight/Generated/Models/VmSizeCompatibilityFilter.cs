// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;

namespace Microsoft.Azure.Management.HDInsight.Models
{
    public partial class VmSizeCompatibilityFilter
    {
        private IList<string> _clusterFlavors;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<string> ClusterFlavors
        {
            get { return this._clusterFlavors; }
            set { this._clusterFlavors = value; }
        }
        
        private IList<string> _clusterVersions;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<string> ClusterVersions
        {
            get { return this._clusterVersions; }
            set { this._clusterVersions = value; }
        }
        
        private string _filterMode;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string FilterMode
        {
            get { return this._filterMode; }
            set { this._filterMode = value; }
        }
        
        private IList<string> _nodeTypes;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<string> NodeTypes
        {
            get { return this._nodeTypes; }
            set { this._nodeTypes = value; }
        }
        
        private IList<string> _regions;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }
        
        private IList<string> _vMSizes;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<string> VMSizes
        {
            get { return this._vMSizes; }
            set { this._vMSizes = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VmSizeCompatibilityFilter class.
        /// </summary>
        public VmSizeCompatibilityFilter()
        {
            this.ClusterFlavors = new LazyList<string>();
            this.ClusterVersions = new LazyList<string>();
            this.NodeTypes = new LazyList<string>();
            this.Regions = new LazyList<string>();
            this.VMSizes = new LazyList<string>();
        }
    }
}
