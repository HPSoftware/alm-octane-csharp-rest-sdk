﻿/*!
* (c) 2016-2018 EntIT Software LLC, a Micro Focus company
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/


using MicroFocus.Adm.Octane.Api.Core.Entities;
using MicroFocus.Adm.Octane.Api.Core.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MicroFocus.Adm.Octane.Api.Core.Tests
{
	[TestClass]
    public class WorkspaceUserTests : BaseTest
    {

        [TestMethod]
        public void GetAllWorkspaceUsers()
        {
            EntityListResult<WorkspaceUser> users = entityService.Get<WorkspaceUser>(workspaceContext, null, null);
            Assert.IsTrue(users.total_count >= 1);

        }
    }
}