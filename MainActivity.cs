using Android.App;
using Android.Widget;
using Android.OS;

namespace squashApp
{
	[Activity(Label = "squashApp", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			Button addScore1Button = FindViewById<Button>(Resource.Id.addScore1);
			Button addScore2Button = FindViewById<Button>(Resource.Id.addScore2);
			Button remScore1Button = FindViewById<Button>(Resource.Id.remScore1);
			Button remScore2Button = FindViewById<Button>(Resource.Id.remScore2);
			TextView score1Disp = FindViewById<TextView>(Resource.Id.textScore1);
			TextView score2Disp = FindViewById<TextView>(Resource.Id.textScore2);
			TextView scoreSeparator = FindViewById<TextView>(Resource.Id.textSeparator);
			TextView servingPlayerDisp = FindViewById<TextView>(Resource.Id.textServe);

			int score1 = 0;
			int score2 = 0;
			string servingPlayerName;

			addScore1Button.Click += delegate {

				if (servingPlayerDisp.Text == "Serving: Player 1")
				{
					score1++;
					score1Disp.Text = score1.ToString();
					servingPlayerName = "Serving: Player 1";
					servingPlayerDisp.Text = servingPlayerName;
					remScore1Button.Clickable = true;
					remScore2Button.Clickable = true;
				}

				else
				{
					score1Disp.Text = score1.ToString();
					servingPlayerName = "Serving: Player 1";
					servingPlayerDisp.Text = servingPlayerName;

				}

				if (score1 - score2 > 1 && score1 >= 11)
				{
					servingPlayerDisp.Text = "Set 1 Won by Player 1!";
					addScore1Button.Clickable = false;
					addScore2Button.Clickable = false;
					remScore1Button.Clickable = false;
					remScore2Button.Clickable = false;
				}

			};

			addScore2Button.Click += delegate {
				if (servingPlayerDisp.Text == "Serving: Player 2")
				{
					score2++;
					score2Disp.Text = score2.ToString();
					servingPlayerName = "Serving: Player 2";
					servingPlayerDisp.Text = servingPlayerName;
					remScore1Button.Clickable = true;
					remScore2Button.Clickable = true;
				}

				else
				{
					score2Disp.Text = score2.ToString();
					servingPlayerName = "Serving: Player 2";
					servingPlayerDisp.Text = servingPlayerName;

				}

				if (score2 - score1 > 1 && score2 >= 11)
				{
					servingPlayerDisp.Text = "Set 1 Won by Player 2!";
					addScore1Button.Clickable = false;
					addScore2Button.Clickable = false;
					remScore1Button.Clickable = false;
					remScore2Button.Clickable = false;
				}
			};

			remScore1Button.Click += delegate {
				if (score1 == 0)
				{
					remScore1Button.Clickable = false;
				}

				else
				{
					score1--;
					score1Disp.Text = score1.ToString();
				}

				remScore2Button.Click += delegate {
					if (score2 == 0)
					{
						remScore2Button.Clickable = false;
					}

					else
					{
						score2--;
						score2Disp.Text = score2.ToString();
					}
				};
			};



		}
	}
}

