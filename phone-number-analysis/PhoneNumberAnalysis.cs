public static class PhoneNumber
{
	/// <summary>
	/// Takes in a phone number and returns a tuple
	/// which contains if the phone number is in New York,
	/// if it is fake, and the local number
	/// </summary>
	/// <param name="IsNewYork"></param>
	/// <param name="IsFake"></param>
	/// <param name="phoneNumber"></param>
	/// <returns>(IsNewYork, IsFake, LocalNumber)</returns>
	public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber) => 
        phoneNumber.Split('-') switch { 
            var analysis => (analysis[0].Equals("212"), analysis[1].Equals("555"), analysis[2])};
    
	/// <summary>
	/// Takes in a tuple and returns if the phone
	/// number is fake
	/// </summary>
	/// <param name="IsNewYork"></param>
	/// <param name="IsFake"></param>
	/// <param name="phoneNumberInfo"></param>
	/// <returns>IsFake</returns>
	public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
