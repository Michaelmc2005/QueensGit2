using System;
using queensGame;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Hardware;
using Android.Widget;
using Xamarin.Forms;
using Android.Content;
using Android.Media;

namespace queensGame.Droid
{
    [Activity(Label = "queens", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, ISensorEventListener
    {
        MediaPlayer _player;
        private SensorManager sensorManager;
        private Sensor accelerometer;

        private float acceleration;
        private float currentAcceleration;
        private float lastAcceleration;

        private MainPage mainPage;

        private Label label;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            _player = MediaPlayer.Create(this, Resource.Raw.test);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            base.OnCreate(savedInstanceState);

            sensorManager = (SensorManager)GetSystemService(SensorService);
            accelerometer = sensorManager.GetDefaultSensor(SensorType.Accelerometer);
            acceleration = 0.00f;
            currentAcceleration = SensorManager.GravityEarth;
            lastAcceleration = SensorManager.GravityEarth;

            //label = FindViewById<Label>(Resource.Id.label);


            LoadApplication(new App());

        }
        public void OnAccuracyChanged(Sensor sensor, SensorStatus accuracy)
        {

        }

        public void OnSensorChanged(SensorEvent e)
        {
            float x = e.Values[0];
            float y = e.Values[1];
            float z = e.Values[2];


            lastAcceleration = currentAcceleration;
            currentAcceleration = (float)Math.Sqrt((double)(x * x + y * y + z * z));
            float delta = currentAcceleration - lastAcceleration;
            acceleration = acceleration * 0.9f + delta;


            if (acceleration > 3.5)
            {
                //mainPage.ShakeDetected();
                Toast.MakeText(this, "Shake detected!", ToastLength.Short).Show();
                
            }
        }
        protected override void OnResume()
        {
            base.OnResume();
            sensorManager.RegisterListener(this, accelerometer, SensorDelay.Ui);
        }

        protected override void OnPause()
        {
            base.OnPause();
            sensorManager.UnregisterListener(this);
        }
        private void ShakeDetected()
        {

            // Add your code here to handle the shake event
            // For example, you might show a toast message or vibrate the phone

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
