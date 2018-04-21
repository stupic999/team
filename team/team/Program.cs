using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入每一組的人數");

            int teampp=int.Parse(Console.ReadLine());

            int n = 1;

            string[] name={"葉俊廷", "張澤瑜", "龘䶛䨻䎱㸞蚮䡶䴞䴝䯬䬛䰕㹚王程捷", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "張鈺慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新張豐愷", "世新遲正雯", "世新周詮"};

            Random rand = new Random();

            List<string> nameList = new List<string>();

            for (int i = 0; i < name.Length; i++)
            {
                nameList.Add(name[i]);
            }
            int teamcount = nameList.Count / teampp;
            int sidepoeple= nameList.Count % teampp;
            int sidepeople2 = sidepoeple;
            while (n < teamcount)
            {
                Console.Write("第" + n + "組的人有:  ");
                for (int i = 0; i < teampp; i++)
                {
                    if (sidepoeple > 0 && sidepeople2 ==sidepoeple) 
                    {
                        int l = rand.Next(0, nameList.Count);
                        Console.Write(nameList[l] + " ");
                        nameList.RemoveAt(l);
                        sidepoeple--;
                    }
                    int j = rand.Next(0, nameList.Count);
                    Console.Write(nameList[j] + " ");
                    nameList.RemoveAt(j);
                }
                sidepeople2--;
                Console.WriteLine("");
                n++;
            }
            Console.ReadLine();
        }
    }
}
