using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dxc.FibonacciAPI.Controller;
using System.Threading.Tasks;
using dxc.FibonacciAPI.Service;
using dxc.FibonacciAPI.Models;

namespace dxc.FibonacciTest.controller
{
    [TestClass]
    public class FibonacciControllerTest
    {
        [TestMethod]
        [DataRow(4)]
        [DataRow(8)]
        [DataRow(3)]
        public async Task Get(int id)
        {
            // Arrange
            CalculateValue service = new CalculateValue();
            // Act
            CalculationResult response = await service.CreateFibonacci(1);

            // Assert
            Assert.IsNotNull(response.Result);
            Assert.AreEqual(id, "0, 1, 1, 2");
        }
    }
}