using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
	public class Car
	{
		public string registrationNumber { get; set; }
		public string color { get; set; }
		public string model { get; set; }
		 

		public Car(string RegistrationNumber, string Color, string Model)
		{
			this.registrationNumber = RegistrationNumber;
			this.color = Color;
			this.model = Model;
		}
		public override string ToString()
		{
			return $"Model: {model}, Color:  {color}  RegistrationNumber: {registrationNumber}";
		}

	}
}
