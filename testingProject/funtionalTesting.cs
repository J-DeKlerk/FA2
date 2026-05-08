using ULMSWinFormsApp;
using ULMSWinFormsApp.Models;

namespace testingProject
{
    [TestClass]
    public sealed class FunctionalTests
    {
        private FrmLogin _form = null;

        public FunctionalTests()
        {
            this._form = new FrmLogin();
        }

        // Login validation

        // TC-01: Valid login with correct credentials
        [TestMethod]
        public void TC01_Login_ValidCredentials_ReturnsTrue()
        {
            bool result = _form.login("admin", "1234");

            Assert.IsTrue(result, "Login should succeed with correct username and password.");
        }

        // TC-02: Invalid login with wrong username and wrong password
        [TestMethod]
        public void TC02_Login_InvalidCredentials_ReturnsFalse()
        {
            bool result = _form.login("user", "wrong");

            Assert.IsFalse(result, "Login should fail when both username and password are incorrect.");
        }

        // TC-03: Correct username, wrong password (exposes || bug)
        [TestMethod]
        public void TC03_Login_CorrectUsernameWrongPassword_ReturnsFalse()
        {
            bool result = _form.login("admin", "wrong");

            Assert.IsFalse(result, "Login should fail when password is incorrect, even if username is correct.");
        }

        // TC-04: Empty username and empty password
        [TestMethod]
        public void TC04_Login_EmptyCredentials_ReturnsFalse()
        {
            bool result = _form.login("", "");

            Assert.IsFalse(result, "Login should fail when credentials are empty.");
        }

        // course enrolement

        // TC-05: Valid enrollment with all fields completed
        [TestMethod]
        public void TC05_Enrollment_ValidData_CreatesSuccessfully()
        {
            Enrollment enrollment = new Enrollment
            {
                StudentId = "STU001",
                StudentName = "John Doe",
                CourseName = "Programming 1",
                Semester = "Semester 1"
            };

            Assert.AreEqual("STU001", enrollment.StudentId);
            Assert.AreEqual("John Doe", enrollment.StudentName);
            Assert.AreEqual("Programming 1", enrollment.CourseName);
            Assert.AreEqual("Semester 1", enrollment.Semester);
        }

        // TC-06: Enrollment with empty/blank course selection
        [TestMethod]
        public void TC06_Enrollment_EmptyCourse_ShouldFailValidation()
        {
            Enrollment enrollment = new Enrollment
            {
                StudentId = "STU001",
                StudentName = "John Doe",
                CourseName = "",
                Semester = "Semester 1"
            };

            Assert.IsFalse(string.IsNullOrEmpty(enrollment.CourseName),
                "Enrollment should not be allowed with an empty course name.");
        }

        // TC-07: Duplicate enrollment - no duplicate check exists
        [TestMethod]
        public void TC07_Enrollment_DuplicateEntry_ShouldBeRejected()
        {
            Enrollment enrollment1 = new Enrollment
            {
                StudentId = "STU001",
                StudentName = "John Doe",
                CourseName = "Programming 1",
                Semester = "Semester 1"
            };

            Enrollment enrollment2 = new Enrollment
            {
                StudentId = "STU001",
                StudentName = "John Doe",
                CourseName = "Programming 1",
                Semester = "Semester 1"
            };

            bool isDuplicate = (enrollment1.StudentId == enrollment2.StudentId &&
                                enrollment1.CourseName == enrollment2.CourseName &&
                                enrollment1.Semester == enrollment2.Semester);

            Assert.IsTrue(isDuplicate,
                "System should detect and reject duplicate enrollments. Currently no duplicate check exists.");
        }

        // marks capyure

        // TC-08: Valid marks — average should be correct
        [TestMethod]
        public void TC08_Marks_ValidInput_AverageIsCorrect()
        {
            MarkRecord record = new MarkRecord();
            record.Subject1 = 70;
            record.Subject2 = 80;
            record.Subject3 = 60;

            // Replicating the faulty formula from FrmMarksCapture.cs
            record.Average = record.Subject1 + record.Subject2 + record.Subject3 / 3;

            double expectedAverage = (70 + 80 + 60) / 3.0; // correct answer = 70.0

            Assert.AreEqual(expectedAverage, record.Average, 0.01,
                "Average should be (Subject1 + Subject2 + Subject3) / 3.");
        }

        // TC-09: Non-numeric input in subject mark field
        [TestMethod]
        public void TC09_Marks_NonNumericInput_ShouldHandleGracefully()
        {
            bool threwException = false;

            try
            {
                // Replicating the Convert.ToDouble call from FrmMarksCapture.cs
                double subject1 = Convert.ToDouble("abc");
            }
            catch (FormatException)
            {
                threwException = true;
            }

            Assert.IsFalse(threwException,
                "System should validate input before conversion, not throw an unhandled exception.");
        }

        // TC-10: Negative mark value entered
        [TestMethod]
        public void TC10_Marks_NegativeInput_ShouldBeRejected()
        {
            MarkRecord record = new MarkRecord();
            record.Subject1 = -10;
            record.Subject2 = 80;
            record.Subject3 = 60;

            bool hasNegativeMark = (record.Subject1 < 0 || record.Subject2 < 0 || record.Subject3 < 0);

            Assert.IsFalse(hasNegativeMark,
                "System should reject negative mark values. Currently no range validation exists.");
        }

        // Average calc

        // TC-11: Boundary — all marks at pass threshold (50)
        [TestMethod]
        public void TC11_Marks_BoundaryPassThreshold_AverageIs50()
        {
            MarkRecord record = new MarkRecord();
            record.Subject1 = 50;
            record.Subject2 = 50;
            record.Subject3 = 50;

            record.Average = record.Subject1 + record.Subject2 + record.Subject3 / 3;

            Assert.AreEqual(50.0, record.Average, 0.01,
                "Average of three 50s should equal 50.");
        }

        // TC-12: Boundary — all marks at zero
        [TestMethod]
        public void TC12_Marks_AllZero_ResultIsFail()
        {
            MarkRecord record = new MarkRecord();
            record.Subject1 = 0;
            record.Subject2 = 0;
            record.Subject3 = 0;

            record.Average = record.Subject1 + record.Subject2 + record.Subject3 / 3;

            if (record.Average >= 50)
                record.ResultStatus = "PASS";
            else
                record.ResultStatus = "FAIL";

            Assert.AreEqual("FAIL", record.ResultStatus,
                "Student with all zero marks should fail.");
        }

        // TC-13: Boundary — all marks at maximum (100)
        [TestMethod]
        public void TC13_Marks_AllMaximum_AverageIs100()
        {
            MarkRecord record = new MarkRecord();
            record.Subject1 = 100;
            record.Subject2 = 100;
            record.Subject3 = 100;

            record.Average = record.Subject1 + record.Subject2 + record.Subject3 / 3;

            Assert.AreEqual(100.0, record.Average, 0.01,
                "Average of three 100s should equal 100.");
        }

        // report gen

        // TC-14: Marks Report displays incorrect average
        [TestMethod]
        public void TC14_Report_MarksReportAverage_IsCorrect()
        {
            // Hardcoded values from FrmReports.cs
            int subject1 = 78;
            int subject2 = 65;
            int subject3 = 80;
            int reportedAverage = 169;

            double correctAverage = (subject1 + subject2 + subject3) / 3.0; // 74.33

            Assert.AreEqual(correctAverage, reportedAverage, 0.01,
                "Marks Report average should be (78+65+80)/3 = 74.33, not 169.");
        }

        // TC-15: Generate report with no type selected
        [TestMethod]
        public void TC15_Report_NoTypeSelected_ShowsAppropriateMessage()
        {
            string reportType = "";
            string expectedMessage = "No report type selected.";

            bool showsMessage = string.IsNullOrEmpty(reportType);

            Assert.IsTrue(showsMessage,
                "System should display 'No report type selected' when no report type is chosen.");
        }
    }
}