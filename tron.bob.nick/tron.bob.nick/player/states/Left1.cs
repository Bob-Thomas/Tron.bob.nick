﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace tron.bob.nick
{
    public class Left1 : DrawPlayer
    {
        private Player1 player;

        public Left1(Player1 player) : base(player)
        {
            this.player = player;
            this.initialize();
        }

        public void initialize()
        {
            this.LoadContent();

        }

        //loadcontent
        public void LoadContent()
        {
        }
        public override void Update(GameTime gameTime)
        {

            this.player.Position += new Vector2(-this.player.Speed, 0f);
            this.player.TailList.Add(new Tail(this.player.Game, this.player.Position + new Vector2(8, 0), Color.Yellow));
            if (Input.DetectKeyUp(Keys.A))
            {
                this.player.State = new Idle1(player, "Left");
            }
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
