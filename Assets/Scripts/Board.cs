using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Board : MonoBehaviour {

    public int counter = 1;
    public GameObject[,] pos = new GameObject[16, 15];
    public GameObject ant;
    public GameObject antlion;
    public GameObject highlight;
    public Text Hint;

    public GameObject card1, card2, card3, card4;
    public GameObject[] antCards = new GameObject[8];
    public GameObject[] antlionCards = new GameObject[8];


    public bool inSkill;
    public bool IsOver = false;
    GameObject cur;
    // Use this for initialization
    void Start () {
        //第二难度设定把墙加上，如果墙需要挂cs，墙的图层在background里
        //我现在让墙藏在后面了，想要墙显示的话，在hierarchy里选中wall，然后在右边order in layer 把0改成1
        //关于(0,8)：如果设定第三难度的话，可以让这个卡的数量double一下，每张x2，就是每个卡槽16张牌

        card1 = antCards[Random.Range(0, 8)];
        card2 = antCards[Random.Range(0, 8)];
        card1.GetComponent<Renderer>().enabled = false;
        card2.GetComponent<Renderer>().enabled = false;

        card3 = antlionCards[Random.Range(0, 7)];
        card4 = antlionCards[Random.Range(0, 7)];
        card3.GetComponent<Renderer>().enabled = false;
        card4.GetComponent<Renderer>().enabled = false;

        //如果这些写在start里，你要怎么确认它们会update
    }

    // Update is called once per frame
    void Update () {
        
        if (!IsOver)
        {
            if (ant.GetComponent<Critter>().x == antlion.GetComponent<Critter>().x && antlion.GetComponent<Critter>().y == ant.GetComponent<Critter>().y)
            {
                IsOver = true;
                Hint.text = "Antlion Wins！";
            }
            if (ant.GetComponent<Critter>().x == 8 && ant.GetComponent<Critter>().y == 7 )
            {
                IsOver = true;
                Hint.text = "Ant Wins！";
            }
            if (!inSkill)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    counter++;
                    if (counter % 2 == 0)
                    {
                        if( card1 == null)
                        {
                            //补充一张卡？
                            //card1 = antCards[Random.Range(0, 9)];
                            //下同
                        }
                        if ( card2 == null)
                        {

                        }
                        cur = antlion;
                        ant.GetComponent<Critter>().isMovable = false;
                        antlion.GetComponent<Critter>().isMovable = true;
                        antlion.GetComponent<Critter>().maxReach = 2;
                    }
                    else
                    {
                        cur = ant;
                        ant.GetComponent<Critter>().isMovable = true;
                        antlion.GetComponent<Critter>().isMovable = false;
                        ant.GetComponent<Critter>().maxReach = 2;
                    }
                }

                if(cur == ant)
                {
                    if (Input.GetKeyDown(KeyCode.Alpha1) && card1 != null)
                    {
                        castFunctions(card1.GetComponent<Cards>().index);
                        castFunctions(card2.GetComponent<Cards>().index);
                        
                    }
                }

                if (Input.GetKeyDown(KeyCode.Return))
                {
                    highlight.GetComponent<Renderer>().enabled = true;
                    highlight.GetComponent<Critter>().isMovable = true;
                    highlight.GetComponent<Critter>().maxReach = 999;
                    highlight.GetComponent<Critter>().x = cur.GetComponent<Critter>().x;
                    highlight.GetComponent<Critter>().y = cur.GetComponent<Critter>().y;
                    ant.GetComponent<Critter>().isMovable = false;
                    antlion.GetComponent<Critter>().isMovable = false;
                    inSkill = true;
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    cur.GetComponent<Critter>().isMovable = true;
                    highlight.GetComponent<Critter>().isMovable = false;
                    highlight.GetComponent<Renderer>().enabled = false;

                    //大概这个位置？如果你的某张卡片用完了之后是不是得
                    //card1 2 3 4  = null;之类的？
                    inSkill = false;
                }
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    cur.GetComponent<Critter>().isMovable = true;
                    highlight.GetComponent<Critter>().isMovable = false;
                    highlight.GetComponent<Renderer>().enabled = false;
                    inSkill = false;
                }

            }
            print(cur);
        }
        

    }

    void castFunctions(int index)
    {   
        //后面的comments 我会给你备注上这个卡叫啥，和效果，方便你区分（有一些图里没改的文字忽略不计，文件名是啥它就是啥）
        //格式：技能名  效果

        //anthill 移动格数+3
        if(index == 0)
        {
            ant.GetComponent<Critter>().maxReach +=3;
            print("0");
        }

        //broomMaster 放一个蛋，死后可在蛋的所在地重生
        if (index == 1)
        {

            //移动指示框，释放技能后显示egg
            //我给ant加一个boolean hasEgg，判断有无egg,如果这个卡使用过后的任意回合内，antlion杀死ant，同时ant hasEgg判断为正确,那么ant死后会在egg在的地方重生
            //egg的位置是可见的，我已经把图导进去了，在players目录下
            //这个cs里面isover的两个判定是不是得加上个 && ant.hasegg
            print("1");
        }

        //conceal 蚂蚁隐身一回合
        if (index == 2)
        {
            
            print("2");
        }

        //formicAcid 对蚁狮造成2点伤害（注意，蚂蚁是一碰就死；antlion血量是4，即被打两次死亡）
        if (index == 3)
        {

            print("3");
        }
        //freetrade 弃1抽1
        if (index == 4)
        {
            //不会写怎么pick期中一张卡，鼠标点？
            //if (选中弃卡)
            //{
            //  card1 = antCards[Random.Range(0, 9)];
            // 记得写弃牌啊，不然一张卡在同一个卡槽里重复pick了。
            //}
            print("4");
        }

        //hardenedshell 阻挡下一次debuff
        //注 debuff卡是不是得有一个boolean判断它是不是debuff，这样这里才好判断是不是阻挡
        //我考虑过吧卡牌改成血量提升，然后就是antlion杀两次才能杀死ant，但是antlion设定的是踩到就杀死，踩到的一瞬间ant血量归零，这个瞬间能控制好它的update吗？
        //能控制好的话，就改成antlion需要再踩一次ant才能吃掉。这里看你们觉得怎么好写怎么改吧。
        if (index == 5)
        {

            print("5");
        }

        //preperation 这回合剩下的步数移到下回合
        if (index == 6)
        {
            //if(counter != 0){
            // int cur = counter;
            // 下回合counter = counter + cur；
            //}
            
            print("6");
        }

        // sprint 加2移动
        if (index == 7)
        {
            counter += 2;
            print("7");
        }


    }
}
