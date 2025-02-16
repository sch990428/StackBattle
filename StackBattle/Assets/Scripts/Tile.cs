using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private float distance;
    private float maxDistance;
    private float stepTime;
    private bool moveForward;
    bool moveX;

    private void Start()
    {
        maxDistance = 7f;
        distance = maxDistance;
        moveForward = false;

        if (moveX)
        { transform.Translate(distance, 0, 0); }
        else
        { transform.Translate(0, 0, distance); }
    }

    private void Update()
    {
        stepTime = Time.deltaTime * 6f;

        if (moveX)
        { MoveX(); }
        else 
        { MoveZ(); }
    }

    private void MoveX()
    {
        if (moveForward)
        {
            if (distance < maxDistance)
            {
                transform.Translate(stepTime, 0, 0);
                distance += stepTime;
            }
            else
            { moveForward = false; }
        }
        else
        {
            if (distance > -maxDistance)
            {
                transform.Translate(-stepTime, 0, 0);
                distance -= stepTime;
            }
            else
            { moveForward = true; }
        }
    }

    private void MoveZ()
    {
        if (moveForward)
        {
            if (distance < maxDistance)
            {
                transform.Translate(0, 0, stepTime);
                distance += stepTime;
            }
            else
            { moveForward = false; }
        }
        else
        {
            if (distance > -maxDistance)
            {
                transform.Translate(0, 0, -stepTime);
                distance -= stepTime;
            }
            else
            { moveForward = true; }
        }
    }
}
