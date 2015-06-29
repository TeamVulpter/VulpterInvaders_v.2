﻿using System.Collections.Generic;
using Game.Classes.Factory;

namespace Game
{
    using System.Drawing;
    using System.Windows.Forms;

    using Classes;
    using Classes.Characters;
    using Classes.Enemies;
    using System.Collections;

    public partial class InvadersAttack : Form
    {

        private PlayerShip shipPlayer;
        private Bullet bullet;
        private EnemyShip enemy;
        private bool spaceKeyIsPressed = false;
        private IList<EnemyShip> enemies;
        private Attack attack;
        private EnemyInvaderFactory factoryInvaders;

        public InvadersAttack()
        {
            InitializeComponent();
            this.KeyPress += this.InvadersAttack_KeyPress;
            this.KeyDown += this.InvaderAttack_KeyDown;
            this.shipPlayer = new PlayerShip(playerShip);
            this.bullet = new Bullet(bulletPanel);
            this.enemy = new EnemyShip(shipEnemy);

            enemies = new List<EnemyShip>()
            {
                new EnemyShip(shipEnemy),
                new EnemyShip(invaderTwo),
                new EnemyShip(invaderThree),
                new EnemyShip(invaderFour),
                new EnemyShip(invaderFive),
                new EnemyShip(invaderSix),
                new EnemyShip(invaderSeven),
                new EnemyShip(invaderEight)
            };
            //attack = new Attack();
            factoryInvaders = new EnemyInvaderFactory();
            factoryInvaders.CreateEnemy(enemies);


        }

        private void InvadersAttack_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Space)
            {
                spaceKeyIsPressed = true;
                bulletPanel.Location = new Point(playerShip.Location.X, 450);
            }
        }

        private void InvaderAttack_KeyDown(object sender, KeyEventArgs e)
        {
            if (!shipPlayer.StopAtMin(playerShip.Location.X, 20))
            {

                if (e.KeyCode == Keys.A)
                {
                    shipPlayer.MoveLeft();
                }

            }
            if (!shipPlayer.StopAtMax(playerShip.Location.X, this.Width - 70))
            {
                if (e.KeyCode == Keys.D)
                {
                    shipPlayer.MoveRight();
                }
            }
        }

        private void TimerMovementsTick(object sender, System.EventArgs e)
        {
            if (spaceKeyIsPressed)
            {
                this.bullet.PositionX = playerShip.Location.X+10;
                this.bullet = new Bullet(bulletPanel);
                bulletPanel.Location = new Point(playerShip.Location.X, bullet.PositionY - 10);
                bullet.Start();
            }
            foreach (var en in enemies)
            {
                en.PositionX = en.EnemyInvader.Location.X;
                en.PositionY = en.EnemyInvader.Location.Y;
                en.EnemyInvader.Location = new Point(en.PositionX, en.PositionY + 1);
                if (en.PositionY >= this.Height - 30)
                {
                    en.EnemyInvader.Location = new Point(en.PositionX, 20);
                }
            }
        }
    }
}
