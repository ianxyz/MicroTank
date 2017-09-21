using UnityEngine;
using VRStandardAssets.Utils;



    public class EnemyBehaviorBasic : MonoBehaviour
    {

    

        [SerializeField]
        private VRInteractiveItem m_InteractiveItem;
        private void OnEnable()
        {
            m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;
    }

        private void OnDisable()
        {
            m_InteractiveItem.OnOver -= HandleOver;
        m_InteractiveItem.OnOut -= HandleOut;
    }



    [SerializeField]
    private ParticleSystem myParticleSystem;
    private ParticleSystem.EmissionModule myEmissionModule;
    private float myEmissionRate;

    public float ParticleIncreaseWithDamage = .2f;





    public GameObject deathExplosion;


    public float HP = 100f;
    private bool gazeOn = false;

    // Use this for initialization
    void Start()
        {


        myEmissionModule = myParticleSystem.emission;


        //temporary, to ensure that enemies don't live on forever
        Destroy(gameObject, 10);
        }

        // Update is called once per frame
        void Update()
        {
        if (gazeOn == true)
        {
            HP -= 1;
            Debug.Log(HP);

            myEmissionRate += ParticleIncreaseWithDamage;
        }

        if (HP <= 0)
        {
            //put a death explosion where this enemy was
            Instantiate(deathExplosion, transform.position, transform.rotation);


            Destroy(gameObject);
        }

        myEmissionModule.rate = new ParticleSystem.MinMaxCurve(myEmissionRate);


    }


    private void HandleOver()
    {
        gazeOn = true;
    }
    private void HandleOut()
    {
        gazeOn = false;
    }







}
