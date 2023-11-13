namespace BlazorApp1.DataModels
{
	public class Product
	{
		public string Id { get; set; }
		public int AskingPrice { get; set; }	
		public int Units { get; set; }
		public int Total => Units * AskingPrice; // Can't be SET from outside
	}
}
