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
    /// Container for the parameters to the SearchOrganizationInsights operation.
    /// Returns a list of insights in your organization. You can specify which insights are
    /// returned by their start time, one or more statuses (<code>ONGOING</code>, <code>CLOSED</code>,
    /// and <code>CLOSED</code>), one or more severities (<code>LOW</code>, <code>MEDIUM</code>,
    /// and <code>HIGH</code>), and type (<code>REACTIVE</code> or <code>PROACTIVE</code>).
    /// 
    /// 
    ///  
    /// <para>
    ///  Use the <code>Filters</code> parameter to specify status and severity search parameters.
    /// Use the <code>Type</code> parameter to specify <code>REACTIVE</code> or <code>PROACTIVE</code>
    /// in your search. 
    /// </para>
    /// </summary>
    public partial class SearchOrganizationInsightsRequest : AmazonDevOpsGuruRequest
    {
        private List<string> _accountIds = new List<string>();
        private SearchOrganizationInsightsFilters _filters;
        private int? _maxResults;
        private string _nextToken;
        private StartTimeRange _startTimeRange;
        private InsightType _type;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The ID of the Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && this._accountIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        ///  A <code>SearchOrganizationInsightsFilters</code> object that is used to set the severity
        /// and status filters on your insight search. 
        /// </para>
        /// </summary>
        public SearchOrganizationInsightsFilters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <code>nextToken</code> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

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
        /// Gets and sets the property StartTimeRange.
        /// </summary>
        [AWSProperty(Required=true)]
        public StartTimeRange StartTimeRange
        {
            get { return this._startTimeRange; }
            set { this._startTimeRange = value; }
        }

        // Check to see if StartTimeRange property is set
        internal bool IsSetStartTimeRange()
        {
            return this._startTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of insights you are searching for (<code>REACTIVE</code> or <code>PROACTIVE</code>).
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InsightType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}