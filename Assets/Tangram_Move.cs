using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tangram_Move : MonoBehaviour
{
    public GameObject GameObject;
    private Vector3 screenPoint;
    private Vector3 offset;
    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    bool DoubleClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clicked++;
            if (clicked == 1) clicktime = Time.time;
        }
        if (clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;
            return true;
        }
        else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;
        return false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        if (DoubleClick())
        {
            GameObject.transform.Rotate(0, 0, 45, Space.World);

        }
        // GameObject.transform.Rotate(0, 0, 45, Space.World);


        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        
        
    }
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

   
}
