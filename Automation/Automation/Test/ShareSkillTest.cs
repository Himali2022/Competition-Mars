using Automation.Pages;
using Automation.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Test
{
    [TestFixture]
    public class ShareSkillTest:Commondriver
    {
        [Test, Order(1)]
        public void LoginAction()
        {
            var signInPageObj = new SignInPage();
            signInPageObj.LoginAction();
        }
        [Test, Order(2)]
        public void CreateShareSkill()
        {
            var shareSkillPageObj = new ShareSkillPage();
            shareSkillPageObj.CreateShareSkill();
        }
    }
}
