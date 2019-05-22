using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMauseController : MonoBehaviour
{
    [SerializeField]
    GameObject target_point;

    [SerializeField]
    GameObject ActivObject;  //Активный объект 

    public int one;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _raycast();
         
        }


    }

    void _raycast()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out hit);

        if (hit.collider.tag == null) one++;
        if((hit.collider.tag=="Characters")||(hit.collider.tag=="Infrastructure"))
        {
            ActivObject = hit.collider.gameObject;
        }
        
        //ActivObject.GetComponent<PlayerCharacterContoller>().welk(hit.point);
    }
}
