using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Animation_script10 : MonoBehaviour 
{

	public GameObject switch_on_1_btn;
	public GameObject switch_off_1_btn;
	public GameObject switch_on_2_btn;
	public GameObject switch_off_2_btn;
	public GameObject switch_on_3_btn;
	public GameObject switch_off_3_btn;
	public GameObject switch_on_4_btn;
	public GameObject switch_off_4_btn;
	public GameObject switch_on_5_btn;
	public GameObject switch_off_5_btn;
	public GameObject switch_on_6_btn;
	public GameObject switch_off_6_btn;
	public GameObject switch_on_7_btn;
	public GameObject switch_off_7_btn;
	public GameObject switch_on_8_btn;
	public GameObject switch_off_8_btn;
	public GameObject switch_on_9_btn;
	public GameObject switch_off_9_btn;
	public GameObject switch_on_10_btn;
	public GameObject switch_off_10_btn;
	public GameObject switch_on_11_btn;
	public GameObject switch_off_11_btn;
	public GameObject switch_on_12_btn;
	public GameObject switch_off_12_btn;

	public GameObject paper_sheck_1;
	public GameObject paper_sheck_2;
	public GameObject paper_sheck_3;
	public GameObject paper_sheck_4;
	public GameObject paper_sheck_5;
	public GameObject paper_sheck_6;
	public GameObject paper_sheck_7;
	public GameObject paper_sheck_8;

	public GameObject iron_filling_btn;


	public GameObject battery_flip_btn_1;
	public GameObject battery_flip_btn_2;
	public GameObject battery_flip_btn_3;

	public GameObject hand_1;
	public GameObject hand_2;
	public Slider sliderChange;
	public Slider sliderChange_2;
	public GameObject fbx;

	public GameObject sound_2;
	public GameObject sound_3;
	public GameObject sound_4;
	public GameObject sound_5;



	// Use this for initialization
	void Start () 
	{
		switch_off_1_btn.gameObject.SetActive(false);
		switch_on_2_btn.gameObject.SetActive(false);
		switch_off_2_btn.gameObject.SetActive(false);
		switch_on_3_btn.gameObject.SetActive(false);
		switch_off_3_btn.gameObject.SetActive(false);
		switch_on_4_btn.gameObject.SetActive(false);
		switch_off_4_btn.gameObject.SetActive(false);
		switch_on_5_btn.gameObject.SetActive(false);
		switch_off_5_btn.gameObject.SetActive (false);
		switch_on_6_btn.gameObject.SetActive(false);
		switch_off_6_btn.gameObject.SetActive (false);
		switch_on_7_btn.gameObject.SetActive(false);
		switch_off_7_btn.gameObject.SetActive (false);
		switch_on_8_btn.gameObject.SetActive(false);
		switch_off_8_btn.gameObject.SetActive (false);
		switch_on_9_btn.gameObject.SetActive(false);
		switch_off_9_btn.gameObject.SetActive (false);
		switch_on_10_btn.gameObject.SetActive(false);
		switch_off_10_btn.gameObject.SetActive (false);
		switch_on_11_btn.gameObject.SetActive(false);
		switch_off_11_btn.gameObject.SetActive (false);
		switch_on_12_btn.gameObject.SetActive(false);
		switch_off_12_btn.gameObject.SetActive (false);

		iron_filling_btn.gameObject.SetActive (false);
		paper_sheck_1.gameObject.SetActive (false);
		paper_sheck_2.gameObject.SetActive (false);
		paper_sheck_3.gameObject.SetActive (false);
		paper_sheck_4.gameObject.SetActive (false);
		paper_sheck_5.gameObject.SetActive (false);
		paper_sheck_6.gameObject.SetActive (false);
		paper_sheck_7.gameObject.SetActive (false);
		paper_sheck_8.gameObject.SetActive (false);

		battery_flip_btn_1.gameObject.SetActive (false);
		battery_flip_btn_2.gameObject.SetActive (false);
		battery_flip_btn_3.gameObject.SetActive (false);

		hand_1.gameObject.SetActive (false);
		hand_2.gameObject.SetActive (false);

		sliderChange.gameObject.SetActive (false);
		sliderChange_2.gameObject.SetActive (false);
	}
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void switch_on_1()
	{
		hand_1.gameObject.SetActive (true);
		hand_2.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<AudioSource> ().Stop ();
		sound_2.gameObject.GetComponent<AudioSource> ().Play ();
		switch_off_1_btn.gameObject.SetActive(true);
		switch_on_1_btn.gameObject.SetActive(false);
		battery_flip_btn_1.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on_1");
		fbx.gameObject.GetComponent<Animation> ().Play ("current_show_1");
		Invoke ("wait_1",1);
	}
	void wait_1()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_1");
	}
	public void switch_off_1()
	{
		hand_1.gameObject.SetActive (false);
		sound_2.gameObject.GetComponent<AudioSource> ().Stop ();
		switch_off_1_btn.gameObject.SetActive(false);
		switch_on_1_btn.gameObject.SetActive(true);
		battery_flip_btn_1.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off_1");
	}

	public void battery_flip_1()
	{
		battery_flip_btn_1.gameObject.SetActive (false);
		switch_on_1_btn.gameObject.SetActive(false);
		fbx.gameObject.GetComponent<Animation> ().Play ("battery_flip_1");
		switch_on_2_btn.gameObject.SetActive(true);
	}
		

	public void switch_on_2()
	{
		sound_3.gameObject.GetComponent<AudioSource> ().Play ();
		hand_1.gameObject.SetActive (false);
		hand_2.gameObject.SetActive (true);
		switch_on_2_btn.gameObject.SetActive(false);
		switch_off_2_btn.gameObject.SetActive(true);
		iron_filling_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on_2");
		fbx.gameObject.GetComponent<Animation> ().Play ("current_show_2");
		Invoke ("wait_2",1);
	}
	void wait_2()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_2");
	}
	public void switch_off_2()
	{
		sound_3.gameObject.GetComponent<AudioSource> ().Stop ();
		hand_2.gameObject.SetActive (false);
		switch_on_2_btn.gameObject.SetActive(true);
		switch_off_2_btn.gameObject.SetActive(false);
		iron_filling_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off_2");
	}

	public void iron_filling()
	{
		hand_2.gameObject.SetActive (false);
		sound_3.gameObject.GetComponent<AudioSource> ().Stop ();
		iron_filling_btn.gameObject.SetActive (false);
		switch_off_2_btn.gameObject.SetActive(false);
		switch_off_3_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("iron_filling");
		Invoke ("wait_3",2);
	}
	void wait_3()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("iron_current_show");
		Invoke ("wait_4",1.5f);
	}
	void wait_4()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_3");
	}
	//

	public void switch_off_3()
	{
		sound_4.gameObject.GetComponent<AudioSource> ().Stop ();
		switch_off_3_btn.gameObject.SetActive (false);
		switch_on_3_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off_3");
	}
	public void switch_on_3()
	{
		sound_5.gameObject.GetComponent<AudioSource> ().Stop ();
		sound_4.gameObject.GetComponent<AudioSource> ().Play ();
		sliderChange.gameObject.SetActive (true);
		switch_off_3_btn.gameObject.SetActive (true);
		switch_on_3_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on_3");
		Invoke ("wait_5",1);
	}
	void wait_5()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_3");
	}

	public void slider_change_val()
	{
		if (sliderChange.value == 0) 
		{
			fbx.gameObject.GetComponent<Animation> ().Play ("loop_3");

			switch_off_3_btn.gameObject.SetActive (true);
			switch_off_4_btn.gameObject.SetActive (false);
			switch_off_5_btn.gameObject.SetActive (false);
			switch_off_6_btn.gameObject.SetActive (false);
			switch_off_7_btn.gameObject.SetActive (false);

			switch_on_3_btn.gameObject.SetActive (false);	
		}
		else if(sliderChange.value == 1) 
		{
			fbx.gameObject.GetComponent<Animation> ().Play ("1_reostate_i");
			fbx.gameObject.GetComponent<Animation> ().Play ("r_loop_1");

			paper_sheck_1.gameObject.SetActive (true);
			paper_sheck_2.gameObject.SetActive (false);
			paper_sheck_3.gameObject.SetActive (false);
			paper_sheck_4.gameObject.SetActive (false);

			switch_off_4_btn.gameObject.SetActive (true);
			switch_off_3_btn.gameObject.SetActive (false);
			switch_off_5_btn.gameObject.SetActive (false);
			switch_off_6_btn.gameObject.SetActive (false);
			switch_off_7_btn.gameObject.SetActive (false);

			switch_on_4_btn.gameObject.SetActive (false);
		}
		else if(sliderChange.value==2)
		{
			fbx.gameObject.GetComponent<Animation> ().Play ("2_reostate_i");
			fbx.gameObject.GetComponent<Animation> ().Play ("r_loop_2");

			paper_sheck_1.gameObject.SetActive (false);
			paper_sheck_2.gameObject.SetActive (true);
			paper_sheck_3.gameObject.SetActive (false);
			paper_sheck_4.gameObject.SetActive (false);

			switch_off_5_btn.gameObject.SetActive (true);
			switch_off_4_btn.gameObject.SetActive (false);
			switch_off_3_btn.gameObject.SetActive (false);
			switch_off_6_btn.gameObject.SetActive (false);
			switch_off_7_btn.gameObject.SetActive (false);
		}
		else if(sliderChange.value==3)
		{
			fbx.gameObject.GetComponent<Animation> ().Play ("3_reostate_i");
			fbx.gameObject.GetComponent<Animation> ().Play ("r_loop_3");

			switch_off_7_btn.gameObject.SetActive (false);
			switch_off_6_btn.gameObject.SetActive (true);
			switch_off_5_btn.gameObject.SetActive (false);
			switch_off_4_btn.gameObject.SetActive (false);
			switch_off_3_btn.gameObject.SetActive (false);

			paper_sheck_1.gameObject.SetActive (false);
			paper_sheck_2.gameObject.SetActive (false);
			paper_sheck_3.gameObject.SetActive (true);
			paper_sheck_4.gameObject.SetActive (false);
		}
		else if(sliderChange.value==4)
		{
			fbx.gameObject.GetComponent<Animation> ().Play ("4_reostate_i");
			fbx.gameObject.GetComponent<Animation> ().Play ("r_loop_4");

			switch_off_7_btn.gameObject.SetActive (true);
			switch_off_6_btn.gameObject.SetActive (false);
			switch_off_5_btn.gameObject.SetActive (false);
			switch_off_4_btn.gameObject.SetActive (false);
			switch_off_3_btn.gameObject.SetActive (false);

			paper_sheck_1.gameObject.SetActive (false);
			paper_sheck_2.gameObject.SetActive (false);
			paper_sheck_3.gameObject.SetActive (false);
			paper_sheck_4.gameObject.SetActive (true);
		}
	}
	// Slider
	public void slider_change_val_2()
	{
		if (sliderChange_2.value == 4) 
		{
			fbx.gameObject.GetComponent<Animation> ().Play ("rv_loop_5");
			switch_off_12_btn.gameObject.SetActive (false);
			switch_off_11_btn.gameObject.SetActive (false);
			switch_off_10_btn.gameObject.SetActive (false);
			switch_off_8_btn.gameObject.SetActive (true);
			switch_off_9_btn.gameObject.SetActive (false);

			paper_sheck_5.gameObject.SetActive (true);
			paper_sheck_6.gameObject.SetActive (false);
			paper_sheck_7.gameObject.SetActive (false);
			paper_sheck_8.gameObject.SetActive (false);
		}
		else if(sliderChange_2.value == 3)
		{
			fbx.gameObject.GetComponent<Animation> ().Play ("rv_loop_4");
			switch_off_12_btn.gameObject.SetActive (false);
			switch_off_11_btn.gameObject.SetActive (false);
			switch_off_10_btn.gameObject.SetActive (false);
			switch_off_9_btn.gameObject.SetActive (true);
			switch_off_8_btn.gameObject.SetActive (false);

			paper_sheck_5.gameObject.SetActive (false);
			paper_sheck_6.gameObject.SetActive (true);
			paper_sheck_7.gameObject.SetActive (false);
			paper_sheck_8.gameObject.SetActive (false);
		}
		else if(sliderChange_2.value == 2)
		{
			fbx.gameObject.GetComponent<Animation> ().Play ("rv_loop_3");
			switch_off_12_btn.gameObject.SetActive (false);
			switch_off_11_btn.gameObject.SetActive (false);
			switch_off_10_btn.gameObject.SetActive (true);
			switch_off_9_btn.gameObject.SetActive (false);
			switch_off_8_btn.gameObject.SetActive (false);

			paper_sheck_5.gameObject.SetActive (false);
			paper_sheck_6.gameObject.SetActive (false);
			paper_sheck_7.gameObject.SetActive (true);
			paper_sheck_8.gameObject.SetActive (false);
		}
		else if(sliderChange_2.value == 1)
		{
			fbx.gameObject.GetComponent<Animation> ().Play ("rv_loop_2");
			switch_off_12_btn.gameObject.SetActive (false);
			switch_off_11_btn.gameObject.SetActive (true);
			switch_off_10_btn.gameObject.SetActive (false);
			switch_off_9_btn.gameObject.SetActive (false);
			switch_off_8_btn.gameObject.SetActive (false);

			paper_sheck_5.gameObject.SetActive (false);
			paper_sheck_6.gameObject.SetActive (false);
			paper_sheck_7.gameObject.SetActive (false);
			paper_sheck_8.gameObject.SetActive (true);
		}
		else if(sliderChange_2.value == 0)
		{
			fbx.gameObject.GetComponent<Animation> ().Play ("rv_loop_1");
			switch_off_12_btn.gameObject.SetActive (true);
			switch_off_11_btn.gameObject.SetActive (false);
			switch_off_10_btn.gameObject.SetActive (false);
			switch_off_9_btn.gameObject.SetActive (false);
			switch_off_8_btn.gameObject.SetActive (false);

		}
	}
	//Sdlider

	public void switch_off_4()
	{
		paper_sheck_1.gameObject.SetActive (false);
		switch_off_4_btn.gameObject.SetActive (false);
		switch_on_4_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off_4");
	}
	public void switch_on_4()
	{
		switch_off_4_btn.gameObject.SetActive (true);
		switch_on_4_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on_4");
		Invoke ("wait_6",1);
	}
	void wait_6()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("r_loop_1");
	}
	public void paper_sheak_fun_1()
	{
		sound_4.gameObject.GetComponent<AudioSource> ().Stop ();
		sound_5.gameObject.GetComponent<AudioSource> ().Play ();
		paper_sheck_1.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("paper_sheak_1");
		Invoke ("wait_7",1);
	}
	void wait_7()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("p_loop_1");
	}

	public void switch_off_5()
	{
		paper_sheck_2.gameObject.SetActive (false);
		switch_off_5_btn.gameObject.SetActive (false);
		switch_on_5_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off_5");
	}
	public void switch_on_5()
	{
		switch_off_5_btn.gameObject.SetActive (true);
		switch_on_5_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on_5");
		Invoke ("wait_8",1);
	}
	void wait_8()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("r_loop_2");
	}
	public void paper_sheak_fun_2()
	{
		paper_sheck_2.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("paper_sheak_2");
		Invoke ("wait_9",1);
	}
	void wait_9()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("p_loop_2");
	}

	//

	public void switch_off_6()
	{
		paper_sheck_3.gameObject.SetActive (false);
		switch_off_6_btn.gameObject.SetActive (false);
		switch_on_6_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off_6");
	}
	public void switch_on_6()
	{
		switch_off_6_btn.gameObject.SetActive (true);
		switch_on_6_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on_6");
		Invoke ("wait_10",1);
	}
	void wait_10()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("r_loop_3");
	}
	public void paper_sheak_fun_3()
	{
		paper_sheck_3.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("paper_sheak_3");
		Invoke ("wait_11",1);
	}
	void wait_11()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("p_loop_3");
	}

	//

	public void switch_off_7()
	{
		battery_flip_btn_2.gameObject.SetActive (true);
		paper_sheck_4.gameObject.SetActive (false);
		paper_sheck_8.gameObject.SetActive (false);
		switch_off_7_btn.gameObject.SetActive (false);
		switch_on_7_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off_7");
	}
	public void switch_on_7()
	{
		battery_flip_btn_2.gameObject.SetActive (false);
		switch_off_7_btn.gameObject.SetActive (true);
		switch_on_7_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on_7");
		Invoke ("wait_12",1);
	}
	void wait_12()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("r_loop_4");
	}
	public void paper_sheak_fun_4()
	{
		paper_sheck_4.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("paper_sheak_4");
		Invoke ("wait_13",1);
	}
	void wait_13()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("p_loop_4");
	}
	////
	///
	public void battery_flip_2()
	{
		sliderChange_2.value = 4;
		switch_on_7_btn.gameObject.SetActive (false);	
		switch_on_8_btn.gameObject.SetActive (true);

		sliderChange.gameObject.SetActive (false);
		sliderChange_2.gameObject.SetActive (true);

		battery_flip_btn_2.gameObject.SetActive (false);	
		fbx.gameObject.GetComponent<Animation> ().Play ("battery_flip_7");
	}

	public void switch_on_8()
	{
		switch_on_8_btn.gameObject.SetActive (false);
		switch_off_8_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on_12");
		Invoke ("wait_14",1);
	}
	void wait_14()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("rv_loop_5");
	}
	public void switch_off_8()
	{
		paper_sheck_5.gameObject.SetActive (false);
		switch_on_8_btn.gameObject.SetActive (true);
		switch_off_8_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off_12");
	}
	//

	public void switch_on_9()
	{
		switch_on_9_btn.gameObject.SetActive (false);
		switch_off_9_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on_11");
		Invoke ("wait_15",1);
	}
	void wait_15()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("rv_loop_4");
	}
	public void switch_off_9()
	{
		paper_sheck_6.gameObject.SetActive (false);
		switch_on_9_btn.gameObject.SetActive (true);
		switch_off_9_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off_11");
	}
	//

	public void switch_on_10()
	{
		switch_on_10_btn.gameObject.SetActive (false);
		switch_off_10_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on_10");
		Invoke ("wait_16",1);
	}
	void wait_16()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("rv_loop_3");
	}
	public void switch_off_10()
	{
		paper_sheck_7.gameObject.SetActive (false);
		switch_on_10_btn.gameObject.SetActive (true);
		switch_off_10_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off_10");
	}

	//
	public void switch_on_11()
	{
		switch_on_11_btn.gameObject.SetActive (false);
		switch_off_11_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on_9");
		Invoke ("wait_17",1);
	}
	void wait_17()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("rv_loop_2");
	}
	public void switch_off_11()
	{
		paper_sheck_8.gameObject.SetActive (false);
		switch_on_11_btn.gameObject.SetActive (true);
		switch_off_11_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off_9");
	}
	//

	public void switch_on_12()
	{
		battery_flip_btn_3.gameObject.SetActive (false);
		switch_on_12_btn.gameObject.SetActive (false);
		switch_off_12_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on_8");
		Invoke ("wait_18",1);
	}
	void wait_18()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("rv_loop_1");
	}
	public void switch_off_12()
	{
		battery_flip_btn_3.gameObject.SetActive (true);
		switch_on_12_btn.gameObject.SetActive (true);
		switch_off_12_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off_8");
	}

	//

	public void paper_sheak_fun_5()
	{
		paper_sheck_5.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("paper_sheak_5");
		Invoke ("wait_19",1);
	}
	void wait_19()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("p_loop_5");
	}
	//
	public void paper_sheak_fun_6()
	{
		paper_sheck_6.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("paper_sheak_6");
		Invoke ("wait_20",1);
	}
	void wait_20()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("p_loop_6");
	}
	//

	public void paper_sheak_fun_7()
	{
		paper_sheck_7.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("paper_sheak_7");
		Invoke ("wait_21",1);
	}
	void wait_21()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("p_loop_7");
	}
	//

	public void paper_sheak_fun_8()
	{
		paper_sheck_8.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("paper_sheak_8");
		Invoke ("wait_22",1);
	}
	void wait_22()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("p_loop_8");
	}


	public void battery_flip_3()
	{
		sliderChange.value = 0;
		sliderChange.gameObject.SetActive (true);
		sliderChange_2.gameObject.SetActive (false);

		switch_off_3_btn.gameObject.SetActive (false);
		battery_flip_btn_3.gameObject.SetActive (false);
		switch_on_12_btn.gameObject.SetActive(false);
		fbx.gameObject.GetComponent<Animation> ().Play ("battery_flip_3");
		switch_on_3_btn.gameObject.SetActive(true);
	}
}

