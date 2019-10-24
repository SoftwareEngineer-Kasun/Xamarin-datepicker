using Android.App;
using Android.Widget;
using Android.OS;
using Java.Lang;

 private TextView showCurrentDate;
 
 DatePicker pickDate = FindViewById<DatePicker>(Resource.Id.datePicker1);
            showCurrentDate = FindViewById<TextView>(Resource.Id.txtShowDate);
            setCurrentDate();
            Button button = FindViewById<Button>(Resource.Id.btnSetDate);
            button.Click += delegate {
                showCurrentDate.Text = String.Format("{0}/{1}/{2}",
                   pickDate.Month, pickDate.DayOfMonth, pickDate.Year);
            };
            
            
            
            private void setCurrentDate()
        {
            string TodaysDate = string.Format("{0}",
               System.DateTime.Now.ToString("M/d/yyyy").PadLeft(2, '0'));
            showCurrentDate.Text = TodaysDate;
        }
