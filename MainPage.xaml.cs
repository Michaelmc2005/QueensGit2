using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace queensGame
{
    public partial class MainPage : ContentPage
    {
        string[] askable = { "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true" };
        string[] cards = { "QUEENS", "QUEENS", "QUEENS", "QUEENS", "90 Seconds in Heaven", "90 Seconds in heaven", "Kiss or slap", "Kiss or slap", "Lick someone’s neck", "Lick someone’s neck", "Kissing booth", "Kissing booth", "Fuck Marry Kill", "Fuck Marry Kill", "Most Likely To cheat", "Most Likely To drunk cry", "Most Likely To go back to an ex", "Most Likely To make a sex tape", "Most Likely To hook up with a stranger", "Most Likely To drop out of uni", "Most Likely To have a sugar daddy/mommy", "Most Likely To start an onlyfans", "Never Have I Ever faked it", "Never Have I Ever fancied another player", "Never Have I Ever ghosted someone", "Never Have I Ever had covid", "Never Have I Ever had a one night stand", "Never Have I Ever hooked up with another player", "Never Have I Ever been kicked out of a nightclub", "Never Have I Ever led someone on", "Never Have I Ever sent nudes", "Never Have I Ever failed a driving test", "Never Have I Ever gone out underage", "Never Have I Ever had sex in a car", "Never Have I Ever been in a physical fight", "Never Have I Ever done the walk of shame", "Never Have I Ever had a viral TikTok", "Never Have I Ever dumped someone", "Never Have I Ever made a booty call", "Never Have I Ever damaged a car", "Spin the bottle", "Spin the bottle", "Suck and blow", "Suck and blow", "Truth or dare", "Truth or dare", "Body Count", "Body Count to the right", "Big Dick Energy", "Best Hubby", "Best wife material", "Body Shot", "Cute couple", "Do a shot", "Drivers drink", "Favourite person in the room", "Explain your type", "Explain your first time", "Floor is lava", "Give a shot", "Highest body count drink", "Highest snap score drink", "Host drinks", "Hottest girl in the room", "Hottest guy in the room", "What’s your kink", "Make a toast", "Name and shame last hookup", "Read last text", "Rock paper scissors", "Compliment the boys", "Compliment the girls", "Search history", "Say your icks", "Singles drink", "Neighbours drink", "Smokers drink", "Youngest and oldest", "Top hottest in the room", "True or false", "Peer pressure", "Funniest person in the room", "Rhyme", "When did you last do it?", "Categories", "Slap someone’s ass", "Closest birthday", "Chinese whispers", "Weirdest place you’ve done it", "Lowest battery %", "Aux Cord", "Weakest link (biggest lightweight drinks)", "Paranoia", "How spicy are you? (Nandos sauce order)", "Biggest flirt drinks", "My eyes only", "Tiny Tim", "Group photo", "Last arrival drinks", "No bra club", "Biggest fuckboy/girl drinks", "Drink if you travelled furthest tonight", "Steal a sip", "Eight mate", "Momma bird" };
        int numOfFalse = 1;
        public MainPage()
        {
            InitializeComponent();
            label.IsVisible = true;
        }
        void Button_Clicked(object sender, System.EventArgs e)
        {
            Random rnd = new Random();

            int cardNumber = rnd.Next(1, 105);
            if (askable[cardNumber] == "true")
            {
                label2.Text = $"{cards[cardNumber]}";
                askable[cardNumber] = "false";
                numOfFalse++;

            }
            else if (askable[cardNumber] == "false")
            {
                while (askable[cardNumber] == "false")
                {
                    cardNumber = rnd.Next(1, 105);


                }
                if (askable[cardNumber] == "true")
                {
                    label2.Text = $"{cards[cardNumber]}";
                    askable[cardNumber] = "false";
                    numOfFalse++;
                }


            }
            if (numOfFalse == 105)
            {
                label.IsVisible = true;
                label.Text = "All cards have been displayed.";
            }

        }

        public void ShakeDetected()
        {
            label.Text = "This text has been changed to test github";
        }


    }
}

