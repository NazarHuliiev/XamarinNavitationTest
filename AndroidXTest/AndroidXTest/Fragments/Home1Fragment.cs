using Android.OS;
using Android.Runtime;
using Android.Views;
using AppCompatFragment = AndroidX.Fragment.App.Fragment;

namespace AndroidXTest.Fragments
{
    [Register("com.companyname.androidxtest.fragments.home1Fragment")]
    public class Home1Fragment : AppCompatFragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.fragment_home1, container, false);
        }
    }
}