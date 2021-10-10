using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;


public class Control : MonoBehaviour
{
    public UndoRedoSystem undoRedoSystem;
    public string heroName="Relis";
    public int health=3;

    public int attackCount=0;

    public int mana=5;

    public int tier=1;

    public int kills=-1;

    public int armor=12;

    public int speed=5;

    public int round=0;

    const int HERO_MAX_HITPOINTS=3;

    //RELIS
    const int RELIS_MAX_MANA=5;
    const int RELIS_ARMOR=12;
    const int RELIS_SPEED=5;
    const int TWIRL_COST=2;
    const int SHOCKWAVE_COST=3;
    const int DISTRIKE_COST=4;
    //IMVUS
    const int IMVUS_MAX_MANA=6;
    const int IMVUS_ARMOR=10;
    const int IMVUS_SPEED=5;
    const int CARDS_OF_BUFF_COST=2;
    const int CARDS_OF_EXPLOSION_COST=3;
    const int CARDS_OF_REJUVENATION_COST=2;
    //THARKOS
    const int THARKOS_MAX_MANA=5;
    const int THARKOS_ARMOR=14;
    const int THARKOS_SPEED=3;
    const int DIVINE_BLESSING_COST=2;
    const int TEST_OF_FAITH_COST=3;
    const int SHIELD_OF_LIGHT_COST=3;
    //SLVIA
    const int SLVIA_MAX_MANA=4;
    const int SLVIA_ARMOR=11;
    const int SLVIA_SPEED=6;
    const int PIERCING_ARROW_COST=1;
    const int ARROW_BARRAGE_COST=3;
    const int PHANTOM_STEPS_COST=2;
    //WEVIL
    const int WEVIL_MAX_MANA=5;
    const int WEVIL_ARMOR=8;
    const int WEVIL_SPEED=6;
    const int SWAP_COST=3;
    const int DELAY_COST=2;
    const int DEADLY_KNIVES_COST=3;

    public Dropdown dropdown;
    public Transform dropdownLabel;
    public Text dropdownLabelText;

    public GameObject hitpointsNumber;
    public Text hitpointsNumberText;

    public GameObject manaNumber;
    public Text manaNumberText;

    public Text tierText;

    public Text armorText;

    public Text speedText;

    public Text roundText;

    public Text attackCountText;

    public Text killsText;

    


    // Start is called before the first frame update
    
    // Update is called once per frame

    void Start()
    {
        hitpointsNumberText.text=health.ToString();
        manaNumberText.text=mana.ToString();
        roundText.text = "R"+round.ToString();
        speedText.text = ":"+speed.ToString();
        attackCountText.text = ":"+attackCount.ToString();
        killsText.text = ":"+kills.ToString();
        tierText.text = "T"+tier.ToString();
    }

//Hero Change
#region 
    public void heroChange()
    {
        heroName=dropdownLabelText.text;
        health=HERO_MAX_HITPOINTS;
        tier=1;
        kills=-1;
        attackCount=0;
        if(heroName=="Relis"){
            
            mana=RELIS_MAX_MANA;
            speed=RELIS_SPEED;
            armor=RELIS_ARMOR;
        }
        if(heroName=="Imvus"){
            mana=IMVUS_MAX_MANA;
            speed=IMVUS_SPEED;
            armor=IMVUS_ARMOR;
        }
        if(heroName=="Tharkos"){
            mana=THARKOS_MAX_MANA;
            speed=THARKOS_SPEED;
            armor=THARKOS_ARMOR;
        }
        if(heroName=="Slvia"){
            mana=SLVIA_MAX_MANA;
            speed=SLVIA_SPEED;
            armor=SLVIA_ARMOR;
        }
        if(heroName=="Wevil"){
            mana=WEVIL_MAX_MANA;
            speed=WEVIL_SPEED;
            armor=WEVIL_ARMOR;
        }
        hitpointsNumberText.text=health.ToString();
        manaNumberText.text=mana.ToString();
        tierText.text="T"+tier.ToString();
        armorText.text=":"+armor.ToString();
        speedText.text= ":"+speed.ToString();
        killsText.text= ":"+kills.ToString();
        attackCountText.text = ":"+attackCount.ToString();
    }
#endregion
//Relis Abilities
#region  

public void lungeslash(){
    AttackCounter();
    RoundCounter();
}

public void chainSlash(){
    AttackCounter();
    RoundCounter();
}

public void twirl(){
    if(mana>=TWIRL_COST){
        mana-=TWIRL_COST;
        manaNumberText.text=mana.ToString();
        AttackCounter();
        RoundCounter();
    }
   
   
}

public void staticTwirl(){
 
     if(mana>=TWIRL_COST){
        mana-=TWIRL_COST;
        manaNumberText.text=mana.ToString();
        AttackCounter();
        RoundCounter();
    }
    
}

public void shockwave(){
     if(mana>=SHOCKWAVE_COST){
        mana-=SHOCKWAVE_COST;
        manaNumberText.text=mana.ToString();
        AttackCounter();
        RoundCounter();
    }
}

public void stormwave(){
    if(mana>=SHOCKWAVE_COST){
        mana-=SHOCKWAVE_COST;
        manaNumberText.text=mana.ToString();
        AttackCounter();
        RoundCounter();
    }
}

public void diStrike(){
    if(mana>=DISTRIKE_COST){
        mana-=DISTRIKE_COST; 
        manaNumberText.text=mana.ToString();
        AttackCounter();
        RoundCounter();
    }
}
#endregion

//Imvus Abilities
#region 

public void cardThrow(){
    AttackCounter();
    RoundCounter();
}

public void multiCardThrow(){
    AttackCounter();
    RoundCounter();
}

public void cardsOfBuff(){
    if(mana>=CARDS_OF_BUFF_COST){
        mana-=CARDS_OF_BUFF_COST;
        manaNumberText.text=mana.ToString();
        AttackCounter();
        RoundCounter();
    }
}

public void cardsOfExplosion(){
    if(mana>=CARDS_OF_EXPLOSION_COST){
        mana-=CARDS_OF_EXPLOSION_COST;
        manaNumberText.text=mana.ToString();
        AttackCounter();
        RoundCounter();
    }
}

public void cardsOfRejuvenation(){
    if(mana>=CARDS_OF_REJUVENATION_COST){
        mana-=CARDS_OF_REJUVENATION_COST;
        manaNumberText.text = mana.ToString();
        AttackCounter();
        RoundCounter();
    }
}

#endregion
//Tharkos Abilities
#region 

public void shieldBash(){
    AttackCounter();
    RoundCounter();
}

public void shieldSmash(){
    AttackCounter();
    RoundCounter();
}

public void divineBlessing(){
    if (mana>=DIVINE_BLESSING_COST){
        mana-=DIVINE_BLESSING_COST;
        manaNumberText.text = mana.ToString();
        AttackCounter();
        RoundCounter();
    }
}

public void testOfFaith(){
    if (mana>=TEST_OF_FAITH_COST){
        mana-=TEST_OF_FAITH_COST;
        manaNumberText.text = mana.ToString();
        AttackCounter();
        RoundCounter();
    }
}

public void shieldOfLight(){
    if (mana>=SHIELD_OF_LIGHT_COST){
        mana-=SHIELD_OF_LIGHT_COST;
        manaNumberText.text = mana.ToString();
        AttackCounter();
        RoundCounter();
    }
}
#endregion

//Slvia Abilities
#region

public void singleShot(){
    AttackCounter();
    RoundCounter();
}

public void multiShot(){
    AttackCounter();
    RoundCounter();
}

public void piercingArrow(){
    if (mana>=PIERCING_ARROW_COST){
        mana-=PIERCING_ARROW_COST;
        manaNumberText.text = mana.ToString();
        AttackCounter();
        RoundCounter();
    }
}

public void arrowBarrage(){
    if (mana>=ARROW_BARRAGE_COST){
        mana-=ARROW_BARRAGE_COST;
        manaNumberText.text = mana.ToString();
        AttackCounter();
        RoundCounter();
    }
}

public void phantomSteps(){
    if (mana>=PHANTOM_STEPS_COST){
        mana-=PHANTOM_STEPS_COST;
        manaNumberText.text = mana.ToString();
        AttackCounter();
        RoundCounter();
    }
}
#endregion

//Wevil Abilities
#region

public void backstab(){
    AttackCounter();
    RoundCounter();
}

public void backSlash(){
    AttackCounter();
    RoundCounter();
}

public void swap(){
    if (mana>=SWAP_COST){
        mana-=SWAP_COST;
        manaNumberText.text = mana.ToString();
        AttackCounter();
        RoundCounter();
    }
}

public void delay(){
    if (mana>=DELAY_COST){
        mana-=DELAY_COST;
        manaNumberText.text = mana.ToString();
        AttackCounter();
        RoundCounter();
    }
}

public void deadlyKnives(){
    if (mana>=DEADLY_KNIVES_COST){
        mana-=DEADLY_KNIVES_COST;
        manaNumberText.text = mana.ToString();
        AttackCounter();
        RoundCounter();
    }
}
#endregion



//Hipoint Manipulation
#region
public void addHitpoints(){
    if (health<HERO_MAX_HITPOINTS){
        health+=1;
        hitpointsNumberText.text=health.ToString();
        undoRedoSystem.undoStack.Push(UndoRedoSystem.HITPOINT_PLUS);
    }
}

public void minusHitpoints(){
    if (health>0){
        health-=1;
        hitpointsNumberText.text=health.ToString();
        undoRedoSystem.undoStack.Push(UndoRedoSystem.HITPOINT_MINUS);
    }
}
#endregion
//Mana Manipulation
#region    
public void addMana(){
    if (heroName == "Relis"){
        if (mana<RELIS_MAX_MANA){
            mana+=1;
            manaNumberText.text=mana.ToString();
        }
    }else if (heroName == "Imvus"){
        if (mana<IMVUS_MAX_MANA){
            mana+=1;
            manaNumberText.text=mana.ToString();
        }
    }else if (heroName == "Tharkos"){
        if (mana<5){
            mana+=1;
            manaNumberText.text=mana.ToString();
        }
    }else if (heroName == "Slvia"){
        if (mana<4){
            mana+=1;
            manaNumberText.text=mana.ToString();
        }
    }else if(heroName == "Wevil"){
        if (mana<5) {
            mana+=1;
            manaNumberText.text=mana.ToString();
        }
    }
}   
public void minusMana(){
    if (mana>0){
        mana-=1;
        manaNumberText.text=mana.ToString();
    }
}
#endregion

public void AttackCounter()
{
    if(attackCount<2){
        attackCount+=1;
        attackCountText.text = attackCount.ToString();
    }
}


public void RoundCounter()
{
    if (attackCount==2){
        round+=1;
        attackCount=0;
        attackCountText.text = ":"+attackCount.ToString();
        roundText.text = "R"+round.ToString();
    }
}
  

public void tierUpgrade(){
    if(kills==3){
        tier=2;
        tierText.text = "T"+tier.ToString();
    }
    if(kills==6){
        tier=3;
        tierText.text = "T"+tier.ToString();
    }
    if(kills==11){
        tier=4;
        tierText.text = "T"+tier.ToString();
    }
    if(kills==16){
        tier=5;
        tierText.text = "T"+tier.ToString();
    }
}  
}
   

