using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    private Vector3 CamDis;
    void Start()
    {
        CamDis = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + CamDis;
    }
}
