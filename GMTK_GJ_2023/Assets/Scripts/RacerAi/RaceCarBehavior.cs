using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RaceCarBehavior : MonoBehaviour
{
    [SerializeField] private NavMeshAgent myAiAgent;
    public Transform myNavTargetTrans;
    private float startSpeed, startAngular, startAccel;

    // Start is called before the first frame update
    void Start()
    {
        //set vars
        startSpeed = myAiAgent.speed; startAngular = myAiAgent.angularSpeed; startAccel = myAiAgent.acceleration;
        myAiAgent.SetDestination(myNavTargetTrans.position);
    }


    //Enum.GetValues() if we want to check the enum type of the road

        //on col objects
    public void OnCollisionEnter(Collision col)
    {
        print("colled...");

        if (col.transform.tag == "RoadTrack")
            print("YEEEEEE HAWWWWWW!!!!!!!!");
    }//end of OnCollisionEnter(col)

}//end of race car behavior
