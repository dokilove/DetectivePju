using TMPro;
using UnityEngine;

public class TestTouch : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI debugSubText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.touches[0];

            if (touch.phase == TouchPhase.Began)
            {
                Vector3 pos = touch.position;
                ClickAction(pos);
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            ClickAction(pos);
        }
    }
    void ClickAction(Vector3 pos)
    {
        Ray ray = Camera.main.ScreenPointToRay(pos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            string clickedObjectName = hit.collider.gameObject.name;
            Debug.Log(clickedObjectName);
            debugSubText.text = clickedObjectName;
        }
    }
}
