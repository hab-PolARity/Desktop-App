// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// /* Copyright (C) Xenfinity LLC - All Rights Reserved
//  * Unauthorized copying of this file, via any medium is strictly prohibited
//  * Proprietary and confidential
//  * Written by Bilal Itani <bilalitani1@gmail.com>, June 2017
//  */

// public class elementHandler : MonoBehaviour {

//     public float force = 5;

//     Camera cam;

// void Start(){
//     cam = GetComponent<Camera>();
// }

//     private void Update()
//     {
//         if (Input.GetMouseButtonDown(0))
//         {
//             RaycastHit hit;
//             Ray ray = cam.ScreenPointToRay(Input.mousePosition);

//             if (Physics.Raycast(ray, out hit, 100.0f))
//             {
//                 if (hit.transform != null)
//                 {

//                     Rigidbody rb;

//                     if (rb = hit.transform.GetComponent<Rigidbody>())
//                     {
//                         PrintName(hit.transform.gameObject);
//                         LaunchIntoAir(rb);
//                     }
//                 }
//             }
//         }
//     }

//     private void PrintName(GameObject go)
//     {
//         print(go.name);
//     }

//     private void LaunchIntoAir(Rigidbody rig)
//     {
//         rig.AddForce(rig.transform.up * force, ForceMode.Impulse);
//     }

// }

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
                        periodicTable.transform.position = new Vector3(-17, 6, 61);

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