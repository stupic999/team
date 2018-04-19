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
            int n = 1;

            string[] name={ "葉俊廷", "張澤瑜", "龘䶛䨻䎱㸞蚮䡶䴞䴝䯬䬛䰕㹚王程捷", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "張鈺慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新張豐愷", "世新遲正雯", "世新周詮"};

            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "男", "女", "男" };

            Random rand = new Random();

            List<string> nameList = new List<string>();
            List<string> team1List = new List<string>();
            List<string> team2List = new List<string>();
            List<string> team3List = new List<string>();
            List<string> team4List = new List<string>();
            List<string> team5List = new List<string>();
            List<string> team6List = new List<string>();
            List<string> team7List = new List<string>();
            List<string> team8List = new List<string>();
            List<string> team9List = new List<string>();
            List<string> team10List = new List<string>();
            List<string> team11List = new List<string>();

            for (int i = 0; i < name.Length; i++)
            {
                nameList.Add(name[i]);
            }
            while (n < 13)
            {
                Console.Write("第" + n + "組的人有:  ");
                for (int i = 0; i < 6; i++)
                {
                    int j = rand.Next(0, nameList.Count);
                    Console.Write(nameList[j] + " ");
                    nameList.RemoveAt(j);
                }
                Console.WriteLine("");
                n++;
            }
            Console.WriteLine("分剩下的邊緣人為: " + nameList[0] + " " + nameList[1] + " " + nameList[2]);
            Console.ReadLine();
        }
    }
}
