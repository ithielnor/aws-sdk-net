/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides aggregated data for a usage metric. The value for the metric reports usage
    /// data for an account during the past 30 days.
    /// </summary>
    public partial class UsageTotal
    {
        private Currency _currency;
        private string _estimatedCost;
        private UsageType _type;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The type of currency that the value for the metric (estimatedCost) is reported in.
        /// </para>
        /// </summary>
        public Currency Currency
        {
            get { return this._currency; }
            set { this._currency = value; }
        }

        // Check to see if Currency property is set
        internal bool IsSetCurrency()
        {
            return this._currency != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedCost. 
        /// <para>
        /// The estimated value for the metric.
        /// </para>
        /// </summary>
        public string EstimatedCost
        {
            get { return this._estimatedCost; }
            set { this._estimatedCost = value; }
        }

        // Check to see if EstimatedCost property is set
        internal bool IsSetEstimatedCost()
        {
            return this._estimatedCost != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The name of the metric. Possible values are: DATA_INVENTORY_EVALUATION, for monitoring
        /// S3 buckets; and, SENSITIVE_DATA_DISCOVERY, for analyzing sensitive data.
        /// </para>
        /// </summary>
        public UsageType Type
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