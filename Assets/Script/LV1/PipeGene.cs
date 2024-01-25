using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGene : MonoBehaviour
{
    public GameObject pipePrefabs;
    // Start is called before the first frame update
    private float countdown;
    public float timeDuration;
    public bool choPhepSinhOng;
    private void Awake()
    {
        countdown = 1f;
        choPhepSinhOng = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(choPhepSinhOng == true)
        {
            countdown -= Time.deltaTime; //mỗi frame countdown -=1 FPS
            if (countdown <= 0)
            {
                //Sinh ra ống
                //Debug.Log("sinh 1 ong");
                Instantiate(pipePrefabs, new Vector3(10, Random.Range(-1.5f, 2.5f), 0), Quaternion.identity);
                countdown = timeDuration;
            }
        }
        
    }
}
