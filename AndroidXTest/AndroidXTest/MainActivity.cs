using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using AndroidX.Navigation.Fragment;
using AndroidX.Navigation.UI;
using Google.Android.Material.BottomNavigation;

namespace AndroidXTest
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            SetupNavigation();
        }

        private void SetupNavigation()
        {
            var bottomNavigationView = FindViewById<BottomNavigationView>(Resource.Id.main_bottom_navigation_view);
            NavHostFragment navHostFragment = (NavHostFragment)SupportFragmentManager
                .FindFragmentById(Resource.Id.fragNavHost);
            NavigationUI.SetupWithNavController(
                bottomNavigationView,
                navHostFragment.NavController);
        }
    }
}