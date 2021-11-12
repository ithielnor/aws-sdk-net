/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Container for the parameters to the GetResourceCollection operation.
    /// Returns lists Amazon Web Services resources that are of the specified resource collection
    /// type. The one type of Amazon Web Services resource collection supported is Amazon
    /// Web Services CloudFormation stacks. DevOps Guru can be configured to analyze only
    /// the Amazon Web Services resources that are defined in the stacks. You can specify
    /// up to 500 Amazon Web Services CloudFormation stacks.
    /// </summary>
    public partial class GetResourceCollectionRequest : AmazonDevOpsGuruRequest
    {
        private string _nextToken;
        private ResourceCollectionType _resourceCollectionType;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// If this value is null, it retrieves the first page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceCollectionType. 
        /// <para>
        ///  The type of Amazon Web Services resource collections to return. The one valid value
        /// is <code>CLOUD_FORMATION</code> for Amazon Web Services CloudFormation stacks. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceCollectionType ResourceCollectionType
        {
            get { return this._resourceCollectionType; }
            set { this._resourceCollectionType = value; }
        }

        // Check to see if ResourceCollectionType property is set
        internal bool IsSetResourceCollectionType()
        {
            return this._resourceCollectionType != null;
        }

    }
}