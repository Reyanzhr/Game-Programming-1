using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHandle : MonoBehaviour
{
    public Animator CharAnimator;    
    void Start()
    {
        print("Start");
      CharAnimator = GetComponent<Animator>();
    }

  void AttackNow()
  {
    CharAnimator.SetTrigger("doAttack");
  }
    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))  
      {
        print("Kepencet");
        AttackNow();
      }
    }

} 
