using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RaceViewingSystem : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera _vcamDriverPov;
    [SerializeField] CinemachineVirtualCamera _vcamThirdPerson;
    [SerializeField] CinemachineVirtualCamera _vcamReverseThirdPerson;


    private void OnEnable()
    {
        ViewingCameraSwitcher.Register(_vcamThirdPerson);
        ViewingCameraSwitcher.Register(_vcamDriverPov);
        ViewingCameraSwitcher.SwitchCamera(_vcamThirdPerson);
    }

    private void OnDisable()
    {
        ViewingCameraSwitcher.UnRegister(_vcamThirdPerson);
        ViewingCameraSwitcher.UnRegister(_vcamDriverPov);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ViewingCameraSwitcher.IsActiveCamera(_vcamReverseThirdPerson))
            {
                ViewingCameraSwitcher.SwitchCamera(_vcamDriverPov);
            }
            else if (ViewingCameraSwitcher.IsActiveCamera(_vcamDriverPov))
            {
                ViewingCameraSwitcher.SwitchCamera(_vcamThirdPerson);
            }
            else if (ViewingCameraSwitcher.IsActiveCamera(_vcamThirdPerson))
            {
                ViewingCameraSwitcher.SwitchCamera(_vcamReverseThirdPerson);
            }
        }
    }
}
