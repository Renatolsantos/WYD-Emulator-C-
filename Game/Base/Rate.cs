﻿namespace Emulator
{
    public static class Rate
    {
        public static ulong[] Exp_Mortal_Arch = {
        500 ,1124 ,1826 ,2610 ,3480 ,4440 ,5494 ,6646 ,7900 ,  9260 ,10893 ,12817 ,15050 ,17610 ,20515 ,23783 ,27432 ,31480 ,
        35945 ,40845 ,46251 ,52187 ,58677 ,65745 ,73415 ,81711 ,90657 ,100277 ,110595 ,121635 ,133647 ,146671 ,160747 ,175915 ,192215 ,209687 ,
        228371 ,248307 ,269535 ,292095 ,316151 ,341751 ,368943 ,397775 ,428295 , 460551 ,494591 ,530463 ,568215 ,607895 ,649715 ,693731 ,739999 ,788575 ,
        839515 ,892875 ,948711 ,1007079 ,1068035 ,1131635 ,1198670 ,1269230 ,1343405 , 1421285 ,1502960 ,1588520 ,1678055 ,1771655 ,1869410 ,1971410 ,2078255 ,2190055 ,
        2306920 ,2428960 ,2556285 ,2689005 ,2827230 ,2971070 ,3120635 ,3276035 ,3438521 ,  3608249 ,3785375 ,3970055 ,4162445 ,4362701 ,4570979 ,4787435 ,5012225 ,5245505 ,
        5488163 ,5740379 ,6002333 ,6274205 ,6556175 ,6848423 ,7151129 ,7464473 ,7788635 , 8123795 ,8460174 ,8797774 ,9136597 ,9476645 ,9817920 ,10160424 ,10504159 ,10849127 ,
        11195330 ,11542770 ,11892311 ,12243959 ,12597720 ,12953600 ,13311605 ,13671741 ,14034014 , 14398430 ,14764995 ,15133715 ,15508850 ,15890450 ,16278565 ,16673245 ,
        17074540 ,17482500 , 17897175 ,18318615 ,18746870 ,19181990 ,19625811 ,20078403 ,20539836 ,21010180 ,21489505 , 21977881 ,22475378 ,22982066 ,23498015 ,24023295 ,
        24559110 ,25105558 ,25662737 ,26230745 , 26809680 ,27399640 ,28000723 ,28613027 ,29236650 ,29871690 ,30517485 ,31174125 ,31841700 , 32520300 ,33210015 ,33910935 ,
        34623150 ,35346750 ,36081825 ,36828465 ,37587867 ,38360139 , 39145389 ,39943725 ,40755255 ,41580087 ,42418329 ,43270089 ,44135475 ,45014595 ,45904870 , 46806370 ,
        47719165 ,48643325 ,49578920 ,50526020 ,51484695 ,52455015 ,53437050 ,54430870 , 55439542 ,56463162 ,57501826 ,58555630 ,59624670 ,60709042 ,61808842 ,62924166 ,
        64055110 , 65201770 ,66366010 ,67547930 ,68747630 ,69965210 ,71200770 ,72454410 ,73726230 ,75016330 , 76324810 ,77651770 ,78985354 ,80325578 ,81672458 ,83026010 ,
        84386250 ,85753194 ,87126858 , 88507258 ,89894410 ,91288330 ,92693002 ,94108458 ,95534730 ,96971850 ,98419850 ,99878762 , 101348618 ,102829450 ,104321290 ,105824170 ,
        107352234 ,108905674 ,110484682 ,112089450 ,113720170 , 115377034 ,117060234 ,118769962 ,120506410 ,122269770 ,124065890 ,125895058 ,127757562 ,129653690 , 131583730 ,
        133547970 ,135546698 ,137580202 ,139648770 ,141752690 ,143928178 ,146176386 ,148498466 , 150895570 ,153368850 ,155919458 ,158548546 ,161257266 ,164046770 ,166918210 ,
        169956978 ,173167682 , 176554930 ,180123330 ,205345890 ,209100050 ,212902550 ,216753470 ,220652890 ,224600890 ,228597550 , 232642950 ,236737170 ,240880290 ,245072390 ,
        249313550 ,253603850 ,257943370 ,262332190 ,266770390 , 271258050 ,275795250 ,280382070 ,285018590 ,289904810 ,295042730 ,300434350 ,306081670 ,311986690 , 318151410 ,
        324577830 ,331267950 ,338223770 ,345447290 ,354039310 ,364049830 ,375528850 ,388526370 , 403092390 ,419276910 ,437129930 ,456701450 ,476272970 ,495844490 ,515416010 ,
        534987530 ,554559050 , 574130570 ,593702090 ,613273610 ,632845130 ,652416650 ,671988170 ,691559690 ,711131210 ,730702730 , 750274250 ,769845770 ,789417290 ,808988810 ,
        828560330 ,848131850 ,867703370 ,887274890 ,906846410 , 926417930 ,945989450 ,965560970 ,985132490 ,1004704010 ,1024275530 ,1043847050 ,1063418570 ,1082990090 ,
        1102561610 ,1122133130 ,1141704650 ,1161276170 ,1180847690 ,1200419210 ,1222705731 ,1244995262 ,1267288477 , 1289622601 ,1311966887 ,1334333102 ,1356724650 ,
        1379151914 ,1401651370 ,1424151231 ,1448674779 ,1473220997 , 1497782544 ,1522364697 ,1546957043 ,1571581919 ,1596243411 ,1620925875 ,1645647464 ,1670373305 ,
        1710373305 , 1770373305 ,1870373305 ,2000000000 ,2039000000 ,2078000000 ,2117000000 ,2156000000 ,2195000000 ,2234000000 , 2273000000 ,2312000000 ,2351000000 ,
        2390000000 ,2429000000 ,2468000000 ,2507000000 ,2546000000 ,2585000000 , 2624000000 ,2663000000 ,2702000000 ,2741000000 ,2780000000 ,2819000000 ,2858000000 ,
        2897000000 ,2936000000 , 3000000000 ,3043000000 ,3086000000 ,3129000000 ,3172000000 ,3215000000 ,3258000000 ,3301000000 ,3344000000 , 3387000000 ,3430000000 ,
        3473000000 ,3516000000 ,3559000000 ,3602000000 ,3645000000 ,3688000000 ,3731000000 , 3774000000 ,3817000000 ,4000000000, 4100000000};
        public static int[,] ReplationBota = new int[30, 4]
            {
 { 2, 30, 74, 18 } , { 2, 30, 74, 15}, {2, 30, 74, 12},      {2, 24, 74, 18}, {2, 24, 74, 15}, {2, 24, 74, 12},
 {2, 18, 74, 18}, {2, 18, 74, 15}, {2, 18, 74, 12},          {2, 12, 74, 18}, {2, 12, 74, 15}, {2, 12, 74, 12},
 {2, 6, 74, 18}, {2, 6, 74, 15}, {2, 6, 74, 12},             {2, 30, 60, 10}, {2, 30, 60, 8}, {2, 30, 60, 6},
 {2, 24, 60, 10}, {2, 24, 60, 8}, {2, 24, 60, 6},            {2, 18, 60, 10}, {2, 18, 60, 8}, {2, 18, 60, 6},
 {2, 12, 60, 10}, {2, 12, 60, 8}, {2, 12, 60, 6},            {2, 6, 60, 10}, {2, 6, 60, 8}, {2, 6, 60, 6}
            };
        public static int[,] ReplationLuva = new int[27, 4]
            {
 {2, 30, 72, 30}, {2, 30, 72, 25}, {2, 30, 72, 20},   {2, 30, 72, 15}, {2, 30, 72, 10}, {2, 24, 72, 30},
 {2, 24, 72, 25}, {2, 24, 72, 20}, {2, 24, 72, 15},   {2, 24, 72, 10}, {2, 18, 72, 30}, {2, 18, 72, 25},
 {2, 18, 72, 20}, {2, 18, 72, 15}, {2, 18, 72, 10},   {60, 10, 72, 30}, {60, 10, 72, 25}, {60, 10, 72, 20},
 {60, 10, 72, 15}, {60, 8, 72, 30}, {60, 8, 72, 25},  {60, 8, 72, 20}, {60, 8, 72, 15}, {60, 6, 72, 30},
 {60, 6, 72, 25}, {60, 6, 72, 20}, {60, 6, 72, 15}
            };
        public static int[,] ReplationElmo = new int[25, 4]
            {
 {4, 60, 26, 18}, {4, 60, 26, 15}, {4, 60, 26, 12},   {4, 50, 26, 18}, {4, 50, 26, 15}, {4, 50, 26, 12},
 {4, 40, 26, 18}, {4, 40, 26, 15}, {4, 40, 26, 12},   {4, 30, 26, 18}, {4, 30, 26, 15}, {4, 30, 26, 12},
 {4, 60, 60, 12}, {4, 60, 60, 10}, {4, 60, 60, 8},    {4, 60, 60, 6}, {4, 50, 60, 12}, {4, 50, 60, 10},
 {4, 50, 60, 8}, {4, 50, 60, 6}, {4, 40, 60, 12},     {4, 40, 60, 10}, {4, 40, 60, 8}, {4, 40, 60, 6},
 {4, 40, 60, 4}
            };
        public static int[,] ReplationPeitoCalca = new int[48, 4]
            {
 {2, 30, 3, 30}, {2, 30, 3, 25}, {2, 30, 3, 20},      {2, 30, 3, 10}, {2, 24, 3, 30}, {2, 24, 3, 25},
 {2, 24, 3, 20}, {2, 24, 3, 15}, {2, 18, 3, 30},      {2, 18, 3, 25}, {2, 18, 3, 20}, {2, 18, 3, 15},
 {2, 30, 71, 50}, {2, 30, 71, 60}, {2, 30, 71, 70},   {2, 24, 71, 50}, {2, 24, 71, 60}, {2, 24, 71, 70},
 {2, 18, 71, 50}, {2, 18, 71, 60}, {2, 18, 71, 70},   {60, 10, 3, 30}, {60, 10, 3, 25}, {60, 10, 3, 20},
 {60, 10, 3, 15}, {60, 10, 3, 10}, {60, 8, 3, 30},    {60, 8, 3, 25}, {60, 8, 3, 20}, {60, 8, 3, 15},
 {60, 8, 3, 10}, {60, 6, 3, 30}, {60, 6, 3, 25},      {60, 6, 3, 20}, {60, 6, 3, 15}, {60, 6, 3, 10},
 {60, 10, 71, 50}, {60, 10, 71, 60}, {60, 10, 71, 70},               {60, 8, 71, 50}, {60, 8, 71, 60}, {60, 8, 71, 70},
 {60, 6, 71, 50}, {60, 6, 71, 60}, {60, 6, 71, 70},   {60, 4, 71, 50}, {60, 4, 71, 60}, {60, 4, 71, 70}
            };
        public static int[] ItemSeladoCelestial = new int[15] { 100, 100, 100, 100, 100, 100, 100, 100, 70, 50, 40, 40, 40, 10, 5 };
        public static int[] PoeraOriRate = new int[12] { 100, 100, 100, 85, 70, 40, 00, 00, 00, 00, 00, 00 };
        public static int[] PoeraLacRate = new int[12] { 100, 100, 100, 100, 100, 80, 70, 70, 50, 60, 00, 00 };
        public static int[] AmagoRate = new int[12] { 100, 80, 60, 40, 20, 10, 10, 10, 5, 5, 5, 5 };
        public static int[,,] PergaminhaCaca = new int[6, 10, 2] {
	        //Armia
	        { {2370, 2106}, {2508, 2101}, {2526, 2109}, {2529, 1882}, {2126, 1600}, {2005, 1617}, {2241, 1474}, {1858, 1721}, {2250, 1316}, {1989, 1755} },
	
	        //Dungeon
	        { {290, 3799}, {724, 3781}, {481, 4062}, {876, 4058}, {855, 3922}, {808, 3876}, {959, 3813}, {926, 3750}, {1096, 3730}, {1132, 3800} },
	
	        //SubMundo
	        { {1242 , 4035}, {1264 , 4017}, {1333 , 3994}, {1358 , 4041}, {1462 , 4033}, {1326 , 3788}, {1493 , 3777}, {1437 , 3741}, {1389 , 3740}, {1422 , 3810} },
	
	        //Kult
	        { {1376 , 1722}, {1426 , 1686}, {1381 , 1861}, {1326 , 1896}, {1510 , 1723}, {1543 , 1726}, {1580 , 1758}, {1182 , 1714}, {1634 , 1727}, {1237 , 1764} }, 
	
	        //Kefra
	        { {2367 , 4024}, {2236 , 4044}, {2236 , 3993}, {2209 , 3989}, {2453 , 4067}, {2485 , 4043}, {2537 , 3897}, {2489 , 3919}, {2269 , 3910}, {2202 , 3866} },
	
	        //Nipple
	        { {3664 , 3024}, {3582 , 3007}, {3514 , 3008}, {3819 , 2977}, {3517 , 2889}, {3745 , 2977}, {3639 , 2877}, {3650 , 2727}, {3660 , 2773}, {3746 , 2879} }
        };
        public static TransformacaoBonus[] TransfBonus =  TransformacaoBonus.New();
       
    }

    public class TransformacaoBonus
    {
        public int Unk; // MinDamAdd ? // 0
        public int Unk2; // MaxDamAdd ? // 4
        public int Unk3; // MinAcAdd ? // 8
        public int Unk4; // MaxAcAdd ? //12
        public int Unk5; // MinHpAdd ? // 16
        public int Unk6; // MaxHpAdd ? // 20
        public int Unk7; // RunSpeedBonus ? // 24
        public int Unk8; // 28
        public int Unk9; // AttackSpeedBonus ? // 32
        public int Unk10; // 36
        public int Unk11; // 40
        public int Unk12; // 44 
        public int Unk13; // 48
        public int Unk14; // 52
        public int Unk15; // 56
        public int Unk16; // 60
        public int Unk17; // BaseSanc ? // 64

        public static TransformacaoBonus[] New()
        {
            TransformacaoBonus[] tmp = new TransformacaoBonus[6];
            tmp[0] = new TransformacaoBonus()
            { Unk = 110, Unk2 = 130, Unk3 = 95, Unk4 = 105, Unk5 = 95, Unk6 = 105, Unk7 = 1, Unk8 = 0, Unk9 = 20, Unk10 = 0, Unk11 = 100, Unk12 = 100, Unk13 = 100, Unk14 = 100, Unk15 = 100, Unk16 = 100, Unk17 = 15 };
            tmp[1] = new TransformacaoBonus()
            { Unk = 110, Unk2 = 130, Unk3 = 95, Unk4 = 105, Unk5 = 95, Unk6 = 105, Unk7 = 1, Unk8 = 0, Unk9 = 20, Unk10 = 0, Unk11 = 100, Unk12 = 100, Unk13 = 100, Unk14 = 100, Unk15 = 100, Unk16 = 100, Unk17 = 15 };
            tmp[2] = new TransformacaoBonus()
            { Unk = 80, Unk2 = 100, Unk3 = 100, Unk4 = 110, Unk5 = 100, Unk6 = 140, Unk7 = 0, Unk8 = 0, Unk9 = 0, Unk10 = 0, Unk11 = 100, Unk12 = 100, Unk13 = 100, Unk14 = 100, Unk15 = 100, Unk16 = 100, Unk17 = 60 };
            tmp[3] = new TransformacaoBonus()
            { Unk = 100, Unk2 = 120, Unk3 = 105, Unk4 = 115, Unk5 = 100, Unk6 = 120, Unk7 = 1, Unk8 = 0, Unk9 = 20, Unk10 = 0, Unk11 = 100, Unk12 = 100, Unk13 = 100, Unk14 = 100, Unk15 = 100, Unk16 = 100, Unk17 = 115 };
            tmp[4] = new TransformacaoBonus()
            { Unk = 90, Unk2 = 110, Unk3 = 110, Unk4 = 125, Unk5 = 105, Unk6 = 110, Unk7 = 0, Unk8 = 0, Unk9 = 20, Unk10 = 0, Unk11 = 100, Unk12 = 100, Unk13 = 100, Unk14 = 100, Unk15 = 100, Unk16 = 100, Unk17 = 155 };
            tmp[5] = new TransformacaoBonus()
            { Unk = 105, Unk2 = 120, Unk3 = 110, Unk4 = 120, Unk5 = 105, Unk6 = 115, Unk7 = 3, Unk8 = 0, Unk9 = 20, Unk10 = 0, Unk11 = 100, Unk12 = 100, Unk13 = 100, Unk14 = 100, Unk15 = 100, Unk16 = 100, Unk17 = 155 };

            return tmp;
        }
    };

}