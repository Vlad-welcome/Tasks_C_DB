namespace myTestLib
{
	public interface IFigure
	{
		double CalculateArea();
	}

	public class Circle : IFigure
	{
		public double Radius { get; private set; }

		public Circle(double radius)
		{
			if (radius <= 0) throw new ArgumentException($"Error: Raduis must be positive");

			this.Radius = radius;	
		}

		public double CalculateArea()
		{
			return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
		}
	}

	public class Triangle : IFigure
	{
		public double sideA { get; private set; }
		public double sideB { get; private set; }
		public double sideC { get; private set; }

		public Triangle(double sideA, double sideB, double sideC)
		{
			if (sideA <= 0 || sideB <= 0 || sideC <= 0)
				throw new ArgumentException("Sides must be positive.");

			if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
				throw new ArgumentException("There is no triangle with such sides.");

			this.sideA = sideA;
			this.sideB = sideB;
			this.sideC = sideC;
		}

		public double CalculateArea()
		{
			double p = (sideA + sideB + sideC) / 2;
			return Math.Round(Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC)), 1);
		}

		public bool isRectangular()
		{
			return	(sideA == Math.Sqrt(Math.Pow(sideB, 2) + Math.Pow(sideC, 2))
					|| sideB == Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideC, 2))
					|| sideC == Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2)));
		}
	}
}
