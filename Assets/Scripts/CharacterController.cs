using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class CharacterController : MonoBehaviour
{

     public Slider sl;
    public TextMeshProUGUI slidertxt; 
    [SerializeField] private float _rotationSpeed; 
    [SerializeField] private float _moveSpeed; 
     
    [SerializeField] private Animator _animator; 
    [SerializeField] private  int _speedMulti = 2;
    [SerializeField] private int  _movementId = Animator.StringToHash("MovementSpeed"); 
    [SerializeField] private int  _jumpId = Animator.StringToHash("Jump"); 
    [SerializeField] private KeyCode _jumpKey = KeyCode.Space;  
    [SerializeField] private float _moveSlider; 
    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal"); 
        float verticalInput = Input.GetAxis("Vertical"); 
    

        // _moveSlider = sl.value;
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput); 
        movement.Normalize(); 

        transform.position = Vector3.MoveTowards(transform.position, transform.position + movement, Time.deltaTime * _moveSpeed); 
        Quaternion targetRotation = Quaternion.LookRotation(new Vector3(horizontalInput, 0, verticalInput));
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * _rotationSpeed);   

        float calculatedSpeed =  Mathf.Clamp(Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput), 0, 0.7f); 
        

        Jump(_jumpId, _jumpKey); 
      
          if(Input.GetKey(KeyCode.LeftShift))
        {
            calculatedSpeed *= _speedMulti; ;
            _moveSpeed = Mathf.Clamp(_moveSpeed, 2 , _moveSpeed * _speedMulti); 

        }
        
        // Debug.Log(calculatedSpeed); 
         _animator.SetFloat(_movementId, calculatedSpeed); 


    }




    private void Jump (int jumpId, KeyCode keyForJump)
    {
          if(Input.GetKeyDown(keyForJump))
        {
            _animator.SetTrigger(jumpId); 
        }


    }


    public void SliderUpd(Slider slider)
    {
        // Debug.Log(slider.value); 
        // please forgive me that code and project overall has this much junk in it 
        _animator.SetFloat(_movementId, slider.value); 
    }
}
