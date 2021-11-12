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
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsGuru.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DevOpsGuru.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AccountHealth Object
    /// </summary>  
    public class AccountHealthUnmarshaller : IUnmarshaller<AccountHealth, XmlUnmarshallerContext>, IUnmarshaller<AccountHealth, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AccountHealth IUnmarshaller<AccountHealth, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AccountHealth Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AccountHealth unmarshalledObject = new AccountHealth();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Insight", targetDepth))
                {
                    var unmarshaller = AccountInsightHealthUnmarshaller.Instance;
                    unmarshalledObject.Insight = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AccountHealthUnmarshaller _instance = new AccountHealthUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AccountHealthUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}