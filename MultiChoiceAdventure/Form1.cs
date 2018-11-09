using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiChoiceAdventure
{
    public partial class Form1 : Form
    {
        int scene = 0;
        bool keyPresent = false;
        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();

            //

            outputLabel.Text = "You begin daydreaming in class, and wake up to a sudden snap of a ruler on your desk. " +
                "\nYou open your eyes, and everyone is missing, with no trace.";
            blueText.Text=  "Investigate room.";
            redText.Text=   "Leave Immediately.";
            yellowText.Text="N/A";
            labelDebug.Text = "" + (scene);
            labelImage.Image = Properties.Resources.Classroom;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int randNum = randGen.Next(1, 11);
            if (e.KeyCode == Keys.M) //Red 
            {
                if (scene == 0)
                {
                    scene = 1;
                    outputLabel.Text = "You run out through the door, looking both ways down the hall," +
                        "\nstill seeing no one around.";
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                    labelImage.Image = Properties.Resources.hallway;
                }
                else if (scene == 1 | scene == 4)
                {
                    labelImage.Image = Properties.Resources.field;
                    scene = 5;
                    outputLabel.Text = "You continue down the hall, and exit the building. " +
                        "\nThe door leaves you in a random field, and the door is gone when you turn around to look.";
                    yellowText.Text = "N/A";
                    redText.Text = "Continue traveling straight forward";
                    blueText.Text = "Observe surrounding area";
                }
                else if (scene == 2)
                {
                    scene = 0;
                    outputLabel.Text = "Obtained key.";
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                    keyPresent = true;
                }
                else if (scene == 5)
                {
                    scene = 6;
                    outputLabel.Text = "You trip on some sort of root, and close your eyes. " +
                        "\nWhen it feels you’re about to hit the ground, you notice the sensation of high gusts of wind. " +
                        "\nYou’re now on a snowy mountain. Somehow";
                    labelImage.Image = Properties.Resources.snow;
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                }
                else if (scene == 6)
                {
                    scene = 8;
                    outputLabel.Text = "You enter a nearby structure to escape the cold, and come across an armory, " +
                        "\nwith a locked door on the one side.";
                    redText.Text = "Browse Equipment";
                    blueText.Text = "Attempt to unlock door";
                    labelImage.Image = Properties.Resources.armory;
                }
                else if (scene == 7)
                {
                    scene = 99;
                    outputLabel.Text = "You blink, and you’re fully awake in the classroom. You’re sitting straight up, and looking at the board. " +
                        "\nYou continue your day, forgetting your daydream.";
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                    labelImage.Image = Properties.Resources.Classroom;
                }
                else if (scene == 8)
                {
                    scene = 10;
                    outputLabel.Text = "You assume you’ll probably need some level of protection, " +
                        "\nso you equip a basic set of armor from the wall, and grab an odd looking sword" +
                        "\n from the wall with a trigger.";
                    redText.Text = "Exit.";
                    blueText.Text = "Explore.";
                    labelImage.Image = Properties.Resources.armory;
                }
                else if (scene == 9)
                {
                    scene = 7;
                    outputLabel.Text = "You're blinded by a bright light, coming through the door.";
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                    labelImage.Image = null;

                }
                else if (scene == 10)
                {
                    scene = 11;
                    outputLabel.Text = "You exit the building back out into the snow. You suddenly get an odd feeling, and look behind you.";
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                    labelImage.Image = Properties.Resources.snow;
                }
                else if (scene == 11)
                {
                    scene = 12;
                    outputLabel.Text = "A figure approaches, and takes a stance a distance away.";
                    redText.Text = "First Strike.";
                    blueText.Text = "Defend.";
                }
                else if (scene == 12)
                {
                    scene = 15;
                    outputLabel.Text = "You successfully land a first hit on the figure, and it retreats to a safe distance.";
                    redText.Text = "Second hit.";
                    blueText.Text = "Retreat.";
                }
                else if (scene == 13)
                {
                    scene = 14;
                    outputLabel.Text = "You continue down a wide corridor which leads outside, and notice a figure waiting for you.";
                    redText.Text = "First Strike";
                    blueText.Text = "Defend.";
                    labelImage.Image = Properties.Resources.snow;
                }

                else if (scene == 15)
                {
                    scene = 16;
                    outputLabel.Text = "You land a successful second hit, and the figure drops to the ground.";
                    redText.Text = "Finisher.";
                    blueText.Text = "Enter nearby cave.";
                }
                else if (scene == 16)
                {
                    scene = 18;
                    outputLabel.Text = "You retreat into the cave, and find a place to relax.";
                    redText.Text = "Meditate.";
                    blueText.Text = "Sleep.";
                    labelImage.Image = Properties.Resources.cave;
                }
                else if (scene == 17)
                {
                    scene = 20;
                    outputLabel.Text = "You attempt a second hit, knocking the figure to the ground.";
                    redText.Text = "Finisher.";
                    blueText.Text = "Enter nearby cave.";
                }
                else if (scene == 18)
                {
                    scene = 99;
                    outputLabel.Text = "You wake up in bed, as it was all a dream.";
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                    labelImage.Image = Properties.Resources.bed;
                }
                else if (scene == 20)
                {
                    scene = 99;
                    outputLabel.Text = "You enter the cave to the point where you can’t see, and wake up in bed.";
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                    labelImage.Image = Properties.Resources.bed;
                }
                else if (scene == 21)
                {
                    scene = 99;
                    outputLabel.Text = "You strike your foe one last time, and get knocked out by the force of an explosion. " +
                        "\nYou sit up straight at your desk, and catch up with the class.";
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                    labelImage.Image = Properties.Resources.Classroom;
                }
                else if (scene == 22)
                {
                    scene = 99;
                    outputLabel.Text = "You go back to sleep, and wake up at the end of the class.";
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                    labelImage.Image = Properties.Resources.Classroom;
                }
                else if (scene == 23)
                {
                    scene = 7;
                    outputLabel.Text = "Figure gets around you block and knocks you out.";
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                    labelImage.Image = null;
                }

                else if (scene == 99)
                {
                    scene = 100;
                    labelImage.Image = null;
                    outputLabel.Text = "Restart?";
                    redText.Text = "Yes.";
                    blueText.Text = "No.";
                }
                else if (scene == 100)
                {
                    outputLabel.Text = "You begin daydreaming in class, and wake up to a sudden snap of a ruler on your desk. " +
                   "\nYou open your eyes, and everyone is missing, with no trace.";
                    blueText.Text = "Investigate room.";
                    redText.Text = "Leave Immediately.";
                    yellowText.Text = "N/A";
                    labelDebug.Text = "" + (scene);
                    labelImage.Image = Properties.Resources.Classroom;
                    scene = 0;
                }
            }
            if (e.KeyCode == Keys.B)
            {
                if (scene == 0)
                {
                    scene = 2;
                    outputLabel.Text = "You walk up and down between the rows of desks, looking for some kind of clue. " +
                        "\nYou hear the click of the room’s door lock.";
                    yellowText.Text = "Go back to sleep.";
                    redText.Text = "Investigate more, then attempt to bust door open.";
                    blueText.Text = "Enter ventilation system.";
                }
                else if (scene == 2)
                {
                    scene = 4;
                    outputLabel.Text = "The vent comes off easily, and you enter the ventilation system.";
                    yellowText.Text = "N/A";
                    redText.Text = "Exit into hallway.";
                    blueText.Text = "Continue through vents.";
                }
                else if (scene == 4)
                {
                    scene = 7;
                    outputLabel.Text = "You keep travelling down the shaft, and it gets darker and darker.";
                    yellowText.Text = "N/A";
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                }
                else if (scene == 5|scene == 9|scene == 23)
                {
                    scene = 7;
                }
                else if (scene == 8)
                {
                    if (keyPresent == true)
                    {
                        scene = 9;
                        outputLabel.Text = "The key opens the door.";
                        redText.Text = "Continue.";
                        blueText.Text = "N/A";
                    }
                    else
                    {
                        scene = 10;
                        outputLabel.Text = "The door doesn't budge. You get some equipment ";
                        redText.Text = "Continue.";
                        blueText.Text = "N/A";
                    }
                }
                else if (scene == 10)
                {
                    scene = 13;
                    outputLabel.Text = "You step into what seems to be a practice floor in a facility.";
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                }

                else if (scene ==12|scene==14)
                {
                    if (randNum < 7)
                    {
                        scene = 20;
                        outputLabel.Text = "You successfully block and counterattack, kcocking your opponent to the ground.";
                        redText.Text = "Enter Cave.";
                        blueText.Text = "Final Strike.";

                    }
                    else
                    {
                        scene = 7;
                        outputLabel.Text = "Your opponent gets around your block, and knocks you out.";
                        redText.Text = "Continue.";
                        blueText.Text = "N/A";
                    }
                }
                else if (scene == 15)
                {
                    scene = 17;
                    outputLabel.Text = "You attempt a second hit and the figure.";
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                }
                else if (scene == 17)
                {
                    scene = 21;
                    outputLabel.Text = "You strike the figure, and you feel the force of an explosion.";
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                }
                else if (scene == 16)
                {
                    scene = 19;
                    outputLabel.Text = "You wake up in class, ruler on your desk, with the teacher beside your desk";
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                }
                else if (scene == 99)
                {
                    scene = 99;
                    labelImage.Image = null;
                    outputLabel.Text = "Restart?";
                    redText.Text = "Yes.";
                    blueText.Text = "No.";
                }
                else if (scene ==100)
                {
                    Application.Exit();
                }
            }
            if (e.KeyCode == Keys.N)
            {
                if (scene == 2)
                {
                    scene = 7;
                    outputLabel.Text = "You go back to sleep, deciding not to explore.l";
                    yellowText.Text = "N/A";
                    redText.Text = "Continue.";
                    blueText.Text = "N/A";
                }
            }
            labelDebug.Text = "" + (scene);
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
