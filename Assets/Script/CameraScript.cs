using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    private Transform Player;
    private float minX = 0, maxX = 204;
    private void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;

    }
    private void Update()
    {
        if (Player != null)
        {
            Vector3 vitriMario = transform.position;
            vitriMario.x = Player.position.x;
            if(vitriMario.x < minX) vitriMario.x = 0;
            if(vitriMario.x > maxX) vitriMario.x = maxX;
            transform.position = vitriMario;
        }
    }
}
