using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yossymobileapp {
    public interface IAuthorizationService {
        Task AcquireTokenAsync(string policy);
    }

    public class AuthorizationService : IAuthorizationService {
        /// <summary>
        /// アプリケーションID
        /// </summary>
        public string ApplicationID { get; set; }
        /// <summary>
        /// 要求スコープ
        /// </summary>
        public string[] Scopes { get; set; }
        /// <summary>
        /// サインイン＆サインアップポリシー
        /// </summary>
        public string SignInUpPolicy { get; set; }
        /// <summary>
        /// Authority
        /// </summary>
        public string Authority { get; set; }

        public string AccessToken { get; private set; }

        private PublicClientApplication ADB2CClient_;
        private PublicClientApplication ADB2CClient {
            get {
                ADB2CClient_ = ADB2CClient_ ??
                    new PublicClientApplication(ApplicationID, Authority);
                return ADB2CClient_;
            }
        }

        public async Task AcquireTokenAsync(string policy) {
            /*
            AuthenticationClient_.PlatformParameters = B2CPlatformParams_.BuildPlatformParameters();

            AccessToken = result.Token;
            */
            var result = await ADB2CClient_.AcquireTokenAsync(
                Scopes,
                string.Empty,
                UIBehavior.SelectAccount,
                string.Empty);
            AccessToken = result.AccessToken;
        }

    }
}
