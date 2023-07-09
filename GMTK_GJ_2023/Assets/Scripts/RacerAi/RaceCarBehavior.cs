using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RaceCarBehavior : MonoBehaviour
{
    public NavMeshAgent myAiAgent;
    public Transform myNavTargetTrans;
    private float startSpeed, startAngular, startAccel;

    [Range(0,1)] [Tooltip("higher *Speed* means faster on straight aways || higher *Handling* means more speed on turns || higher *Traction* means more speed on different terrain")]
    public float mySpeed, myHandling, myTraction;

    // Start is called before the first frame update
    void Start()
    {
        SetVars();
    }

    public void SetVars()
    {
        //set vars
        startSpeed = myAiAgent.speed; startAngular = myAiAgent.angularSpeed; startAccel = myAiAgent.acceleration;
        myAiAgent.SetDestination(myNavTargetTrans.position);
    }


    // a function to update current speeds
    private void UpdateSpeeds(bool _isTerrain, bool _isCurved)
    {
        print($"Curr Road: Terrain{_isTerrain} - Curved {_isCurved}");
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

        
        //multiplyer = 1 + multiplyer;

        myAiAgent.speed = startSpeed * multiplyer;
        myAiAgent.angularSpeed = startAngular * multiplyer;
        myAiAgent.acceleration = startAccel * multiplyer;

        

    }//end of UpdateSpeeds()

    //Enum.GetValues() if we want to check the enum type of the road

    //on trig objects
    private void OnTriggerEnter(Collider trig)
    {
        if (trig.tag == "RoadTrack")
        {
            TileBehavior scriptTB;

            if (trig.transform.GetComponent<TileBehavior>() == null)
                scriptTB = trig.transform.parent.GetComponent<TileBehavior>();
            else
                scriptTB = trig.transform.GetComponent<TileBehavior>();

            UpdateSpeeds(scriptTB.isTerrain, scriptTB.isCurved);
        }
    }//end of OnTriggerEnter
   



}//end of race car behavior
