using System;

using Xamarin.Forms;
using System.Threading.Tasks;
using SimpleInjector;

namespace yossymobileapp
{
    public interface IAuthenticate {
        Task<bool> Authenticate();
    }

    public class App : Application
	{
        public static Container DIContainer { get; private set; }

        public static IAuthenticate Authenticator { get; private set; }

        public static void Init(IAuthenticate authenticator) {
            Authenticator = authenticator;
        }

        public App ()
		{
            // DIコンテナセットアップ
            DIContainer = new Container();

            // AzureB2C
            DIContainer.RegisterSingleton<IAuthorizationService>(() => {
                return new AuthorizationService(
                    ) {
                    ApplicationID = Constants.ApplicationID,
                    Scopes = Constants.Scopes,
                    SignInUpPolicy = Constants.SingInUpPolicy,
                    Authority = Constants.Authority
                };
            });

            DIContainer.Verify();

            // The root page of your application
            MainPage = new TodoList();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

