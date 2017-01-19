using Android.App;
using Android.Widget;
using Android.OS;

namespace squashApp
{
	[Activity(Label = "squashApp", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		
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
			TextView servingPlayerDisp = FindViewById<TextView>(Resource.Id.textServe);
			Button newGameStart = FindViewById<Button>(Resource.Id.newGame);
			TextView setScore1Dsp = FindViewById<TextView>(Resource.Id.setScore1);
			TextView setScore2Dsp = FindViewById<TextView>(Resource.Id.setScore2);

			int score1 = 0;
			int score2 = 0;
			int setScore1 = 0;
			int setScore2 = 0;


			string servingPlayerName;
			newGameStart.Visibility = Android.Views.ViewStates.Invisible;

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
					servingPlayerDisp.Text = "Set Won by Player 1!";
					addScore1Button.Clickable = false;
					addScore2Button.Clickable = false;
					remScore1Button.Clickable = false;
					remScore2Button.Clickable = false;
					newGameStart.Visibility = Android.Views.ViewStates.Visible;
					setScore1++;
					setScore1Dsp.Text = setScore1.ToString();
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
					servingPlayerDisp.Text = "Set Won by Player 2!";
					addScore1Button.Clickable = false;
					addScore2Button.Clickable = false;
					remScore1Button.Clickable = false;
					remScore2Button.Clickable = false;
					newGameStart.Visibility = Android.Views.ViewStates.Visible;
					setScore2++;
					setScore2Dsp.Text = setScore2.ToString();
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

			newGameStart.Click += delegate {
				score1 = 0;
				score2 = 0;
				score1Disp.Text = score1.ToString();
				score2Disp.Text = score2.ToString();
				addScore1Button.Clickable = true;
				addScore2Button.Clickable = true;
				servingPlayerDisp.Text = "Tap + to select serving Player";
				newGameStart.Visibility = Android.Views.ViewStates.Invisible;
			};


		}
	}
}

