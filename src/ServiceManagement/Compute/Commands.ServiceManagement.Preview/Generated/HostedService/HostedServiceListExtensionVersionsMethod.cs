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

using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;
using System;
using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.WindowsAzure.Commands.Compute.Automation
{
    public partial class InvokeAzureComputeMethodCmdlet : ComputeAutomationBaseCmdlet
    {
        protected object CreateHostedServiceListExtensionVersionsDynamicParameters()
        {
            dynamicParameters = new RuntimeDefinedParameterDictionary();
            var pProviderNamespace = new RuntimeDefinedParameter();
            pProviderNamespace.Name = "ProviderNamespace";
            pProviderNamespace.ParameterType = typeof(System.String);
            pProviderNamespace.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 1,
                Mandatory = true
            });
            pProviderNamespace.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ProviderNamespace", pProviderNamespace);

            var pExtensionType = new RuntimeDefinedParameter();
            pExtensionType.Name = "ExtensionType";
            pExtensionType.ParameterType = typeof(System.String);
            pExtensionType.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 2,
                Mandatory = true
            });
            pExtensionType.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ExtensionType", pExtensionType);

            return dynamicParameters;
        }

        protected void ExecuteHostedServiceListExtensionVersionsMethod(object[] invokeMethodInputParameters)
        {
            string providerNamespace = (string)ParseParameter(invokeMethodInputParameters[0]);
            string extensionType = (string)ParseParameter(invokeMethodInputParameters[1]);

            var result = HostedServiceClient.ListExtensionVersions(providerNamespace, extensionType);
            WriteObject(result);
        }
    }

    public partial class NewAzureComputeParameterCmdlet : ComputeAutomationBaseCmdlet
    {
        protected object[] CreateHostedServiceListExtensionVersionsParameters()
        {
            string providerNamespace = string.Empty;
            string extensionType = string.Empty;

            return new object[] { providerNamespace, extensionType };
        }
    }
}
