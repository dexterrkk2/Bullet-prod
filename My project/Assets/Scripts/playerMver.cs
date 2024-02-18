using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class playerMver : Kinematic
{
    playerMvmnt myMoveType;
    LookWhereGoing mySeekRotateType;
    LookWhereGoing myFleeRotateType;
    public float speed;
    public float rotateSpeed;
    public bool flee = false;
    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new playerMvmnt();
        myMoveType.character = this;
        myMoveType.target = myTarget;
        myMoveType.flee = flee;
        myMoveType.speed = speed;
        myMoveType.rotateSpeed = rotateSpeed;

        mySeekRotateType = new LookWhereGoing();
        mySeekRotateType.character = this;
        mySeekRotateType.target = myTarget;

        myFleeRotateType = new LookWhereGoing();
        myFleeRotateType.character = this;
        myFleeRotateType.target = myTarget;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = flee ? myFleeRotateType.getSteering().angular : mySeekRotateType.getSteering().angular;
        base.Update();
    }
}
