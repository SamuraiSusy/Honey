using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RunMyBadger
{
    public class GameObject
    {
        protected Vector2 origin;
        protected Texture2D texture;
        private Vector2 _position;
        private Rectangle localBoundingRectangle;

        public Rectangle boundingRectangle
        {
            get
            {
                int x = (int)Math.Round(_position.X - origin.X) + localBoundingRectangle.X;
                int y = (int)Math.Round(_position.Y - origin.Y) + localBoundingRectangle.Y;

                return new Rectangle(x, y, localBoundingRectangle.Width, localBoundingRectangle.Height);
            }
        }

        public Vector2 position
        {
            get { return _position; }
            set { _position = value; }
        }
        
        public GameObject(Texture2D texture, Rectangle localBoundingRectangle)
        {
            this.texture = texture;
            this.localBoundingRectangle = localBoundingRectangle;
        }
    }
}
