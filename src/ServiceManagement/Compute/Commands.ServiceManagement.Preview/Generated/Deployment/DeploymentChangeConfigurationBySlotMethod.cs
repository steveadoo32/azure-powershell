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
        protected object CreateDeploymentChangeConfigurationBySlotDynamicParameters()
        {
            dynamicParameters = new RuntimeDefinedParameterDictionary();
            var pServiceName = new RuntimeDefinedParameter();
            pServiceName.Name = "ServiceName";
            pServiceName.ParameterType = typeof(System.String);
            pServiceName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 1,
                Mandatory = true
            });
            pServiceName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ServiceName", pServiceName);

            var pDeploymentSlot = new RuntimeDefinedParameter();
            pDeploymentSlot.Name = "DeploymentSlot";
            pDeploymentSlot.ParameterType = typeof(Microsoft.WindowsAzure.Management.Compute.Models.DeploymentSlot);
            pDeploymentSlot.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 2,
                Mandatory = true
            });
            pDeploymentSlot.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("DeploymentSlot", pDeploymentSlot);

            var pParameters = new RuntimeDefinedParameter();
            pParameters.Name = "DeploymentChangeConfigurationBySlotParameters";
            pParameters.ParameterType = typeof(Microsoft.WindowsAzure.Management.Compute.Models.DeploymentChangeConfigurationParameters);
            pParameters.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 3,
                Mandatory = true
            });
            pParameters.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("DeploymentChangeConfigurationBySlotParameters", pParameters);

            return dynamicParameters;
        }

        protected void ExecuteDeploymentChangeConfigurationBySlotMethod(object[] invokeMethodInputParameters)
        {
            string serviceName = (string)ParseParameter(invokeMethodInputParameters[0]);
            DeploymentSlot deploymentSlot = (DeploymentSlot)ParseParameter(invokeMethodInputParameters[1]);
            DeploymentChangeConfigurationParameters parameters = (DeploymentChangeConfigurationParameters)ParseParameter(invokeMethodInputParameters[2]);

            var result = DeploymentClient.ChangeConfigurationBySlot(serviceName, deploymentSlot, parameters);
            WriteObject(result);
        }
    }

    public partial class NewAzureComputeParameterCmdlet : ComputeAutomationBaseCmdlet
    {
        protected object[] CreateDeploymentChangeConfigurationBySlotParameters()
        {
            string serviceName = string.Empty;
            DeploymentSlot deploymentSlot = new DeploymentSlot();
            DeploymentChangeConfigurationParameters parameters = new DeploymentChangeConfigurationParameters();

            return new object[] { serviceName, deploymentSlot, parameters };
        }
    }
}
