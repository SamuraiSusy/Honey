using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace RunMyBadger
{
    public class Object
    {
        private Texture2D _texture;
        //private Vector2 _position;

        public Texture2D texture
        {
            get { return _texture; }
            set { _texture = value; }
        }
    }
}
