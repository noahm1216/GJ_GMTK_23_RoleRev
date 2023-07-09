using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RaceCarBehavior : MonoBehaviour
{
    [SerializeField] private NavMeshAgent myAiAgent;
    public Transform myNavTargetTrans;
    private float startSpeed, startAngular, startAccel;

    [Range(0,1)]
    public float mySpeed, myHandling, myTraction;

    // Start is called before the first frame update
    void Start()
    {
        //set vars
        startSpeed = myAiAgent.speed; startAngular = myAiAgent.angularSpeed; startAccel = myAiAgent.acceleration;
        myAiAgent.SetDestination(myNavTargetTrans.position);
    }


    // a function to update current speeds
    private void UpdateSpeeds(Vector3 _newSpeeds, bool _isTerrain, bool _isCurved)
    {
        float multiplyer = 0;

        //------------------is terrtain
        if (_isTerrain)
            multiplyer = myTraction;
        else
            multiplyer = 1 - myTraction; //if we have a low traction we get more speed on normal roads


        //----------------is curved
        if (_isCurved)
            multiplyer = (multiplyer + myHandling) / 2;
        else
            multiplyer = (multiplyer + mySpeed) / 2;

        myAiAgent.speed = _newSpeeds.x;
        myAiAgent.angularSpeed = _newSpeeds.y;
        myAiAgent.acceleration = _newSpeeds.z;
    }//end of UpdateSpeeds()

    //Enum.GetValues() if we want to check the enum type of the road

    //on col objects
    public void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "RoadTrack")
            print("YEEEEEE HAWWWWWW!!!!!!!!");
    }//end of OnCollisionEnter(col)



}//end of race car behavior
