
using UnityEngine;

public class MobContr : MonoBehaviour
{
    private bool _isaround = false , _isjump = false, _isgo = false,_hisgoing;
    private Transform needpos;
    [SerializeField] private GameObject _cam,ch,ram;
    [SerializeField] private float _speed;
    [SerializeField] private LayerMask _ground;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) _isaround = !_isaround;
        if(Input.GetKeyDown(KeyCode.J)) _isjump = !_isjump;
        if (_isaround) gameObject.transform.Rotate(new Vector3(0,1,0));
        else gameObject.transform.rotation = Quaternion.Euler(Vector3.zero);
        if(_isjump && Physics.CheckSphere(ch.transform.position,0.2f,_ground)) gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up* 5);
        if (Input.GetKey(KeyCode.F)) _isgo = true;
        else _isgo = false;
        _cam.SetActive(_isgo);
        ram.SetActive(_isgo);
        if(_hisgoing) transform.position = Vector3.MoveTowards(transform.position, new Vector3(needpos.position.x,transform.position.y,needpos.position.z), _speed);
    }

    public void MoveTo(Transform point)
    {
        _hisgoing = true;
        needpos = point;
    }
}
