using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace Hello_1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button btn = FindViewById<Button>(Resource.Id.button1);
            TextView txtView = FindViewById<TextView>(Resource.Id.textView1);
            EditText txtEdit = FindViewById<EditText>(Resource.Id.editText1);

            btn.Click += delegate {
                txtView.Text = txtEdit.Text;
                txtEdit.Text = "";
            };
        }
    }
}

