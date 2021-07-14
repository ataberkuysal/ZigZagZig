
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameAndUiManager _gameAndUiManager;

    public GameObject gem;
    private Vector3 dirRight;
    private Vector3 dirLeft;
    private bool dir;
    private Vector3 placeholder;

    private void Start()
    {
        dirRight = new Vector3(1,0,1).normalized;
        dirLeft = new Vector3(-1, 0, 1).normalized;
        
        placeholder = dirRight;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "gem")
        {
            gem = other.GetComponent<Collider>().gameObject;

            Destroy(gem);
            _gameAndUiManager.score2 += 10;
        }
    }
    private void Update()
    {
        transform.Translate(placeholder * (5.5f * Time.deltaTime));
        if (Input.touchCount > 0)
        {
            Touch _touch = Input.GetTouch(0);
            
            if (_touch.phase == TouchPhase.Began)
            {
                if (dir==false)
                {
                    placeholder = dirLeft;
                    dir = true;
                }
                else if (dir==true)
                {
                    placeholder = dirRight;
                    dir = false;
                }

                _gameAndUiManager.score++;
            }
        }
        if (transform.position.y < 2.4f)
        {
            gem = GameObject.FindGameObjectWithTag("gem");
            Destroy(gem);
            
        }
    }

}
