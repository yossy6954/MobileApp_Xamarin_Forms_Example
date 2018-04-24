using System;

namespace yossymobileapp
{
	public static class Constants
	{
        /// <summary>
        /// AzureB2C設定情報
        /// </summary>
        public const string ApplicationID = "101abe36-adaf-4b57-9ca0-38502187511c";
        public static string[] Scopes = { ApplicationID };
        public const string SingInUpPolicy = "B2C_1_sign_in_up";
        public const string Authority = "https://login.microsoftonline.com/yossyad.onmicrosoft.com/";


        // Replace strings with your Azure Mobile App endpoint.
        public static string ApplicationURL = @"https://yossymobileapp.azurewebsites.net";
	}
}

