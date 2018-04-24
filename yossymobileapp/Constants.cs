using System;

namespace yossymobileapp
{
	public static class Constants
	{
        /// <summary>
        /// AzureB2C設定情報
        /// </summary>
        public const string ApplicationID = "39262b82-5641-4879-9730-4e70ddb361f5";
        public static string[] Scopes = { ApplicationID };
        public const string SingInUpPolicy = "B2C_1_sign_in_sign_up";
        public const string Authority = "https://login.microsoftonline.com/pasmodevb2c.onmicrosoft.com/";


        // Replace strings with your Azure Mobile App endpoint.
        public static string ApplicationURL = @"https://yossymobileapp.azurewebsites.net";
	}
}

