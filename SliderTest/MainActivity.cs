using System;
using System.Collections.Generic;
using System.Timers;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.View;
using DK.Ostebaronen.Droid.ViewPagerIndicator;

namespace SliderTest
{

    [Activity(Label = "SliderTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : FragmentActivity
    {
        //輪播圖片的列表
        private List<int> ImagesList;

        //圖片的配接器 主要是繼承 FragmentStatePagerAdapter 
        FragStateSupport _adapter;

        ViewPager _pager;
        //分頁器
        protected IPageIndicator _indicator;

        //做暫存目前輪播圖片
        public int CurrentFlag = 0;

        //做輪播的動畫的計時器
        private Timer _Timer;
        protected override void OnCreate(Bundle bundle)
        {
            //Init page to Main.axml
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);


            //加入圖片
            ImagesList = new List<int>();
            ImagesList.Add(Resource.Drawable.sh095);
            ImagesList.Add(Resource.Drawable.sh096);
            ImagesList.Add(Resource.Drawable.sh097);
            ImagesList.Add(Resource.Drawable.sh098);

            _adapter = new FragStateSupport(SupportFragmentManager, ImagesList);

            //將UI上的圖片顯示放入資料
            _pager = FindViewById<ViewPager>(Resource.Id.pager);
            _pager.Adapter = _adapter;

            
            //下方的分頁器
            _indicator = FindViewById<CirclePageIndicator>(Resource.Id.indicator);
            _indicator.SetViewPager(_pager);


            _Timer = new Timer();
            _Timer.Elapsed += _Timer_Elapsed;
            _Timer.Interval = 2000;
            _Timer.Start();

        }


        //每一秒讓他輪播如果撥放到最後拉回到第一張
        private void _Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            CurrentFlag = _pager.CurrentItem;
           
            CurrentFlag++;
            CurrentFlag = CurrentFlag % 4;
            this.RunOnUiThread(() => _pager.SetCurrentItem(CurrentFlag, true));
        }
    }
}

