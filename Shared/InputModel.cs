namespace Moment_1_2_Blazor_Wasm.Shared
{
	public class InputModel
	{
		public string? StrMetres { get; set; }

		public string? StrFeet { get; set; }
		public double Metres { get; set; }
		public double Feet { get; set; }


		//Konvertera strängen metres till double
		public void ConvertToDouble()
		{
			this.Metres = Convert.ToDouble(this.StrMetres);
		}

		//Konvertera M till Feet
		public string ConvertToFeet()
		{
			this.Feet = (this.Metres / 0.3048); //Räkna om M till Feet
			this.Feet = Math.Round(Feet, 2); //Två decimaler
			this.StrFeet = this.Feet.ToString(); //Konvertera till sträng

			return this.StrFeet; //Returnera strängen

        }
	}
}
