using Microsoft.VisualStudio.TestTools.UnitTesting;
using myTestLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTestLib.Tests
{
	[TestClass()]
	public class CircleTest
	{
		[TestMethod()]
		public void Radius_5_Return_78_5()
		{
			// arrange
			Circle circle = new Circle(5);
			double expected = 78.5;

			// act
			double result = circle.CalculateArea();

			// assert
			Assert.AreEqual(expected, result);
		}
	}

	[TestClass()]
	public class TriangleTest
	{
		[TestMethod]
		public void Square_5_5_6_Return_12()
		{
			// arrange
			Triangle triangle = new Triangle(5, 5, 6);
			double expected = 12;

			// act
			double result = triangle.CalculateArea();

			// assert
			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Triangle_is_Rectangular_ReturnTrue()
		{
			// arrange
			Triangle triangle = new Triangle(3, 4, 5);

			// act
			bool result = triangle.isRectangular();

			// assert
			Assert.IsTrue(result);
		}
	}
}