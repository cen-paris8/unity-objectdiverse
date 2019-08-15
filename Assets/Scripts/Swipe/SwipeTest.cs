﻿using UnityEngine;

public class SwipeTest : MonoBehaviour
{
    public Swipe swipeControl;
    public Transform player;
    private Vector3 desirePosition;
    public float Speed = 10.0f;

    void Start()
    {
        desirePosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // TO DO Donner une position fixe
        if (swipeControl.SwipeDelta.x != 0 || swipeControl.SwipeDelta.y != 0)
        {
            if (swipeControl.SwipeLeft) desirePosition += Vector3.left;

            if (swipeControl.SwipeRight) desirePosition += Vector3.right;

            if (swipeControl.SwipeUp) desirePosition += Vector3.up;

            if (swipeControl.SwipeDown) desirePosition += Vector3.down;

            // Specific for these swipe game to only move up and down, to comment if not.
            desirePosition.x = player.transform.position.x;
            player.transform.position = Vector3.MoveTowards(player.transform.position, desirePosition, Speed * Time.deltaTime);
        }

    }
}
