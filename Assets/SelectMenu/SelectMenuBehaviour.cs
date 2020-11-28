using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SelectMenuBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject container;

    // Start is called before the first frame update
    void Start()
    {
        container.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Switch();
    }

    private void Switch() {
        if (Input.GetKeyDown(KeyCode.B)){
            if (container.activeInHierarchy)
            {
                container.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                container.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
}
