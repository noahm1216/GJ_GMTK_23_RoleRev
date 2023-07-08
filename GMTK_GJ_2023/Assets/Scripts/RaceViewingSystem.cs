using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RaceViewingSystem : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera _vcamDriverPov;
    [SerializeField] CinemachineVirtualCamera _vcamThirdPerson;
    [SerializeField] CinemachineVirtualCamera _vcamReverseThirdPerson;
    [SerializeField] CinemachineVirtualCamera _vcamFrontBumper;
    [SerializeField] CinemachineVirtualCamera _vcamTopDown;
    [SerializeField] CinemachineVirtualCamera _vcamRotatingAroundCar;
    [SerializeField] CinemachineVirtualCamera _vcamDriverWindow;


    private void OnEnable()
    {
        ViewingCameraSwitcher.Register(_vcamThirdPerson);
        ViewingCameraSwitcher.Register(_vcamDriverPov);
        ViewingCameraSwitcher.Register(_vcamReverseThirdPerson);
        ViewingCameraSwitcher.Register (_vcamFrontBumper);
        ViewingCameraSwitcher.Register(_vcamTopDown);   
        ViewingCameraSwitcher.Register(_vcamRotatingAroundCar);
        ViewingCameraSwitcher.Register(_vcamDriverWindow);
        
        ViewingCameraSwitcher.SwitchCamera(_vcamDriverPov);
    }

    private void OnDisable()
    {
        ViewingCameraSwitcher.UnRegister(_vcamThirdPerson);
        ViewingCameraSwitcher.UnRegister(_vcamDriverPov);
        ViewingCameraSwitcher.UnRegister(_vcamReverseThirdPerson);
        ViewingCameraSwitcher.UnRegister(_vcamFrontBumper);
        ViewingCameraSwitcher.UnRegister(_vcamTopDown);
        ViewingCameraSwitcher.UnRegister(_vcamRotatingAroundCar);
        ViewingCameraSwitcher.UnRegister(_vcamDriverWindow);
    }

    // Update is called once per frame
    void Update()
    {
        //cycles through different cameras on space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ViewingCameraSwitcher.IsActiveCamera(_vcamDriverWindow))
            {
                ViewingCameraSwitcher.SwitchCamera(_vcamDriverPov);
                Debug.Log("Switch to Driver Pov");
            }
            else if (ViewingCameraSwitcher.IsActiveCamera(_vcamDriverPov))
            {
                ViewingCameraSwitcher.SwitchCamera(_vcamThirdPerson);
                Debug.Log("Switch to Third Person");
            }
            else if (ViewingCameraSwitcher.IsActiveCamera(_vcamThirdPerson))
            {
                ViewingCameraSwitcher.SwitchCamera(_vcamReverseThirdPerson);
                Debug.Log("Switch to Reverse Third Person");
            }
            else if (ViewingCameraSwitcher.IsActiveCamera(_vcamReverseThirdPerson))
            {
                ViewingCameraSwitcher.SwitchCamera(_vcamFrontBumper);
            }
            else if (ViewingCameraSwitcher.IsActiveCamera(_vcamFrontBumper))
            {
                ViewingCameraSwitcher.SwitchCamera(_vcamTopDown);
            }
            else if (ViewingCameraSwitcher.IsActiveCamera(_vcamTopDown))
            {
                ViewingCameraSwitcher.SwitchCamera(_vcamRotatingAroundCar);
            }
            else if (ViewingCameraSwitcher.IsActiveCamera(_vcamRotatingAroundCar))
            {
                ViewingCameraSwitcher.SwitchCamera(_vcamDriverWindow);
            }

        }
    }
}
