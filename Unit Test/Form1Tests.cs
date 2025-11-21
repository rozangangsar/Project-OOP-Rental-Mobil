using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using Project_OOP_broookk;

namespace Project_OOP_broookk.Tests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void BtnRegister_Click_InvokesHandler_WithoutThrowing()
        {
            // Arrange
            var form = new Form1();

            // We know that the btnRegister_Click handler is private.
            // Let's get it using reflection.
            MethodInfo methodInfo = typeof(Form1).GetMethod("btnRegister_Click",
                BindingFlags.NonPublic | BindingFlags.Instance);

            Assert.IsNotNull(methodInfo, "btnRegister_Click event handler not found.");

            // Act & Assert
            // We're just verifying no exceptions occur when we invoke it.
            // This doesn't guarantee UI calls like ShowDialog() or Application.Exit() worked as expected.
            try
            {
                methodInfo.Invoke(form, new object[] { null, EventArgs.Empty });
            }
            catch (TargetInvocationException ex)
            {
                Assert.Fail($"btnRegister_Click threw an exception: {ex.InnerException.Message}");
            }
        }
    }
}
