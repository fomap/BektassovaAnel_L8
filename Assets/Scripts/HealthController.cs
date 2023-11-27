using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HealthController : MonoBehaviour
{
 
     [SerializeField] private Slider[] _healthBar; 
      [SerializeField]private float _health;
     [SerializeField] private float _fillSpeed; 
     private float _healthPresent;

    
    private void Start()
    {
        _healthPresent = _health / 100; 
    }


    public void MakeDamage (float damage)
    {

       

        if(_health > 0)
        {
            _health -= damage; 
        }
        else
        {
            _health = 0; 
        }



         _healthPresent = _health / 100; 


    }

   

   private void Update()
   {
        foreach (var item in _healthBar)
        {
            item.value = Mathf.Lerp(item.value, _healthPresent,  Time.deltaTime *_fillSpeed); 
        }    
       
   }

}
