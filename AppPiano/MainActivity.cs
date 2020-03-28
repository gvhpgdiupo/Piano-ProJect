using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using DotLiquid.Util;
using Android.Media;
using System.Data;
using System;
using Android.Content.Res;
using Android.Content;
using SQLite;
using System.IO;

namespace AppPiano
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        private MediaPlayer pc,pd,pe,pf,pg,pa,pb,pc1,pd1,pe1,pf1;
        private MediaPlayer pc_s,pd_s,pf_s,pg_s,pBb,pc_s1,pd_s1;
     
        public void PlaySound() 
        {
            pc = MediaPlayer.Create(this, Resource.Raw.C);
            Button cbtn = FindViewById<Button>(Resource.Id.c);
            cbtn.Click += (sender, e) =>
            {
                pc.Start();
            };
            pd = MediaPlayer.Create(this, Resource.Raw.D);
            Button dbtn = FindViewById<Button>(Resource.Id.d);
            dbtn.Click += (sender, e) =>
            {
                pd.Start();
            };


            pe = MediaPlayer.Create(this, Resource.Raw.E);
            Button ebtn = FindViewById<Button>(Resource.Id.e);
            ebtn.Click += (sender, e) =>
            {
                pe.Start();
            };

            pf = MediaPlayer.Create(this, Resource.Raw.F);
            Button fbtn = FindViewById<Button>(Resource.Id.f);
            fbtn.Click += (sender, e) =>
            {
                pf.Start();
            };

            pg = MediaPlayer.Create(this, Resource.Raw.G);
            Button gbtn = FindViewById<Button>(Resource.Id.g);
            gbtn.Click += (sender, e) =>
            {
                pg.Start();
            };

            pa = MediaPlayer.Create(this, Resource.Raw.A);
            Button abtn = FindViewById<Button>(Resource.Id.a);
            abtn.Click += (sender, e) =>
            {
                pa.Start();
            };

            pb = MediaPlayer.Create(this, Resource.Raw.B);
            Button bbtn = FindViewById<Button>(Resource.Id.b);
            bbtn.Click += (sender, e) =>
            {
                pb.Start();
            };

            pc1 = MediaPlayer.Create(this, Resource.Raw.C1);
            Button c1btn = FindViewById<Button>(Resource.Id.c1);
            c1btn.Click += (sender, e) =>
            {
                pc1.Start();
            };

            pd1 = MediaPlayer.Create(this, Resource.Raw.D1);
            Button d1btn = FindViewById<Button>(Resource.Id.d1);
            d1btn.Click += (sender, e) =>
            {
                pd1.Start();
            };

            pe1 = MediaPlayer.Create(this, Resource.Raw.E1);
            Button e1btn = FindViewById<Button>(Resource.Id.e1);
            e1btn.Click += (sender, e) =>
            {
                pe1.Start();
            };

            pf1 = MediaPlayer.Create(this, Resource.Raw.F1);
            Button f1btn = FindViewById<Button>(Resource.Id.f1);
            f1btn.Click += (sender, e) =>
            {
                pf1.Start();
            };
        }

        public void PlaySoundtop() 
        {
            pc_s = MediaPlayer.Create(this, Resource.Raw.C_s);
            Button c_sbtn = FindViewById<Button>(Resource.Id.c_s);
            c_sbtn.Click += (sender, e) =>
            {
                pc_s.Start();
            };

            pd_s = MediaPlayer.Create(this, Resource.Raw.D_s);
            Button d_sbtn = FindViewById<Button>(Resource.Id.d_s);
            d_sbtn.Click += (sender, e) =>
            {
                pd_s.Start();
            };

            pf_s = MediaPlayer.Create(this, Resource.Raw.F_s);
            Button f_sbtn = FindViewById<Button>(Resource.Id.f_s);
            f_sbtn.Click += (sender, e) =>
            {
                pf_s.Start();
            };
            pg_s = MediaPlayer.Create(this, Resource.Raw.G_s);
            Button g_sbtn = FindViewById<Button>(Resource.Id.g_s);
            g_sbtn.Click += (sender, e) =>
            {
                pg_s.Start();
            };
            pBb = MediaPlayer.Create(this, Resource.Raw.Bb);
            Button Bbbtn = FindViewById<Button>(Resource.Id.Bb);
            Bbbtn.Click += (sender, e) =>
            {
                pBb.Start();
            };
            pc_s1 = MediaPlayer.Create(this, Resource.Raw.C_s1);
            Button c_s1btn = FindViewById<Button>(Resource.Id.c_s1);
            c_s1btn.Click += (sender, e) =>
            {
                pc_s1.Start();
            };
            pd_s1 = MediaPlayer.Create(this, Resource.Raw.D_s1);
            Button d_s1btn = FindViewById<Button>(Resource.Id.d_s1);
            d_s1btn.Click += (sender, e) =>
            {
                pd_s1.Start();
            };
        }

        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "MusicKey.db3");

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            PlaySound();
            PlaySoundtop();

            var detailbtn = FindViewById<Button>(Resource.Id.Detailbutton);
            detailbtn.Click += (s, e) => 
            {
                Intent it = new Intent(this, typeof(DetailActivity));
                StartActivity(it);           
            };

            /*  Button showdata = FindViewById<Button>(Resource.Id.Showbutton);     //Error XMAL ผมแก้ไม่ได้ครับ
              showdata.Click += delegate{              
                  var db = new SQLiteConnection(dbPath);
                  db.CreateTable<Contact>();
                  Contact myContact = new Contact("C", "555-555");                 
                  db.Insert(myContact);
               }; 

              Button getButton = FindViewById<Button>(Resource.Id.Getbutton);
              getButton.Click += delegate 
              {
                  TextView displayText = FindViewById<Button>(Resource.Id.textView1);
                  var db = new SQLiteConnection(dbPath);
                  var table = db.Table<Contact>();

                  foreach (var item in table) 
                  {
                      Contact myContact = new Contact(item.Name, item.Path);
                      displayText.Text += myContact ;
                  }
              };*/

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}