using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Minesweeper
{
    public class Grid : MonoBehaviour
    {
        public GameObject tilePrefab;
        public int width = 10;
        public int height = 10;
        public float spacing = 0.155f;
        private Tile[,] tiles;
        Tile SpawnTile(Vector3 pos)
        {
            GameObject clone = Instantiate(tilePrefab);
            clone.transform.position = pos;
            Tile currentTile = clone.GetComponent<Tile>();
            return currentTile;
        }
        void GenerateTiles()
        {
            tiles = new Tile[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Vector2 halfSize = new Vector2(width * 0.5f, height * 0.5f);
                    Vector2 pos = new Vector2(x - halfSize.x, y - halfSize.y);
                    pos *= spacing;
                    Tile tile = SpawnTile(pos);
                    tile.transform.SetParent(transform);
                    tile.x = x;
                    tile.y = y;
                    tiles[x, y] = tile;
                }
            }
        }
        void Start()
        {
            GenerateTiles();
        }
        public int GetAdjacentMinecount(Tile tile)
        {
            int count = 0;
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    int desiredx = tile.x + x;
                    int desiredY = tile.y + y;
                    if (desiredx < 0 || desiredx >= width ||
                        desiredY < 0 || desiredY >= height)
                    {
                        continue;
                    }
                    Tile currentTile = tiles[desiredx, desiredY];
                    if (currentTile.isMine)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        void FFuncover(int x, int y, bool[,] visited)
        {
            if (x >= 0 && y >= 0 &&
               x < width && y < height)
            {
                if (visited[x, y])
                    return;
                Tile tile = tiles[x, y];
                int adjacentMines = GetAdjacentMinecount(tile);
                tile.Reveal(adjacentMines);
                if (adjacentMines == 0)
                {
                    visited[x, y] = true;
                    FFuncover(x - 1, y, visited);
                    FFuncover(x + 1, y, visited);
                    FFuncover(x, y - 1, visited);
                }
            }
        }
        void UncoverMines(int mineState = 0)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Tile tile = tiles[x, y];
                    if (tile.isMine)
                    {
                        int adjacentMines = GetAdjacentMinecount(tile);
                        tile.Reveal(adjacentMines, mineState);
                    }
                }
            }
        }

    }
}
