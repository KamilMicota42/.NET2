﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace FizzBuzzWeb.Forms
{
    public class FizzBuzzForm
    {
		[Display(Name = "Twój szczęśliwy numerek")]
		[Required, Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakredu {1} i {2}.")]



		public int? Number { get; set; }


		public string check()
		{
			string comment = "";

			if (Number%3 == 0)
			{
				comment += "Fizz";
			}
			if (Number % 5 == 0)
			{
				comment += "Buzz";
			}

			return comment;
		}
	}


}
