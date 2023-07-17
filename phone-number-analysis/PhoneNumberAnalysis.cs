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
	public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
	{
		(bool IsNewYork, bool IsFake, string LocalNumber) analysis = (false, false, "");
		var phoneNumberSections = phoneNumber.Split("-");
		var areaCode = phoneNumberSections[0];
		analysis.IsNewYork = areaCode.Equals("212") ? true : false;
		var potentialFakeNumber = phoneNumberSections[1];
		analysis.IsFake = potentialFakeNumber.Equals("555") ? true : false;
		analysis.LocalNumber = phoneNumberSections[2];
		return analysis;
	}

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
