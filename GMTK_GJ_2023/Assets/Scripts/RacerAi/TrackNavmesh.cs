using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class TrackNavmesh : MonoBehaviour
{
    public List<NavMeshSurface> surfaces = new List<NavMeshSurface>();
    public List<Transform> objectsToRotate = new List<Transform>();
    [SerializeField] private bool buildNavMeshNow;

    public void AddPieceToNavMesh(NavMeshSurface _navMshSrf)
    {
        surfaces.Add(_navMshSrf);
    }

    private void Update()
    {
        if (buildNavMeshNow) { BuildNaveMesh(); buildNavMeshNow = false; }
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
            surfaces[i].BuildNavMesh();
        }
    }

}
