using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

namespace Game.Map2D
{
    [System.Serializable]
    public class Block
    {
        [SerializeField] private TileBase _tile;
        [SerializeField] private bool _wall = true;
        [SerializeField] private Color _color = new Color(0, 0, 0, 1);

        public TileBase Tile => _tile;
        public bool Wall => _wall;
        public Color Color => _color;
        public bool Check(Color color) { return color == _color; }
    }
}