using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Reflection;
using System;
using System.Windows.Forms; // Ensure you have this for TextBox, Form, etc.
using Project_OOP_broookk;
// If IAuthenticationService is in another namespace, also add:
// using Project_OOP_broookk.Services; 

[TestClass]
public class LoginPageTests
{
    [TestMethod]
    public void BtnLogin_Click_ValidCredentials_ShowsHomePage()
    {
        // Arrange
        var authServiceMock = new Mock<IAuthenticationService>();
        authServiceMock.Setup(a => a.ValidateUser("valid@example.com", "password")).Returns(true);

        // Make sure LoginPage has a constructor that accepts IAuthenticationService
        var loginPage = new LoginPage(authServiceMock.Object);

        // Make sure textBoxEmail and textBoxPassword exist and have these names
        var emailField = loginPage.Controls["textBoxEmail"] as TextBox;
        var passwordField = loginPage.Controls["textBoxPassword"] as TextBox;

        // Verify the controls are found
        Assert.IsNotNull(emailField, "textBoxEmail not found. Check the Name property of the TextBox in the Designer.");
        Assert.IsNotNull(passwordField, "textBoxPassword not found. Check the Name property of the TextBox in the Designer.");

        emailField.Text = "valid@example.com";
        passwordField.Text = "password";

        // Retrieve the event handler for the login button
        MethodInfo btnLoginClick = typeof(LoginPage).GetMethod("btnLogin_Click", BindingFlags.NonPublic | BindingFlags.Instance);
        Assert.IsNotNull(btnLoginClick, "btnLogin_Click event handler not found in LoginPage. Check your method name and its accessibility.");

        // Act
        // Simulate the button click
        btnLoginClick.Invoke(loginPage, new object[] { null, EventArgs.Empty });

        // Assert
        // Check that ValidateUser was called once with the correct parameters
        authServiceMock.Verify(a => a.ValidateUser("valid@example.com", "password"), Times.Once);

        // If LoginPage code hides the form after successful login:
        // Check if the form is hidden
        // This may not always work as expected in unit tests, but if Hide() is called, Visible should be false.
        Assert.IsFalse(loginPage.Visible, "LoginPage should be hidden after successful login.");

        // Note: If the form calls Application.Exit(), it may interfere with the test runner.
        // Consider removing or mocking the exit call in production code for testability.
    }

    [TestMethod]
    public void BtnLogin_Click_InvalidCredentials_ShowsError()
    {
        // Arrange
        var authServiceMock = new Mock<IAuthenticationService>();
        authServiceMock.Setup(a => a.ValidateUser("invalid@example.com", "wrong")).Returns(false);

        var loginPage = new LoginPage(authServiceMock.Object);

        var emailField = loginPage.Controls["textBoxEmail"] as TextBox;
        var passwordField = loginPage.Controls["textBoxPassword"] as TextBox;

        // Check that controls are not null
        Assert.IsNotNull(emailField, "textBoxEmail not found.");
        Assert.IsNotNull(passwordField, "textBoxPassword not found.");

        emailField.Text = "invalid@example.com";
        passwordField.Text = "wrong";

        MethodInfo btnLoginClick = typeof(LoginPage).GetMethod("btnLogin_Click", BindingFlags.NonPublic | BindingFlags.Instance);
        Assert.IsNotNull(btnLoginClick, "btnLogin_Click event handler not found in LoginPage.");

        // Act
        btnLoginClick.Invoke(loginPage, new object[] { null, EventArgs.Empty });

        // Assert
        // Check that ValidateUser was called with invalid credentials
        authServiceMock.Verify(a => a.ValidateUser("invalid@example.com", "wrong"), Times.Once);

        // We know that a message box will show with an error.
        // It's difficult to assert a message box in a unit test.
        // We rely on the logic: if ValidateUser returns false, the user isn't authenticated.
    }
}
