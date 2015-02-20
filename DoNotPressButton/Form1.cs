using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoNotPressButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int stevec = 191;
        int time = 0;

        bool movingLeft = false;
        bool movingRight = false;
        bool firstMoveDone = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            redButton.SizeMode = PictureBoxSizeMode.StretchImage;
            setText(stevec);
        }

        /* Basic methods */
        public void resetButton()
        {
            redButton.Size = new Size(250, 250);
            redButton.Location = new Point(157, 23);
            mainLabel.Location = new Point(12, 276);

            penguinCircle.Visible = false;
            redButton2.Visible = false;
            blueButton.Visible = false;

            funkyButton1.Visible = false;
            funkyButton2.Visible = false;
            funkyButton3.Visible = false;
            funkyButton4.Visible = false;
            funkyButton5.Visible = false;
            funkyButton6.Visible = false;
            funkyButton7.Visible = false;
            funkyButton8.Visible = false;
            funkyButton9.Visible = false;
            
        }
        
        public void changeObjectSize(PictureBox box, int x, int y)
        {
            box.Size = new Size(x, y);
        }

        public void changeObjectLocation(PictureBox box, int x, int y)
        {
            box.Location = new Point(x, y);
        }

        public void getFunky()
        {

            funkyButton1.Visible = true;
            funkyButton2.Visible = true;
            funkyButton3.Visible = true;
            funkyButton4.Visible = true;
            funkyButton5.Visible = true;
            funkyButton6.Visible = true;
            funkyButton7.Visible = true;
            funkyButton8.Visible = true;
            funkyButton9.Visible = true;
        }

        public void makeVisible(PictureBox box)
        {
            box.Visible = true;
        }


        private void redButton_Click(object sender, EventArgs e)
        {
                stevec += 1;
                setText(stevec);
        }

        /* End basic methods */

        public void setText(int st)
        {
            string[] values = 
            {
	            "DO NOT PRESS",
	            "*ahem*\nDO NOT PRESS",
	            "... you pressed it again.\nOkay punk, press it again.",
	            "Yeah, that's it.\nCome on, one more time.",
	            "Again.",
	            "Do it.",
	            "Okay, now you've had your fill.\nStop clicking.",
	            "You see, this is why\nwe can't be friends.",
	            "You're just so selfish.",
	            "Grr... now you've asked for it.\nDo NoT pReSs ThE bUtToN!",

	            "You seem to be imune to\nmy mind control.",
	            "Time for plan B.\nPress it. You know you want to.",
	            "Mwahahaha! Now let's see\nyou press it! LOSER!", // 12 - Makes it smaller
	            "...this displeases me.",
	            "Ha! I have replaced the button\nwith this penguin. Now what are you\ngoing to do?", // 14 - Penguin overdraw
	            "...I hate you.",
	            "In that 'cut off your head with a\ntoothbrush' kind of way.",
	            "Quick! What's that behind you?!",
	            "Which one is it?\nNot so smart now, are ya?", // 18 - Shows 3 buttons
	            "You're a clever one.",

	            "...",
	            "Okay Okay. You can press the button.\nI don't care.",
	            "No really, I don't care anymore.",
	            "In fact, I lost interest a while ago.",
	            "I'm doing this just to entertain you.",
	            "Really.",
	            "Do you like cartoons?",
	            "...and paint?",
	            
                "Cartoons and paint?",
	            "Well you should.",
	            "Pick a color.",
	            "Blue. Perfect.",
	            "Press the BLUE button.", // 32 - BRG
	            "See, you just can't trust me.\nOr can you?",
	            "You know, I'm glad we get\nto spend so much time together.",
	            "Doesn't it make you want to stop\nclicking big red buttons?",
	            
                "No seriously.",
	            "Look deep inside you.",
	            "Deeper.",
	            "DEEPER!",
	            "What if I told you that the next\ntime you press the button, the world\nwill explode?",
	            "See. You could have been\ndead right there.",
	            "And there.",
	            "You know, eventually\nI'll stop letting you get away with this.",
	            "The world is going to explode\nand all you care about is pressing buttons.",
	            "BOOM!\nYou're dead.",
	            
                "That wasn't very smart now was it?",
	            "Everyone's dead. Even you.",
	            "I'm not. I'm just text.",
	            "But you're dead.",
	            "Ha! Dead-face!",
	            "Stop clicking.",
	            "Have I ever told you how much I hate you?",
	            "Well I do.",
	            "I'm gonna start talking upside down\nif you click one more time.",
	            "¿noʎ uɐɔ 'ʍou ǝɯ pɐǝɹ ʇ,uɐɔ ¡ɐH", // 55 - Upside down
	            
                "¿ʎɐʍʎuɐ ǝɯ pɐǝɹ oʇ ʇuɐʍ ʇ,upıp noʎ ¿ʇɐɥM", // 56 - Upside down
	            "¡noʎ ʍoɥs ןן,ı 'uǝɥʇ ןןǝM", // 57 - Upside down
	            " ",
	            " ",
	            "You really are stubborn.",
	            "Stop clicking. Please.",
	            "See look. You've reduced me\nto begging. So please stop.",
	            "PLEASE!!!!",
	            "I'll give you a nickle.",
	            "Dime?",
	            
                "Quarter?",
	            "Aww come on! Just stop!",
	            "That does it! Time to\nunleash my master plan!",
	            "BEHOLD!\n The awesome power of C# animation!", // 69 - Slides left and right
	            "H8!",
	            "Let's get funky!", // 71 - Funky buttons
	            "I'll bet you're starting to wonder\nwhy you've been doing this\nfor so long.",
	            "Like jeez, all you've been doing is\nclicking a red button.",
	            "How lame is that?",
	            "But there is a bonus to all this.",
	            
                "But it's a secret.\nSo I can't tell you.",
	            "I got you going didn't I?",
	            "You should've seen the look\non your face! HA!",
	            "But seriously, there is a secret.\nThere's been one the whole time.",
	            "You've been busy clicking away at\nthis big red button...",
	            "... when all the while a little white\nbutton has watched your every move.",
	            "MWAHAHAHAHAHA!",
	            "HAHAHA!",
	            "BWAHAA!",
	            "MWAAAAH!!",
	            
                "HAHA!",
	            "hehe!",
	            "lol",
	            "rofl",
	            "roflmao",
	            "roflmaoqxz",
	            "and so on and so forth",
	            "...",
	            "*whistles*",
	            "Find it yet?",
	            
                "Look harder!\nIt's right under your nose.",
	            "I know where it is. But I'll never tell.",
	            "Or maybe I will...",
	            "But you gotta stop clicking the\nBig Red Button first!",
	            "Stop.",
	            "Now.",
	            "Fine, I won't tell you\nthe secret.",
	            "Go ahead. Try to find it yourself.\nYou'll never find it.",
	            "Well you might... but the odds\nare against you.",
	            "~",
	            
                "What's your favorite letter?",
	            "Mine is the squiggly!",
	            "~",
	            "Find it yet?",
	            "No?",
	            "Then stop clicking and I'll tell you.",
	            "You know what?",
	            "POOF! It's gone!", // 113 - Inside 'o' in gone
	            "Has anyone ever slapped you?",
	            "Cuz I will.",
	            
                "Really I will.",
	            "It won't hurt though.",
	            "Cuz you're dead.",
	            "D-E-D",
	            "Remember? You went and blew up\nthe entire planet!",
	            "Though I'd forget about that\ndidn't you?",
	            "But an elephant never forgets!",
	            "...or something along those lines.",
	            "You killed everyone.",
	            "Sikko.",
	            
                "What would your mother say?",
	            "That's right... feel bad.",
	            "The world is null and you're to blame.",
	            "I'd recomment suicide,\nbut you're dead already.",
	            "So there's only one thing left\nthat you can do...",
	            "Stop clicking the button.",
	            "Dude, you're dead.\nWhat are you gaining from this?",
	            "Okay, everytime you click, you\nget sent to a lower layer of hell.",
	            "Welcome to layer 2",
	            "3",
	            
                "4",
	            "5",
	            "6",
	            "7",
	            "8",
	            "9",
	            "BOOM!\nYou've exploded Hell.",
	            "I hope you're happy.",
	            "Heaven's gone too.\nThat's how smooth you are.",
	            "Now you're dead, and there's\nno heaven or hell.",
	            
                "How does it feel?\nYou've condemned the world of limbo.",
	            "I once shot a man for being in limbo.",
	            "...or was he doing the limbo?",
	            "Meh, Tomato Tomahto",
	            "This is getting boring isn't it?",
	            "But you can't stop!",
	            "You want to end this.\nYou want to leave your computer.",
	            "But you can't!",
	            "You need to see if there's a pot of gold\nat the end of the rainbow!",
	            "But I've already told you how to\nfind the pot of gold.",
	            
                "Follow the white rabbit.",
	            "..erm, button.",
	            "Remember the hidden button?",
	            "Or are you so self-centered you\nforgot about that too?",
	            "I could just keep you here all day\nif I wanted.",
	            "You're in my world now.",
	            "No matter how much you\nhate it, you have to press the button.",
	            "again...",
	            "and again...",
	            "and again.",
	            
                "You just keep hoping something\ngood will come of this.",
	            "Sure I could tell you if I wanted\nto, but I'm not gonna.",
	            "You decided to keep clicking.\nSo I'm gonna enjoy it.",
	            "I mean, there's nothing else to enjoy.",
	            "You blew it all up remember?",
	            "You're probably wondering who I am",
	            "Well let me tell you a tale about myself",
	            "One day, I was walking home from\nwork and I saw a small little house.",
	            "I knocked on the door out of curiousity\nto see if anyone was home.",
	            "The door opened.",
	            
                "But no one was there.",
	            "I went inside to check it out\nand found nothing...",
	            "...nothing but a little metal box.",
	            "So I opened it.",
	            "Inside the box was a layer of\nfoam protecting it's contents",
	            "I removed the foam and there it was...",
	            "...",
	            "... ...",
	            "ZZZzzzzzz",
	            "zzzzZZZZzzzz",
	            
                "ZZZZzzzZZZZ",
	            "Huh?",
	            "Oh! Right! The story!",
	            "So there I was, holding this\nlittle metal box in my hands.",
	            "The top was open and sitting\ninside was this...",
	            "Big Red Button",
	            "And you know what it said?",
	            "Oh I'll tell you what it said.\nIt said...",
                " "
            };

            switch(st)
            {
                case 12:
                    mainLabel.Text = values[st];
                    changeObjectSize(redButton, 10, 10);
                    changeObjectLocation(redButton, 277, 160);
                    break;

                case 14:
                    mainLabel.Text = values[st];
                    makeVisible(penguinCircle);
                    break;

                case 18:
                    mainLabel.Text = values[st];
                    makeVisible(redButton2);
                    changeObjectLocation(redButton, 290, 23);
                    break;

                case 32:
                    mainLabel.Text = values[st];
                    makeVisible(blueButton);
                    changeObjectLocation(redButton, 290, 23);
                    break;

                case 55:
                    mainLabel.Text = values[st];
                    redButton.Location = new Point(157, 220);
                    mainLabel.Location = new Point(12, 23);
                    break;

                case 56:
                    mainLabel.Text = values[st];
                    changeObjectLocation(redButton, 157, 220);
                    mainLabel.Location = new Point(12, 23);
                    break;

                case 57:
                    mainLabel.Text = values[st];
                    changeObjectLocation(redButton, 157, 220);
                    mainLabel.Location = new Point(12, 23);
                    break;

                case 69:
                    mainLabel.Text = values[st];
                    // done in the ticker method below
                    break;

                case 71:
                    mainLabel.Text = values[st];
                    getFunky();

                    changeObjectSize(redButton, 40, 40);
                    changeObjectLocation(redButton, 250, 205);
                    break;

                case 113:
                    mainLabel.Text = values[st];
                    changeObjectSize(redButton, 8, 8);
                    changeObjectLocation(redButton, 328, 361);
                    break;

                default:
                    mainLabel.Text = values[st];
                    resetButton();
                    if(stevec==193) // If you're at the end of the array
                    {
                        stevec = -1; // Why -1? Because var 'stevec' goes up by 1 (to 0 in this case) when you click on the button anyway
                    }
                    break;
            }
        }

        public void animateButton(object sender, EventArgs e)
        {
            if(stevec==69)
            {
                int x = redButton.Location.X;
                int y = redButton.Location.Y;

                if(!firstMoveDone)
                {
                    time++;
                    redButton.Location = new Point(x + 20, y);
                    x = x + 20;
                    if(x>=286)
                    {
                        firstMoveDone = true;
                    }
                }

                if(firstMoveDone && !movingRight)
                {
                    movingLeft = true;
                    time++;
                    redButton.Location = new Point(x - 20, y);
                    x = x - 20;
                    if (x <= 12)
                    {
                        movingLeft = false;
                        movingRight = true;
                    }
                }

                if (firstMoveDone && !movingLeft)
                {
                    movingRight = true;
                    time++;
                    redButton.Location = new Point(x + 20, y);
                    x = x + 20;
                    if (x >= 286)
                    {
                        movingLeft = true;
                        movingRight = false;
                    }
                }
                
            }
        }
        

        

    }
}
