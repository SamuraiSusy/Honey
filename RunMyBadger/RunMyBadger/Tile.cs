using System;

namespace RunMyBadger
{
    public class Tile
    {
        public const int size = 100;

        private bool _walkable;

        public bool walkable
        {
            get { return _walkable; }
        }

        public Tile()
        {
            _walkable = true;
        }

        public Tile(bool walkable)
        {
            this._walkable = walkable;
        }
    }
}