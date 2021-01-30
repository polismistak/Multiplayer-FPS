using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryButton : MonoBehaviour
{

    [SerializeField]
    private GameObject category;
    private GameObject startMenu;
    // Start is called before the first frame update
    void Start()
    {
        category.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showCategory() {
        category.gameObject.SetActive(true);
        startMenu.gameObject.SetActive(false);
    }
}
