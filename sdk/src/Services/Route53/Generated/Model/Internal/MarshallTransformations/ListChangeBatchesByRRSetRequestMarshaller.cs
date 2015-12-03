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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListChangeBatchesByRRSet Request Marshaller
    /// </summary>       
    public class ListChangeBatchesByRRSetRequestMarshaller : IMarshaller<IRequest, ListChangeBatchesByRRSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListChangeBatchesByRRSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListChangeBatchesByRRSetRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            request.HttpMethod = "GET";
            string uriResourcePath = "/2013-04-01/hostedzone/{Id}/rrsChanges";
            uriResourcePath = uriResourcePath.Replace("{Id}", publicRequest.IsSetHostedZoneId() ? StringUtils.FromString(publicRequest.HostedZoneId) : string.Empty);
            
            if (publicRequest.IsSetName())
                request.Parameters.Add("rrSet_name", StringUtils.FromString(publicRequest.Name));
            
            if (publicRequest.IsSetType())
                request.Parameters.Add("type", StringUtils.FromString(publicRequest.Type));
            
            if (publicRequest.IsSetSetIdentifier())
                request.Parameters.Add("identifier", StringUtils.FromString(publicRequest.SetIdentifier));
            
            if (publicRequest.IsSetStartDate())
                request.Parameters.Add("startDate", StringUtils.FromString(publicRequest.StartDate));
            
            if (publicRequest.IsSetEndDate())
                request.Parameters.Add("endDate", StringUtils.FromString(publicRequest.EndDate));
            
            if (publicRequest.IsSetMaxItems())
                request.Parameters.Add("maxItems", StringUtils.FromString(publicRequest.MaxItems));
            
            if (publicRequest.IsSetMarker())
                request.Parameters.Add("marker", StringUtils.FromString(publicRequest.Marker));
            request.ResourcePath = uriResourcePath;


            request.UseQueryString = true;
            return request;
        }

        
    }    
}