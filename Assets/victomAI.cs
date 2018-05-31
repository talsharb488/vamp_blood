using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victomAI : MonoBehaviour {
	public float movmantspeed=6;
	public Vector3 locas;
	public float idletime=3f,potrolRtime=4f,potrolLtime=4f;
	public float idletimesave,potrolRtimesave,potrolLtimesave;
	public string idle="enemyide",potrol="enemyakk";
	public Rigidbody2D victom;
	public bool R=true;
	public GameObject player;
	public float dist;
    public enum victomState 
    {
        idle,
     potrol,
    run,
   
    
   }
   public victomState en;
	// Use this for initialization
	void Start () {
		idletime=Random.Range(1f,4f);
		potrolRtime=Random.Range(3f,6f);
		potrolLtime=Random.Range(3f,6f);
		victom=this.gameObject.GetComponent<Rigidbody2D>();
		player=GameObject.Find("player");
       locas=transform.localScale;
	   en=victomState.idle;
	   idletimesave=idletime;
	   potrolRtimesave=potrolRtime;
	   potrolLtimesave=potrolLtime;
	}
	
	// Update is called once per frame
	void Update () {
		if (en==victomState.idle)
		{
			transform.position=new Vector2(transform.position.x,transform.position.y);
			idletime-=Time.deltaTime;
			if (idletime<=0)
			{
				en=victomState.potrol;
				idletime=idletimesave;
			}
		}
		if (en==victomState.potrol)
		{
			if (R)
			{

				MR();
				potrolRtime-=Time.deltaTime;
				if (potrolRtime<=0)
				{
					 R=!R;
					potrolRtime=potrolRtimesave;
					en=victomState.idle;
                   
				}
			}
			else
			{
				ML();
				potrolLtime-=Time.deltaTime;
				if (potrolLtime<=0)
				{
					 R=!R;
					potrolLtime=potrolLtimesave;
					en=victomState.idle;
				}
			}
		}
		if (en==victomState.run)
		{
			movmantspeed=movmantspeed+0.15f;
			if (player.transform.position.x < transform.position.x)
			{
				MR();
			}
			if (player.transform.position.x > transform.position.x)
			{
				ML();
			}
		}
		
		
	}
	void FixedUpdate ()
    {
		dist= Vector3.Distance(player.transform.position, transform.position);
		if (dist<=4.6f)
		{
			idletime=idletimesave;
			potrolRtime=potrolRtimesave;
			potrolLtime=potrolLtimesave;
			en=victomState.run;
	
		}
		if ((dist>=20)&&(en==victomState.run))
		{
			movmantspeed=movmantspeed-0.15f;
			en=victomState.idle;
		}
	}
	public void MR()
    {
      //movingrhait=true;
      if (locas.x<0)
      {
          locas.x *= -1;
       }
      
       transform.localScale=locas;
       victom.velocity=new Vector2(locas.x*movmantspeed,victom.velocity.y);
    }
    public void ML()
    {
      //movingrhait=false;
      if (locas.x>0)
      {
          locas.x *= -1;
      }
      
      transform.localScale=locas;
      victom.velocity=new Vector2(locas.x*movmantspeed,victom.velocity.y);
    }
}
