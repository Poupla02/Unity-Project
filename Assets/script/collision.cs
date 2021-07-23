using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{


    float x,y,z;
    int score=0;
    Vector3 pos;
    float timeRemaining=20;
    public GameObject scoretext;
    bool timeIsRuning;

    GameObject projetile1, projectile2;
    // Start is called before the first frame update
    void Start()
    {

        timeIsRuning=true;
        projetile1=GameObject.Find("cube1");
        
        projectile2=GameObject.Find("cube2");

        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeIsRuning){

            if(timeRemaining>0){
                timeRemaining-=Time.deltaTime;
            }
            else{
                x=Random.Range(-1f,1f);
                y=Random.Range(0.4f,1f);
                
                z=Random.Range(-1f,1f);

                pos=new Vector3(x,y,z);

                transform.position=pos;
                timeRemaining=20;
            }
        }
        
    }

    public void OnCollisionEnter(Collision col){


            if(col.gameObject.name=="cube1" || col.gameObject.name=="cube2"){
                SetScore(1);
            }
            
    }


    public void SetScore(int ajouterscore){

        score+=ajouterscore;

        GameObject.Find("Score").GetComponent<UnityEngine.UI.Text>().text="Score: "+score.ToString();


        x=Random.Range(-1f,1f);
        y=Random.Range(0.4f,1f);
        z=Random.Range(-1f,1f);

        pos=new Vector3(x,y,z);

        transform.position=pos;
        timeRemaining=20;

    }
}