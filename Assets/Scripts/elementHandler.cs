
using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.Events;

 public class elementHandler : MonoBehaviour {

     public GameObject definedButton, periodicTable, instance;
     public string element ;
     public UnityEvent OnClick = new UnityEvent();
     private bool flag = true;

     // Use this for initialization
     void Start () {
         definedButton = this.gameObject;
         periodicTable = GameObject.Find("periodicTable");

     }

     void unloadElement() {
                            flag = true;
                            Destroy(instance);
                            Vector3 currPos = new Vector3(-17, 6, 53);
                            Vector3 newPos = new Vector3(-17, 6, 30);
                        // periodicTable.transform.position = Vector3.Lerp(currPos, newPos, Time.deltaTime * 20);
                        periodicTable.transform.position = new Vector3(-17, 6, 30);
                    }


     // Update is called once per frame
     void Update () {
         var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit Hit;


        if (Input.GetKey ("escape")) {
                 Application.Quit();
        }


         if (Input.GetMouseButtonDown(0))
         {
             if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
             {
                 if(Hit.collider.gameObject.name == definedButton.name){
                //  Debug.Log(Hit.collider.gameObject);
                    Debug.Log("gelo");

                    // instance.setActive(true);

                    if (flag) {

                        flag = false;
                        Vector3 currPos = new Vector3(-17, 6, 30);
                        Vector3 newPos = new Vector3(-17, 6, 61);
                        // periodicTable.transform.position = Vector3.Lerp(currPos, newPos, Time.deltaTime * 20);
                        periodicTable.transform.position = new Vector3(-17, 6, 1000);

                        instance = Instantiate(Resources.Load(element, typeof(GameObject))) as GameObject;
                        // GameObject button = (GameObject) Instantiate( buttonPrefab ) ;

                        // button.onClick.AddListener(() => unloadElement());


                        }


                        // void MakeButton()
                        // {
                        //     // Instantiate (clone) the prefab
                        //     GameObject button = (GameObject) Instantiate( buttonPrefab ) ;
                        //     button.AddListener(() => unloadElement());

                        //     // var panel = GameObject.Find("CommandPanel");
                        //     // button.transform.position = panel.transform.position;
                        //     // button.GetComponent<RectTransform>().SetParent(panel.transform);
                        //     // button.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left,0,10);
                        //     // button.layer = 5;

                        // }
                 }



             }

             if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject.name == "Text.002") {
                 unloadElement();
                }


         }
     }
 }


// 0.66
// 3.0565
// 0.12
// 0
// -185.942
// 0
// 48
// 48
// 48

// -1.66
// 3.05
// -0.13
// 0
// -185.942
// 0
// 48
// 48
// 48


// 0.26
// 3.25
// 0.08
// 0
// -185.942
// 0
// 48
// 48
// 48

// 2
// -2.56
// 2.808
// -0.22
// 0
// -185.942
// 0
// 48
// 48
// 48



// 3
// 3.08
// 0.35
// 0.38
// 0
// -185.942
// 0
// 48
// 48
// 48


// 4
// 3.07
// 3.02
// 0.37
// 0
// -185.942
// 0
// 48
// 48
// 48

// 5
// -1.62
// 0.35
// 0
// 0
// -185.942
// 0
// 48
// 48


// -0.1
// -1.5
// 6.6

// -0.65
// -1.63
// 5.1



// 6
// -2.01
// 0.35
// -0.05
// 0
// -185.942
// 0
// 48
// 48
// 48