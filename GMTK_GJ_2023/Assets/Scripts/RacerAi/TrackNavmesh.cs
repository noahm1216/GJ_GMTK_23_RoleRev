using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;
using Cinemachine;

public class TrackNavmesh : MonoBehaviour
{
    public List<NavMeshSurface> surfaces = new List<NavMeshSurface>();
    public List<Transform> objectsToRotate = new List<Transform>();
    [SerializeField] private bool buildNavMeshNow;

    public List<GameObject> racerPrefabs = new List<GameObject>();
    public GameObject racerTextPrefab;
    public GameObject gabrielsCardsObj;

    public void GetNewTrack()
    {
        print("clicked New Track");

        foreach (Transform _child in transform)
        {
            if (_child.GetComponent<NavMeshSurface>() != null)
                AddPieceToNavMesh(_child.GetComponent<NavMeshSurface>());
        }

        print("spawning soon...");
        BuildNaveMesh();
        print("0) waiting to spawn racers");
        StartCoroutine( WaitToSpawnRacers());
    }

    public void AddPieceToNavMesh(NavMeshSurface _navMshSrf)
    {
        surfaces.Add(_navMshSrf);
    }

    private void Update()
    {
        if (buildNavMeshNow) { BuildNaveMesh(); buildNavMeshNow = false; } // for manual updates ideally
    }

    // Use this for initialization
    public void BuildNaveMesh()
    {

        //for (int j = 0; j < objectsToRotate.Length; j++)
        //{
        //    objectsToRotate[j].localRotation = Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0));
        //}

        for (int i = 0; i < surfaces.Count; i++)
        {
            surfaces[i].RemoveData();
            surfaces[i].BuildNavMesh();
        }
    }


    public IEnumerator WaitToSpawnRacers()
    {
        print("1) waiting to spawn racers");
        gabrielsCardsObj.SetActive(false);

        yield return new WaitForSeconds(2);

        print("2) waiting to spawn racers");

        //spawn a target cube
        GameObject winnerCube = new GameObject("Winner Cube");
        winnerCube.transform.position = surfaces[surfaces.Count-1].transform.position + new Vector3(0, 5f, 0);

        yield return new WaitForSeconds(1);

        print("3) waiting to spawn racers");

        List<RaceCarBehavior> carScripts = new List<RaceCarBehavior>();

        //spawn racers
        foreach (GameObject _racer in racerPrefabs)
        {
            GameObject racerClone = Instantiate(_racer, surfaces[0].transform.position, _racer.transform.rotation);
            //assign cube
            racerClone.GetComponent<RaceCarBehavior>().myNavTargetTrans = winnerCube.transform;
            racerClone.GetComponent<RaceCarBehavior>().myAiAgent.SetDestination(winnerCube.transform.position);
            carScripts.Add(racerClone.GetComponent<RaceCarBehavior>());
        }

        yield return new WaitForSeconds(0.05f);

        print("4) waiting to spawn racers");

        //add cinema camera brain to our  main camera
        Camera.main.gameObject.AddComponent<CinemachineBrain>();
        racerTextPrefab.SetActive(true);

        yield return new WaitForSeconds(0.1f);

        //spawn racers
        foreach (RaceCarBehavior _script in carScripts)
        {
            _script.SetVars();
            print("GO GO GO!!!");
        }

    }

}
