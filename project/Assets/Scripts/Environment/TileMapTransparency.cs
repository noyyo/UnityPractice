using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapTransparency : MonoBehaviour
{
    private Tilemap _tileMap;
    private void Awake()
    {
        _tileMap = GetComponent<Tilemap>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Color color = _tileMap.color;
        color.a = 0.4f;
        _tileMap.color = color;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Color color = _tileMap.color;
        color.a = 1f;
        _tileMap.color = color;
    }
}
