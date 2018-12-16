using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3
{
    public partial class Form1 : Form
    {
        private const int AppleCount = 2;
        private int bringedAppleCount;
        private int count;
        private Character character;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            count = 0;
            bringedAppleCount = 0;
            lblSource.Text = (AppleCount - 1) + " left";
            Point source = new Point(pbSource.Location.X + pbSource.Width, pbSource.Location.Y);
            Point target = new Point(pbTarget.Location.X, pbTarget.Location.Y - pbCharacter.Height);
            character = new Character(source, target, this);
            timerCharacter.Start();
        }

        private void timerCharacter_Tick(object sender, EventArgs e)
        {
            count++;
            character.Refresh();
            pbCharacter.Location = character.getCurrentLocation();
            int[] images = character.ImageIndexes();
            if (count % 2 == 0)
                pbCharacter.Image = ilCharacter.Images[images[0]];
            else
                pbCharacter.Image = ilCharacter.Images[images[1]];
        }

        public void TriggerTargetLbl()
        {
            bringedAppleCount++;
            if (bringedAppleCount >= AppleCount)
            {
                timerCharacter.Stop();
                pbCharacter.Image = ilCharacter.Images[8];
            }
            lblTarget.Text = bringedAppleCount + " bringed.";
        }

        public void TriggerSourceLbl()
        {
            lblSource.Text = (AppleCount - bringedAppleCount - 1) + " left";
        }
    }

    class Character
    {
        private Form1 MainForm;
        private bool RightControl, DownControl;
        private Point CurrentLocation;
        private Point SourceLocation, TargetLocation;
        private Direction direction;

        private enum Direction
        {
            Right,
            Down,
            Up,
            Left
        }

        public Character(Point sourceLocation, Point targetLocation, Form1 form)
        {
            MainForm = form;
            RightControl = true;
            DownControl = true;
            SourceLocation = sourceLocation;
            TargetLocation = targetLocation;
            CurrentLocation = new Point(sourceLocation.X + 5, sourceLocation.Y + 10);
            direction = Direction.Right;
        }

        private void Move()
        {
            if (RightControl && DownControl) //Go Right
                CurrentLocation.X += 5;
            else if (!RightControl && DownControl) //Go Down
                CurrentLocation.Y += 5;
            else if (RightControl && !DownControl) //Go Up
                CurrentLocation.Y -= 5;
            else //Go Left
                CurrentLocation.X -= 5;
        }

        public void Refresh()
        {
            switch (direction)
            {
                case Direction.Right:
                    goRight();
                    break;
                case Direction.Down:
                    goDown();
                    break;
                case Direction.Up:
                    goUp();
                    break;
                case Direction.Left:
                    goLeft();
                    break;
            }

            Move();
        }

        private void goRight()
        {
            if (CurrentLocation.X >= TargetLocation.X + 5)
            {
                CurrentLocation.X = TargetLocation.X + 5;
                RightControl = false;
                DownControl = true;
                direction = Direction.Down;
            }
        }

        private void goDown()
        {
            if (CurrentLocation.Y >= TargetLocation.Y - 5)
            {
                CurrentLocation.Y = TargetLocation.Y - 5;
                RightControl = true;
                DownControl = false;
                MainForm.TriggerTargetLbl();
                direction = Direction.Up;
            }
        }

        private void goUp()
        {
            if (CurrentLocation.Y <= SourceLocation.Y + 5)
            {
                CurrentLocation.Y = SourceLocation.Y + 5;
                RightControl = false;
                DownControl = false;
                direction = Direction.Left;
            }
        }

        private void goLeft()
        {
            if (CurrentLocation.X <= SourceLocation.X + 5)
            {
                CurrentLocation.X = SourceLocation.X + 5;
                RightControl = true;
                DownControl = true;
                MainForm.TriggerSourceLbl();
                direction = Direction.Right;
            }
        }

        public int[] ImageIndexes()
        {
            switch (direction)
            {
                case Direction.Right:
                    return new int[] { 4, 5 };
                case Direction.Down:
                    return new int[] { 0, 1 };
                case Direction.Left:
                    return new int[] { 2, 3 };
                case Direction.Up:
                    return new int[] { 6, 7 };
                default:
                    return new int[] { 4, 5 };
            }
        }

        public Point getCurrentLocation()
        {
            return CurrentLocation;
        }
    }
}
