namespace Moment_1_2_Blazor_Wasm.Shared
{
	public class SecondModel
	{
		public int Kmh { get; set; }
		public int Mph { get; set; }

		//Konvertera Kilometer i timmen till miles per hour
		public void ConvertKmhToMph()
		{
			double temp = this.Kmh / 1.609344; //Konvertera kmh till mph
			this.Mph = Convert.ToInt32(temp); //Konvertera double till Int (Heltal)


        }
	}
}
