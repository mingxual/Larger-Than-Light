﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall3D : MonoBehaviour
{
    /*[System.Serializable]
    public struct Coordinate2D
    {
        public float x, y;
        public Coordinate2D(float _x, float _y)
        {
            x = _x;
            y = _y;
        }
    }*/
    public GameObject wall2D;
    //public Coordinate2D coordinate2D;
    public Vector2 coordinate2D;

    // Start is called before the first frame update
    void Start()
    {
        //Create gameobjects for wall2D
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 RaycastToWall2D(Vector3 point, Vector3 originPos)
    {
        //Debug.DrawRay(originPos, wall2D.transform.TransformPoint(point) - originPos, Color.red);
        return wall2D.transform.TransformPoint(point);
    }

    public GameObject GetWall2D()
    {
        if(wall2D)
            return wall2D;

        return null;
    }
}
