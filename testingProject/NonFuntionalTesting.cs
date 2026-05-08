using ULMSWinFormsApp;

namespace testingProject
{
    [TestClass]
    public sealed class NonFunctionalTests
    {
        private FrmLogin _form = null;

        public NonFunctionalTests()
        {
            this._form = new FrmLogin();
        }

        //performance testig

        // NFT-01: Report generation should complete within 2 seconds
        [TestMethod]
        [Timeout(2000)]
        public void NFT01_ReportGeneration_ShouldCompleteWithin2Seconds()
        {
            // Replicating the Thread.Sleep(4000) from FrmReports.cs btnGenerateReport_Click
            Thread.Sleep(4000);

            Assert.IsTrue(true, "Report generation should complete within 2 seconds.");
        }

        // NFT-02: Login authentication should respond within 1 second
        [TestMethod]
        public void NFT02_Login_ShouldRespondWithin1Second()
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            bool result = _form.login("admin", "1234");

            stopwatch.Stop();

            Assert.IsTrue(stopwatch.ElapsedMilliseconds < 1000,
                "Login should respond in under 1 second. Actual time: " + stopwatch.ElapsedMilliseconds + "ms.");
        }

        // security tests

        // NFT-03: Login should require BOTH correct username AND password
        [TestMethod]
        public void NFT03_Security_CorrectUsernameOnly_ShouldNotGrantAccess()
        {
            bool result = _form.login("admin", "wrongpassword");

            Assert.IsFalse(result,
                "Providing only a correct username should not grant access. Authentication bypass detected.");
        }

        // NFT-04: Login should reject correct password with wrong username
        [TestMethod]
        public void NFT04_Security_CorrectPasswordOnly_ShouldNotGrantAccess()
        {
            bool result = _form.login("hacker", "1234");

            Assert.IsFalse(result,
                "Providing only a correct password should not grant access. Authentication bypass detected.");
        }

        // NFT-05: SQL injection attempt should not grant access
        [TestMethod]
        public void NFT05_Security_SQLInjectionAttempt_ShouldFail()
        {
            bool result = _form.login("' OR 1=1 --", "' OR 1=1 --");

            Assert.IsFalse(result,
                "SQL injection input should not grant access.");
        }

        // reliability tests

        // NFT-06: System should handle 100 rapid login attempts without crashing
        [TestMethod]
        public void NFT06_Reliability_100RapidLoginAttempts_NoCrash()
        {
            bool completedSuccessfully = true;

            try
            {
                for (int i = 0; i < 100; i++)
                {
                    _form.login("admin", "1234");
                }
            }
            catch (Exception)
            {
                completedSuccessfully = false;
            }

            Assert.IsTrue(completedSuccessfully,
                "System should handle 100 rapid login attempts without crashing.");
        }

        // NFT-07: System should handle repeated valid and invalid login alternation
        [TestMethod]
        public void NFT07_Reliability_AlternatingValidInvalidLogins_NoCrash()
        {
            bool completedSuccessfully = true;

            try
            {
                for (int i = 0; i < 50; i++)
                {
                    _form.login("admin", "1234");
                    _form.login("wrong", "wrong");
                }
            }
            catch (Exception)
            {
                completedSuccessfully = false;
            }

            Assert.IsTrue(completedSuccessfully,
                "System should handle alternating valid/invalid login attempts without crashing.");
        }
    }
}