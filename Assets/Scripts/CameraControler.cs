// Inspired by https://www.youtube.com/watch?v=xcn7hz7J7sI

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public Transform player;

    private Vector3 offset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool LookAtPlayer = false;

    public bool RotateAroundPlayer = true;

    public float RotationsSpeed = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {   
        //lets camera rotate around the player by mouse movement
        if(RotateAroundPlayer)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationsSpeed, Vector3.up);

            offset = camTurnAngle * offset;
        }

        Vector3 newPos = player.position + offset;

        //camera position will be set to new player position but with added offset
        transform.position = player.transform.position + offset;

        if(LookAtPlayer || RotateAroundPlayer)
        {
            transform.LookAt(player);
        }
    }
}
